using AfaOHS.Application.Repositories.IEntityRepositories.RepOHSEmployee;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConOHSEmployee
{
    public class OHSEmployeeWriteRepository : WriteRepository<OHSEmployee>, IOHSEmployeeWriteRepository
    {
        public OHSEmployeeWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
