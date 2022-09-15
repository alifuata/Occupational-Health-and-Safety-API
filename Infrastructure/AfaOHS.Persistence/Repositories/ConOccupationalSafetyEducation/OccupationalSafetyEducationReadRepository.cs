using AfaOHS.Application.Repositories.IEntityRepositories.RepOccupationalSafetyEducation;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConOccupationalSafetyEducation
{
    public class OccupationalSafetyEducationReadRepository : ReadRepository<OccupationalSafetyEducation>, IOccupationalSafetyEducationReadRepository
    {
        public OccupationalSafetyEducationReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
