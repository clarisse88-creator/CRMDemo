using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class RegisterUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get;set;}
        public string PhoneNumber {get;set;}
        public string Password {get;set;}
        public string ConfirmPassword {get;set;}
        public string EmailConfirmed {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}


    }
    public class UserDetailDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get;set;}
        public string PhoneNumber {get;set;}
        public bool EmailConfirmed {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
    }
    public class UpdateUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get;set;}
        public string PhoneNumber {get;set;}

       
    }
        public class LoginDTO
        {
            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid email address")]
            public string Email {get;set;} = string.Empty;
            [Required(ErrorMessage ="Password is required")]
            public string Password {get;set;} = string.Empty;
            public bool RememberMe {get;set;}
            
        }
}