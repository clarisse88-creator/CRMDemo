using Application.Services.Customers;
using Application.Services.Tickets;
using Application.Services.Campaigns;
using Infrastructure.DependencyInjection;
using Infrastructure.Data;
using API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddInfrastructureServices(builder.Configuration);

// Application Services
 builder.Services.AddScoped<ICustomerService, CustomerService>();
 builder.Services.AddScoped<ITicketService, TicketService>();
 builder.Services.AddScoped<ICampaignService, CampaignService>();
 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseMiddleware<ApiKeyMiddleWare>();

app.UseAuthorization();

app.MapControllers();

app.Run();
