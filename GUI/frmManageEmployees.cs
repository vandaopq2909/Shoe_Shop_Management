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
    public partial class frmManageEmployees : Form
    {
        private UsersBUL _usersBUL = new UsersBUL();
        // Biến lưu đường dẫn ảnh đã chọn
        private string selectedImagePath = string.Empty;
        public frmManageEmployees()
        {
            InitializeComponent();           
        }
        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            loadCboGioiTinh();
            loadCboTrangThai();
            loadCboChonQuyen();
            LoadDgvEmployees();
        }

        private void loadCboChonQuyen()
        {
            // Tạo danh sách các KeyValuePair cho trạng thái
            List<KeyValuePair<string, int>> RoleList = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("Admin", 1),
                new KeyValuePair<string, int>("Nhân viên", 2)
            };

            cboChonQuyen.DataSource = RoleList;

            cboChonQuyen.DisplayMember = "Key";
            cboChonQuyen.ValueMember = "Value";

            cboChonQuyen.SelectedIndex = 1;
        }

        private void LoadDgvEmployees()
        {
            var emps = _usersBUL.GetAllEmployees();
            dgvEmployees.DataSource = emps;

            dgvEmployees.Columns["UserName"].HeaderText = "Mã nhân viên";
            dgvEmployees.Columns["FullName"].HeaderText = "Họ tên";
            dgvEmployees.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dgvEmployees.Columns["Gender"].HeaderText = "Giới tính";
            dgvEmployees.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvEmployees.Columns["Address"].HeaderText = "Địa chỉ";
            dgvEmployees.Columns["isActive"].HeaderText = "Trạng thái";

            // Ẩn cột không cần thiết
            dgvEmployees.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEmployees.Columns["Password"].Visible = false;
            dgvEmployees.Columns["Image"].Visible = false;
            dgvEmployees.Columns["Role"].Visible = false;
            dgvEmployees.Columns["RoleID"].Visible = false;
        }

        private void loadCboTrangThai()
        {
            // Tạo danh sách các KeyValuePair cho trạng thái
            List<KeyValuePair<string, int>> genderList = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("Đã xóa", 0),
                new KeyValuePair<string, int>("Hoạt động", 1)
            };

            cboTrangThai.DataSource = genderList;

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoTen = txtHoTen.Text;
            string gioiTinh = cboGioiTinh.Text;
            int quyen = int.Parse(cboChonQuyen.SelectedValue.ToString());
            string SDT = txtSDT.Text;
            DateTime ngaySinh = dtpNgaySinhNV.Value;
            string email = txtEmail.Text;
            string diaChi = txtDiaChi.Text;
            int trangThai = int.Parse(cboTrangThai.SelectedValue.ToString());
            string image = selectedImagePath;

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Mã nhân viên không được để trống");
                return;
            }

            bool checkDuplicateUsername = CheckDuplicateUsername(maNV);
            if (checkDuplicateUsername == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
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
            if (string.IsNullOrEmpty(quyen.ToString()))
            {
                MessageBox.Show("Quyền không được để trống");
                return;
            }
            _usersBUL.AddEmployee(maNV, hoTen, gioiTinh, SDT, ngaySinh, email, diaChi, trangThai, quyen, image);
            MessageBox.Show("Đã thêm thành công!");
            LoadDgvEmployees();
            ClearText();
        }

        private bool CheckDuplicateUsername(string maNV)
        {
            return _usersBUL.CheckDuplicateUsername(maNV);
        }

        private void ClearText()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            picAnhNV.Image = null;
            selectedImagePath = string.Empty;
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["UserName"].Value.ToString();
                txtHoTen.Text = row.Cells["Fullname"].Value.ToString();
                cboGioiTinh.SelectedValue = row.Cells["Gender"].Value.ToString() == "Nam" ? 0 : 1;
                txtSDT.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                dtpNgaySinhNV.Value = (row.Cells["DateOfBirth"].Value as DateTime?) ?? DateTime.Now;
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDiaChi.Text = row.Cells["Address"].Value?.ToString() ?? "";
                cboTrangThai.SelectedValue = row.Cells["isActive"].Value;
                cboChonQuyen.SelectedValue = row.Cells["RoleID"].Value;
                // Hiển thị ảnh nếu có
                string img = row.Cells["Image"].Value?.ToString();
                if (!string.IsNullOrEmpty(img))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", img);
                    if (File.Exists(imagePath))
                    {
                        picAnhNV.Image = Image.FromFile(imagePath);
                        picAnhNV.Tag = img; // Lưu tên ảnh vào Tag
                    }
                    else
                    {
                        picAnhNV.Image = null;
                        picAnhNV.Tag = null;
                    }
                }
                else
                {
                    img = "";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaNV.Text;
                string hoTen = txtHoTen.Text;
                string gioiTinh = cboGioiTinh.Text;
                string SDT = txtSDT.Text;
                DateTime ngaySinh = dtpNgaySinhNV.Value;
                string email = txtEmail.Text;
                string diaChi = txtDiaChi.Text;
                int trangThai = int.Parse(cboTrangThai.SelectedValue.ToString());
                string image = picAnhNV.Tag?.ToString() ?? "";
                int quyen = int.Parse(cboChonQuyen.SelectedValue.ToString());

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    image = Path.GetFileName(selectedImagePath);
                    string targetPath = Path.Combine(Application.StartupPath, "Images", image);
                    if (!File.Exists(targetPath))
                        File.Copy(selectedImagePath, targetPath);
                }

                _usersBUL.UpdateEmployee(maKH, hoTen, gioiTinh, SDT, ngaySinh, email, diaChi, trangThai, quyen, image);
                LoadDgvEmployees();
                MessageBox.Show("Sửa nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                _usersBUL.DeleteEmployee(txtMaNV.Text);
                LoadDgvEmployees();
                MessageBox.Show("Xóa nhân viên thành công!");
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadDgvEmployees();
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }
            try
            {
                _usersBUL.ResetPassword(txtMaNV.Text);
                LoadDgvEmployees();
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
                var result = _usersBUL.GetAllEmployees()
                                        .Where(p => p.UserName.Contains(searchText) ||
                                                    p.FullName.ToLower().Contains(searchText))
                                        .ToList();
                dgvEmployees.DataSource = result;

                // Ẩn cột không cần thiết
                dgvEmployees.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvEmployees.Columns["Password"].Visible = false;
                dgvEmployees.Columns["Image"].Visible = false;
                dgvEmployees.Columns["Role"].Visible = false;
                dgvEmployees.Columns["RoleID"].Visible = false;

                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên.");
                }
            }
        }
    }
}
