using AfaOHS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfaOHS.Persistence.Contexts
{
    public class AfaOHSAPIDbContext : DbContext
    {
        public AfaOHSAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EmployeeCompany>().HasNoKey();
        //    modelBuilder.Entity<EmployeeOSE>().HasNoKey();

        //}
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ContactEmployee> contactEmployees { get; set; }
        public DbSet<DangerLevel> DangerLevels { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EmployeeCompany> EmployeeCompanies { get; set; }
        public DbSet<EmployeeOSE> EmployeeOSEs { get; set; }
        public DbSet<HealthObservation> HealthObservations { get; set; }
        public DbSet<NaceCode> NaceCodes { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<OccupationalSafetyEducation> OccupationalSafetyEducations { get; set; }
        public DbSet<OHSEmployee> OHSEmployees { get; set; }
        public DbSet<RiskAnalysis> RiskAnalyses { get; set; }
        public DbSet<SUTData> SUTDatas { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        //1:19:00 test kısmında
    }
}
