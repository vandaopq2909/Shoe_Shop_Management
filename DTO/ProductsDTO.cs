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
            //this.ProductID = GenerateProductID();
        }
        public ProductsDTO(string ProductName, string Image, float ProductPrice, int Quantity,
            string Description, string Size, string Color, string Brand, string Status, int CategoryID)
        {
            //ProductID = GenerateProductID();
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
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Image { get; set; }
        public float ProductPrice { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public string? Description { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Brand { get; set; }
        public string? Status { get; set; }
        public int? CategoryID { get; set; }
        //private string GenerateProductID()
        //{
        //    return "PRO" + Guid.NewGuid().ToString("N");
        //}
    }
}
