using Microsoft.AspNetCore.Http;

namespace Application.Interfaces.ExceptionProcessor;

public interface IExceptionProcessor
{
    Task HandleAsync(HttpContext context, Exception exception);
}
