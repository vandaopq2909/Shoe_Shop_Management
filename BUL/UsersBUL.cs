using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace BUL
{
    public class UsersBUL
    {
        UsersDAL usersDAL = new UsersDAL();
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

        public void AddCustomer(string maKH, string hoTen, string gioiTinh, string sDT, DateTime ngaySinh, string email, string diaChi, int trangThai, string image)
        {
            var customer = new User
            {
                UserName = maKH,
                Password = "123",
                FullName = hoTen,
                Gender = gioiTinh,
                PhoneNumber = sDT,
                DateOfBirth = ngaySinh,
                Email = email,
                Address = diaChi,
                isActive = trangThai,
                Image = image,
                RoleID = 3
            };
            usersDAL.AddUser(customer);
        }

        public List<User> GetAllCustomers()
        {
            return usersDAL.GetAllCustomers();
        }

        public bool CheckDuplicateUsername(string maKH)
        {
            return usersDAL.CheckDuplicateUsername(maKH);
        }

        public void UpdateCustomer(string maKH, string hoTen, string gioiTinh, string sDT, DateTime ngaySinh, string email, string diaChi, int trangThai, string image)
        {
            var customer = usersDAL.getCustomerByUserName(maKH);
            if (customer != null)
            {
                customer.UserName = maKH;
                customer.FullName = hoTen;
                customer.Gender = gioiTinh;
                customer.PhoneNumber = sDT;
                customer.DateOfBirth = ngaySinh;
                customer.Email = email;
                customer.Address = diaChi;
                customer.isActive = trangThai;
                customer.Image = image;
            }
            usersDAL.UpdateUser(customer);
        }

        public void DeleteCustomer(string maKH)
        {
            usersDAL.DeleteUser(maKH);
        }

        public void ResetPassword(string maKH)
        {
            var customer = usersDAL.getCustomerByUserName(maKH);
            if (customer != null)
            {
                customer.Password = "123";
            }
                usersDAL.ResetPassword(customer);
        }

        public bool IsExistEmployee(string maNV, string matKhau)
        {
            return usersDAL.IsExistEmployee(maNV, matKhau);
        }

        public User LoadInfoUserByMaNV(string maNhanVien)
        {
            return usersDAL.LoadInfoUserByMaNV(maNhanVien);
        }

        public bool ChangePass(string maNV, string mkCu, string mkMoi)
        {
            return usersDAL.ChangePass(maNV, mkCu, mkMoi);
        }

        public List<User> GetAllEmployees()
        {
            return usersDAL.GetAllEmployees();
        }

        public void AddEmployee(string maNV, string hoTen, string gioiTinh, string sDT, DateTime ngaySinh, string email, string diaChi, int trangThai, int quyen, string image)
        {
            var emp = new User
            {
                UserName = maNV,
                Password = "123",
                FullName = hoTen,
                Gender = gioiTinh,
                PhoneNumber = sDT,
                DateOfBirth = ngaySinh,
                Email = email,
                Address = diaChi,
                isActive = trangThai,
                Image = image,
                RoleID = quyen
            };
            usersDAL.AddUser(emp);
        }

        public void UpdateEmployee(string maKH, string hoTen, string gioiTinh, string sDT, DateTime ngaySinh, string email, string diaChi, int trangThai, int quyen, string image)
        {
            var emp = usersDAL.getCustomerByUserName(maKH);
            if (emp != null)
            {
                emp.UserName = maKH;
                emp.FullName = hoTen;
                emp.Gender = gioiTinh;
                emp.PhoneNumber = sDT;
                emp.DateOfBirth = ngaySinh;
                emp.Email = email;
                emp.Address = diaChi;
                emp.isActive = trangThai;
                emp.Image = image;
            }
            usersDAL.UpdateUser(emp);
        }

        public void DeleteEmployee(string maNV)
        {
            usersDAL.DeleteUser(maNV);
        }
    }
}
