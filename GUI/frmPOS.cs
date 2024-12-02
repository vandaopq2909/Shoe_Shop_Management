using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProduct();
            SetupDataGridView();
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

            lblTongTien.Text = total.ToString("C"); // Hiển thị tổng tiền (vd: dạng tiền tệ)
        }

    }
}
