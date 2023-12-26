using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Category.GetCategory
{
    public class GetCategoryQueryRequest : IRequest<GetCategoryQueryResponse>
    {
        public string Id { get; set; }
    }
}
