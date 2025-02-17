using CQRSAndSpecificationWithRepository.Aplication.Contracts.IUnitOfWork;
using CQRSAndSpecificationWithRepository.Domain.Models;
using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByIdWithProjects
{
    public class GetEmployeeByIdIncludProjectQueryHandelr(IUnitOfWork unitOfWork) : IRequestHandler<GetEmployeeByIdIncludProjectQuery, Employee>
    {

        async Task<Employee> IRequestHandler<GetEmployeeByIdIncludProjectQuery, Employee>
            .Handle(GetEmployeeByIdIncludProjectQuery request, CancellationToken cancellationToken)
        {
            var emp = await unitOfWork.EmployeeRepository.GetByIdIncludProject(request.Id, cancellationToken);

            return emp;
        }
    }
}
