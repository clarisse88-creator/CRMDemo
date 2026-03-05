
using Application.DTO;
using Application.Interface;
using Core.Domain.ValueObeject;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;




namespace Infrastructure.Identity
{
    public class IdentityRepository : IIdentity
    {
        private readonly ApplicationDbContext _dbContext;
         private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
           private readonly RoleManager<IdentityRole<int>> _roleManager;
        public IdentityRepository(
        ApplicationDbContext context ,
        UserManager<User> userManager,
        SignInManager<User> signInManager,
        RoleManager<IdentityRole<int>> roleManager)
        {
           _dbContext = context; 
           _userManager = userManager;
           _signInManager = signInManager;
           _roleManager = roleManager;
        }

        public async Task RegisterUser(RegisterUserDTO dto)
        {
            var newUser = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                UserName = dto.Email,  
                PhoneNumber = dto.PhoneNumber,
                EmailConfirmed = true,  // Auto-confirm email for demo
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

           var result = await _userManager.CreateAsync(newUser, dto.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException($"Failed to create user: {errors}");
            }

            // Assign role to user
            if (!string.IsNullOrEmpty(dto.Role))
            {
                await _userManager.AddToRoleAsync(newUser, dto.Role);
            }
        }
        public async Task<List<UserDetailDTO>> GetAllUsers()
        {
            var users = await _userManager.Users

            .OrderBy(u=>u.FirstName)
            .ThenBy(u=>u.LastName)
            .ToListAsync();

            return users.Select(u => new UserDetailDTO
            {
                Id = u.Id,
                FirstName = u.FirstName??"",
                LastName = u.LastName??"",
                Email = u.Email??"",
                PhoneNumber = u.PhoneNumber??"",
                EmailConfirmed = u.EmailConfirmed,
                CreatedAt = u.CreatedAt,
                UpdatedAt = u.UpdatedAt
            }).ToList();
        }
        public async Task<UserDetailDTO?> GetUserById(int id)
        {
          var user =await _userManager.Users 
          .FirstOrDefaultAsync(u => u.Id == id);
          
          if (user == null) return null;

            return new UserDetailDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                EmailConfirmed = user.EmailConfirmed,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt
            };
        }
        public async Task UpdateUser(int id, UpdateUserDTO dto)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
             throw new InvalidOperationException($"User with ID {id} not found.");

            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.PhoneNumber = dto.PhoneNumber;
            user.UpdatedAt = DateTime.UtcNow;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException($"User update failed: {errors}");
            }
            // Update user role if provided
            if (!string.IsNullOrEmpty(dto.Role))
            {
                var currentRoles = await _userManager.GetRolesAsync(user);
                if (!currentRoles.Contains(dto.Role))
                {
                    await _userManager.RemoveFromRolesAsync(user, currentRoles); // Remove from older roles
                    await _userManager.AddToRoleAsync(user, dto.Role); // Add to new role for user
                }
            }
        }
    public async Task<bool> LoginAsync (LoginDTO dto)
      {
        
        if (!await _roleManager.Roles.AnyAsync())
        {
           await _roleManager.CreateAsync(new IdentityRole<int> { Name = UserRole.Admin.ToString() });
           await _roleManager.CreateAsync(new IdentityRole<int> { Name = UserRole.Customer.ToString() });     
        }


        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user == null)
            {
                return false;
            }
            var result =await _signInManager.PasswordSignInAsync(
                user.UserName?? dto.Email,
                dto.Password,
                dto.RememberMe,
                lockoutOnFailure:true
            );
            return result . Succeeded;

     }
     
        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}