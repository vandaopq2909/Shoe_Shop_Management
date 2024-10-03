
namespace DTO
{
    public class UsersDTO
    {
        public string? UserName {  get; set; }
        public string? Password { get; set; }
        public int IsActive { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public UsersDTO() { }
        public UsersDTO(string? userName, string? password, int isActive, string? fullName, string email, string phoneNumber, string gender, DateTime dateOfBirth, string address)
        {
            UserName = userName;
            Password = password;
            IsActive = isActive;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Address = address;
        }
    }
}
