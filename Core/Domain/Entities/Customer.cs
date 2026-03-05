using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(50), EmailAddress]
        public string Email { get; set; }
        [MaxLength(15), Phone]
        public string PhoneNumber { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        // Audit Fields
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
        public int? CreatedById { get; set; }
        
        public int? UpdatedById { get; set; }

    }
}
