using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Control
{
    public partial class UserControl1 : UserControl
    {
        // Sự kiện để báo khi đăng nhập thành công
        public event EventHandler LoginSuccessful;
        public string MaNV { get; set; }
        public string MatKhau { get; set; }
        public UsersBUL _usersBUL = new UsersBUL();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            chkHienThiMK.Checked = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string matKhau = txtMK.Text;

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Mã nhân viên không được để trống!");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }

            bool checkLogin = _usersBUL.IsExistEmployee(maNV, matKhau);
            if (checkLogin)
            {
                MessageBox.Show("Đăng nhập thành công!");

                MaNV = maNV;
                MatKhau = matKhau;
                // Gọi sự kiện LoginSuccessful
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
                return;
            }
            else
            {
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không chính xác!");
                txtMaNV.Focus();
                return;
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtMK.Clear();
            txtMaNV.Focus();
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }
    }
}
