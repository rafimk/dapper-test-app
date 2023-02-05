using dapper_test_app.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace dapper_test_app.Controllers;

[Route("api/companies")]
[ApiController]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyRepository _companyRepo;
    public CompaniesController(ICompanyRepository companyRepo)
    {
        _companyRepo = companyRepo;
    }
    [HttpGet]
    public async Task<IActionResult> GetCompanies()
    {
        try
        {
            var companies = await _companyRepo.GetCompanies();
            return Ok(companies);
        }
        catch (Exception ex)
        {
            //log error
            return StatusCode(500, ex.Message);
        }
    }
}