
using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;




namespace Infrastructure.Identity
{
    public class IdentityRepository : IIdentity
    {
        private readonly ApplicationDbContext dbContext;
         private readonly UserManager<User> userManager;
          private readonly SignInManager<User> SignInManager;
           private readonly RoleManager<IdentityRole<int>> roleManager;
        public IdentityRepository(
        ApplicationDbContext context ,
        UserManager<User> userManager,
        SignInManager<User> SignInManager,
        RoleManager<IdentityRole<int>> roleManager)
        {
           dbContext = context; 
           userManager = userManager;
           SignInManager = SignInManager;
           roleManager = roleManager;
        }

        public async Task RegisterUser(RegisterUserDTO dto)
        {
            var newUser = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                UserName = dto.Email,  // Use email as username
                PhoneNumber = dto.PhoneNumber,
                EmailConfirmed = true,  // Auto-confirm email for demo
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            
            var result = await userManager.CreateAsync(newUser, dto.Password);
            
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception($"User registration failed: {errors}");
            }
        }
    }
}