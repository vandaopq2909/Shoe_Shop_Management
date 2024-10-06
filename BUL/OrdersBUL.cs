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
    }
}
