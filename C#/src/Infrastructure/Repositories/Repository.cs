using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T>(DbContext dbContext) : IRepository<T> where T : class
{
    private readonly DbContext _dbContext = dbContext;
    protected DbSet<T> Entities => _dbContext.Set<T>();
}
