using BUL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChangePassword : Form
    {
        public UsersBUL _usersBUL = new UsersBUL();
        public string maNV {  get; set; }   
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = maNV;
        }

        private void btnDoiMKMoi_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string mkCu = txtMKCu.Text;
            string mkMoi = txtMKMoi.Text;
            string nhapLaiMKMoi = txtNhapLaiMKMoi.Text;

            if (string.IsNullOrEmpty(maNV)) {
                MessageBox.Show("Mã nhân viên không được để trống!");
                txtMaNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mkCu))
            {
                MessageBox.Show("Mật khẩu cũ không được để trống!");
                txtMKCu.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mkMoi))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!");
                txtMKMoi.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nhapLaiMKMoi))
            {
                MessageBox.Show("Nhập lại mật khẩu mới không được để trống!");
                txtNhapLaiMKMoi.Focus();
                return;
            }

            if (mkMoi != nhapLaiMKMoi) {
                MessageBox.Show("Mật khẩu mới không khớp!");
                txtNhapLaiMKMoi.Focus();
                return;
            }
            bool checkDoiMK = _usersBUL.ChangePass(maNV, mkCu, mkMoi);
            if (checkDoiMK) {
                MessageBox.Show("Đổi mật khẩu thành công!");
                txtMKCu.Clear();
                txtMKMoi.Clear();
                txtNhapLaiMKMoi.Clear();
                return;
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
            }
                                  
        }
    }
}
