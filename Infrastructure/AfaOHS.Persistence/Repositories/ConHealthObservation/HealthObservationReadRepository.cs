using AfaOHS.Application.Repositories.IEntityRepositories.RepHealthObservation;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConHealthObservation
{
    public class HealthObservationReadRepository : ReadRepository<HealthObservation>, IHealthObservationReadRepository
    {
        public HealthObservationReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
