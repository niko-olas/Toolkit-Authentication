﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit_Authentication.JWTBearer
{
    public interface IJWTAuthetnicationBuilder
    {
        IServiceCollection Service { get; }
    }
}
