using Microsoft.EntityFrameworkCore;
using Tech_Store.Models;

namespace Tech_Store.NewFolder
{
    public class TechStoreContext : DbContext
    {
        public TechStoreContext(DbContextOptions<TechStoreContext> options) : base(options) {}
        public DbSet<Item> Items { get; set; }
    }
}

/*
 Reverse Migration: Scaffold-DbContext "Server=(LocalDB)\\MSSQLLocalDB;Database=TechStore;Trusted_Connection=True;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotation
 */
