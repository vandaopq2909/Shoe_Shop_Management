using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Roles
    {
        public string? UsergroupID { get; set; }
        public string? ScreenID {  get; set; }
        public int isActive { get; set; } = 0;
        public Roles() { }
        public Roles(string? usergroupID, string? screenID, int isActive)
        {
            UsergroupID = usergroupID;
            ScreenID = screenID;
            this.isActive = isActive;
        }
    }
}
