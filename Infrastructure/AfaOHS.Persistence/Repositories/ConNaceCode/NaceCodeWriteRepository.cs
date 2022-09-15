using AfaOHS.Application.Repositories.IEntityRepositories.RepNaceCode;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConNaceCode
{
    public class NaceCodeWriteRepository : WriteRepository<NaceCode>, INaceCodeWriteRepository
    {
        public NaceCodeWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
