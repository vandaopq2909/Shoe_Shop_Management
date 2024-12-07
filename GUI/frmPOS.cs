using BUL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
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
        private CategoriesBUL _categoriesBUL;
        private OrderBUL _orderBUL;
        private ProductBUL _productBUL;
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            _categoriesBUL = new CategoriesBUL();
            _productBUL=new ProductBUL();
            _orderBUL = new OrderBUL();
            LoadCategories();
            LoadProduct();

            SetupDataGridView();
            LoadComboboxKhachHang();
        }
        private void SetupDataGridView()
        {
            dgvOrder.AllowUserToAddRows = false;

            if (!dgvOrder.Columns.Contains("ProductID"))
            {
                dgvOrder.Columns.Add("ProductID", "Mã sản phẩm");
                dgvOrder.Columns.Add("ProductName", "Tên sản phẩm");
                dgvOrder.Columns.Add("dgvQty", "Số lượng");
                dgvOrder.Columns.Add("dgvPrice", "Giá");
                dgvOrder.Columns.Add("dgvAmount", "Tổng tiền");
                dgvOrder.RowTemplate.Height = 40;
            }
        }
        void LoadComboboxKhachHang()
        {
            var customers = _usersBUL.GetAllCustomers()
                                     .Select(c => new
                                     {
                                         UserName = c.UserName,
                                         DisplayName = $"({c.UserName}) {c.FullName}" 
                                     })
                                     .ToList();

            cboKhachHang.DataSource = customers;
            cboKhachHang.DisplayMember = "DisplayName"; 
            cboKhachHang.ValueMember = "UserName";    
        }

        private void LoadCategories()
        {
            var categories = _categoriesBUL.GetCategories();

            foreach (var category in categories)
            {
                Guna.UI2.WinForms.Guna2CheckBox ckb = new Guna.UI2.WinForms.Guna2CheckBox();
                ckb.AutoSize = true;
                ckb.Name = category.CategoryName;
                ckb.Text = category.CategoryName;
                ckb.CheckedChanged += Ckb_CheckedChanged;
                panLoai.Controls.Add(ckb);  // Thêm checkbox vào panel
            }
        }
        private void Ckb_CheckedChanged(object sender, EventArgs e)
        {
            // Lọc sản phẩm theo danh mục
            FilterProductsByCategories();
        }
     
        private void FilterProductsByCategories()
        {
            var selectedCategories = panLoai.Controls.OfType<Guna.UI2.WinForms.Guna2CheckBox>()
                                              .Where(ckb => ckb.Checked)
                                              .Select(ckb => ckb.Name)
                                              .ToList();
            panSanPham.Controls.Clear();
            if (selectedCategories.Count == 0)
            {
                LoadProduct(); // Load tất cả sản phẩm
            }
            else
            {
                var filteredProducts = _productBUL.GetProducts()
                                                  .Where(p => selectedCategories.Contains(p.Category.CategoryName))
                                                  .ToList();

                LoadProductByCat(filteredProducts);
            }
         
        }

        private void LoadProductByCat(List<Product> filteredProducts)
        {
            panSanPham.Controls.Clear();

            foreach (var product in filteredProducts)
            {
                string img = product.Image; 
                if (!string.IsNullOrEmpty(img))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                    if (File.Exists(imagePath))
                    {
                        AddItem(product.ProductID.ToString(), product.ProductName,
                                Image.FromFile(imagePath), product.ProductPrice);
                    }
                }
                else
                {
                    AddItem(product.ProductID.ToString(), product.ProductName,
                            Properties.Resources.save, product.ProductPrice);
                }
            }
        }


        private void AddItem(string id, string name, Image image, double? price)
        {
            var pro = new ucProduct()
            {
                name = name,
                image = image,
                price = price,
                id = Convert.ToInt32(id)
            };

            panSanPham.Controls.Add(pro);
            pro.onSelect += (l, ee) =>
            {
                var uc = (ucProduct)l;
                bool isExist = false;

                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductID"].Value) == uc.id)
                    {
                        isExist = true;

                        row.Cells["dgvQty"].Value = Convert.ToInt32(row.Cells["dgvQty"].Value) + 1;
                        row.Cells["dgvAmount"].Value = Convert.ToInt32(row.Cells["dgvQty"].Value) * Convert.ToDouble(row.Cells["dgvPrice"].Value);
                        break;
                    }
                }
                if (!isExist)
                {
                    dgvOrder.Rows.Add(new object[]
                    {
                        dgvOrder.Rows.Count + 1,  // Số thứ tự
                        uc.id,                            // ProductID
                        uc.name,                          // Tên sản phẩm
                        1,                                 // Số lượng mặc định = 1
                        uc.price,                         // Giá sản phẩm
                        uc.price                          // Tổng tiền ban đầu
                    });
                }

                UpdateTotalAmount(); 
            };
        }

        private void LoadProduct()
        {
            panSanPham.Controls.Clear();

            var allProducts = _productBUL.GetProducts();

            foreach (var product in allProducts)
            {
                string img = product.Image;
                if (!string.IsNullOrEmpty(img))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                    if (File.Exists(imagePath))
                    {
                        // Thêm sản phẩm vào panel với ảnh
                        AddItem(product.ProductID.ToString(), product.ProductName,
                                Image.FromFile(imagePath), product.ProductPrice ?? 0); // Nếu giá trị null, mặc định là 0
                    }
                }
                else
                {
                    // Thêm sản phẩm vào panel với ảnh mặc định
                    AddItem(product.ProductID.ToString(), product.ProductName,
                            Properties.Resources.save, product.ProductPrice ?? 0);
                }
            }
        }

        private void UpdateTotalAmount()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells["dgvAmount"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["dgvAmount"].Value);
                }
            }
            lblTongTien.Text = total.ToString("N0");
        }
        private void SaveOrderToDatabase()
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ShoeShop;Integrated Security=True"))
                {
                    conn.Open();

                    if (!double.TryParse(lblTongTien.Text, out double totalAmount))
                    {
                        MessageBox.Show("Tổng tiền không hợp lệ.");
                        return;
                    }

                    string description = txtGhiChu.Text.Trim();
                    string selectedUserName = cboKhachHang.SelectedValue.ToString();

                    string query = @"
                        INSERT INTO Orders (TotalAmount, Status, DateCreated, UserName, Description)
                        VALUES (@TotalAmount, @Status, @DateCreated, @UserName, @Description);
                        SELECT SCOPE_IDENTITY();";  

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@Status", "Đã thanh toán");
                        cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UserName", selectedUserName);
                        cmd.Parameters.AddWithValue("@Description", description); 

                        var result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int orderId = Convert.ToInt32(result); 

                            AddOrderDetails(orderId);

                            dgvOrder.DataSource = null;
                            dgvOrder.Rows.Clear();

                            lblTongTien.Text = "0";
                            txtGhiChu.Text = ""; 
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


        private void AddOrderDetails(int orderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ShoeShop;Integrated Security=True"))
                {
                    conn.Open();
                    string query = @"
                    INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price, TotalAmount)
                    VALUES (@OrderID, @ProductID, @Quantity, @Price, @TotalAmount);";

                    foreach (DataGridViewRow row in dgvOrder.Rows)
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
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@OrderID", orderId);
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                cmd.Parameters.AddWithValue("@Quantity", quantity);
                                cmd.Parameters.AddWithValue("@Price", price);
                                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

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
            if (dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào được thêm vào đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveOrderToDatabase();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = guna2TextBox1.Text.Trim().ToLower();

            var filteredProducts = _productBUL.GetProducts()
                                              .Where(p => p.ProductName.ToLower().Contains(searchKeyword))
                                              .ToList();
            LoadProductByName(filteredProducts);
        }

        private void LoadProductByName(List<Product> products)
        {
            panSanPham.Controls.Clear();

            foreach (var product in products)
            {
                string img = product.Image;
                if (!string.IsNullOrEmpty(img))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                    if (File.Exists(imagePath))
                    {
                        AddItem(product.ProductID.ToString(), product.ProductName,
                                Image.FromFile(imagePath), product.ProductPrice ?? 0); 
                    }
                }
                else
                {
                    AddItem(product.ProductID.ToString(), product.ProductName,
                            Properties.Resources.save, product.ProductPrice ?? 0);
                }
            }
        }
    }
}
