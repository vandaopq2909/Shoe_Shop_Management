﻿using BUL;
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
    public partial class frmMain : Form
    {
        public string maNhanVien {  get; set; }
        public UsersBUL _userBUL = new UsersBUL();
        public frmMain()
        {
            InitializeComponent();
            
        }
        public void AddControl(Form f)
        {
            panelCenter.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelCenter.Controls.Add(f);
            f.Show();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            AddControl(new frmManageEmployees());
        }

        private void btnQLLoai_Click(object sender, EventArgs e)
        {
            AddControl(new frmManageCategories());
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            AddControl(new frmManageProducts());
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControl(new frmPOS());
	}
        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            AddControl(new frmManageCustomers());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadInfoUser();
        }

        private void LoadInfoUser()
        {
            User user = _userBUL.LoadInfoUserByMaNV(maNhanVien);
            lblNameAndRole.Text = user.FullName + " - " + user.Role.RoleName;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

            this.Hide();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.maNV = maNhanVien;
            frm.ShowDialog();
        }
    }
}
