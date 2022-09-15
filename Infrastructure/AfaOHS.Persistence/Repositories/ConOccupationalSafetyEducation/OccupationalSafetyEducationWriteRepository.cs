using AfaOHS.Application.Repositories.IEntityRepositories.RepOccupationalSafetyEducation;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConOccupationalSafetyEducation
{
    public class OccupationalSafetyEducationWriteRepository : WriteRepository<OccupationalSafetyEducation>, IOccupationalSafetyEducationWriteRepository
    {
        public OccupationalSafetyEducationWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
