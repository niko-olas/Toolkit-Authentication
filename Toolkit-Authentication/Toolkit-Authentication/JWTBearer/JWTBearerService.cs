using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Authentication.JWTBearer
{
    internal class JWTBearerService : IJWTBearerService
    {
        private readonly JWTBearerSettings jwtBearerSettings;

        public JWTBearerService(IOptions<JWTBearerSettings> jwtBearerSettingsOptions)
        {
            jwtBearerSettings = jwtBearerSettingsOptions.Value;
        }

        public string CreateToken(string username, IList<Claim>? claims = null, string? issuer = null, string? audience = null)
        {
            claims ??= new List<Claim>();
            if (!claims.Any(c => c.Type == ClaimTypes.Name))
            {
                claims.Add(new Claim(ClaimTypes.Name, username));
            }

            var signingCredentials = !string.IsNullOrWhiteSpace(jwtBearerSettings.SecurityKey)
                ? new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtBearerSettings.SecurityKey)), SecurityAlgorithms.HmacSha256)
                : null;

            var jwtSecurityToken = new JwtSecurityToken(
                issuer ?? jwtBearerSettings.Issuers?.FirstOrDefault(),
                audience ?? jwtBearerSettings.Audiences?.FirstOrDefault(),
                claims,
                DateTime.UtcNow,
                jwtBearerSettings.ExpirationTime.GetValueOrDefault() > TimeSpan.Zero ? DateTime.UtcNow.Add(jwtBearerSettings.ExpirationTime!.Value) : null,
                signingCredentials);

            var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            return token;
        }


    }
}
