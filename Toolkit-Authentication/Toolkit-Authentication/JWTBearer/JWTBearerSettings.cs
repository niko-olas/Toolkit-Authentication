using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Authentication.JWTBearer
{
    public class JWTBearerSettings
    {
       

        /// <summary>
        /// Gets or sets the security key that is used to sign the token.
        /// </summary>
        public string SecurityKey { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list that contains valid issuers that will be used to check against the token's issuer.
        /// </summary>
        /// <seealso cref="TokenValidationParameters.ValidIssuers"/>
        public string[]? Issuers { get; set; }

        /// <summary>
        /// Gets or sets the list that contains valid audiences that will be used to check against the token's audience.
        /// </summary>
        /// <seealso cref="TokenValidationParameters.ValidAudience"/>
        public string[]? Audiences { get; set; }

        /// <summary>
        /// Gets or sets the expiration time (relative to UTC current time) of the bearer token.
        /// </summary>
        public TimeSpan? ExpirationTime { get; set; }

       
    }
}
