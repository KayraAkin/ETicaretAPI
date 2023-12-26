using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandRequest: IRequest<CreateProductCommandResponse>
    {
        public Domain.Entities.Product Product { get; set; }
    }
}
