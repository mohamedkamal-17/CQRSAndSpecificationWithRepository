using CQRSAndSpecificationWithRepository.Aplication.specefication;
using CQRSAndSpecificationWithRepository.Domain.Models;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByNameIncludeProjectAndDepartment
{
    public class GetEmployeeByNameIncludeProjectAndDepartmentSpecification : Specification<Employee>
    {
        public GetEmployeeByNameIncludeProjectAndDepartmentSpecification(string name) : base(em => em.Name == name)
        {
            AddIncluds(em => em.Project);
            AddIncluds(em => em.Department);

        }
    }
}
