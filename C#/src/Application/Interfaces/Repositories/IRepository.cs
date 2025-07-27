namespace Application.Interfaces.Repository;

public interface IRepository<T> where T : class
{
    Task<T?> GetAsync();
    Task<T> GetAllAsync();
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T?> DeleteAsync (object id);
}
