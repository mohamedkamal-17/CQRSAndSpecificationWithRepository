using CQRSAndSpecificationWithRepository.Domain.Models;
using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByNameIncludeProjectAndDepartment
{
    public class GetEmployeeByNameIncludeProjectAndDepartmentQuery : IRequest<Employee>
    {
        public string Name { get; set; }
    }
}
