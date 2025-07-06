using Application.Interfaces.ExceptionProcessor;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Exceptions;

public class ExceptionProcessor : IExceptionProcessor
{
    public async Task HandleAsync(HttpContext context, Exception exception)
    {
        switch (exception)
        {
            case InvalidOperationException:
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Reosurce retrieval failed");
                break;
            case ApplicationException:
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("Application exception");
                break;
            default:
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("Internal Server Error");
                break;
        }

    }
}
