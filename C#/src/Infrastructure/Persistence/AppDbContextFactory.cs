using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence;

/// <summary>
/// Provides a mechanism for creating instances of a <see cref="AppDbContext"/> at design time 
/// when the context type does not expose a public parameterless constructor.
/// This is typically used by Entity Framework Core tools to enable operations such as 
/// migrations and scaffolding outside the runtime application's dependency injection.
/// </summary>

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {

        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");
        var builder = new DbContextOptionsBuilder<AppDbContext>();
        builder.UseSqlServer(connectionString);
        return new AppDbContext(builder.Options);
    }
}
