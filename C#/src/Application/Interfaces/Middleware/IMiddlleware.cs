using Microsoft.AspNetCore.Http;

namespace Application.Interfaces.Middleware;

public interface IMiddlleware
{
    Task InvokeAsync(HttpContext context);
}
