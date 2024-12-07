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

            dgvCategories.Columns["CategoryID"].HeaderText = "Mã loại";
            dgvCategories.Columns["CategoryName"].HeaderText = "Tên loại";
        }
        void clearText()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtMaLoai.Focus();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];

                txtMaLoai.Text = row.Cells["CategoryID"].Value.ToString();
                txtTenLoai.Text = row.Cells["CategoryName"].Value.ToString();
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống");
                return;
            }
            //int ma = int.Parse(txtMaLoai.Text);
            _categoriesBUL.AddCategory(txtTenLoai.Text);
            MessageBox.Show("Đã thêm thành công!");
            Load_Categories();
            clearText();
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaLoai.Text);
            _categoriesBUL.DeleteCategory(ma);
            Load_Categories();
            MessageBox.Show("Đã xóa thành công!");
            clearText();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text) || string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("ID hoặc Tên danh mục không được để trống");
                return;
            }
            int ma = int.Parse(txtMaLoai.Text);
            _categoriesBUL.UpdateCategory(ma, txtTenLoai.Text);
            MessageBox.Show("Đã sửa thành công!");
            Load_Categories();
            clearText();
        }

        private void btnLamMoiLoai_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Kiểm tra xem người dùng có nhấn Enter không
            {
                string searchText = txtSearch.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Vui lòng nhập mã loại hoặc tên loại để tìm kiếm.");
                    return;
                }

                // Tìm kiếm sản phẩm theo mã sản phẩm hoặc tên loại
                var searchResult = _categoriesBUL.GetCategories()
                                              .Where(c => c.CategoryID.ToString().Contains(searchText) ||
                                                          c.CategoryName.ToLower().Contains(searchText))
                                              .ToList();

                // Hiển thị kết quả tìm kiếm lên DataGridView
                dgvCategories.DataSource = searchResult;

                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy loại nào khớp với tìm kiếm.");
                }                
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
