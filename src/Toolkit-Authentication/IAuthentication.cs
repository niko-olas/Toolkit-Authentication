using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Authentication
{
    public interface IAuthentication
    {
        public IConfiguration Configuration { get; }

        public Microsoft.AspNetCore.Authentication.AuthenticationBuilder Builder { get; }
    }
}
