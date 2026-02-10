using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Data;
using Application.Interface;
using Infrastructure.Repositories;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register ApplicationDbContext (service here) with SQL Server provider
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("CRMDemoMSSQLConnection")),ServiceLifetime.Scoped
                );
            // Register other infrastructure services here
             services.AddScoped<ICustomer, CustomerRepository>();
             services.AddScoped<ICampaign, CampaignRepository>();
             services.AddScoped<ITicket, TicketRepository>();
            //  services.AddScoped<IUser, UserRepository>();

            return services;
        }
    }
}