﻿using AfaOHS.Application.Repositories.IEntityRepositories.RepBill;
using AfaOHS.Domain.Entities;
using AfaOHS.Persistence.Contexts;
using AfaOHS.Persistence.Repositories;

namespace AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConBill
{
    public class BillReadRepository : ReadRepository<Bill>, IBillReadRepository
    {
        public BillReadRepository(AfaOHSAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
