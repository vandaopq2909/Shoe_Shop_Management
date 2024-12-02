using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUL
{
    public class ProductBUL
    {
        private ProductDAL _productDAL;
        
        public ProductBUL()
        {
            _productDAL = new ProductDAL();
        }

        public IQueryable<Product> GetProducts()
        {
            return _productDAL.getProduct();
        }

        public void AddProduct(int catID, string name, float price, string des, int quantity,
            string size, string color, string brand, string status, string img)
        {
            var pro = new Product
            {
                CategoryID = catID,
                //ProductID = proID,
                ProductName = name,
                ProductPrice = price,
                Quantity = quantity,
                Description = des,
                Size = size,
                Color = color,
                Brand = brand,
                Image = img,
                Status = status

            };
            _productDAL.addProduct(pro);
        }

        public void DeleteProduct(int id)
        {
            var pro = _productDAL.getProductByID(id);
            if (pro != null)
            {
                _productDAL.deleteProduct(pro);
            }
        }

        public void UpdateProduct(int catID, int proID, string name, float price, string des, int quantity,
            string size, string color, string brand, string status, string img)
        {
            var pro = _productDAL.getProductByID(proID);
            if (pro != null)
            {
                var category = _productDAL.getCategoryByID(catID);

                pro.Category = category;
                pro.ProductName = name;
                pro.ProductPrice = price;
                pro.Quantity = quantity;
                pro.Description = des;
                pro.Size = size;
                pro.Color = color;
                pro.Brand = brand;
                pro.Status = status;
                pro.Image = img;
                _productDAL.updateProduct(pro);
            }
        }

        public double getGiaProductByID(int masp)
        {
            return _productDAL.getGiaProductByID(masp);
        }
    }
}
