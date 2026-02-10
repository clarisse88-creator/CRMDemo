namespace Application.DTO
{
    public class TicketCreateDTO
    {
       
        public string CustomerId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public string Priority { get; set; }
        public string Type { get; set; }
        public DateTime closedAt { get; set; }
    }

    public class TicketUpdateDTO
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
         public string Priority { get; set; }
        public string Type { get; set; }
        public DateTime closedAt { get; set; }
    }
}