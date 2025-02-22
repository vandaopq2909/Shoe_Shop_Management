﻿
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
        public string getDislayName(string userName)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "Select FullName from Users where UserName = "+userName;
            SqlCommand cmd = new SqlCommand(query, conn);
            string fullname = cmd.ExecuteScalar().ToString();
            string displayName = "( " + userName + " ) " + fullname;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            if (displayName != null)
            {
                return displayName;
            }
            else
            {
                return null; 
            }
        }
        public void AddUser(User user)
        {
            db.Users.InsertOnSubmit(user);
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

        public void UpdateUser(User customer)
        {
            db.SubmitChanges();
        }

        public void DeleteUser(string maUser)
        {
            var deleteUser = db.Users.Where(x=> x.UserName == maUser).FirstOrDefault();
            db.Users.DeleteOnSubmit(deleteUser);
            db.SubmitChanges();
        }

        public void ResetPassword(User customer)
        {
            db.SubmitChanges();
        }

        public bool IsExistEmployee(string maNV, string matKhau)
        {
            return db.Users.Where(x=> x.UserName == maNV && x.Password == matKhau &&
                                    (x.RoleID == 1 || x.RoleID == 2 )).Any();
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

        public List<User> GetAllEmployees()
        {
            return db.Users.Where(x => x.RoleID == 1 || x.RoleID == 2).ToList();
        }
    }
}
