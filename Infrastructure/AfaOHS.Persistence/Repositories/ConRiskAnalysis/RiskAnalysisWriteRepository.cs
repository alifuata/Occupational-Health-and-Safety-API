using AfaOHS.Application.Repositories.IEntityRepositories.RepRiskAnalysis;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConRiskAnalysis
{
    public class RiskAnalysisWriteRepository : WriteRepository<RiskAnalysis>, IRiskAnalysisWriteRepository
    {
        public RiskAnalysisWriteRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
