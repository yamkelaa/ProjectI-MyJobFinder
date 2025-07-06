using Application.Interfaces.ExceptionProcessor;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Middleware;

public class ErrorHandlingMiddleware(ILogger<ErrorHandlingMiddleware> logger, IExceptionProcessor exceptionProcessor) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError($"An error occurred: {ex.Message}");
            await exceptionProcessor.HandleAsync(context, ex);
        }
    }
}
