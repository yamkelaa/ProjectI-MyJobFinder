using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Middleware;

public class LoggingMiddleware(ILogger<LoggingMiddleware> logger) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        logger.LogInformation($"Request path: {context.Request.Path}, Method:{context.Request.Method}");
        await next(context);
        logger.LogInformation($"Respnse Status: {context.Response.StatusCode}");
    }
}
