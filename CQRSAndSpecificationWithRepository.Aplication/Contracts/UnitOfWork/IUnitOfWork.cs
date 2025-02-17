using CQRSAndSpecificationWithRepository.Aplication.Contracts.RepositorisEnterfaces;

namespace CQRSAndSpecificationWithRepository.Aplication.Contracts.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }

        Task<int> SaveChangesAsync();
    }

}
