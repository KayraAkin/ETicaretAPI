using ETicaretAPI.Application.Repositries.ProductRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositries.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product , ETicaretAPIDbContext> , IProductReadRepository
    {
    }
}
