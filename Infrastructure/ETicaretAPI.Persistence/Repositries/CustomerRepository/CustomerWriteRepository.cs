using ETicaretAPI.Application.Repositries.CustomerRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositries.CustomerRepository
{
    public class CustomerWriteRepository : WriteRepository<Customer , ETicaretAPIDbContext> , ICustomerWriteRepository
    {
    }
}
