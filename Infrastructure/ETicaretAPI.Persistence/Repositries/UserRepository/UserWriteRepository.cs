using ETicaretAPI.Application.Repositries.UserRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositries.UserRepository
{
    public class UserWriteRepository : WriteRepository<User , ETicaretAPIDbContext>, IUserWriteRepository
    {
    }
}
