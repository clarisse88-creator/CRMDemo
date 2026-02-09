using Domain.Entities;
using Application.DTO;
namespace Application.Interface

{
    public interface ICampaign
    {
        public List<Campaign> GetAllCampaigns();
        public Campaign GetCampaignById(int Id);
        void CreateCampaign(CampaignCreateDTO campaignDTO);
        void UpdateCampaign(int Id, CampaignUpdateDTO campaignDTO);
    }
}