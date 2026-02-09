namespace Application.DTO
{
    public class CampaignCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Budget { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }

    public class CampaignUpdateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Budget { get; set; }
        public string Status { get; set; }
    }
}