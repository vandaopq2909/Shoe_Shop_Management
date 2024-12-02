using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class SuppliersBUL
    {
        private SuppliersDAL _suppliersDAL;
        public SuppliersBUL()
        {
            _suppliersDAL = new SuppliersDAL();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _suppliersDAL.GetAllSuppliers();
        }
    }
}
