using AfaOHS.Application.Repositories;
using AfaOHS.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AfaOHS.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly AfaOHSAPIDbContext _dbContext;

        public ReadRepository(AfaOHSAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public IQueryable<T> GetAll() => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(object id) =>
            //throw new NotImplementedException();
            await Table.FindAsync(id);
        //43:00 5. videı



    }
}
