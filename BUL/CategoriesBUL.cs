using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUL
{
    public class CategoriesBUL
    {
        private CategoriesDAL _categoriesDAL;
        public CategoriesBUL()
        {
            _categoriesDAL = new CategoriesDAL();
        }
        public IQueryable<Category> GetCategories()
        {
            return _categoriesDAL.getCategories();
        }
        public void AddCategory(string id, string name)
        {
            var cat = new Category
            {
                CategoryID = id,
                CategoryName = name
            };
            _categoriesDAL.addCategory(cat);
        }

        public void DeleteCategory(string id)
        {
            var cat = _categoriesDAL.getCategoryByID(id);
            if (cat != null)
            {
                _categoriesDAL.deleteCategory(cat);
            }            
        }

        public void UpdateCategory(string id, string name)
        {
            var cat = _categoriesDAL.getCategoryByID(id);
            if (cat != null)
            {
                cat.CategoryName = name;
                _categoriesDAL.updateCategory(cat);
            }
        }
    }
}
