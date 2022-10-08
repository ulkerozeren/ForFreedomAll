using Core.Security.JWT;
using MediatR;

namespace Application.Features.Login.Commands
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
