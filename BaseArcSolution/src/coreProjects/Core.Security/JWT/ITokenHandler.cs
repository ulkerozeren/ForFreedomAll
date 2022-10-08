using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.JWT
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
