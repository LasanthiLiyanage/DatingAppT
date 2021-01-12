using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CreatrToken(AppUser user);
    }
}