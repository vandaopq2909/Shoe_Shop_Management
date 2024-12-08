using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class OrdersBUL
    {
        public OrdersDAL dal = new OrdersDAL();
        public List<OrdersDTO> getListOrders()
        {
            return dal.getListOrders();
        }

        public int GetProQuantity(int orderID)
        {
            return dal.GetProQuantity(orderID);
        }

        public double GetTotalRevenueForMonth(int month, int year)
        {
            return dal.GetTotalRevenueForMonth(month, year);    
        }

        public double GetTotalRevenueForWeek(DateTime date)
        {
            return dal.GetTotalRevenueForWeek(date);
        }

        public double GetTotalRevenueForYear(int year)
        {
            return dal.GetTotalRevenueForYear(year);
        }

        public List<dynamic> ThongKeTheoNam(int year)
        {
            return dal.ThongKeTheoNam(year);
        }

        public List<Order> ThongKeTheoNgay(DateTime date)
        {
            return dal.ThongKeTheoNgay(date);
        }

        public List<dynamic> ThongKeTheoThang(int month, int year)
        {
            return dal.ThongKeTheoThang(month, year);
        }

        public List<dynamic> ThongKeTheoTuan(DateTime date)
        {
            return dal.ThongKeTheoTuan(date);
        }
    }
}
