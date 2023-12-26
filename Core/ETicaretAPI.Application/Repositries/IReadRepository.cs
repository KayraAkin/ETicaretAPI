using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositries
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<IList<T>> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
