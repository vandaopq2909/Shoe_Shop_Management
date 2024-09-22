using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductsDTO
    {
        public ProductsDTO()
        {
            this.ProductID = GenerateProductID();
        }
        public ProductsDTO(string ProductName, string Image, double ProductPrice, int Quantity,
            string Description, int Size, string Color, string Brand, int Status, string CategoryID)
        {
            ProductID = GenerateProductID();
            this.ProductName = ProductName;
            this.Image = Image;
            this.ProductPrice = ProductPrice;
            this.Quantity = Quantity;
            this.Description = Description;
            this.Size = Size;
            this.Color = Color;
            this.Brand = Brand;
            this.Status = Status;
            this.CategoryID = CategoryID;
        }
        public string ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Image { get; set; }
        public double ProductPrice { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public string? Description { get; set; }
        public int Size { get; set; } = 0;
        public string? Color { get; set; }
        public string? Brand { get; set; }
        public int? Status { get; set; } = 0;
        public string? CategoryID { get; set; }
        private string GenerateProductID()
        {
            return "PRO" + Guid.NewGuid().ToString("N");
        }
    }
}
