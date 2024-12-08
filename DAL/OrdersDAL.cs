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

        public double GetTotalRevenueForWeek(DateTime currentDate)
        {
            try
            {
                // Xác định ngày bắt đầu tuần (thứ Hai) và ngày kết thúc tuần (Chủ Nhật)
                int daysSinceMonday = (7 + (currentDate.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime startOfWeek = currentDate.Date.AddDays(-daysSinceMonday);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                // Tính tổng doanh thu từ cơ sở dữ liệu trong khoảng thời gian tuần
                double totalRevenue = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue &&
                                o.DateCreated.Value.Date >= startOfWeek &&
                                o.DateCreated.Value.Date <= endOfWeek)
                    .Sum(o => o.TotalAmount ?? 0);

                return totalRevenue;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính tổng doanh thu trong tuần: " + ex.Message, ex);
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

        public List<dynamic> ThongKeTheoTuan(DateTime currentDate)
        {
            try
            {
                // Xác định ngày bắt đầu tuần (thứ Hai) và ngày kết thúc tuần (Chủ Nhật)
                int daysSinceMonday = (7 + (currentDate.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime startOfWeek = currentDate.Date.AddDays(-daysSinceMonday);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                // Lấy tất cả các đơn hàng trong tuần từ cơ sở dữ liệu
                var rawData = DBContext.Orders
                    .Where(o => o.DateCreated.HasValue &&
                                o.DateCreated.Value.Date >= startOfWeek &&
                                o.DateCreated.Value.Date <= endOfWeek)
                    .ToList();

                // Tạo danh sách chứa doanh thu từng ngày trong tuần
                List<dynamic> weeklyRevenue = new List<dynamic>();

                for (int i = 0; i < 7; i++)
                {
                    DateTime currentDay = startOfWeek.AddDays(i);

                    // Tính tổng doanh thu trong ngày
                    var dailyRevenue = rawData
                        .Where(o => o.DateCreated.Value.Date == currentDay)
                        .Sum(o => o.TotalAmount ?? 0);

                    // Thêm kết quả vào danh sách
                    weeklyRevenue.Add(new
                    {
                        DayOfWeek = currentDay.ToString("dddd", new System.Globalization.CultureInfo("vi-VN")),
                        Date = currentDay.ToString("dd/MM/yyyy"),
                        TotalRevenue = dailyRevenue
                    });
                }

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
