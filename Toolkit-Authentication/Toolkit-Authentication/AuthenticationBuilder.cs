using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Authentication
{
    internal class AuthenticationBuilder : IAuthentication
    {
        public IConfiguration Configuration { get; }

        public Microsoft.AspNetCore.Authentication.AuthenticationBuilder Builder { get; }

        public AuthenticationBuilder(IConfiguration configuration, Microsoft.AspNetCore.Authentication.AuthenticationBuilder builder)
        {
            Configuration = configuration;
            Builder = builder;
        }
    }
}
