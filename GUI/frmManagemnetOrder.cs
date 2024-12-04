using BUL;
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
            dtpNgayNhap.Value = DateTime.Now;
            LoadSuppliers();
            LoadCboChonSP();
            LoadOrder();
        }

        private void LoadCboChonSP()
        {
            var listSP = _productBUL.GetProducts();
            cboChonSP.DataSource = listSP;
            cboChonSP.DisplayMember = "ProductName";
            cboChonSP.ValueMember = "ProductID";

            // Thiết lập AutoComplete
            cboChonSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Gợi ý và cho phép nhập
            cboChonSP.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Thêm danh sách sản phẩm vào AutoComplete
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            foreach (var row in listSP)
            {
                autoComplete.Add(row.ProductName);
            }
            cboChonSP.AutoCompleteCustomSource = autoComplete;
        }

        private void LoadOrder()
        {
            dgvOrder.DataSource = orderBUL.GetAllOrder()
            .Select(order => new
            {
                order.OrderID,
                order.UserName,
                order.DateCreated,
                TotalAmount = string.Format(new CultureInfo("vi-VN"), "{0:C0}", order.TotalAmount),
                order.Description,
                order.Status
            })
            .ToList();
        }

        private void LoadSuppliers()
        {
            cboKH.DataSource = usersBUL.GetAllCustomers();
            cboKH.DisplayMember = "FullName";
            cboKH.ValueMember = "UserName";
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            string makh = cboKH.SelectedValue.ToString();
            DateTime ngayNhap = dtpNgayNhap.Value;
            orderBUL.AddOrder(makh, ngayNhap);
            MessageBox.Show("Thêm phiếu nhập thành công");
            LoadOrder();
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            int ma = ORDID;
            string makh =cboKH.SelectedValue.ToString();
            DateTime ngayNhap = dtpNgayNhap.Value;

            if (ma == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }
            if (string.IsNullOrEmpty(makh.ToString()))
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }
            try
            {
                orderBUL.UpdateOrder(ma, makh, ngayNhap);
                MessageBox.Show("Đã sửa thành công!");
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!" + ex);
            }
        }

        private void dgvPR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrder.Rows[e.RowIndex];

                ORDID = int.Parse(row.Cells["OrderID"].Value.ToString());
                //ProductID = int.Parse(row.Cells["ProductID"].Value.ToString()) ;
                //Quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                
                cboKH.SelectedValue = row.Cells["UserName"].Value.ToString();
                dtpNgayNhap.Value = (row.Cells["DateCreated"].Value as DateTime?) ?? DateTime.Now;
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

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            //int maSP = int.Parse(cboChonSP.SelectedValue.ToString());
            //int maPN = PRID;
            //int soLuong = int.Parse(numSoLuong.Value.ToString());
            //double gia = _productBUL.getGiaProductByID(maSP);

            //if (maPN == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn phiếu nhập!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(maSP.ToString()))
            //{
            //    MessageBox.Show("Vui lòng chọn sản phẩm!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(soLuong.ToString()))
            //{
            //    MessageBox.Show("Vui lòng nhập số lượng!");
            //    return;
            //}
            //_pRDetailsBUL.AddPRDetails(maPN, maSP, soLuong, gia);
            //MessageBox.Show("Thêm thành công!");
            //LoadPRDetails(maPN);
            //LoadPR();
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
            //dgvPRDetail.Columns["ProductID"].Visible = false;
        }

        private void dgvPRDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int ma = ORDID;
            int maSP = int.Parse(cboChonSP.SelectedValue.ToString());
            orderDetailBUL.DeleteOrderDetails(ma, maSP);
            MessageBox.Show("Xóa thành công!");
            LoadOrderDetails(ma);
            LoadOrder();

        }
    }
}
