using AfaOHS.Application.Repositories.IEntityRepositories.RepEmployeeCompany;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmployeeCompany
{
    public class EmployeeCompanyWriteRepository : WriteRepository<EmployeeCompany>, IEmployeeCompanyWriteRepository
    {
        public EmployeeCompanyWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
