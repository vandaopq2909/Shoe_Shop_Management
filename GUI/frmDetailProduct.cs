using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class frmDetailProduct : Form
    {
        public frmDetailProduct()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void frmDetailProduct_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                string qry = @"
               SELECT p.*, c.CategoryName 
               FROM Products p 
               LEFT JOIN Categories c ON p.CategoryID = c.CategoryID 
               WHERE p.ProductID = " + id;

                DataTable dt = MainClass.GetData(qry);
                foreach (DataRow row in dt.Rows)
                {
                    lblName.Text = row["ProductName"].ToString();
                    lblPrice.Text = Convert.ToDouble(row["ProductPrice"]).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
                    lblLoai.Text = row["CategoryName"].ToString();
                    lblThuongHieu.Text = row["Brand"].ToString();
                    lblSize.Text = row["Size"].ToString();
                    lblMauSac.Text = row["Color"].ToString();
                    lblTrangThai.Text = row["Status"].ToString();
                    lblMoTa.Text = row["Description"].ToString();

                    string img = row["Image"].ToString();
                    if (!string.IsNullOrEmpty(img))
                    {
                        string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                        if (File.Exists(imagePath))
                        {
                            pImage.Image = Image.FromFile(imagePath);
                            pImage.Tag = img; // Lưu tên ảnh vào Tag
                        }
                        else
                        {
                            pImage.Image = null;
                            pImage.Tag = null;
                        }
                    }
                    else
                    {
                        img = "";
                    }
                }
            }
        }
    }
}
