using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoriesDTO
    {
        //public CategoriesDTO()
        //{
        //    this.CategoriesID = GenerateCategoriesID();
        //}
        public int CategoriesID {  get; set; }
        public string CategoriesName { get; set; }
        public CategoriesDTO(int id, string name)
        {
            CategoriesID = id;
            this.CategoriesName = name;
        }
        //private string GenerateCategoriesID()
        //{
        //    return "CAT" + Guid.NewGuid().ToString("N");
        //}
    }
}
