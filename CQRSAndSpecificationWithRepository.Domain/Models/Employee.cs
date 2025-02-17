namespace CQRSAndSpecificationWithRepository.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public int? ProjectId { get; set; }


        // Navigation properties

        public Department Department { get; set; }

        public Project Project { get; set; }
    }

}
