using CQRSAndSpecificationWithRepository.Domain.Models;

namespace CQRSAndSpecificationWithRepository.Aplication.Contracts.RepositorisEnterfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<Employee> GetByIdIncludProject(int id, CancellationToken cancellationToken);
        Task<Employee> GetByNameIncludProjectandDpartment(string name, CancellationToken cancellation);
        Task<IReadOnlyCollection<Employee>> GetAllIncludProjectsOrderById(CancellationToken cancellationToken);


    }
}
