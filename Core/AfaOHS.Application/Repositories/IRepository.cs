using Microsoft.EntityFrameworkCore;

namespace AfaOHS.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}
