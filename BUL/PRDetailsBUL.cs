using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public  class PRDetailsBUL
    {
        public PRDetailsDAL pRDetailsDAL = new PRDetailsDAL();
        public PRDetailsBUL()
        {
            
        }

        public void AddPRDetails(int maPN, int maSP, int soLuong, double gia)
        {
            var prdetails = new PurchaseReceiptDetail 
            {
                PReceiptID = maPN,
                ProductID = maSP,
                Quantity = soLuong,
                Price = gia
            };
            pRDetailsDAL.AddPRDetails(prdetails);
        }

        public void DeletePRDetails(int maPN, int maSP)
        {
            pRDetailsDAL.DeletePRDetails(maPN, maSP);
        }

        public List<PurchaseReceiptDetail> GetAllPRDetails(int maPN)
        {
            return pRDetailsDAL.GetAllPRDetails(maPN);
        }
    }
}
