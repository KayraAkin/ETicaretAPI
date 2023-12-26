using ETicaretAPI.Application.Features.Queries.Category.GetAllCategory;
using ETicaretAPI.Application.Features.Queries.Category.GetCategory;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll(GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            GetAllCategoryQueryResponse response = await _mediator.Send(getAllCategoryQueryRequest);
            return Ok(response);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] GetCategoryQueryRequest getCategoryQueryRequest )
        {
            GetCategoryQueryResponse response = await _mediator.Send(getCategoryQueryRequest);
            return Ok(response);
        }
    }
}
