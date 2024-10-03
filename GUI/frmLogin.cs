using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length == 0)
            {
                MessageBox.Show("Vui long nhap " + txtTenDangNhap.Text);
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Vui long nhap " + txtMatKhau.Text);
                txtMatKhau.Focus();
                return;
            }

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            
        }
    }
}
