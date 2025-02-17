using CQRSAndSpecificationWithRepository.Aplication.specefication;
using CQRSAndSpecificationWithRepository.Domain.Models;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByIdWithProjects
{
    public class GetEmployeeByIdIncludProjectSpecification : Specification<Employee>
    {
        public GetEmployeeByIdIncludProjectSpecification(int id) : base(em => em.Id == id)
        {
            AddIncluds(em => em.Department);

        }

    }
}
