using MediatR;

namespace Application.Features.RefreshTokenLogin.Commands
{
    public class RefreshTokenLoginCommandRequest : IRequest<RefreshTokenLoginCommandResponse>
    {
        public string RefreshToken { get; set; }
    }
}
