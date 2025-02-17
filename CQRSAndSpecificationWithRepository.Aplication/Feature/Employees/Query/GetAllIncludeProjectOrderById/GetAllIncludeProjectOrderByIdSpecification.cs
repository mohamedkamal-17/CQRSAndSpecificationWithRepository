using CQRSAndSpecificationWithRepository.Aplication.specefication;
using CQRSAndSpecificationWithRepository.Domain.Models;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetAllIncludeProjectOrderById
{
    public class GetAllIncludeProjectOrderByIdSpecification : Specification<Employee>
    {
        public GetAllIncludeProjectOrderByIdSpecification()
        {
            AddIncluds(em => em.Project);

            AddOrderBy(em => em.Id);
        }
    }
}
