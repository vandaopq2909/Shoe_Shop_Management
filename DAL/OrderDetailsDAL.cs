using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDetailsDAL
    {
        public ShoeStoreDataContext db = new ShoeStoreDataContext();
        public void AddOrderDetails(OrderDetail o)
        {
            bool checkTrung = db.OrderDetails.Where(
                 x => x.OrderID == o.ProductID &&
                 x.ProductID == o.ProductID).Any();
            if (checkTrung == false)
            {
                db.OrderDetails.InsertOnSubmit(o);
                db.SubmitChanges();
                UpdateTotalAmount(o.OrderID);
            }
            else
            {
                var prd = db.OrderDetails.Where(
                    x => x.OrderID == o.OrderID &&
                    x.ProductID == o.ProductID).FirstOrDefault();
                prd.Quantity += o.Quantity;
                db.SubmitChanges();
                UpdateTotalAmount(o.OrderID);
            }
        }
        public void UpdateTotalAmount(int ma)
        {
            // Tính tổng tiền của phiếu nhập
            var totalAmount = db.OrderDetails
                                .Where(detail => detail.OrderID == ma)
                                .Sum(detail => detail.Quantity * detail.Price);

            // Cập nhật lại tổng tiền trong bảng PurchaseReceipts
            var order = db.Orders.SingleOrDefault(pr => pr.OrderID == ma);
            if (order != null)
            {
                order.TotalAmount = totalAmount;

                db.SubmitChanges();
            }
        }
        public List<OrderDetail> GetAllDetails(int ma)
        {
            return db.OrderDetails.Where(x => x.OrderID == ma).ToList();
        }

        public void DeletePRDetails(int ma, int maSP)
        {
            var prd = db.OrderDetails.Where(x => x.OrderID == ma &&
                                                x.ProductID == maSP).FirstOrDefault();
            db.OrderDetails.DeleteOnSubmit(prd);
            db.SubmitChanges();
            UpdateTotalAmount(ma);
        }
    }
}
