using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PurchaseReceiptsDAL
    {
        public ShoeStoreDataContext db = new ShoeStoreDataContext();
        public PurchaseReceiptsDAL()
        {
            
        }

        public void AddPR(PurchaseReceipt receipt)
        {
            db.PurchaseReceipts.InsertOnSubmit(receipt);
            db.SubmitChanges();
        }

        public void DeletePR(int maPN)
        {
            var listPRDetails = db.PurchaseReceiptDetails.Where(x => x.PReceiptID == maPN).ToList();

            if (listPRDetails.Any())
            {
                db.PurchaseReceiptDetails.DeleteAllOnSubmit(listPRDetails);
            }

            var purchaseReceipt = db.PurchaseReceipts.FirstOrDefault(x => x.PReceiptID == maPN);

            if (purchaseReceipt != null)
            {
                db.PurchaseReceipts.DeleteOnSubmit(purchaseReceipt);
            }
            db.SubmitChanges();
        }

        public List<PurchaseReceipt> GetAllPR()
        {
            return db.PurchaseReceipts.ToList();
        }

        public PurchaseReceipt GetPRByID(int maPN)
        {
            return db.PurchaseReceipts.Where(x=> x.PReceiptID == maPN).FirstOrDefault();
        }

        public void UpdatePR(PurchaseReceipt receipt)
        {
            db.SubmitChanges();
        }
    }
}
