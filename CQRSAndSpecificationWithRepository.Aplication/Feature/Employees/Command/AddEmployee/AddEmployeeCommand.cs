using MediatR;

namespace CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Command.AddEmployee
{
    public class AddEmployeeCommand : IRequest<int>
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public int? ProjectId { get; set; }



    }
}
