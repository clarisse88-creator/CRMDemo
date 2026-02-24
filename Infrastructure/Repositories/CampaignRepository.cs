using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Application.DTO;



namespace Infrastructure.Repositories
{
  public class CampaignRepository : ICampaign

  {
      private readonly ApplicationDbContext dbContext;
        public CampaignRepository(ApplicationDbContext context)
        {
           dbContext= context; 
        }
        // Repository for retrieving campaign data
        public List<Campaign> GetAllCampaigns()
        {
          List<Campaign> campaigns = dbContext.Campaigns.ToList();
          return campaigns;
        }
        public Campaign GetCampaignById(int Id)
        {
            return  dbContext.Campaigns.FirstOrDefault(c => c.Id == Id);
       }
       public void CreateCampaign(CampaignCreateDTO campaignDTO)
        {
            var campaign = new Campaign
            {
                Name = campaignDTO.Name,
                Description = campaignDTO.Description,
                Type = campaignDTO.Type,
                StartDate = campaignDTO.StartDate,
                EndDate = campaignDTO.EndDate,
                Budget = campaignDTO.Budget,
                Status = campaignDTO.Status,
            };
            dbContext.Campaigns.Add(campaign);
            dbContext.SaveChanges();
        }
        public void UpdateCampaign(int Id,CampaignUpdateDTO campaignDTO)
        {
            var campaign = dbContext.Campaigns.Find(Id);
            if (campaign != null)
            {
                campaign.Name = campaignDTO.Name;
                campaign.Description = campaignDTO.Description;
                campaign.StartDate = campaignDTO.StartDate;
                campaign.EndDate = campaignDTO.EndDate;
                campaign.Budget = campaignDTO.Budget;
                campaign.Status = campaignDTO.Status;
                campaign.UpdatedById = 1;
                campaign.UpdatedAt = DateTime.Now;

                dbContext.SaveChanges();
            }
        }
}}