using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolkit_Authentication.JWTBearer;

namespace Toolkit_Authentication
{
    public static class AuthenticationExtection
    {
        public static IAuthentication AddBaseAuthentication(this IServiceCollection services)
            => new AuthenticationBuilder(services);

        public static IJWTAuthetnicationBuilder WithJWTBearer(this IAuthentication builder, IConfiguration configuration, string sectionName = "Authentication")
        {
            var section = configuration.GetSection(sectionName);
            var jwrSettings = section.Get<JWTBearerSettings>();
            builder.Service.Configure<JWTBearerSettings>(section);

            //ROBA
            
            return new JWTAuthentication(builder.Service);
        }

        public static IJWTAuthetnicationBuilder TokenGenerator(this IJWTAuthetnicationBuilder builder)
        {
            builder.Service.TryAddSingleton<IJWTTokenGeneratorService, JWTTokenGeneratorService>();
            return builder;
        }

        public static IApplicationBuilder UseAuthentication(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }
    }
}
