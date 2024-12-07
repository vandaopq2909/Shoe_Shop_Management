using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrdersDAL
    {
        public ShoeStoreDataContext DBContext;
        public OrdersDAL()
        {
            DBContext = new ShoeStoreDataContext();
        }

        public void AddPR(Order order)
        {
            DBContext.Orders.InsertOnSubmit(order);
            DBContext.SubmitChanges();
        }

        public void DeleteORD(int ma)
        {
            var orderDetails = DBContext.OrderDetails.Where(od => od.OrderID == ma).ToList();

            if (orderDetails.Any())
            {
                DBContext.OrderDetails.DeleteAllOnSubmit(orderDetails);
            }

            var order = DBContext.Orders.FirstOrDefault(o => o.OrderID == ma);

            if (order != null)
            {
                DBContext.Orders.DeleteOnSubmit(order);
            }
            DBContext.SubmitChanges();
        }


        public List<Order> GetAllOrder()
        {
            return DBContext.Orders.ToList();
        }

        public List<OrdersDTO> getListOrders()
        {
            List<OrdersDTO> l = new List<OrdersDTO>() { new OrdersDTO(DateTime.Now, 20000, "hoạt động", "hihi", "admin") };
            return l;
        }

        public Order GetOrderByID(int ma)
        {
            return DBContext.Orders.Where(x => x.OrderID == ma).FirstOrDefault();
        }

        public int GetProQuantity(int orderID)
        {
            try
            {
                int totalQuantity = (int)DBContext.OrderDetails
                    .Where(od => od.OrderID == orderID) // Lọc theo OrderID
                    .Sum(od => od.Quantity); // Tính tổng số lượng

                return totalQuantity; 
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính tổng số lượng sản phẩm cho đơn hàng", ex);
            }
        }

        public double GetTotalRevenueForMonth(int month, int year)
        {
            try
            {
                // Lọc các đơn hàng có ngày tạo thuộc tháng và năm được truyền vào
                var totalRevenue = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue && o.DateCreated.Value.Month == month && o.DateCreated.Value.Year == year)
                    .Sum(o => o.TotalAmount ?? 0); // Tính tổng doanh thu

                return totalRevenue;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính tổng doanh thu trong tháng", ex);
            }
        }

        public double GetTotalRevenueForWeek(int date)
        {
            try
            {
                // Lấy ngày bắt đầu của tuần (thứ Hai) và ngày kết thúc của tuần (Chủ Nhật)
                DateTime today = DateTime.Now;
                DateTime startOfWeek = today.AddDays(DayOfWeek.Monday - today.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6); // Thêm 6 ngày để có Chủ Nhật

                // Lọc các đơn hàng có ngày tạo nằm trong tuần này
                var totalRevenue = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue && o.DateCreated.Value >= startOfWeek && o.DateCreated.Value <= endOfWeek)
                    .Sum(o => o.TotalAmount ?? 0); // Tính tổng doanh thu

                return totalRevenue;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính tổng doanh thu trong tuần", ex);
            }
        }

        public double GetTotalRevenueForYear(int year)
        {
            try
            {
                // Kiểm tra xem có bất kỳ đơn hàng nào trong năm này không
                bool hasOrdersInYear = DBContext.Orders
                    .Any(o => o.DateCreated.HasValue && o.DateCreated.Value.Year == year);

                if (!hasOrdersInYear)
                {
                    // Nếu không có đơn hàng trong năm này, trả về 0
                    return 0;
                }

                // Nếu có đơn hàng, tính tổng doanh thu
                var totalRevenue = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue && o.DateCreated.Value.Year == year)
                    .Sum(o => o.TotalAmount ?? 0); // Tính tổng doanh thu

                return totalRevenue;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính tổng doanh thu cho năm", ex);
            }
        }

        public List<dynamic> ThongKeTheoNam(int year)
        {
            try
            {
                // Xác định ngày đầu năm và cuối năm
                DateTime startOfYear = new DateTime(year, 1, 1);
                DateTime endOfYear = new DateTime(year, 12, 31);

                // Lấy dữ liệu từ cơ sở dữ liệu
                var rawData = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue && o.DateCreated.Value.Year == year)
                    .ToList(); // Tải dữ liệu lên bộ nhớ

                // Nhóm dữ liệu theo tháng
                var groupedData = rawData
                    .GroupBy(o => o.DateCreated.Value.Month)
                    .Select(g => new
                    {
                        Month = g.Key, // Tháng
                        TotalRevenue = g.Sum(o => o.TotalAmount ?? 0) // Tổng doanh thu trong tháng
                    })
                    .ToDictionary(x => x.Month, x => x.TotalRevenue); // Chuyển thành Dictionary để tra cứu dễ hơn

                // Tạo danh sách 12 tháng (kể cả tháng không có dữ liệu)
                var yearlyRevenue = Enumerable.Range(1, 12) // 1 đến 12
                    .Select(month => new
                    {
                        Month = month, // Tháng
                        MonthName = new DateTime(year, month, 1).ToString("MMMM"), // Tên tháng
                        TotalRevenue = groupedData.ContainsKey(month) ? groupedData[month] : 0 // Doanh thu (0 nếu không có dữ liệu)
                    })
                    .ToList<dynamic>();

                return yearlyRevenue;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính doanh thu theo năm", ex);
            }
        }

        public List<Order> ThongKeTheoNgay(DateTime date)
        {
            try
            {
                DateTime startDate = date.Date; // Đầu ngày
                DateTime endDate = date.Date.AddDays(1).AddTicks(-1); // Cuối ngày

                return DBContext.Orders
                    .Where(x => x.DateCreated >= startDate && x.DateCreated <= endDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thống kê theo ngày", ex);
            }
        }

        public List<dynamic> ThongKeTheoThang(int month, int year)
        {
            try
            {
                // Xác định ngày bắt đầu và ngày kết thúc của tháng
                DateTime startOfMonth = new DateTime(year, month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng

                // Lấy dữ liệu thô từ DB
                var rawData = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue && o.DateCreated.Value.Date >= startOfMonth && o.DateCreated.Value.Date <= endOfMonth)
                    .ToList(); // Tải dữ liệu vào bộ nhớ

                // Tính toán doanh thu theo ngày trong C#
                var monthlyRevenue = rawData
                    .GroupBy(o => o.DateCreated.Value.Date) // Nhóm theo ngày
                    .Select(g => new
                    {
                        Date = g.Key,                               // Ngày
                        TotalRevenue = g.Sum(o => o.TotalAmount ?? 0) // Tổng doanh thu trong ngày
                    })
                    .OrderBy(r => r.Date) // Sắp xếp theo ngày
                    .ToList<dynamic>();

                return monthlyRevenue;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính doanh thu theo tháng", ex);
            }
        }

        public List<dynamic> ThongKeTheoTuan(int date)
        {
            try
            {
                DateTime today = DateTime.Today;

                // Xác định ngày bắt đầu tuần (thứ Hai gần nhất)
                int daysSinceMonday = (int)today.DayOfWeek - (int)DayOfWeek.Monday;
                DateTime startOfWeek = today.AddDays(-daysSinceMonday < 0 ? -6 : -daysSinceMonday).Date;

                // Xác định ngày cuối tuần (Chủ Nhật)
                DateTime endOfWeek = startOfWeek.AddDays(6).Date;

                // Lấy dữ liệu thô từ DB
                var rawData = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue && o.DateCreated >= startOfWeek && o.DateCreated <= endOfWeek)
                    .ToList(); // Thực thi truy vấn và tải dữ liệu vào bộ nhớ

                // Xử lý tính toán và định dạng phía C#
                var weeklyRevenue = rawData
                    .GroupBy(o => o.DateCreated.Value.Date) // Nhóm theo ngày
                    .Select(g => new
                    {
                        DayOfWeek = g.Key.ToString("dddd"),  // Thực hiện định dạng ở C#
                        Date = g.Key,
                        TotalRevenue = g.Sum(o => o.TotalAmount ?? 0)
                    })
                    .ToList<dynamic>();

                return weeklyRevenue;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính doanh thu theo tuần", ex);
            }
        }

        public void UpdateOrder(Order order)
        {
            DBContext.SubmitChanges();
        }
    }
}
