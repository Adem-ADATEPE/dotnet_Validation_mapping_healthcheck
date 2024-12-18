﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace BP.Api.Extensions
{
    public static class HealthCheckConfigureExtension
    {

        public static IApplicationBuilder UseCustomHealthCheck(this IApplicationBuilder app)
        {
            app.UseHealthChecks("/api/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions()
            {
                ResponseWriter = async (context, report) =>
                {
                    await context.Response.WriteAsync("ok");
                }

            });

            return app;
        }
    }
}
