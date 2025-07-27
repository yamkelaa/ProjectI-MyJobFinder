using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T>(DbContext dbContext) : IRepository<T> where T : class
{
    private readonly DbContext _dbContext = dbContext;
    protected DbSet<T> Entities => _dbContext.Set<T>();

    public Task<T> CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T?> DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
