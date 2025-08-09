using System.Linq.Expressions;

namespace Application.Interfaces.Repository;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync (int id);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
}
