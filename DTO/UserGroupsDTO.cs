using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserGroupsDTO
    {
        public string UserGroupID {  get; set; }
        public string? UserGroupName { get; set; }
        public string? Note {  get; set; }
        public UserGroupsDTO()
        {
            UserGroupID = GenerateUserGroupID();
        }
        public UserGroupsDTO(string? userGroupName, string? note)
        {
            UserGroupID = GenerateUserGroupID();
            UserGroupName = userGroupName;
            Note = note;
        }
        private string GenerateUserGroupID()
        {
            return "UserGID" + Guid.NewGuid().ToString("N");
        }
    }
}
