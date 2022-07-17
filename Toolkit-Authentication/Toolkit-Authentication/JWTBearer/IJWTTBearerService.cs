using System.Security.Claims;

namespace Toolkit_Authentication.JWTBearer
{
    public interface IJWTBearerService
    {
        string CreateToken(string username, IList<Claim>? claims = null, string? issuer = null, string? audience = null);
    }
}