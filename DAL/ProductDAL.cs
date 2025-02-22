﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        private ShoeStoreDataContext _context;
        public ProductDAL()
        {
            _context = new ShoeStoreDataContext();
        }
        public IQueryable<Product> getProduct()
        {
            return _context.Products;
        }
        public IQueryable<Product> getProductByName(string pName)
        {
            return _context.Products.Where(x=>x.ProductName==pName);
        }

        public Product getProductByID(int id)
        {
            return _context.Products.SingleOrDefault(pro => pro.ProductID == id);
        }

        public Category getCategoryByID(int id)
        {
            return _context.Categories.SingleOrDefault(cat => cat.CategoryID == id);
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

        public double getGiaProductByID(int masp)
        {
            var sp = _context.Products.Where(x=> x.ProductID == masp).FirstOrDefault();
            return sp.ProductPrice ?? 0;
        }
    }
}
