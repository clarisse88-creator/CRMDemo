using Application.Interface;
using Domain.Entities; 
using Application.DTO;


namespace Application.Services.Users
{
    public class IdentityService : IIdentityService
    {
    
        private readonly IIdentity Identity;

        //constructor 
        public IdentityService(IIdentity identity)
        {
            Identity = identity;
        }
     
            public async Task RegisterUser(RegisterUserDTO dto)
        {
            // Implementation for user registration can be added here
             await Identity.RegisterUser(dto);
        }
    } 
}