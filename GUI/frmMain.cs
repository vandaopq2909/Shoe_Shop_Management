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
    }
}
