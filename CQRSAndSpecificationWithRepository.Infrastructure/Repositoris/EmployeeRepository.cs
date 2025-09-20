using CQRSAndSpecificationWithRepository.Aplication.Contracts.RepositorisEnterfaces;
using CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetAllIncludeProjectOrderById;
using CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByIdWithProjects;
using CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByNameIncludeProjectAndDepartment;
using CQRSAndSpecificationWithRepository.Domain.Models;
using CQRSAndSpecificationWithRepository.Infrastructure.DataHelper;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndSpecificationWithRepository.Infrastructure.Repositoris
{
    public class EmployeeRepository(ApplicationContext context) : GenericRepository<Employee>(context), IEmployeeRepository
    {
        DbSet<Employee> employeeSet = context.Set<Employee>();

        public async Task<IReadOnlyCollection<Employee>> GetAllIncludProjectsOrderById(CancellationToken cancellationToken)
        {
            return await ApllaySpeceification(employeeSet, new GetAllIncludeProjectOrderByIdSpecification()).ToListAsync(cancellationToken);
        }

        public async Task<Employee?> GetByIdIncludProject(int id, CancellationToken cancellationToken)
        {
            return await ApllaySpeceification(employeeSet, new GetEmployeeByIdIncludProjectSpecification(id))
                .FirstOrDefaultAsync(cancellationToken);
        }



        public async Task<Employee?> GetByNameIncludProjectandDpartment(string name, CancellationToken cancellationToken)
        {
            return await ApllaySpeceification(employeeSet, new GetEmployeeByNameIncludeProjectAndDepartmentSpecification(name))
                .FirstOrDefaultAsync(cancellationToken);

        }


    }



}
