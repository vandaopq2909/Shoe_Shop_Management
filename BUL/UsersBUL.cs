﻿using DAL;
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
            usersDAL.AddCustomer(customer);
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
            usersDAL.UpdateCustomer(customer);
        }

        public void DeleteCustomer(string maKH)
        {
            usersDAL.DeleteCustomer(maKH);
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
    }
}
