using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;

namespace GUI
{
    public partial class frmManageOrders : Form
    {
        public OrdersBUL bul = new OrdersBUL();
        public frmManageOrders()
        {
            InitializeComponent();
        }

        private void frmManageOrders_Load(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void loadOrders()
        {
           var listOrders = bul.getListOrders();
            dgvOrders.DataSource = listOrders;
        }
    }
}
