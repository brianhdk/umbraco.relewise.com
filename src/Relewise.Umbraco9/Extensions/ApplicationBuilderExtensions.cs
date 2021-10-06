using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace Relewise.Umbraco9.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IUmbracoEndpointBuilderContext UseRelewiseEndpoints(this IUmbracoEndpointBuilderContext builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            builder.EndpointRouteBuilder.MapGet("/relewise-tracking", async context =>
            {
                await context.Response.WriteAsync("Hello from Relewise");
            });

            return builder;
        }
    }
}
