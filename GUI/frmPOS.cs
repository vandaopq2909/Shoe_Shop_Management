using BUL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class frmPOS : Form
    {
        private UsersBUL _usersBUL = new UsersBUL();
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProduct();
            SetupDataGridView();
            LoadComboboxKhachHang();
        }
        private void SetupDataGridView()
        {
            // Kiểm tra xem các cột đã tồn tại chưa, nếu chưa thì thêm vào
            if (!guna2DataGridView1.Columns.Contains("ProductID"))
            {
                guna2DataGridView1.Columns.Add("ProductID", "Mã sản phẩm");
                guna2DataGridView1.Columns.Add("ProductName", "Tên sản phẩm");
                guna2DataGridView1.Columns.Add("dgvQty", "Số lượng");
                guna2DataGridView1.Columns.Add("dgvPrice", "Giá");
                guna2DataGridView1.Columns.Add("dgvAmount", "Tổng tiền");
            }
        }
        void LoadComboboxKhachHang()
        {
            var customer = _usersBUL.GetAllCustomers().ToList();

            cboKhachHang.DataSource = customer;
            cboKhachHang.DisplayMember = "FullName";
            cboKhachHang.ValueMember = "UserName";
        }
        private void LoadCategories()
        {
            string qry = @"Select * from Categories";
            DataTable dt = MainClass.GetData(qry);
            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2CheckBox ckb = new Guna.UI2.WinForms.Guna2CheckBox();
                ckb.AutoSize = true;
                ckb.Name = row["CategoryName"].ToString();
                ckb.Text = row["CategoryName"].ToString();
                panLoai.Controls.Add(ckb);
            }
        }
        private void AddItem(string id, string name, Image image, double price)
        {
            var pro = new ucProduct()
            {
                name = name,
                image = image,
                price = price,
                id = Convert.ToInt32(id)
            };

            panSanPham.Controls.Add(pro);
            pro.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                bool isExist = false;

                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductID"].Value) == wdg.id)
                    {
                        isExist = true;

                        row.Cells["dgvQty"].Value = Convert.ToInt32(row.Cells["dgvQty"].Value) + 1;
                        row.Cells["dgvAmount"].Value = Convert.ToInt32(row.Cells["dgvQty"].Value) * Convert.ToDouble(row.Cells["dgvPrice"].Value);

                        break;
                    }
                }

                if (!isExist)
                {
                    guna2DataGridView1.Rows.Add(new object[]
                    {
                guna2DataGridView1.Rows.Count + 1,  // Số thứ tự
                wdg.id,                            // ProductID
                wdg.name,                          // Tên sản phẩm
                1,                                 // Số lượng mặc định = 1
                wdg.price,                         // Giá sản phẩm
                wdg.price                          // Tổng tiền ban đầu
                    });
                }

                UpdateTotalAmount(); // Cập nhật tổng tiền
            };
        }

        private void LoadProduct()
        {
            string qry = @"Select *from products";
            DataTable dt = MainClass.GetData(qry);
            foreach (DataRow row in dt.Rows)
            {
                string s = (string)dt.Rows[0]["Image"];
                byte[] data = System.Text.Encoding.ASCII.GetBytes(s);


                string img = row["Image"].ToString();
                if (!string.IsNullOrEmpty(img))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                    if (File.Exists(imagePath))
                    {
                        AddItem(row["ProductID"].ToString(), row["ProductName"].ToString(),
                             Image.FromFile(imagePath), Double.Parse(row["ProductPrice"].ToString()));
                    }
                }
                else
                {
                    AddItem(row["ProductID"].ToString(), row["ProductName"].ToString(),
                      Properties.Resources.save, Double.Parse(row["ProductPrice"].ToString()));
                }
            }

        }
        private void getToltal()
        {
            double tot = 0;
            lblTongTien.Text = "00";
            foreach(DataGridViewRow row in guna2DataGridView1.Rows)
            {
                tot += double.Parse(row.Cells["dgvAmount"].Value.ToString());
            }
            lblTongTien.Text=tot.ToString();
        }
        private void UpdateTotalAmount()
        {
            double total = 0;

            // Tính tổng tiền từ cột `dgvAmount`
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells["dgvAmount"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["dgvAmount"].Value);
                }
            }
            lblTongTien.Text = total.ToString();
        }
        private void SaveOrderToDatabase()
        {
            try
            {
                // Mở kết nối tới cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ShoeShop;Integrated Security=True"))
                {
                    conn.Open();

                    // Kiểm tra và chuyển đổi TotalAmount
                    double totalAmount = 0;
                    if (!double.TryParse(lblTongTien.Text, out totalAmount))
                    {
                        MessageBox.Show("Tổng tiền không hợp lệ.");
                        return;
                    }
                    string selectedUserName = cboKhachHang.SelectedValue.ToString();
                    // Tạo câu lệnh SQL để chèn dữ liệu vào bảng Orders
                    string query = @"
                INSERT INTO Orders (TotalAmount, Status, DateCreated, UserName)
                VALUES (@TotalAmount, @Status, @DateCreated, @UserName);
                SELECT SCOPE_IDENTITY();";  // Trả về OrderID vừa được tạo

                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@Status", "Pending");  // Ví dụ Status có thể là "Pending"
                        cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UserName", selectedUserName);  // Sử dụng tên người dùng hiện tại nếu có

                        // Thực thi câu lệnh và lấy OrderID vừa được tạo
                        var result = cmd.ExecuteScalar();

                        // Kiểm tra kết quả trả về từ ExecuteScalar
                        if (result != DBNull.Value)
                        {
                            int orderId = Convert.ToInt32(result);  // Lấy OrderID vừa được tạo

                            // Sau khi lấy OrderID, tiếp tục thêm chi tiết đơn hàng vào OrderDetails
                            AddOrderDetails(orderId);
                            MessageBox.Show("Đơn hàng đã được lưu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể lấy OrderID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu đơn hàng: " + ex.Message);
            }
        }


        // Hàm để thêm chi tiết đơn hàng vào bảng OrderDetails
        private void AddOrderDetails(int orderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ShoeShop;Integrated Security=True"))
                {
                    conn.Open();

                    // Tạo câu lệnh SQL để chèn dữ liệu vào bảng OrderDetails
                    string query = @"
                INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price, TotalAmount)
                VALUES (@OrderID, @ProductID, @Quantity, @Price, @TotalAmount);";

                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.Cells["ProductID"].Value != null)
                        {
                            int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                            int quantity = Convert.ToInt32(row.Cells["dgvQty"].Value);

                            // Kiểm tra và chuyển đổi giá trị Price
                            double price = 0;
                            if (!double.TryParse(row.Cells["dgvPrice"].Value.ToString(), out price))
                            {
                                MessageBox.Show("Giá sản phẩm không hợp lệ.");
                                return;
                            }

                            // Kiểm tra và chuyển đổi TotalAmount
                            double totalAmount = 0;
                            if (!double.TryParse(row.Cells["dgvAmount"].Value.ToString(), out totalAmount))
                            {
                                MessageBox.Show("Tổng tiền sản phẩm không hợp lệ.");
                                return;
                            }

                            // Tạo đối tượng SqlCommand để chèn chi tiết đơn hàng
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@OrderID", orderId);
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                cmd.Parameters.AddWithValue("@Quantity", quantity);
                                cmd.Parameters.AddWithValue("@Price", price);
                                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                                // Thực thi câu lệnh chèn dữ liệu vào OrderDetails
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu chi tiết đơn hàng: " + ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrderToDatabase();
        }
    }
}
