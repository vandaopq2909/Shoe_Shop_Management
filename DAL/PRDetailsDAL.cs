using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PRDetailsDAL
    {
        public ShoeStoreDataContext db = new ShoeStoreDataContext();
        public PRDetailsDAL()
        {
            
        }

        public void AddPRDetails(PurchaseReceiptDetail prdetails)
        {
            bool checkTrung = db.PurchaseReceiptDetails.Where(
                 x => x.PReceiptID == prdetails.PReceiptID &&
                 x.ProductID == prdetails.ProductID).Any();
            if (checkTrung == false)
            {
                db.PurchaseReceiptDetails.InsertOnSubmit(prdetails);
                db.SubmitChanges();
                UpdateTotalAmount(prdetails.PReceiptID);
            }
            else {
                var prd = db.PurchaseReceiptDetails.Where(
                    x => x.PReceiptID == prdetails.PReceiptID &&
                    x.ProductID == prdetails.ProductID).FirstOrDefault();
                prd.Quantity += prdetails.Quantity;
                db.SubmitChanges();
                UpdateTotalAmount(prdetails.PReceiptID);
            }
        }
        public void UpdateTotalAmount(int maPN)
        {
            // Tính tổng tiền của phiếu nhập
            var totalAmount = db.PurchaseReceiptDetails
                                .Where(detail => detail.PReceiptID == maPN)
                                .Sum(detail => detail.Quantity * detail.Price);

            // Cập nhật lại tổng tiền trong bảng PurchaseReceipts
            var purchaseReceipt = db.PurchaseReceipts.SingleOrDefault(pr => pr.PReceiptID == maPN);
            if (purchaseReceipt != null)
            {
                purchaseReceipt.TotalAmount = totalAmount;

                db.SubmitChanges();
            }
        }
        public List<PurchaseReceiptDetail> GetAllPRDetails(int maPN)
        {
            return db.PurchaseReceiptDetails.Where(x=> x.PReceiptID == maPN).ToList();
        }

        public void DeletePRDetails(int maPN, int maSP)
        {
            var prd = db.PurchaseReceiptDetails.Where(x=> x.PReceiptID == maPN &&
                                                x.ProductID == maSP).FirstOrDefault();
            db.PurchaseReceiptDetails.DeleteOnSubmit(prd);
            db.SubmitChanges();
            UpdateTotalAmount(maPN);           
        }
    }
}
