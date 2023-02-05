using Dapper;
using dapper_test_app.Context;
using dapper_test_app.Contracts;
using dapper_test_app.Entities;

namespace dapper_test_app.Repository;

public class CompanyRepository: ICompanyRepository
{
    private readonly DapperContext _context;
    public CompanyRepository(DapperContext context) => _context = context;
    
    public async Task<IEnumerable<Company>> GetCompanies()
    {
        var query = "SELECT * FROM Companies";
        using var connection = _context.CreateConnection();
        var companies = await connection.QueryAsync<Company>(query);
        return companies.ToList();
    }
}