using System.Linq.Expressions;

namespace ApexCare.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>>? filter = null);
        Task<int> UpdateAsync(T entity);
        Task<int> UpdateAsync(T[] entity);
        Task<bool> CreateAsync(T entity);
        Task<bool> CreateAsync(T[] entities);
        Task<bool> DeleteAsync(T entity);
        Task<bool> DeleteAsync(T[] entity);
        Task SaveAsync();
    }    
}
