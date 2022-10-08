using Core.Security.JWT;

namespace Application.Features.Login.Commands
{

    public class LoginCommandResponse 
    {
        public Token Token { get; set; }
    }
}
