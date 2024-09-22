using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ListScreenDTO
    {
        public string ScreenID { get; set; }
        public string? ScreenName { get; set; }
        public ListScreenDTO()
        {
            ScreenID = GenerateScreenID();
        }
        public ListScreenDTO(string? screenName)
        {
            ScreenID = GenerateScreenID();
            ScreenName = screenName;
        }
        private string GenerateScreenID()
        {
            return "SCR" + Guid.NewGuid().ToString("N");
        }
    }
}
