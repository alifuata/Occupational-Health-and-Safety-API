namespace AfaOHS.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Delete(T entity);
        bool Update(T entity);
        Task<int> SaveAsync();
    }
}
