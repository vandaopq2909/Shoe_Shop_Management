using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriesDAL
    {
        private ShoeStoreDataContext _context;
        public CategoriesDAL()
        {
            _context = new ShoeStoreDataContext();
        }
        public IQueryable<Category> getCategories()
        {
            return _context.Categories;
        }
        public Category getCategoryByID(int id)
        {
            return _context.Categories.SingleOrDefault(cat => cat.CategoryID == id);
        }
        public void addCategory(Category cat)
        {            
            _context.Categories.InsertOnSubmit(cat);
            _context.SubmitChanges();            
        }

        public void deleteCategory(Category cat)
        {
            _context.Categories.DeleteOnSubmit(cat);
            _context.SubmitChanges();
        }

        public void updateCategory(Category cat)
        {          
            _context.SubmitChanges();                       
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }
    }
}
