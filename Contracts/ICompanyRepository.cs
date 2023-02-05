using dapper_test_app.Entities;

namespace dapper_test_app.Contracts;

public interface ICompanyRepository
{
    public Task<IEnumerable<Company>> GetCompanies();
}