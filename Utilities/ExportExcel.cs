using System;
using System.Data;
using Microsoft.Office.Interop.Excel;

namespace Utilities
{
    public class ExportExcel
    {
        public ExportExcel()
        {
        }

        public void ExportFile(System.Data.DataTable dataTable, string sheetName, string title, double totalAmount)
        {
            // Tạo các đối tượng Excel
            Application oExcel = new Application();
            Workbooks oBooks;
            _Workbook oBook;
            _Worksheet oSheet;

            // Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oBooks = oExcel.Workbooks;
            oBook = oBooks.Add();
            oSheet = (_Worksheet)oBook.Worksheets[1];
            oSheet.Name = sheetName;

            // Tạo phần tiêu đề
            Range head = oSheet.get_Range("A1", GetExcelColumnName(dataTable.Columns.Count) + "1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = 20;
            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột từ DataTable
            for (int col = 0; col < dataTable.Columns.Count; col++)
            {
                string columnName = dataTable.Columns[col].ColumnName; // Tên cột trong DataTable
                Range headerCell = (Range)oSheet.Cells[3, col + 1];
                headerCell.Value2 = columnName;
                headerCell.Font.Bold = true;
                headerCell.Interior.ColorIndex = 6; // Màu nền vàng nhạt
                headerCell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                headerCell.Borders.LineStyle = XlLineStyle.xlContinuous;
                headerCell.ColumnWidth = 15; // Độ rộng cột mặc định
            }

            // Tạo mảng từ DataTable để điền vào Excel
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    object value = dataTable.Rows[row][col];
                    if (value is DateTime dateValue) // Kiểm tra kiểu DateTime
                    {
                        arr[row, col] = dateValue.ToString("ddMMyyyy"); // Định dạng ngày tháng
                    }
                    else
                    {
                        arr[row, col] = value; // Các giá trị khác
                    }
                }
            }

            // Xác định vùng điền dữ liệu
            int startRow = 4; // Dòng bắt đầu điền dữ liệu
            int startCol = 1; // Cột bắt đầu điền dữ liệu
            int endRow = startRow + dataTable.Rows.Count - 1;
            int endCol = dataTable.Columns.Count;

            Range c1 = (Range)oSheet.Cells[startRow, startCol];
            Range c2 = (Range)oSheet.Cells[endRow, endCol];
            Range range = oSheet.get_Range(c1, c2);

            // Điền dữ liệu vào Excel
            range.Value2 = arr;

            // Kẻ viền cho dữ liệu
            range.Borders.LineStyle = XlLineStyle.xlContinuous;

            // Căn giữa nội dung
            range.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Thêm dòng hiển thị tổng tiền
            int totalRow = endRow + 1; // Dòng tiếp theo sau bảng
            Range totalLabelCell = (Range)oSheet.Cells[totalRow, startCol];
            totalLabelCell.Value2 = "Tổng tiền:";
            totalLabelCell.Font.Bold = true;
            totalLabelCell.HorizontalAlignment = XlHAlign.xlHAlignRight;

            Range totalValueCell = (Range)oSheet.Cells[totalRow, endCol];
            totalValueCell.Value2 = totalAmount.ToString("C"); // Định dạng tiền tệ
            totalValueCell.Font.Bold = true;
            totalValueCell.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Kẻ viền cho dòng tổng tiền
            Range totalRange = oSheet.get_Range(totalLabelCell, totalValueCell);
            totalRange.Borders.LineStyle = XlLineStyle.xlContinuous;
        }

        /// <summary>
        /// Trả về tên cột Excel dựa trên chỉ số (1-based index)
        /// </summary>
        private string GetExcelColumnName(int columnIndex)
        {
            string columnName = string.Empty;
            while (columnIndex > 0)
            {
                int modulo = (columnIndex - 1) % 26;
                columnName = Convert.ToChar('A' + modulo) + columnName;
                columnIndex = (columnIndex - modulo) / 26;
            }
            return columnName;
        }


    }
}
