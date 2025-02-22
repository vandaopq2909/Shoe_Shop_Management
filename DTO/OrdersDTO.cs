﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrdersDTO
    {
 
        public OrdersDTO(DateTimeOffset createdTime, double totalAmount, string? status, string? description, string? userName)
        {
            CreatedTime = createdTime;
            TotalAmount = totalAmount;
            Status = status;
            Description = description;
            UserName = userName;
        }

        public string OrderID { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public double TotalAmount { get; set; } = 0;
        public string? Status { get; set; }
        public string? Description { get; set; }
        public string? UserName { get; set; }

    }
}
