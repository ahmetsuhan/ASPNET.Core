using CustomMiddleware.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseBasicAuth(this IApplicationBuilder app)
        {
            app.UseMiddleware<BasicAuthMiddleware>();
            return app;
        }

    }
}
