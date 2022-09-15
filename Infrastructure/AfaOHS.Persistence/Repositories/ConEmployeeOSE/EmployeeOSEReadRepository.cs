using AfaOHS.Application.Repositories.IEntityRepositories.RepEmployeeOSE;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmployeeOSE
{
    public class EmployeeOSEReadRepository : ReadRepository<EmployeeOSE>, IEmployeeOSEReadRepository
    {
        public EmployeeOSEReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
