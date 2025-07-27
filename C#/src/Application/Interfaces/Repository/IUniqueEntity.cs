namespace Application.Interfaces.Repository;

public interface IUniqueEntity<TKey> where TKey : IUniqueEntity<TKey>
{
    public TKey Id { get; set; }
}
