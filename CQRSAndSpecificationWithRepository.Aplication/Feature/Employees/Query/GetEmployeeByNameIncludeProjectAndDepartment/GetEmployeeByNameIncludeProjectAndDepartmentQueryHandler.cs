using CQRSAndSpecificationWithRepository.Aplication.Contracts.IUnitOfWork;
using CQRSAndSpecificationWithRepository.Domain.Models;
using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByNameIncludeProjectAndDepartment
{
    internal class GetEmployeeByNameIncludeProjectAndDepartmentQueryHandler(IUnitOfWork unitOfWork) :
               IRequestHandler<GetEmployeeByNameIncludeProjectAndDepartmentQuery, Employee>
    {
        public async Task<Employee> Handle(GetEmployeeByNameIncludeProjectAndDepartmentQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.EmployeeRepository.GetByNameIncludProjectandDpartment(request.Name, cancellationToken).ConfigureAwait(false);
        }
    }
}
