using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Authentication.JWTBearer
{
    public class JWTBearerSettings
    {


        public string? SecurityKey { get; init; }

        public string[]? Issuers { get; init; }

        public string[]? Audiences { get; init; }

        public TimeSpan? ExpirationTime { get; init; }

        public TimeSpan ClockSkew { get; init; } = TimeSpan.FromMinutes(5);

        public bool EnableJwtBearerGeneration { get; init; } = true;


    }
}
