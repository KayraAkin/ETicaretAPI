using ETicaretAPI.Application.Repositries.ProductRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Product.GetProduct
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest , GetProductQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;

        public GetProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetProductQueryResponse> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var resultGet = await _productReadRepository.Get(p => p.ProductId == int.Parse(request.Id));
            return new GetProductQueryResponse { Product = resultGet };
        }
    }
}
