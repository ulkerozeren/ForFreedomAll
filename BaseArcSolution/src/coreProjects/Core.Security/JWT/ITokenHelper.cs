using Core.Security.Entities;

namespace Core.Security.JWT;

public interface ITokenHelper
{
    AccessToken CreateToken(AppUser user, IList<OperationClaim> operationClaims);

    RefreshToken CreateRefreshToken(AppUser user, string ipAddress);
}