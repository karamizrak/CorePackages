using Microsoft.AspNetCore.Builder;
using MinistryOfHealth.Core.CrossCuttingConcerns.Exception.WebApi.Middleware;

namespace MinistryOfHealth.Core.CrossCuttingConcerns.Exception.WebApi.Extensions;

public static class ApplicationBuilderExceptionMiddlewareExtensions
{
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}
