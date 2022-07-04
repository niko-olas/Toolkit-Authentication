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
        public IServiceCollection Service { get; }

        public AuthenticationBuilder(IServiceCollection service)
        {
            Service = service;
        }
    }
}
