using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Infrastructure.Data;
using System.Net;
using Microsoft.AspNetCore.Http;


namespace Infrastructure.Identity 
{
    public static class Authentication 
    {
        public static IServiceCollection AddAuthenticationservice(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddAuthentication(option =>
           {
               option.DefaultAuthenticateScheme  =IdentityConstants.ApplicationScheme;
               option.DefaultChallengeScheme =IdentityConstants.ApplicationScheme;
               option.DefaultScheme =IdentityConstants.ApplicationScheme;
           }).AddIdentityCookies();

           services.AddIdentityCore<User>(options =>
           {
                 options.Password.RequireDigit = true;
                 options.Password.RequireLowercase = true;
                 options.Password.RequireNonAlphanumeric = false;
                 options.Password.RequireUppercase = true;
                 options.Password.RequiredLength = 8;
                 options.User.RequireUniqueEmail = true;
                 options.SignIn.RequireConfirmedAccount = true;
                 options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                 options.Lockout.MaxFailedAccessAttempts = 5;

           })
           .AddRoles<IdentityRole<int>>()
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddSignInManager()
           .AddDefaultTokenProviders();

           services.Configure<DataProtectionTokenProviderOptions>(option =>
           {
             option.TokenLifespan = TimeSpan.FromHours(6);
             
           });

           services.ConfigureApplicationCookie(options =>
           {
               options.Cookie.Name ="CRMDemo";
               options.Cookie.HttpOnly =true;
               options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
               options.Cookie.SameSite = SameSiteMode.Lax;               
           });

           return services;
        }
    }
 
}