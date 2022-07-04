using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Authentication.JWTBearer
{
    internal class JWTTokenGeneratorService : IJWTTokenGeneratorService
    {
        private readonly JWTBearerSettings jwtBearerSettings;

        public JWTTokenGeneratorService(IOptions<JWTBearerSettings> jwtBearerSettingsOptions)
        {
            jwtBearerSettings = jwtBearerSettingsOptions.Value;
        }

        public string CreateToken(string username, IList<Claim>? claims = null, string? issuer = null, string? audience = null)
        {
            claims ??= new List<Claim>();
            ///
            return "";

        }


    }
}
