using ETicaretAPI.Application.Repositries.CategoryRepository;
using ETicaretAPI.Application.Repositries.CustomerRepository;
using ETicaretAPI.Application.Repositries.ProductRepository;
using ETicaretAPI.Application.Repositries.UserRepository;
using ETicaretAPI.Persistence;
using ETicaretAPI.Persistence.Context;
using ETicaretAPI.Persistence.Repositries.CategoryRepository;
using ETicaretAPI.Persistence.Repositries.CustomerRepository;
using ETicaretAPI.Persistence.Repositries.ProductRepository;
using ETicaretAPI.Persistence.Repositries.UserRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICusomerReadRepository , CustomerReadRepository>();
builder.Services.AddSingleton<ICustomerWriteRepository , CustomerWriteRepository>();
builder.Services.AddSingleton<ICategoryReadRepository , CategoryReadRepository>();
builder.Services.AddSingleton<ICategoryWriteRepository , CategoryWriteRepository>();
builder.Services.AddSingleton<IProductReadRepository , ProductReadRepository>();
builder.Services.AddSingleton<IProductWriteRepository , ProductWriteRepository>();
builder.Services.AddSingleton<IUserReadRepository , UserReadRepository>();
builder.Services.AddSingleton<IUserWriteRepository , UserWriteRepository>();



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
