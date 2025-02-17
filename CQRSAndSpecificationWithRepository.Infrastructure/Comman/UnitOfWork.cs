using CQRSAndSpecificationWithRepository.Aplication.Contracts.IUnitOfWork;
using CQRSAndSpecificationWithRepository.Aplication.Contracts.RepositorisEnterfaces;
using CQRSAndSpecificationWithRepository.Infrastructure.DataHelper;

namespace CQRSAndSpecificationWithRepository.Infrastructure.Comman
{
    public class UnitOfWork(ApplicationContext context,
        IEmployeeRepository employeeRepository
        ) : IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; } = employeeRepository;

        public void Dispose() => context.Dispose();

        public async Task<int> SaveChangesAsync() => await context.SaveChangesAsync();



    }
}
