using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class frmReportStatistics : Form
    {
        public OrdersBUL _ordersBUL = new OrdersBUL();
        public int year = DateTime.Now.Year;
        public int month = DateTime.Now.Month;
        public double tongDoanhThu = 0;
        public frmReportStatistics()
        {
            InitializeComponent();
        }

        private void frmReportStatistics_Load(object sender, EventArgs e)
        {
            dtpChonTG.Value = DateTime.Now;
        }

        private void btnTKTheoNgay_Click(object sender, EventArgs e)
        {
            lblChonTG.Enabled = false;
            dtpChonTG.Enabled = false;
            dtpChonTG.Value = DateTime.Now;

            var date = DateTime.Now;
            var data = _ordersBUL.ThongKeTheoNgay(date).Select(od => new 
            {
                od.OrderID,
                od.DateCreated,
                Quantity = _ordersBUL.GetProQuantity(od.OrderID),
                od.TotalAmount,
                CustomerName = od.User.FullName,
                od.Description
            }).ToList();
            dgvThongKe.DataSource = data;

            if (data.Count > 0) {
                dgvThongKe.Columns["OrderID"].HeaderText = "Mã đơn hàng";
                dgvThongKe.Columns["TotalAmount"].HeaderText = "Tổng tiền";
                dgvThongKe.Columns["Quantity"].HeaderText = "Số lượng sản phẩm";
                dgvThongKe.Columns["DateCreated"].HeaderText = "Ngày tạo";
                dgvThongKe.Columns["CustomerName"].HeaderText = "Tên khách hàng";
                dgvThongKe.Columns["Description"].HeaderText = "Mô tả";

                if (dgvThongKe.Columns["DateCreated"] != null)
                {
                    dgvThongKe.Columns["DateCreated"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (dgvThongKe.Columns["TotalAmount"] != null)
                {
                    dgvThongKe.Columns["TotalAmount"].DefaultCellStyle.Format = "N0";
                }

                lblTongTien.Text = data.Select(x => x.TotalAmount ?? 0).Sum().ToString("N0") + " đ";
            }
            else
            {
                lblTongTien.Text = "0 đ";
            }
        }

        private void btnTKTheoTuan_Click(object sender, EventArgs e)
        {
            lblChonTG.Enabled = false;
            dtpChonTG.Enabled = false;
            dtpChonTG.Value = DateTime.Now;

            var date = DateTime.Today;
            var data = _ordersBUL.ThongKeTheoTuan(date);

            dgvThongKe.DataSource = data;

            if (data.Count > 0) {
                if (dgvThongKe.Columns["DayOfWeek"] != null)
                    dgvThongKe.Columns["DayOfWeek"].HeaderText = "Thứ trong tuần";
                if (dgvThongKe.Columns["Date"] != null)
                    dgvThongKe.Columns["Date"].HeaderText = "Ngày";
                if (dgvThongKe.Columns["TotalRevenue"] != null)
                    dgvThongKe.Columns["TotalRevenue"].HeaderText = "Tổng doanh thu";
                dgvThongKe.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";

                tongDoanhThu = _ordersBUL.GetTotalRevenueForWeek(date);
                lblTongTien.Text = tongDoanhThu.ToString("N0") + " đ";
            }
            else
            {
                lblTongTien.Text = "0 đ";
            }
        }

        private void btnTKTheoThang_Click(object sender, EventArgs e)
        {
            lblChonTG.Enabled = true;
            dtpChonTG.Enabled = true;

            var year = dtpChonTG.Value.Year;
            var month = dtpChonTG.Value.Month;
            var data = _ordersBUL.ThongKeTheoThang(month, year);
            dgvThongKe.DataSource = data;

            if (data.Count > 0) {
                // Định dạng cột
                dgvThongKe.Columns["Date"].HeaderText = "Ngày";
                dgvThongKe.Columns["TotalRevenue"].HeaderText = "Tổng doanh thu";
                dgvThongKe.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvThongKe.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";

                tongDoanhThu = _ordersBUL.GetTotalRevenueForMonth(month, year);
                lblTongTien.Text = tongDoanhThu.ToString("N0") + " đ";
            }
            else
            {
                lblTongTien.Text = "0 đ";
            }
        }

        private void btnTKTheoNam_Click(object sender, EventArgs e)
        {
            lblChonTG.Enabled = true;
            dtpChonTG.Enabled = true;

            var year = dtpChonTG.Value.Year;

            var data = _ordersBUL.ThongKeTheoNam(year);
            dgvThongKe.DataSource = data;

            if (data.Count > 0)
            {
                // Định dạng cột
                dgvThongKe.Columns["Month"].HeaderText = "Tháng";
                dgvThongKe.Columns["MonthName"].HeaderText = "Tên tháng";
                dgvThongKe.Columns["TotalRevenue"].HeaderText = "Tổng doanh thu";

                dgvThongKe.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";

                tongDoanhThu = _ordersBUL.GetTotalRevenueForYear(year);
                lblTongTien.Text = tongDoanhThu.ToString("N0") + " đ";
            }
            else
            {
                lblTongTien.Text = "0 đ";
            }
        }

        private void btnInTK_Click(object sender, EventArgs e)
        {
            ExportExcel exportExcel = new ExportExcel();

            // Tạo một DataTable mới
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable dựa trên DataGridView
            foreach (DataGridViewColumn column in dgvThongKe.Columns)
            {
                if (column.Visible) // Chỉ thêm các cột hiện
                {
                    // Kiểm tra nếu ValueType là Nullable và lấy kiểu cơ bản
                    Type columnType = column.ValueType;
                    if (columnType != null && columnType.IsGenericType && columnType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        columnType = Nullable.GetUnderlyingType(columnType); // Lấy kiểu không nullable
                    }

                    dataTable.Columns.Add(column.HeaderText, columnType ?? typeof(string));
                }
            }

            // Thêm các dòng vào DataTable
            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                if (!row.IsNewRow) // Bỏ qua dòng trống cuối cùng
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible) // Chỉ thêm giá trị từ cột hiện
                        {
                            dataRow[cell.OwningColumn.HeaderText] = cell.Value ?? DBNull.Value;
                        }
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            exportExcel.ExportFile(dataTable, "thong_ke", "THỐNG KÊ DOANH THU", tongDoanhThu);
        }
    }
}
