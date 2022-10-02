using Application.Features.Product.Commands.CreateProduct;
using Application.Features.Product.Queries.GetAllProduct;
using Application.Features.Product.Queries.GetByIdProduct;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {
        public ProductsController(IConfiguration configuration) : base(configuration)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse result = await Mediator.Send(getAllProductQueryRequest);
            return Ok(result);
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse result = await Mediator.Send(getByIdProductQueryRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse result = await Mediator.Send(createProductCommandRequest);
            return Created("", result);
        }
    }
}
