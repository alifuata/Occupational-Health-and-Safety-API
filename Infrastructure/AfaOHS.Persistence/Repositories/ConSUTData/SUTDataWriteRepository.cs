using AfaOHS.Application.Repositories.IEntityRepositories.RepSUTData;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConSUTData
{
    public class SUTDataWriteRepository : WriteRepository<SUTData>, ISUTDataWriteRepository
    {
        public SUTDataWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
