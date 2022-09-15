
using AfaOHS.Application.Repositories.IEntityRepositories.RepEmployeeCompany;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmployeeCompany
{
    public class EmployeeCompanyReadRepository : ReadRepository<EmployeeCompany>, IEmployeeCompanyReadRepository
    {
        public EmployeeCompanyReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
