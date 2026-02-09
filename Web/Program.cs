
using Web.Components;
using Application.Services.Customers;
using Application.Services.Tickets;
using Application.Services.Campaigns;
using Application.Services.Users;
using Infrastructure.DependencyInjection;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
//regist mudblazor services
  builder.Services.AddMudServices();

// Add services to the container.
 builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

    // Infrastructure Services
builder.Services.AddInfrastructureServices(builder.Configuration);

// Application Services
 builder.Services.AddScoped<ICustomerService, CustomerService>();
 builder.Services.AddScoped<ITicketService, TicketService>();
 builder.Services.AddScoped<ICampaignService, CampaignService>();
 builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets(); // Map static assets from wwwroot and _content folders
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
   

app.Run();
