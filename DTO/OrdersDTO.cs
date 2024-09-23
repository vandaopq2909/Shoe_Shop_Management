using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrdersDTO
    {
        public OrdersDTO()
        {
            OrderID = GenerateOrderID();
        }
        public OrdersDTO(DateTimeOffset createdTime, double totalAmount, int status, string? description, string? userID)
        {
            OrderID = GenerateOrderID();
            CreatedTime = createdTime;
            TotalAmount = totalAmount;
            Status = status;
            Description = description;
            UserID = userID;
        }

        public string OrderID { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public double TotalAmount { get; set; } = 0;
        public int Status { get; set; } = 0;
        public string? Description { get; set; }
        public string? UserID { get; set; }
        private string GenerateOrderID()
        {
            return "ORD" + Guid.NewGuid().ToString("N");
        }
    }
}
