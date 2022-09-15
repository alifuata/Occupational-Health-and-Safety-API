using AfaOHS.Application.Repositories.IEntityRepositories.RepOccupation;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.RepOccupation
{
    public class OccupationReadRepository : ReadRepository<Occupation>, IOccupationReadRepository
    {
        public OccupationReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
