using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class OrderDetailBUL
    {
        public OrderDetailsDAL orderDetailsDAL = new OrderDetailsDAL();
        public OrderDetailBUL()
        {

        }

        public void AddDetails(int ma, int maSP, int soLuong, double gia)
        {
            var orderDetail = new OrderDetail
            {
                OrderID = ma,
                ProductID = maSP,
                Quantity = soLuong,
                Price = gia
            };
            orderDetailsDAL.AddOrderDetails(orderDetail);
        }

        public void DeleteOrderDetails(int ma, int maSP)
        {
            orderDetailsDAL.DeletePRDetails(ma, maSP);
        }

        public List<OrderDetail> GetAllDetails(int ma)
        {
            return orderDetailsDAL.GetAllDetails(ma);
        }

    }
}
