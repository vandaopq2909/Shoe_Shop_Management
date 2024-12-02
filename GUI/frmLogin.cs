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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            userControl11.LoginSuccessful += LoginControl_LoginSuccessful;
        }

        private void LoginControl_LoginSuccessful(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.maNhanVien = userControl11.MaNV;
            frm.Show();
            this.Hide();
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
