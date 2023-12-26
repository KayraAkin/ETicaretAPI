using ETicaretAPI.Application.Repositries;
using ETicaretAPI.Application.Repositries.CategoryRepository;
using ETicaretAPI.Application.Repositries.CustomerRepository;
using ETicaretAPI.Application.Repositries.ProductRepository;
using ETicaretAPI.Application.Repositries.UserRepository;
using ETicaretAPI.Persistence.Context;
using ETicaretAPI.Persistence.Repositries;
using ETicaretAPI.Persistence.Repositries.CategoryRepository;
using ETicaretAPI.Persistence.Repositries.CustomerRepository;
using ETicaretAPI.Persistence.Repositries.ProductRepository;
using ETicaretAPI.Persistence.Repositries.UserRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {

        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddSingleton<ICategoryReadRepository,CategoryReadRepository>();
            services.AddSingleton<ICategoryWriteRepository,CategoryWriteRepository>();
            services.AddSingleton<ICusomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
            services.AddSingleton<IUserReadRepository, UserReadRepository>();
            services.AddSingleton<IUserWriteRepository, UserWriteRepository>();
        }

    }
}
