using Application.Interface;
using Domain.Entities; 
using Application.DTO;

namespace  Application.Services.Campaigns
{
    public class CampaignService : ICampaignService
    { 
     private readonly ICampaign Campaign;
           public CampaignService(ICampaign campaigns)
        {
            Campaign = campaigns;

        }
         public List<Campaign> GetAllCampaigns()
        {
         List<Campaign> campaigns = Campaign.GetAllCampaigns();
         return campaigns;
        }
         public Campaign GetCampaignById(int Id)
        {
         return Campaign.GetCampaignById(Id);
        }
       public void CreateCampaign(CampaignCreateDTO campaignDTO)
        {
         Campaign.CreateCampaign( campaignDTO);
        }
        public void UpdateCampaign(int Id, CampaignUpdateDTO campaignDTO)
        {
            Campaign.UpdateCampaign(Id, campaignDTO);
    }
    }
}