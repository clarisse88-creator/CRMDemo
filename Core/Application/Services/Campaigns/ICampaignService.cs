using Domain.Entities;
using Application.DTO;


namespace Application.Services.Campaigns
{
    public interface ICampaignService
    {    
        Campaign GetCampaignById(int Id);
        List<Campaign> GetAllCampaigns();
        void CreateCampaign(CampaignCreateDTO campaignDTO);
        void UpdateCampaign(int Id, CampaignUpdateDTO campaignDTO);
    }
}