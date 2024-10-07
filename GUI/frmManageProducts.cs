using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DAL;

namespace GUI
{
    public partial class frmManageProducts : Form
    {
        private ProductBUL _productBUL;
        private CategoriesBUL _categoriesBUL;
        bool flagInsert = false;
        bool flagUpdate = false;

        public frmManageProducts()
        {
            InitializeComponent();
            _productBUL = new ProductBUL();
            _categoriesBUL = new CategoriesBUL();
        }

        private void frmManageProducts_Load(object sender, EventArgs e)
        {
            Load_Product();
            Load_ComboBox();
        }
        void Load_Product()
        {
            var pro = _productBUL.GetProducts().ToList();
            dgvProducts.DataSource = pro;
        }
        void Load_ComboBox()
        {
            var cat = _categoriesBUL.GetCategories().ToList();

            cbxCategoryName.DataSource = cat;
            cbxCategoryName.DisplayMember = "CategoryName";  
            cbxCategoryName.ValueMember = "CategoryID";     
        }

        void clearText()
        {
            cbxCategoryName.SelectedIndex = 0;
            txtBrand.Clear();
            txtProductID.Clear();
            txtProductName.Clear();
            txtSize.Clear();
            txtPrice.Clear();
            txtImage.Clear();
            txtDescription.Clear();
            txtColor.Clear();
            txtProductID.Focus();
        }
        private void btnAddPro_Click(object sender, EventArgs e)
        {
            flagInsert = true;
            flagUpdate = false;
            MessageBox.Show("Nhập thông tin để thêm dữ liệu!\n Bấm 'Lưu' để hoàn tất thao tác.");
            clearText();
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            _productBUL.DeleteProduct(txtProductID.Text);
            Load_Product();
            MessageBox.Show("Đã xóa thành công!");
            clearText();
        }

        private void btnUpdatePro_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagInsert = false;
            MessageBox.Show("Nhập thông tin để sửa dữ liệu!\n Bấm 'Lưu' để hoàn tất thao tác.");
            clearText();
        }

        private void btnSavePro_Click(object sender, EventArgs e)
        {
            string catID = cbxCategoryName.SelectedValue.ToString();
            string proID = txtProductID.Text;
            string name = txtProductName.Text;
            decimal prize = decimal.Parse(txtPrice.Text);
            string des = txtDescription.Text;
            int size = int.Parse(txtSize.Text);
            string color = txtColor.Text;
            string brand = txtBrand.Text;
            string img = txtImage.Text;

            try
            {
                if (flagInsert)
                {
                    _productBUL.AddProduct(catID, proID, name, prize, des, size, color, brand, img);
                    Load_Product();
                    MessageBox.Show("Đã thêm thành công!");                    
                }
                if (flagUpdate)
                {
                    _productBUL.UpdateProduct(catID, proID, name, prize, des, size, color, brand, img);
                    Load_Product();
                    MessageBox.Show("Đã sửa thành công!");                    
                }

                flagUpdate = false;
                flagInsert = false;
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnRefreshPro_Click(object sender, EventArgs e)
        {

            flagUpdate = false;
            flagInsert = false;
            clearText();
        }

        private void btnExitPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtSize.Text = row.Cells["Size"].Value.ToString();
                txtPrice.Text = row.Cells["ProductPrice"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value.ToString();
                txtImage.Text = row.Cells["Image"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();

                cbxCategoryName.SelectedValue = row.Cells["CategoryID"].Value;
            }
        }
    }
}
