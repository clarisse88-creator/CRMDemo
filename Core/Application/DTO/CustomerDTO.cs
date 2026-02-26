namespace Application.DTO
{
    public class CustomerCreateDTO
    {
       
        public string Name { get; set; }
        public string Email { get; set; }
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