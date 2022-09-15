using AfaOHS.Application.Repositories.IEntityRepositories.RepUserRole;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConpUserRole
{
    public class UserRoleReadRepository : ReadRepository<UserRole>, IUserRoleReadRepository
    {
        public UserRoleReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
