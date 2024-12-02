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
    public partial class frmManagePurchaseReceipts : Form
    {
        public string MaNV {  get; set; }
        public SuppliersBUL _suppliersBUL = new SuppliersBUL();
        public PurchaseReceiptsBUL _purchaseReceiptsBUL = new PurchaseReceiptsBUL();
        public PRDetailsBUL _pRDetailsBUL = new PRDetailsBUL();        
        public ProductBUL _productBUL = new ProductBUL();
        public int PRID = 0;
        public frmManagePurchaseReceipts()
        {
            InitializeComponent();
        }

        private void frmManagePurchaseReceipts_Load(object sender, EventArgs e)
        {
            dtpNgayNhap.Value = DateTime.Now;
            LoadSuppliers();
            LoadCboChonSP();
            LoadPR();
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

        private void LoadPR()
        {
            dgvPR.DataSource = _purchaseReceiptsBUL.GetAllPR()
            .Select(pr => new {
                pr.PReceiptID,
                pr.DateCreated,
                pr.TotalAmount,
                SupplierName = pr.Supplier.SupplierName,
                CreatedBy = pr.User.FullName,
                pr.SupplierID
            }).ToList();
            dgvPR.Columns["SupplierID"].Visible = false;
        }

        private void LoadSuppliers()
        {
            cboNCC.DataSource = _suppliersBUL.GetAllSuppliers();
            cboNCC.DisplayMember = "SupplierName";
            cboNCC.ValueMember = "SupplierID";
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            int maNCC = int.Parse(cboNCC.SelectedValue.ToString());
            DateTime ngayNhap = dtpNgayNhap.Value;
            string maNV = MaNV;
            _purchaseReceiptsBUL.AddPR(maNCC, ngayNhap, maNV);

            MessageBox.Show("Thêm phiếu nhập thành công");
            LoadPR();
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            int maPN = PRID; 
            int maNCC = int.Parse(cboNCC.SelectedValue.ToString());
            DateTime ngayNhap = dtpNgayNhap.Value;

            if (maPN == 0) {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }
            if (string.IsNullOrEmpty(maNCC.ToString()))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                return;
            }
            try
            {
                _purchaseReceiptsBUL.UpdatePR(maPN, maNCC, ngayNhap);
                MessageBox.Show("Đã sửa thành công!");
                LoadPR();
            }
            catch (Exception ex) {
                MessageBox.Show("Sửa thất bại!"+ ex);
            }
        }

        private void dgvPR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPR.Rows[e.RowIndex];

                PRID = int.Parse(row.Cells["PReceiptID"].Value.ToString());
                cboNCC.SelectedValue = int.Parse(row.Cells["SupplierID"].Value.ToString());
                dtpNgayNhap.Value = (row.Cells["DateCreated"].Value as DateTime?) ?? DateTime.Now;
                LoadPRDetails(PRID);
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            int maPN = PRID;
            _purchaseReceiptsBUL.DeletePR(maPN);
            LoadPR();
            MessageBox.Show("Đã xóa thành công!");
        }

        private void btnLamMoiPN_Click(object sender, EventArgs e)
        {
            LoadPR();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(cboChonSP.SelectedValue.ToString());
            int maPN = PRID;
            int soLuong = int.Parse(numSoLuong.Value.ToString());
            double gia = _productBUL.getGiaProductByID(maSP);

            if(maPN == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập!");
                return;
            }
            if (string.IsNullOrEmpty(maSP.ToString()))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }
            if (string.IsNullOrEmpty(soLuong.ToString()))
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            }
            _pRDetailsBUL.AddPRDetails(maPN, maSP, soLuong, gia);
            MessageBox.Show("Thêm thành công!");
            LoadPRDetails(maPN);
            LoadPR();
        }

        private void LoadPRDetails(int maPN)
        {
            dgvPRDetail.DataSource = _pRDetailsBUL.GetAllPRDetails(maPN)
             .Select(pr => new {
                 pr.PReceiptID,
                 pr.ProductID,
                 pr.Price,
                 pr.Quantity,
                 pr.Product.ProductName
             }).ToList();
            dgvPRDetail.Columns["ProductID"].Visible = false;
        }

        private void dgvPRDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int maPN = PRID;
            int maSP = int.Parse(cboChonSP.SelectedValue.ToString());
            _pRDetailsBUL.DeletePRDetails(maPN, maSP);
            MessageBox.Show("Xóa thành công!");
            LoadPRDetails(maPN);
            LoadPR();

        }
    }
}
