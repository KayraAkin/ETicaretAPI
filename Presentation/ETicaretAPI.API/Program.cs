using Autofac;
using Autofac.Extensions.DependencyInjection;
using ETicaretAPI.Application;
using ETicaretAPI.Application.Repositries.CategoryRepository;
using ETicaretAPI.Application.Repositries.CustomerRepository;
using ETicaretAPI.Application.Repositries.ProductRepository;
using ETicaretAPI.Application.Repositries.UserRepository;
using ETicaretAPI.Persistence;
using ETicaretAPI.Persistence.Context;
using ETicaretAPI.Persistence.DependencyResolvers.Autofac;
using ETicaretAPI.Persistence.Repositries.CategoryRepository;
using ETicaretAPI.Persistence.Repositries.CustomerRepository;
using ETicaretAPI.Persistence.Repositries.ProductRepository;
using ETicaretAPI.Persistence.Repositries.UserRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacModule());
    });



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
