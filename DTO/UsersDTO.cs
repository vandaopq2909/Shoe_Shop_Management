using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsersDTO
    {
        public string? UserID {  get; set; }
        public string? Password { get; set; }
        public int isActive { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public UsersDTO() { }
        public UsersDTO(string? userID, string? password, int isActive, string? fullName, string email, string phoneNumber, string gender, DateTime dateOfBirth, string address)
        {
            UserID = userID;
            Password = password;
            this.isActive = isActive;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Address = address;
        }
    }
}
