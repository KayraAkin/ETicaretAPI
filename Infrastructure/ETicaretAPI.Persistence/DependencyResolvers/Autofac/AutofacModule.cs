using Autofac;
using ETicaretAPI.Application.Repositries.CategoryRepository;
using ETicaretAPI.Application.Repositries.CustomerRepository;
using ETicaretAPI.Application.Repositries.ProductRepository;
using ETicaretAPI.Application.Repositries.UserRepository;
using ETicaretAPI.Persistence.Repositries.CategoryRepository;
using ETicaretAPI.Persistence.Repositries.CustomerRepository;
using ETicaretAPI.Persistence.Repositries.ProductRepository;
using ETicaretAPI.Persistence.Repositries.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.DependencyResolvers.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerReadRepository>().As<ICusomerReadRepository>().SingleInstance();
            builder.RegisterType<CustomerWriteRepository>().As<ICustomerWriteRepository>().SingleInstance();
            builder.RegisterType<CategoryReadRepository>().As<ICategoryReadRepository>().SingleInstance();
            builder.RegisterType<CategoryWriteRepository>().As<ICategoryWriteRepository>().SingleInstance();
            builder.RegisterType<ProductReadRepository>().As<IProductReadRepository>().SingleInstance();
            builder.RegisterType<ProductWriteRepository>().As<IProductWriteRepository>().SingleInstance();
            builder.RegisterType<UserReadRepository>().As<IUserReadRepository>().SingleInstance();
            builder.RegisterType<UserWriteRepository>().As<IUserWriteRepository>().SingleInstance();
        }
    }
}
