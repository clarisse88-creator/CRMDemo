namespace Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        // Audit Fields
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
        public int? CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
        public int? UpdatedById { get; set; }

    }
}
