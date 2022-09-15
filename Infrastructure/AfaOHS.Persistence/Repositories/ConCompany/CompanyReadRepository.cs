using AfaOHS.Application.Repositories.IEntityRepositories.RepCompany;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConCompany
{
    public class CompanyReadRepository : ReadRepository<Company>, ICompanyReadRepository
    {
        public CompanyReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
