using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ApexCare.Repositories{
public class Repository<T>: IRepository<T> where T : class
    {
        internal DbContext context;
        internal DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public Task<bool> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(T[] entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T[] entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(T[] entity)
        {
            throw new NotImplementedException();
        }
    }
}
