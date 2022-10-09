
using Core.Security.JWT;

namespace Application.Features.RefreshTokenLogin.Commands
{
    public class RefreshTokenLoginCommandResponse
    {
        public Token Token { get; set; }
    }
}
