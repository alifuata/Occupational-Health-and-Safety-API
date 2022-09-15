using AfaOHS.Application.Repositories.IEntityRepositories.RepEmployeeOSE;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmployeeOSE
{
    public class EmployeeOSEWriteRepository : WriteRepository<EmployeeOSE>, IEmployeeOSEWriteRepository
    {
        public EmployeeOSEWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
