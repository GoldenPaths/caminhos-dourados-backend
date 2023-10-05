namespace GoldenPaths.Domain.Interfaces.Repositories
{
    public interface IBasicRepository<T, TKey> 
        where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(TKey id);
    }
}
