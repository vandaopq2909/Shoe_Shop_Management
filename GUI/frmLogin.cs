using BUL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        Form frmMNGroupUser, frmMNListScreen, frmMNRole, frmMNUser_GroupUser, frmMNUser;
        public string? userName { get; set; }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập " + txtUserName.Text);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập" + txtPassword.Text);
                txtPassword.Focus();
                return;
            }
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            UsersDTO usersDTO = new UsersDTO(userName, password);
            UsersBUL usersBUL = new UsersBUL();
            if (usersBUL.isValid(usersDTO))
            {
                MessageBox.Show("Đăng nhập thành công");
                frmMain frm = new frmMain();
                frm.userName = userName;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
