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
    public partial class frmManageCategories : Form
    {
        private CategoriesBUL _categoriesBUL;
        bool flagInsert = false;
        bool flagUpdate = false;

        public frmManageCategories()
        {
            InitializeComponent();
            _categoriesBUL = new CategoriesBUL();
        }
        
        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            Load_Categories();
        }

        void Load_Categories()
        {
            var cat = _categoriesBUL.GetCategories().ToList();
            dgvCategories.DataSource = cat;
        }
        void clearText()
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            txtCategoryID.Focus();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            flagInsert = true;
            flagUpdate = false;
            MessageBox.Show("Nhập thông tin để thêm dữ liệu!\n Bấm 'Lưu' để hoàn tất thao tác.");
            clearText();            
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            _categoriesBUL.DeleteCategory(txtCategoryID.Text);
            Load_Categories();
            MessageBox.Show("Đã xóa thành công!");
            clearText();
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagInsert = false;
            MessageBox.Show("Nhập thông tin để sửa dữ liệu!\n Bấm 'Lưu' để hoàn tất thao tác.");
            clearText();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            if(!flagInsert && !flagUpdate)
            {
                MessageBox.Show("Bạn chưa chọn chức năng");
                return;
            }

            if (string.IsNullOrEmpty(txtCategoryID.Text) || string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ID hoặc Tên danh mục không được để trống");
                return;
            }
            try
            {
                if (flagInsert)
                {
                    _categoriesBUL.AddCategory(txtCategoryID.Text, txtCategoryName.Text);
                    MessageBox.Show("Đã thêm thành công!");
                    Load_Categories();
                }

                if (flagUpdate)
                {
                    _categoriesBUL.UpdateCategory(txtCategoryID.Text, txtCategoryName.Text);
                    MessageBox.Show("Đã sửa thành công!");
                    Load_Categories();
                }
                flagInsert = false;
                flagUpdate = false;
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshCat_Click(object sender, EventArgs e)
        {
            flagInsert = false;
            flagUpdate = false;
            clearText();            
        }

        private void btnExitCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];

                txtCategoryID.Text = row.Cells["CategoryID"].Value.ToString();
                txtCategoryName.Text = row.Cells["CategoryName"].Value.ToString();
            }
        }
    }
}
