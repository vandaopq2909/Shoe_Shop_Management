
namespace DTO
{
    public class User_UserGroupDTO
    {
        public string? UserID { get; set; }
        public string? UserGroupID { get; set; }
        public string? Note {  get; set; }
        public User_UserGroupDTO() { }
        public User_UserGroupDTO(string userID, string userGroupID, string note)
        {
            UserID = userID;
            UserGroupID = userGroupID;
            Note = note;
        }
    }
}
