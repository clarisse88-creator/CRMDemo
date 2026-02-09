namespace Domain.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Budget { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        // Audit Fields
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
        public int? CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
        public int? UpdatedById { get; set; }
        
    }
}
