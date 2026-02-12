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
        public async Task<bool> LoginAsync(LoginDTO dto)
        {
            return await Identity.LoginAsync(dto);
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
            throw new NotImplementedException();
        }
    } 
}