using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddProduct(string catID, string proID, string name, decimal price, string des, int size, string color, string brand, string img)
        {
            var pro = new Product
            {
                CategoryID = catID,
                ProductID = proID,
                ProductName = name,
                ProductPrice = price,
                Description = des,
                Size = size,
                Color = color,
                Brand = brand,
                Image = img

            };
            _productDAL.addProduct(pro);
        }

        public void DeleteProduct(string id)
        {
            var pro = _productDAL.getProductByID(id);
            if (pro != null)
            {
                _productDAL.deleteProduct(pro);
            }
        }

        public void UpdateProduct(string catID, string proID, string name, decimal price, string des, int size, string color, string brand, string img)
        {
            var pro = _productDAL.getProductByID(proID);
            if (pro != null)
            {
                pro.CategoryID = catID;
                pro.ProductName = name;
                pro.ProductPrice = price;
                pro.Description = des;
                pro.Size = size;
                pro.Color = color;
                pro.Brand = brand;
                pro.Image = img;
                _productDAL.updateProduct(pro);
            }
        }
    }
}
