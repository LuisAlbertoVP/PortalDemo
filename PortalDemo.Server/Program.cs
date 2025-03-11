using Microsoft.EntityFrameworkCore;
using PortalDemo.Application.AppServices;
using PortalDemo.Application.Interfaces;
using PortalDemo.Domain.Interfaces;
using PortalDemo.Domain.Models;
using PortalDemo.Infrastructure.SqlServer.Extensions;
using PortalDemo.Infrastructure.SqlServer.Models;
using PortalDemo.Infrastructure.SqlServer.Repositories;

var builder = WebApplication.CreateBuilder(args);
var appSettings = builder.Configuration.Get<AppSettings>();

// Add services to the container.
builder.Services.AddDbContext<PortalDemoContext>(options => options.UseSqlServer(appSettings.ToConnectionString()));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
