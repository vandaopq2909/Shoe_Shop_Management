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
        public bool kiemTraTonTai(UsersDTO user)
        {
            return usersDAL.kiemTraTonTai(user);
        }
        public bool kiemTraTrung(string userName)
        {
            return usersDAL.kiemTraTrung(userName);
        }
    }
}
