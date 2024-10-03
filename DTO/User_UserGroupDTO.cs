
namespace DTO
{
    public class User_UserGroupDTO
    {
        public string? UserName { get; set; }
        public string? UserGroupID { get; set; }
        public string? Note {  get; set; }
        public User_UserGroupDTO() { }
        public User_UserGroupDTO(string userName, string userGroupID, string note)
        {
            UserName = userName;
            UserGroupID = userGroupID;
            Note = note;
        }
    }
}
