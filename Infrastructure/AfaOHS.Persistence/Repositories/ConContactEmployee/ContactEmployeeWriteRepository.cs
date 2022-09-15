using AfaOHS.Application.Repositories.IEntityRepositories.RepContactEmployee;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConContactEmployee
{
    public class ContactEmployeeWriteRepository : WriteRepository<ContactEmployee>, IContactEmployeeWriteRepository
    {
        public ContactEmployeeWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
