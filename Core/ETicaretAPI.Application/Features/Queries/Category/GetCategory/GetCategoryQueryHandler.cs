using ETicaretAPI.Application.Repositries.CategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Category.GetCategory
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, GetCategoryQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;

        public GetCategoryQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetCategoryQueryResponse> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var resultGet = await _categoryReadRepository.Get(p => p.CategoryId == int.Parse(request.Id));
            return new GetCategoryQueryResponse { Category =  resultGet };
        }
    }
}
