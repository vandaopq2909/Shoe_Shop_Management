using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class ucProduct : UserControl
    {
        public EventHandler onSelect = null;
        public ucProduct()
        {
            InitializeComponent();
        }
        public int id { get;set;}
        public string cost {  get; set;}
        public double ? price
        {
            get { return double.Parse(lblProductPrice.Text); }
            set { lblProductPrice.Text = value?.ToString("N0"); }
        }
        public string name {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public Image image
        {
            get { return pImage.Image; }
            set { pImage.Image = value; }
        }

        private void pImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this,e);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmDetailProduct() { id = id });
        }

        private void ucProduct_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
        }

        private void ucProduct_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.WhiteSmoke;
        }
    }
}
