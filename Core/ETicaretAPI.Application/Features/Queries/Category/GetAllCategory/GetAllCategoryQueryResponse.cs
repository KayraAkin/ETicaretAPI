using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Category.GetAllCategory
{
    public class GetAllCategoryQueryResponse
    {
        public IList<Domain.Entities.Category> Categories {  get; set; }
    }
}
