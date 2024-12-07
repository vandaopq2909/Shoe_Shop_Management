using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class OrderBUL
    {
        public OrdersDAL ordersDAL = new OrdersDAL();
        OrdersDTO ordersDTO;
        public OrderBUL() { }

        public void AddOrder(string makh, DateTime ngayNhap,string ghiChu)
        {
            var order = new Order
            {
                DateCreated = ngayNhap,
                UserName = makh,
                TotalAmount = 0,
                Status = "Đã thanh toán"
            };

            ordersDAL.AddPR(order);
        }

        public void DeletePR(int maPN)
        {
            ordersDAL.DeleteORD(maPN);
        }

        public List<Order> GetAllOrder()
        {
            return ordersDAL.GetAllOrder().ToList();
        }

        public void UpdateOrder(int ma, string makh, DateTime ngayNhap)
        {
            var order = ordersDAL.GetOrderByID(ma);
            if (order != null)
            {
                order.UserName = makh;
                order.DateCreated = ngayNhap;
            }
            ordersDAL.UpdateOrder(order);
        }
    }
}
