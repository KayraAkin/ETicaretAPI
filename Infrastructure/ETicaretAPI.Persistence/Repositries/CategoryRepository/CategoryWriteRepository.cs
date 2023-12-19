using ETicaretAPI.Application.Repositries.CategoryRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositries.CategoryRepository
{
    public class CategoryWriteRepository : WriteRepository<Category , ETicaretAPIDbContext> , ICategoryWriteRepository
    {
    }
}
