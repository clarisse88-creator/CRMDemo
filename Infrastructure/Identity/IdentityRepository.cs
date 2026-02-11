
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
              FirstName =dto.FirstName,
              LastName = dto.LastName,
              Email =dto.Email,
              PhoneNumber =dto.PhoneNumber,
            };

             await userManager.CreateAsync(newUser,dto.password);
              
        }
    }
}