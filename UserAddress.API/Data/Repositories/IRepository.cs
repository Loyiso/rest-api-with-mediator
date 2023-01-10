using System.Linq.Expressions;

namespace UserAddress.API.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        void Insert(T entity);
        void Delete(T entity);
        Task<bool> SaveChangesAsync();
        Task<IEnumerable<T>> SearchBy(Expression<Func<T, bool>> predicate, string[]? includes = default);
        IEnumerable<T> GetAll(string[] includes);
    }
}