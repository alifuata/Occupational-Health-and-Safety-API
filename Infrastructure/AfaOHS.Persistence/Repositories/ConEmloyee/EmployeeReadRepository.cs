using AfaOHS.Application.Repositories.IEntityRepositories.RepEmloyee;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmloyee
{
    public class EmployeeReadRepository : ReadRepository<Employee>, IEmployeeReadRepository
    {
        public EmployeeReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
