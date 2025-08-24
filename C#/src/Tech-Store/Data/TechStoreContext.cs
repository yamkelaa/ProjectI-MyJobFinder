using Microsoft.EntityFrameworkCore;
using Tech_Store.Models;

namespace Tech_Store.Data;

public partial class TechStoreContext : DbContext
{
    public TechStoreContext(DbContextOptions<TechStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<User> Users { get; set; }
}
