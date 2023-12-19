using ETicaretAPI.Application.Repositries.CustomerRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositries.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer , ETicaretAPIDbContext> , ICusomerReadRepository
    {
    }
}
