using Application.Features.CreateUser.Commands;
using Application.Features.Login.Commands;
using Application.Features.RefreshTokenLogin.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        public AuthController(IConfiguration configuration) : base(configuration)
        {

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommandRequest loginCommandRequest)
        {
            LoginCommandResponse response = new LoginCommandResponse();

            response = await Mediator.Send(loginCommandRequest);
            
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await Mediator.Send(createUserCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshTokenLogin([FromBody] RefreshTokenLoginCommandRequest refreshTokenLoginCommandRequest)
        {
            RefreshTokenLoginCommandResponse response = await Mediator.Send(refreshTokenLoginCommandRequest);
            return Ok(response);
        }

    }
}