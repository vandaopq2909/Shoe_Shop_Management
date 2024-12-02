using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuppliersDAL
    {
        private ShoeStoreDataContext db = new ShoeStoreDataContext();
        public SuppliersDAL()
        {
        }

        public List<Supplier> GetAllSuppliers()
        {
            return db.Suppliers.ToList();
        }
    }
}
