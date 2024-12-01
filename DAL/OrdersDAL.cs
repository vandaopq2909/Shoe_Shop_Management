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
        public List<OrdersDTO> getListOrders()
        {
            //return DBContext.Orders.Select(o => new OrdersDTO
            //{
            //    OrderID = o.OrderID,
            //    CreatedTime = DateTime.Now,
            //    TotalAmount = (double)o.TotalAmount,
            //    Status = o.Status,
            //    Description = o.Description,
            //    UserName = o.UserName

            //}).ToList();

            List<OrdersDTO> l = new List<OrdersDTO>() { new OrdersDTO(DateTime.Now, 20000, "hoạt động", "hihi", "admin") };
            return l;
        }
    }
}
