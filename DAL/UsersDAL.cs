
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
    public class UsersDAL
    {
        SqlConnection conn;
        string strConnection = ConfigurationManager.ConnectionStrings["MyDBShop"].ConnectionString;
        private ShoeStoreDataContext db = new ShoeStoreDataContext();
        public UsersDAL()
        {
            conn = new SqlConnection(strConnection);
        }
        public bool isValid(UsersDTO user)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Select count(*) from Users where UserName='"+user.UserName+"' and Password='"+user.Password+"' and IsActive=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            int kq = (int)cmd.ExecuteScalar();
            return kq > 0;
        }
        public bool isDuplicated(string userName)
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

        public void AddCustomer(User customer)
        {
            db.Users.InsertOnSubmit(customer);
            db.SubmitChanges();
        }

        public List<User> GetAllCustomers()
        {
            return db.Users.Where(x => x.RoleID == 3).ToList();
        }

        public bool CheckDuplicateUsername(string maKH)
        {
            return db.Users.Any(x => x.UserName == maKH);
        }

        public User getCustomerByUserName(string maKH)
        {
            return db.Users.Where(x=> x.UserName == maKH).FirstOrDefault(); 
        }

        public void UpdateCustomer(User customer)
        {
            db.SubmitChanges();
        }

        public void DeleteCustomer(string maKH)
        {
            var deleteCustomer = db.Users.Where(x=> x.UserName == maKH).First();
            db.Users.DeleteOnSubmit(deleteCustomer);
            db.SubmitChanges();
        }

        public void ResetPassword(User customer)
        {
            db.SubmitChanges();
        }

        public bool IsExistEmployee(string maNV, string matKhau)
        {
            return db.Users.Where(x=> x.UserName == maNV && x.Password == matKhau).Any();
        }

        public User LoadInfoUserByMaNV(string maNhanVien)
        {
            return db.Users.Where(x => x.UserName == maNhanVien).FirstOrDefault();
        }

        public bool ChangePass(string maNV, string mkCu, string mkMoi)
        {
            try
            {
                User user = db.Users.Where(x => x.UserName == maNV && x.Password == mkCu).FirstOrDefault();
                if (user != null)
                {
                    user.Password = mkMoi;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
