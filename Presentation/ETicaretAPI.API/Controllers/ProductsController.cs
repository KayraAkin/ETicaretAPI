using ETicaretAPI.Application.Features.Commands.Product.CreateProduct;
using ETicaretAPI.Application.Features.Commands.Product.DeleteProduct;
using ETicaretAPI.Application.Features.Commands.Product.UpdateProduct;
using ETicaretAPI.Application.Features.Queries.Product.GetProduct;
using ETicaretAPI.Application.Features.Queries.ProductQueries.GetAllProduct;
using ETicaretAPI.Application.Repositries.ProductRepository;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IMediator _mediator;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll(GetAllProductQueryRequest getAllProductQueryRequest)
        {
          GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] GetProductQueryRequest getProductQueryRequest)
        {

            GetProductQueryResponse response = await _mediator.Send(getProductQueryRequest);
            return Ok(response);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateProductCommandRequest createProductCommandRequest)
        {
            await _mediator.Send(createProductCommandRequest);
            return Ok();
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteProductCommandRequest deleteProductCommandRequest)
        {
            await _mediator.Send(deleteProductCommandRequest);
            return Ok();
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
        {
            await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }

    }
}
