using ETicaretAPI.Application.Repositries.CategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Category.GetAllCategory
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;

        public GetAllCategoryQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var resultGet = await _categoryReadRepository.GetAll();

            return new GetAllCategoryQueryResponse { Categories = resultGet };
        }
    }
}
