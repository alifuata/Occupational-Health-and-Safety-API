using AfaOHS.Application.Repositories.IEntityRepositories.RepNaceCode;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConNaceCode
{
    public class NaceCodeReadRepository : ReadRepository<NaceCode>, INaceCodeReadRepository
    {
        public NaceCodeReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
