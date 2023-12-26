using ETicaretAPI.Application.Repositries.ProductRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        readonly IProductWriteRepository _productWriteRepository;

        public UpdateProductCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Product resultUpdate = request.Product;
            _productWriteRepository.Update(resultUpdate);

            return await Task.FromResult<UpdateProductCommandResponse>(null);
        }
    }
}
