using CQRSAndSpecificationWithRepository.Domain.Models;
using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByIdWithProjects
{
    public class GetEmployeeByIdIncludProjectQuery : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
