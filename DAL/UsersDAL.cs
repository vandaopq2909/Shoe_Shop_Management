
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class UsersDAL
    {
        SqlConnection conn;
        string strConnection = "Server=.; Database=ShoeShop; Integrated Security=True;TrustServerCertificate=True";
        public UsersDAL()
        {
            conn = new SqlConnection(strConnection);

        }
        public bool kiemTraTonTai(UsersDTO user)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Select count(*) from Users where UserName='"+user.UserName+"' and Password='"+user.Password+"' and IsActive="+user.IsActive+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            int kq = (int)cmd.ExecuteScalar();
            return kq > 0;

        }
        public bool kiemTraTrung(string userName)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select count(*) from Users where UserName='" + userName + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            int kq = (int)sqlCommand.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq > 0;
        }


    }
}
