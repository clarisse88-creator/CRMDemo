using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class CustomerCreateDTO
    {
       [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CustomerFilterDTO
    {
        public string Email{get;set;}
        public string City{get;set;}
        public string CreatedBy{get;set;}
        public string SearchTerm{get;set;}

    }
    public class CityCountDTO
    {
        public string city{get;set;}
        public int Count{get;set;}
    }
    public class CustomerUpdateDTO
    {
      
       public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
    }
}