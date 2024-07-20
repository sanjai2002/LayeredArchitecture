using Relevantz.LXP.Common.Entities;
using Relevantz.LXP.Common.ViewModels;
using Relevantz.LXP.Core.IServices;
using Relevantz.LXP.Core.Services;
using Relevantz.LXP.Data.IRepository;
using Relevantz.LXP.Data.Repository;
 
 
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IDashboardRepository, DashboardRepository>();
builder.Services.AddScoped<IDashboardService, DashboardService>();

builder.Services.AddScoped<LXPDbContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
