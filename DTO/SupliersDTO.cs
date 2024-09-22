using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuppliersDTO
    {
        public SuppliersDTO()
        {
            SupplierID = GenerateSupplierID();
        }
        public SuppliersDTO(string? supplierName, string? phoneNumber, string? email, string? address)
        {
            SupplierID = GenerateSupplierID();
            SupplierName = supplierName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public string SupplierID { get; set; }
        public string? SupplierName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        private string GenerateSupplierID()
        {
            return "SUP" + Guid.NewGuid().ToString("N");
        }
    }
}
