using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BUL;

namespace GUI
{
    public partial class frmManageProducts : Form
    {
        private ProductBUL _productBUL;
        private CategoriesBUL _categoriesBUL;

        // Biến lưu đường dẫn ảnh đã chọn
        private string selectedImagePath = string.Empty;

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
            var pro = _productBUL.GetProducts().Select(pro => new
            {
                pro.ProductID,
                pro.ProductName,
                pro.ProductPrice,
                pro.Brand,
                pro.Description,
                pro.Color,
                pro.Quantity,
                pro.Size,
                CategoryName = pro.Category.CategoryName,
                pro.Status,
                pro.CategoryID,
                pro.Image
            }).ToList();
            dgvProducts.DataSource = pro;

            dgvProducts.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            dgvProducts.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgvProducts.Columns["ProductPrice"].HeaderText = "Giá";
            dgvProducts.Columns["Brand"].HeaderText = "Thương hiệu";
            dgvProducts.Columns["Color"].HeaderText = "Màu sắc";
            dgvProducts.Columns["Size"].HeaderText = "Kích thước";
            dgvProducts.Columns["Quantity"].HeaderText = "Tồn kho";
            dgvProducts.Columns["CategoryName"].HeaderText = "Tên loại";
            dgvProducts.Columns["Description"].HeaderText = "Mô tả";

            dgvProducts.Columns["Status"].Visible = false;
            dgvProducts.Columns["CategoryID"].Visible = false;
            dgvProducts.Columns["Image"].Visible = false;
        }

        void Load_ComboBox()
        {
            var cat = _categoriesBUL.GetCategories().ToList();

            cbxTenLoai.DataSource = cat;
            cbxTenLoai.DisplayMember = "CategoryName";
            cbxTenLoai.ValueMember = "CategoryID";
        }

        void clearText()
        {
            cbxTenLoai.SelectedIndex = 0;
            txtGiaBan.Clear();
            txtKichThuoc.Clear();
            txtMaSP.Clear();
            txtMauSac.Clear();
            txtMoTa.Clear();
            txtSearch.Clear();
            txtTenSP.Clear();
            txtThuongHieu.Clear();
            ckbTrangThai.Checked = false;
            nudSoLuong.Value = 0;
            ptbSanPham.Image = null;
            selectedImagePath = string.Empty;
            txtTenSP.Focus();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["ProductID"].Value.ToString();
                txtTenSP.Text = row.Cells["ProductName"].Value.ToString();
                txtKichThuoc.Text = row.Cells["Size"].Value.ToString();
                txtGiaBan.Text = row.Cells["ProductPrice"].Value.ToString();
                txtMoTa.Text = row.Cells["Description"].Value.ToString();
                txtMauSac.Text = row.Cells["Color"].Value.ToString();
                txtThuongHieu.Text = row.Cells["Brand"].Value.ToString();
                ckbTrangThai.Checked = row.Cells["Status"].Value.ToString() == "Còn hàng";
                nudSoLuong.Value = Convert.ToDecimal(row.Cells["Quantity"].Value);
                cbxTenLoai.SelectedValue = row.Cells["CategoryID"].Value;

                // Hiển thị ảnh nếu có
                string img = row.Cells["Image"].Value?.ToString();
                if (!string.IsNullOrEmpty(img))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                    if (File.Exists(imagePath))
                    {
                        ptbSanPham.Image = Image.FromFile(imagePath);
                        ptbSanPham.Tag = img; // Lưu tên ảnh vào Tag
                    }
                    else
                    {
                        ptbSanPham.Image = null;
                        ptbSanPham.Tag = null;
                    }
                }
                else 
                { 
                    img = "";
                } 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int catID = int.Parse(cbxTenLoai.SelectedValue.ToString());
                string name = txtTenSP.Text;
                float prize = float.Parse(txtGiaBan.Text);
                string des = txtMoTa.Text;
                int quantity = Convert.ToInt32(nudSoLuong.Value);
                string size = txtKichThuoc.Text;
                string color = txtMauSac.Text;
                string brand = txtThuongHieu.Text;
                string status = ckbTrangThai.Checked ? "Còn hàng" : "Hết hàng";
                string img = "";

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    img = Path.GetFileName(selectedImagePath);
                    string targetPath = Path.Combine(Application.StartupPath, "Images", img);
                    if (!Directory.Exists(Path.Combine(Application.StartupPath, "Images")))
                        Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Images"));

                    if (!File.Exists(targetPath))
                        File.Copy(selectedImagePath, targetPath);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ảnh!");
                    return;
                }

                _productBUL.AddProduct(catID, name, prize, des, quantity, size, color, brand, status, img);
                Load_Product();
                MessageBox.Show("Thêm sản phẩm thành công!");
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                _productBUL.DeleteProduct(Convert.ToInt32(txtMaSP.Text));
                Load_Product();
                MessageBox.Show("Xóa sản phẩm thành công!");
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int catID = int.Parse(cbxTenLoai.SelectedValue.ToString());
                int proID = int.Parse(txtMaSP.Text);
                string name = txtTenSP.Text;
                float prize = float.Parse(txtGiaBan.Text);
                string des = txtMoTa.Text;
                int quantity = Convert.ToInt32(nudSoLuong.Value);
                string size = txtKichThuoc.Text;
                string color = txtMauSac.Text;
                string brand = txtThuongHieu.Text;
                string status = ckbTrangThai.Checked ? "Còn hàng" : "Hết hàng";
                string img = ptbSanPham.Tag?.ToString() ?? "";

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    img = Path.GetFileName(selectedImagePath);
                    string targetPath = Path.Combine(Application.StartupPath, "Images", img);
                    if (!File.Exists(targetPath))
                        File.Copy(selectedImagePath, targetPath);
                }

                _productBUL.UpdateProduct(catID, proID, name, prize, des, quantity, size, color, brand, status, img);
                Load_Product();
                MessageBox.Show("Sửa sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sản phẩm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnChonAnhSP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Chọn hình ảnh";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    ptbSanPham.Image = new Bitmap(selectedImagePath);
                    ptbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                var result = _productBUL.GetProducts()
                                        .Where(p => p.ProductID.ToString().Contains(searchText) ||
                                                    p.ProductName.ToLower().Contains(searchText))
                                        .ToList();
                dgvProducts.DataSource = result;

                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.");
                }
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép các ký tự số và dấu chấm thập phân
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn nhập các ký tự không hợp lệ
            }

            // Chỉ cho phép một dấu chấm thập phân
            if (e.KeyChar == '.' && txtGiaBan.Text.Contains("."))
            {
                e.Handled = true; // Ngăn nhập dấu chấm thập phân thứ hai
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
