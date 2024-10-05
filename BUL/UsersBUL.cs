using DAL;
using DTO;
namespace BUL
{
    public class UsersBUL
    {
        UsersDAL usersDAL;
        public UsersBUL()
        {
            usersDAL = new UsersDAL();
        }
        public bool isValid(UsersDTO user)
        {
            return usersDAL.isValid(user);
        }
        public bool isDuplicated(string userName)
        {
            return usersDAL.isDuplicated(userName);
        }
    }
}
