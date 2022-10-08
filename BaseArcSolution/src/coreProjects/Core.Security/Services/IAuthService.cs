using Core.Security.JWT;

namespace Core.Security.Services
{
    public interface IAuthService
    {
        Task<Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
        Task<Token> RefreshTokenLoginAsync(string refreshToken);
    }
}
