using CQRSAndSpecificationWithRepository.Aplication.Contracts.IUnitOfWork;
using CQRSAndSpecificationWithRepository.Domain.Models;
using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Command.AddEmployee
{
    internal class AddEmployeeCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<AddEmployeeCommand, int>
    {
        public async Task<int> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emp = new Employee()
            {
                Name = request.Name,
                DepartmentId = request.DepartmentId,
                Email = request.Email,
            };

            await unitOfWork.EmployeeRepository.AddAsync(emp);
            await unitOfWork.SaveChangesAsync();
            if (emp.Id > 0)
            {
                return emp.Id;
            }
            return emp.Id;
        }
    }
}
