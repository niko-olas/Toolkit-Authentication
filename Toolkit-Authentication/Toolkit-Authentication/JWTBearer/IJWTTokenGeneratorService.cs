using System.Security.Claims;

namespace Toolkit_Authentication.JWTBearer
{
    internal interface IJWTTokenGeneratorService
    {
        string CreateToken(string username, IList<Claim>? claims = null, string? issuer = null, string? audience = null);
    }
}