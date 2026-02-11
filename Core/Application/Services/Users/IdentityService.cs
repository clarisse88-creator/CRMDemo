using Application.Interface;
using Domain.Entities; 
using Application.DTO;
using Application.Interface.Users;


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
     
            public void RegisterUser(RegisterUserDTO dto)
        {
            // Implementation for user registration can be added here
             Identity.RegisterUser(dto);
        }
    } 
}