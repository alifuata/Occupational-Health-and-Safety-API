using AfaOHS.Application.Repositories.IEntityRepositories.RepBill;
using AfaOHS.Application.Repositories.IEntityRepositories.RepCompany;
using AfaOHS.Application.Repositories.IEntityRepositories.RepContactEmployee;
using AfaOHS.Application.Repositories.IEntityRepositories.RepDangerLevel;
using AfaOHS.Application.Repositories.IEntityRepositories.RepEducation;
using AfaOHS.Application.Repositories.IEntityRepositories.RepEmloyee;
using AfaOHS.Application.Repositories.IEntityRepositories.RepEmployeeCompany;
using AfaOHS.Application.Repositories.IEntityRepositories.RepEmployeeOSE;
using AfaOHS.Application.Repositories.IEntityRepositories.RepHealthObservation;
using AfaOHS.Application.Repositories.IEntityRepositories.RepNaceCode;
using AfaOHS.Application.Repositories.IEntityRepositories.RepOccupation;
using AfaOHS.Application.Repositories.IEntityRepositories.RepOccupationalSafetyEducation;
using AfaOHS.Application.Repositories.IEntityRepositories.RepOHSEmployee;
using AfaOHS.Application.Repositories.IEntityRepositories.RepRiskAnalysis;
using AfaOHS.Application.Repositories.IEntityRepositories.RepSUTData;
using AfaOHS.Application.Repositories.IEntityRepositories.RepUserRole;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConBill;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConCompany;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConContactEmployee;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConDangerLevel;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEducation;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmloyee;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmployeeCompany;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConEmployeeOSE;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConHealthObservation;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConNaceCode;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConOccupation;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConOccupationalSafetyEducation;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConOHSEmployee;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConpUserRole;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConRiskAnalysis;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.ConSUTData;
using AfaOHS.Infrastructure.AfaOHS.Persistence.Repositories.RepOccupation;
using AfaOHS.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AfaOHS.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {      
            //services.AddDbContext<AfaOHSAPIDbContext>(options => options.UseSqlServer(GetConnectionStringFromAppSettings("Mssql")));
            services.AddDbContext<AfaOHSAPIDbContext>(options => options.UseNpgsql(GetConnectionStringFromAppSettings("Postgresql")));
            services.AddScoped<IBillReadRepository, BillReadRepository>();
            services.AddScoped<IBillWriteRepository, BillWriteRepository>();
            services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();
            services.AddScoped<IContactEmployeeReadRepository, ContactEmployeeReadRepository>();
            services.AddScoped<IContactEmployeeWriteRepository, ContactEmployeeWriteRepository>();
            services.AddScoped<IDangerLevelReadRepository, DangerLevelReadRepository>();
            services.AddScoped<IDangerLevelWriteRepository, DangerLevelWriteRepository>();
            services.AddScoped<IEducationReadRepository, EducationReadRepository>();
            services.AddScoped<IEducationWriteRepository, EducationWriteRepository>();
            services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
            services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();
            services.AddScoped<IEmployeeCompanyReadRepository, EmployeeCompanyReadRepository>();
            services.AddScoped<IEmployeeCompanyWriteRepository, EmployeeCompanyWriteRepository>();
            services.AddScoped<IEmployeeOSEReadRepository, EmployeeOSEReadRepository>();
            services.AddScoped<IEmployeeOSEWriteRepository, EmployeeOSEWriteRepository>();
            services.AddScoped<IHealthObservationReadRepository, HealthObservationReadRepository>();
            services.AddScoped<IHealthObservationWriteRepository, HealthObservationWriteRepository>();
            services.AddScoped<INaceCodeReadRepository, NaceCodeReadRepository>();
            services.AddScoped<INaceCodeWriteRepository, NaceCodeWriteRepository>();
            services.AddScoped<IOccupationReadRepository, OccupationReadRepository>();
            services.AddScoped<IOccupationWriteRepository, OccupationWriteRepository>();
            services.AddScoped<IOccupationalSafetyEducationReadRepository, OccupationalSafetyEducationReadRepository>();
            services.AddScoped<IOccupationalSafetyEducationWriteRepository, OccupationalSafetyEducationWriteRepository>();
            services.AddScoped<IOHSEmployeeReadRepository, OHSEmployeeReadRepository>();
            services.AddScoped<IOHSEmployeeWriteRepository, OHSEmployeeWriteRepository>();
            services.AddScoped<IUserRoleReadRepository, UserRoleReadRepository>();
            services.AddScoped<IUserRoleWriteRepository, UserRoleWriteRepository>();
            services.AddScoped<IRiskAnalysisReadRepository, RiskAnalysisReadRepository>();
            services.AddScoped<IRiskAnalysisWriteRepository, RiskAnalysisWriteRepository>();
            services.AddScoped<ISUTDataReadRepository, SUTDataReadRepository>();
            services.AddScoped<ISUTDataWriteRepository, SUTDataWriteRepository>();

            
        }
        public static string GetConnectionStringFromAppSettings(string key)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/AfaOHS.Api"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString(key);
        }
    }
}
