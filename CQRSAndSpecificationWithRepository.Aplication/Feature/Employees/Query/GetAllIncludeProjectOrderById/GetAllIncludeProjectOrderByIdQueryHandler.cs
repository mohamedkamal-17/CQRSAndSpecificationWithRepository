using CQRSAndSpecificationWithRepository.Aplication.Contracts.IUnitOfWork;
using CQRSAndSpecificationWithRepository.Domain.Models;
using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetAllIncludeProjectOrderById
{
    internal class GetAllIncludeProjectOrderByIdQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllIncludeProjectOrderByIdQuery, IReadOnlyCollection<Employee>>
    {
        public async Task<IReadOnlyCollection<Employee>> Handle(GetAllIncludeProjectOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.EmployeeRepository.GetAllIncludProjectsOrderById(cancellationToken);
        }
    }
}
