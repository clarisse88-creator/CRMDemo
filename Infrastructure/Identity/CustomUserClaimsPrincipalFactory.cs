using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace Infrastructure.Identity
{
    public class CustomUserClaimPrincipalFactory :UserClaimsPrincipalFactory<User, IdentityRole<int>>
    {
        public CustomUserClaimPrincipalFactory(UserManager<User> userManager,
         RoleManager<IdentityRole<int>> roleManager,
          IOptions<IdentityOptions> options)
         : base(userManager, roleManager, options)
        {
        }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var claimsIdentity = await base.GenerateClaimsAsync(user);

            //not defoult to identity frame work
            claimsIdentity.AddClaim(new Claim("FirstName", user.FirstName));
            claimsIdentity.AddClaim(new Claim("LastName", user.LastName));

            return claimsIdentity;
        }
    }
}