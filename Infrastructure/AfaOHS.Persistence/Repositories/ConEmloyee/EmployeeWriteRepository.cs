using AfaOHS.Application.Repositories.IEntityRepositories.RepEmloyee;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmloyee
{
    public class EmployeeWriteRepository : WriteRepository<Employee>, IEmployeeWriteRepository
    {
        public EmployeeWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
