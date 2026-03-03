using System.Security.Claims;
using Application.Interface;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Identity
{
    public class UserContext : IUserContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor; 

        public UserContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        private ClaimsPrincipal? ClaimsPrincipal => _httpContextAccessor.HttpContext?.User;

        public int? Id
        {
            get
            {
               var userIdClaim =ClaimsPrincipal?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
               if (int.TryParse(userIdClaim, out int userId))
               {
                   return userId;
               }
               return null; 
            } 
        }
        public bool IsAuthenticated => ClaimsPrincipal?.Identity?.IsAuthenticated ?? false; 
        public string Email => ClaimsPrincipal?.FindFirst(ClaimTypes.Email)?.Value;
        public string FirstName => ClaimsPrincipal?.FindFirst("FirstName")?.Value ?? string.Empty;
        public string LastName => ClaimsPrincipal?.FindFirst("LastName")?.Value ?? string.Empty;
        public string FullName => $"{FirstName} {LastName}".Trim();
        public string Initials
        {
            get
            {
                var first = !string.IsNullOrEmpty(FirstName) ? FirstName[0].ToString().ToUpper() : "";
                var last = !string.IsNullOrEmpty(LastName) ? LastName[0].ToString().ToUpper() : "";
                return $"{first}{last}";
            }
        }
    }
}