using BUL;
using DAL;
using Guna.UI2.WinForms;
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

namespace GUI
{
    public partial class frmManagemnetOrder : Form
    {
        public frmManagemnetOrder()
        {
            InitializeComponent();
        }
        public string MaKH { get; set; }
        public UsersBUL usersBUL=new UsersBUL();
        public OrderBUL orderBUL = new OrderBUL();
        public OrderDetailBUL orderDetailBUL = new OrderDetailBUL();
        public ProductBUL _productBUL = new ProductBUL();
        public int ORDID = 0, ProductID=0,Quantity=0;
        public double Price = 0, TotalAmount = 0;

        private void frmManagePurchaseReceipts_Load(object sender, EventArgs e)
        {
         
    
            LoadOrder();
        }

        private void LoadOrder()
        {
         
            dgvOrder.DataSource = orderBUL.GetAllOrder().OrderByDescending(x=>x.DateCreated)
            .Select(order => new
            {
                order.OrderID,
                order.User.FullName,
                order.DateCreated,
                order.TotalAmount,
                order.Description,
                order.Status
            })
            .ToList();
            dgvOrder.Columns["OrderID"].HeaderText = "Mã Đơn Hàng";
            dgvOrder.Columns["FullName"].HeaderText = "Tên Khách Hàng";
            dgvOrder.Columns["DateCreated"].HeaderText = "Ngày Mua Hàng";
            dgvOrder.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
            dgvOrder.Columns["Description"].HeaderText = "Mô Tả";
            dgvOrder.Columns["Status"].HeaderText = "Trạng thái";
            dgvOrder.RowTemplate.Height = 40;
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dgvPR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrder.Rows[e.RowIndex];

                ORDID = int.Parse(row.Cells["OrderID"].Value.ToString());
             
                TotalAmount= double.Parse(row.Cells["TotalAmount"].Value.ToString());
                LoadOrderDetails(ORDID);
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            int maPN = ORDID;
            orderBUL.DeletePR(maPN);
            LoadOrder();
            MessageBox.Show("Đã xóa thành công!");
        }

        private void btnLamMoiPN_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim().ToLower();

            var filteredOrders = orderBUL.GetAllOrder()
                                              .Where(p => p.User.FullName.ToLower().Contains(searchKeyword))
                                              .ToList();
            LoadOrderByUserFullName(filteredOrders);
        }

        private void LoadOrderByUserFullName(List<Order> orders)
        {
            // Clear the existing data in the data grid
            dgvOrder.DataSource = null;

            // If there are no orders found, show a message or set a placeholder in the UI
            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đơn hàng !");
                return;
            }

            var orderList = orders.Select(order => new {
                order.OrderID,
                FullName=order.User.FullName,
                order.DateCreated,
                order.TotalAmount,
                order.Description,
                order.Status
            }).ToList();
       
            dgvOrder.DataSource = orderList;

            dgvOrder.Columns["OrderID"].HeaderText = "Mã Đơn Hàng";
            dgvOrder.Columns["FullName"].HeaderText = "Tên Khách Hàng";
            dgvOrder.Columns["DateCreated"].HeaderText = "Ngày Mua Hàng";
            dgvOrder.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
            dgvOrder.Columns["Description"].HeaderText = "Mô Tả";
            dgvOrder.Columns["Status"].HeaderText = "Trạng thái";
            dgvOrder.RowTemplate.Height = 40;

    
            dgvOrder.Refresh();
        }


        private void btnThemSP_Click(object sender, EventArgs e)
        {
          
        }

        private void LoadOrderDetails(int ma)
        {
            dgvPRDetail.DataSource = orderDetailBUL.GetAllDetails(ma)
             .Select(pr => new
             {
                 pr.OrderID,
                 pr.Product.ProductName,
                 pr.Quantity,
                 pr.Price,
                 pr.TotalAmount
             }).ToList();
            dgvPRDetail.Columns["OrderID"].HeaderText = "Mã Đơn Hàng";
            dgvPRDetail.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
            dgvPRDetail.Columns["Quantity"].HeaderText = "Số Lượng";
            dgvPRDetail.Columns["Price"].HeaderText = "Đơn Giá";
            dgvPRDetail.Columns["TotalAmount"].HeaderText = "Thành Tiền";
            dgvPRDetail.RowTemplate.Height = 40;
            //dgvPRDetail.Columns["ProductID"].Visible = false;
        }

        private void dgvPRDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
