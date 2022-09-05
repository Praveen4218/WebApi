using InsuranceWebApi;
using InsuranceWebApi.Interface;
using InsuranceWebApi.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[assembly: ApiController]


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ICustomer, CustomerService>();
builder.Services.AddScoped<IPolicy, PolicyService>();

builder.Services.AddDbContext<insuranceContext>(option => option.UseSqlServer("Data Source=DESKTOP-M8PSQIS/SQLEXPRESS;Initial Catalog=insurance;Integrated Security=True"));

//builder.Services.AddDbContext<insuranceContext>(option => option.UseSqlServer("Data Source=DESKTOP - M8PSQIS/SQLEXPRESS(DESKTOP - M8PSQIS/PRAVEEN);Initial Catalog=insurance;Integrated Security=True"));


//var app = builder.Build();
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
