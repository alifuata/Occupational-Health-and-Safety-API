using AfaOHS.Application.Repositories.IEntityRepositories.RepEducation;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEducation
{
    public class EducationReadRepository : ReadRepository<Education>, IEducationReadRepository
    {
        public EducationReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
