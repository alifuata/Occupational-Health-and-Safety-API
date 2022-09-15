using AfaOHS.Application.Repositories.IEntityRepositories.RepContactEmployee;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConContactEmployee
{
    public class ContactEmployeeReadRepository : ReadRepository<ContactEmployee>, IContactEmployeeReadRepository
    {
        public ContactEmployeeReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
