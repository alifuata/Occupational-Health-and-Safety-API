using AfaOHS.Application.Repositories.IEntityRepositories.RepCompany;
using Microsoft.AspNetCore.Mvc;

namespace AfaOHS.Api.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        readonly private ICompanyWriteRepository _companyWriteRepository;
        readonly private ICompanyReadRepository _companyReadRepository;

        public CompanyController(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository)
        {
            _companyWriteRepository = companyWriteRepository;
            _companyReadRepository = companyReadRepository;
        }
        [HttpGet("GetCompany")]
        public async Task<IActionResult> Index()
        {
            await _companyWriteRepository.AddRangeAsync(new()
            {
                new Domain.Entities.Company(){Address="ankara",CompanyID="E001",ContractDate=new DateTime(2020,01,01),ContractNumber="1",Email="a@a.com",}
            });
            return Ok();
        }
    }
}
