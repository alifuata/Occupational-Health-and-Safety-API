using AfaOHS.Application.Repositories.IEntityRepositories.RepDangerLevel;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConDangerLevel
{
    public class DangerLevelWriteRepository : WriteRepository<DangerLevel>, IDangerLevelWriteRepository
    {
        public DangerLevelWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
