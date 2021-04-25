using API.Entities;
using API.Interfaces;

namespace API.Services
{
    public class TokenService : ITokenService
    {
        string ITokenService.CreateToken(AppUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}