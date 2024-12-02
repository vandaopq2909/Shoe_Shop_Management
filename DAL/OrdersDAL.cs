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
            List<OrdersDTO> l = new List<OrdersDTO>() { new OrdersDTO(DateTime.Now, 20000, "hoạt động", "hihi", "admin") };
            return l;
        }
    }
}
