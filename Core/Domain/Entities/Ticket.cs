namespace Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public DateTime closedAt { get; set; }
        // Audit Fields
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
        public int? CreatedById { get; set; }
        public int? UpdatedById { get; set; }



    }
}
