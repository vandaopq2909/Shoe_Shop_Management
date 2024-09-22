using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetailsDTO
    {
        public string? OrderDetailID { get; set; }
        public string? OrderID { get; set; }
        public string? ProductID { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
        public double TotalAmount { get { return (Quantity * (Price ?? 0)); } }
        public OrderDetailsDTO(string? orderDetailID,string? orderID, string? productID, int quantity, double? price)
        {
            OrderDetailID = orderDetailID;
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            Price = price;            
        }
    }
}
