using Application.Interfaces.ExceptionProcessor;
using Application.Interfaces.Mediator;
using Infrastructure.Exceptions;
using Infrastructure.Mediator;
using Infrastructure.Middleware;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

/// <summary>
/// Registers infrastructure-layer services such as the AppDbContext.
/// </summary>
/// <param name="services">The IServiceCollection to add services to.</param>
/// <param name="configuration">Application configuration for accessing settings.</param>
/// <returns>The updated IServiceCollection.</returns>
public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddSingleton<IMediatorService, MediatorService>();
        services.AddSingleton<IExceptionProcessor, ExceptionProcessor>();

        services.AddTransient<ErrorHandlingMiddleware>();
        services.AddTransient<LoggingMiddleware>();
        services.AddTransient<AuthenticationMiddleware>();
        return services;
    }
}
