using AfaOHS.Application.Repositories.IEntityRepositories.RepOccupation;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConOccupation
{
    public class OccupationWriteRepository : WriteRepository<Occupation>, IOccupationWriteRepository
    {
        public OccupationWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
