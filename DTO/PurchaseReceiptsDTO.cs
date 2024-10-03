using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PurchaseReceiptsDTO
    {
        public PurchaseReceiptsDTO()
        {
            PReceiptID = GeneratePReceiptID();
        }
        public PurchaseReceiptsDTO(DateTimeOffset CreatedTime, double TotalPrice,
            int Status, string UserName, string SupplierID)
        {
            PReceiptID = GeneratePReceiptID();
            this.CreatedTime = CreatedTime;
            this.TotalPrice = TotalPrice;
            this.Status = Status;
            this.UserName = UserName;
            this.SupplierID = SupplierID;
        }
        public string PReceiptID { get; set; }
        public DateTimeOffset? CreatedTime { get; set; }
        public double TotalPrice { get; set; } = 0;
        public int Status { get; set; } = 0;
        public string? UserName { get; set; }
        public string? SupplierID { get; set; }
        private string GeneratePReceiptID()
        {
            return "PReceipt" + Guid.NewGuid().ToString("N");
        }
    }
}
