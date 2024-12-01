using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Roles
    {
        public int? RoleID { get; set; }
        public string? RoleName {  get; set; }
        public int IsActive { get; set; } = 1;
        public Roles() { }
        public Roles(int? roleID, string? roleName, int isActive)
        {
            RoleID = roleID;
            RoleName = roleName;
            IsActive = isActive;
        }
    }
}
