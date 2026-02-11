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

           services.AddIdentityCore<User>(Options =>
           {
              Options.Password.RequireDigit =true;
              Options.Password.RequiredLength =8; 
              Options.Password.RequireUppercase =true;

              Options.User.RequireUniqueEmail =true;

              Options.SignIn.RequireConfirmedAccount =true;
              Options.Lockout.MaxFailedAccessAttempts =3;
              

           })
           .AddRoles<IdentityRole<int>>()
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddSignInManager()
           .AddDefaultTokenProviders();

           services.Configure<DataProtectionTokenProviderOptions>(option =>
           {
             option.TokenLifespan = TimeSpan.FromHours(6);
             
           });

           services.ConfigureApplicationCookie(Options =>
           {
               Options.Cookie.Name ="CRMDemo";
               Options.Cookie.HttpOnly =true;
               Options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
               Options.Cookie.SameSite = SameSiteMode.Lax;               
           });

           return services;
        }
    }
 
}