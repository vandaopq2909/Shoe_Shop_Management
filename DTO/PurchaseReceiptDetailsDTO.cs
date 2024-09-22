using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PurchaseReceiptDetailsDTO
    {
        public string? PReceiptID { get; set; }
        public string? ProductID { get; set; }
        public int Quantity { get; set; } = 0;
        public double? Price { get; set; }
        public PurchaseReceiptDetailsDTO() { }
        public PurchaseReceiptDetailsDTO(string? pReceiptID, string? productID, int quantity, double? price)
        {
            PReceiptID = pReceiptID;
            ProductID = productID;
            Quantity = quantity;
            Price = price;
        }
    }
}
