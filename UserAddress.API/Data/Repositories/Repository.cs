using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UserAddress.API.Data.Infrastructure;

namespace UserAddress.API.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T :  class
    {
        private ApplicationDbContext _context;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Remove(entity);
        }

        public async Task<T> Get(Guid id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public IEnumerable<T> GetAll(string[] includes)
        {
            foreach (string include in includes)
            {
                entities.Include(include);
            }
            return entities;
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entities.Add(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<IEnumerable<T>> SearchBy(Expression<Func<T, bool>> predicate, string[]? includes = default)
        {
            if (includes != null)
            {
                foreach (string include in includes)
                {
                    entities.Include(include);
                }
            }

            return await entities.Where(predicate).ToListAsync(); 
        }
    }
}