using AfaOHS.Application.Repositories.IEntityRepositories.RepSUTData;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConSUTData
{
    public class SUTDataReadRepository : ReadRepository<SUTData>, ISUTDataReadRepository
    {
        public SUTDataReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
