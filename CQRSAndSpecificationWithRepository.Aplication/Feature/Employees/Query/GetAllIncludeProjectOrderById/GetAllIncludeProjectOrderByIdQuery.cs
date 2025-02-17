using CQRSAndSpecificationWithRepository.Domain.Models;
using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetAllIncludeProjectOrderById
{
    public class GetAllIncludeProjectOrderByIdQuery : IRequest<IReadOnlyCollection<Employee>>
    {
    }
}
