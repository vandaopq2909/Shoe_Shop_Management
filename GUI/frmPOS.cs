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
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (Convert.ToUInt32(row.Cells["ProductID"].Value) == wdg.id)
                    {
                        row.Cells["dgvQty"].Value = int.Parse(row.Cells["dgvQty"].Value.ToString()) + 1;
                        row.Cells["dgvAmount"].Value =
                            (int.Parse(row.Cells["dgvQty"].Value.ToString())) *
                            int.Parse(row.Cells["dgvPrice"].Value.ToString());
                        return;
                    }
                }
                guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.name, wdg.price, 1, wdg.price });
            };
        }
        //Byte[] ImageArray = (byte[])(dt.Rows[0]["Image"]);

        //byte[] ImageByArray = ImageArray;
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
    }
}
