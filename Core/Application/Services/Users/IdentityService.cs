using Application.Interface;
using Domain.Entities; 
using Application.DTO;
using Microsoft.Extensions.Logging;


namespace Application.Services.Users
{
    public class IdentityService : IIdentityService
    {
    
        private readonly IIdentity Identity;

        private readonly ILogger<IdentityService> _Logger;
        //constructor 
        public IdentityService(IIdentity identity , ILogger<IdentityService> logger)
        {
            Identity = identity;
            _Logger = logger;
        }
            public async Task RegisterUser(RegisterUserDTO dto)
        {
            // Implementation for user registration can be added here
             await Identity.RegisterUser(dto);
             _Logger.LogInformation("User created : {Email} {FirstName} {LastName}", dto.Email, dto.FirstName, dto.LastName);
        }
        public async Task<bool> LoginAsync(LoginDTO dto)
        {
            bool Succeeded = await Identity.LoginAsync(dto);
            if (Succeeded)
            {
                _Logger.LogInformation("User logged in : {Email}", dto.Email);
            }
            else
            {
                _Logger.LogWarning("Failed login failed for email: {Email}", dto.Email);
            }           
            return Succeeded;
        }
        public async Task<List<UserDetailDTO>> GetAllUsers()
        {
            return await Identity.GetAllUsers(); 
        }
        public async Task<UserDetailDTO?> GetUserById(int id)
        {
            return await Identity.GetUserById(id);
        }
        public async Task UpdateUser(int id, UpdateUserDTO dto)
        {
            await Identity.UpdateUser(id, dto);
        }

        public Task LogoutAsync()
        {
            return Identity.LogoutAsync();
        }
    } 
}