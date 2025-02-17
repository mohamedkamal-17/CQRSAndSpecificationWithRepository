namespace CQRSAndSpecificationWithRepository.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }

}
