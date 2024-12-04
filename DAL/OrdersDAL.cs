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
        public ShoeStoreDataContext db=  new ShoeStoreDataContext();
        public void AddPR(Order order)
        {
            db.Orders.InsertOnSubmit(order);
            db.SubmitChanges();
        }

        public void DeleteORD(int ma)
        {
            var listOrders= db.Orders.Where(x => x.OrderID == ma).ToList();

            if (listOrders.Any())
            {
                db.Orders.DeleteAllOnSubmit(listOrders);
            }

            var order = db.Orders.FirstOrDefault(x => x.OrderID == ma);

            if (order != null)
            {
                db.Orders.DeleteOnSubmit(order);
            }
            db.SubmitChanges();
        }

        public List<Order> GetAllOrder()
        {
            return db.Orders.ToList();
        }

        public Order GetOrderByID(int ma)
        {
            return db.Orders.Where(x => x.OrderID == ma).FirstOrDefault();
        }

        public void UpdateOrder(Order order)
        {
            db.SubmitChanges();
        }

    }
}
