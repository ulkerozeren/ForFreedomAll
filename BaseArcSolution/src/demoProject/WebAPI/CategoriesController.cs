using Application.Features.Category.Commands.CreateCategory;
using Application.Features.Category.Queries.GetAllCategory;
using Application.Features.Category.Queries.GetByIdCategory;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            GetAllCategoryQueryResponse result = await Mediator.Send(getAllCategoryQueryRequest);
            return Ok(result);
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCategoryQueryRequest getByIdCategoryQueryRequest)
        {
            GetByIdCategoryQueryResponse result = await Mediator.Send(getByIdCategoryQueryRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse result = await Mediator.Send(createCategoryCommandRequest);
            return Created("", result);
        }
    }
}
