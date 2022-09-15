using AfaOHS.Application.Repositories.IEntityRepositories.RepDangerLevel;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConDangerLevel
{
    public class DangerLevelReadRepository : ReadRepository<DangerLevel>, IDangerLevelReadRepository
    {
        public DangerLevelReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
