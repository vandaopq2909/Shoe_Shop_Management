using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        private ShoeShopDataContext _context;
        public ProductDAL()
        {
            _context = new ShoeShopDataContext();
        }
        public IQueryable<Product> getProduct()
        {
            return _context.Products;
        }
        public Product getProductByID(string id)
        {
            return _context.Products.SingleOrDefault(pro => pro.ProductID == id);
        }
        public void addProduct(Product pro)
        {
            _context.Products.InsertOnSubmit(pro);
            _context.SubmitChanges();
        }

        public void deleteProduct(Product pro)
        {
            _context.Products.DeleteOnSubmit(pro);
            _context.SubmitChanges();
        }

        public void updateProduct(Product pro)
        {
            _context.SubmitChanges();
        }
    }
}
