using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PurchaseReceiptsBUL
    {
        public PurchaseReceiptsDAL purchaseReceiptsDAL = new PurchaseReceiptsDAL();
        public PurchaseReceiptsBUL() { }

        public void AddPR(int maNCC, DateTime ngayNhap, string maNV)
        {
             var receipt = new PurchaseReceipt
             {
                SupplierID = maNCC,
                DateCreated = ngayNhap,
                UserName = maNV,
                TotalAmount = 0,
                Status = ""
            };

            purchaseReceiptsDAL.AddPR(receipt);
        }

        public void DeletePR(int maPN)
        {
            purchaseReceiptsDAL.DeletePR(maPN);
        }

        public List<PurchaseReceipt> GetAllPR()
        {
            return purchaseReceiptsDAL.GetAllPR();
        }

        public void UpdatePR(int maPN, int maNCC, DateTime ngayNhap)
        {
            var receipt = purchaseReceiptsDAL.GetPRByID(maPN);
            if (receipt != null)
            {
                receipt.SupplierID = maNCC;
                receipt.DateCreated = ngayNhap;
            }               
            purchaseReceiptsDAL.UpdatePR(receipt);
        }
    }
}
