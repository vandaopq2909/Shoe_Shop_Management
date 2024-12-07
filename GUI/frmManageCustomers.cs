using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmManageCustomers : Form
    {
        private UsersBUL _usersBUL = new UsersBUL();
        // Biến lưu đường dẫn ảnh đã chọn
        private string selectedImagePath = string.Empty;
        public frmManageCustomers()
        {
            InitializeComponent();
            loadCboGioiTinh();
            loadCboTrangThai();
            LoadDgvCustomers();
        }

        private void loadCboTrangThai()
        {
            // Tạo danh sách các KeyValuePair cho trạng thái
            List<KeyValuePair<string, int>> statusList = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("Đã xóa", 0),
                new KeyValuePair<string, int>("Hoạt động", 1)
            };

            cboTrangThai.DataSource = statusList;

            cboTrangThai.DisplayMember = "Key";
            cboTrangThai.ValueMember = "Value";

            cboTrangThai.SelectedIndex = 1;
        }

        private void loadCboGioiTinh()
        {
            List<KeyValuePair<string, int>> genderList = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("Nam", 0),
                new KeyValuePair<string, int>("Nữ", 1)
            };

            cboGioiTinh.DataSource = genderList;

            cboGioiTinh.DisplayMember = "Key";
            cboGioiTinh.ValueMember = "Value";

            cboGioiTinh.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string hoTen = txtHoTen.Text;
            string gioiTinh = cboGioiTinh.SelectedValue.ToString();
            string SDT = txtSDT.Text;
            DateTime ngaySinh = dtpNgaySinhKH.Value;
            string email = txtEmail.Text;
            string diaChi = txtDiaChi.Text;
            int trangThai = int.Parse(cboTrangThai.SelectedValue.ToString());
            string image = selectedImagePath;

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Mã khách hàng không được để trống");
                return;
            }

            bool checkDuplicateUsername = CheckDuplicateUsername(maKH);
            if (checkDuplicateUsername == true)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                return;
            }
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Giới tính không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("Số điện thoại không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(ngaySinh.ToString()))
            {
                MessageBox.Show("Ngày sinh không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Địa chỉ không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(trangThai.ToString()))
            {
                MessageBox.Show("Trạng thái không được để trống");
                return;
            }
            _usersBUL.AddCustomer(maKH, hoTen, gioiTinh, SDT, ngaySinh, email, diaChi, trangThai, image);
            MessageBox.Show("Đã thêm thành công!");
            LoadDgvCustomers();
            ClearText();
        }

        private bool CheckDuplicateUsername(string maKH)
        {
            return _usersBUL.CheckDuplicateUsername(maKH);
        }

        private void ClearText()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            picAnhKH.Image = null;
            selectedImagePath = string.Empty;
        }

        private void LoadDgvCustomers()
        {
            var customers = _usersBUL.GetAllCustomers();
            dgvCustomers.DataSource = customers;

            dgvCustomers.Columns["UserName"].HeaderText = "Mã nhân viên";
            dgvCustomers.Columns["FullName"].HeaderText = "Họ tên";
            dgvCustomers.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dgvCustomers.Columns["Gender"].HeaderText = "Giới tính";
            dgvCustomers.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvCustomers.Columns["Address"].HeaderText = "Địa chỉ";
            dgvCustomers.Columns["isActive"].HeaderText = "Trạng thái";

            // Ẩn cột không cần thiết
            dgvCustomers.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCustomers.Columns["Password"].Visible = false;
            dgvCustomers.Columns["Image"].Visible = false;
            dgvCustomers.Columns["Role"].Visible = false;
            dgvCustomers.Columns["RoleID"].Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaKH.Text;
                string hoTen = txtHoTen.Text;
                string gioiTinh = cboGioiTinh.Text;
                string SDT = txtSDT.Text;
                DateTime ngaySinh = dtpNgaySinhKH.Value;
                string email = txtEmail.Text;
                string diaChi = txtDiaChi.Text;
                int trangThai = int.Parse(cboTrangThai.SelectedValue.ToString());
                string image = picAnhKH.Tag?.ToString() ?? "";

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    image = Path.GetFileName(selectedImagePath);
                    string targetPath = Path.Combine(Application.StartupPath, "Images", image);
                    if (!File.Exists(targetPath))
                        File.Copy(selectedImagePath, targetPath);
                }

                _usersBUL.UpdateCustomer(maKH, hoTen, gioiTinh, SDT, ngaySinh, email, diaChi, trangThai, image);
                LoadDgvCustomers();
                MessageBox.Show("Sửa khách hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa khách hàng: " + ex.Message);
            }
        }

        private void btnChonAnhKH_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Chọn hình ảnh";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picAnhKH.Image = new Bitmap(selectedImagePath);
                    picAnhKH.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["UserName"].Value.ToString();
                txtHoTen.Text = row.Cells["Fullname"].Value.ToString();
                cboGioiTinh.SelectedValue = row.Cells["Gender"].Value.ToString() == "Nam" ? 0 : 1;
                txtSDT.Text = row.Cells["PhoneNumber"].Value.ToString();
                dtpNgaySinhKH.Value = (DateTime)row.Cells["DateOfBirth"].Value;
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDiaChi.Text = row.Cells["Address"].Value.ToString();
                cboTrangThai.SelectedValue = row.Cells["isActive"].Value;

                // Hiển thị ảnh nếu có
                string img = row.Cells["Image"].Value?.ToString();
                if (!string.IsNullOrEmpty(img))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                    if (File.Exists(imagePath))
                    {
                        picAnhKH.Image = Image.FromFile(imagePath);
                        picAnhKH.Tag = img; // Lưu tên ảnh vào Tag
                    }
                    else
                    {
                        picAnhKH.Image = null;
                        picAnhKH.Tag = null;
                    }
                }
                else
                {
                    img = "";
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadDgvCustomers();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                _usersBUL.DeleteCustomer(txtMaKH.Text);
                LoadDgvCustomers();
                MessageBox.Show("Xóa khách hàng thành công!");
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm: " + ex.Message);
            }
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaKH.Text)) {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }
            try 
            {
                _usersBUL.ResetPassword(txtMaKH.Text);
                LoadDgvCustomers();
                MessageBox.Show("Đặt lại mật khẩu thành công!");
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt lại mật khẩu: " + ex.Message);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                var result = _usersBUL.GetAllCustomers()
                                        .Where(p => p.UserName.Contains(searchText) ||
                                                    p.FullName.ToLower().Contains(searchText))
                                        .ToList();
                dgvCustomers.DataSource = result;

                // Ẩn cột không cần thiết
                dgvCustomers.Columns["Password"].Visible = false;
                dgvCustomers.Columns["Image"].Visible = false;
                dgvCustomers.Columns["Role"].Visible = false;
                dgvCustomers.Columns["RoleID"].Visible = false;

                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng.");
                }
            }
        }
    }
}
