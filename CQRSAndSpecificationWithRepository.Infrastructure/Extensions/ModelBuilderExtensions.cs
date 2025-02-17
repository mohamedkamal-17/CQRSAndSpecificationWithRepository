using CQRSAndSpecificationWithRepository.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndSpecificationWithRepository.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seed Projects
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "ERP System" },
                new Project { Id = 2, Name = "HR Management" },
                new Project { Id = 3, Name = "E-Commerce Platform" },
                new Project { Id = 4, Name = "Financial Forecasting Tool" },
                new Project { Id = 5, Name = "Marketing Campaign Automation" }
            );

            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Finance" },
                new Department { Id = 4, Name = "Marketing" }
            );

            // Seed Employees (Reference Foreign Keys Properly)
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Mohamed Kamal", Email = "mohamed@example.com", DepartmentId = 1, ProjectId = 1 },
                new Employee { Id = 2, Name = "Ahmed Ali", Email = "ahmed@example.com", DepartmentId = 2, ProjectId = 2 },
                new Employee { Id = 3, Name = "Sara Ibrahim", Email = "sara@example.com", DepartmentId = 3, ProjectId = 4 },
                new Employee { Id = 4, Name = "Omar Hassan", Email = "omar@example.com", DepartmentId = 1, ProjectId = 1 },
                new Employee { Id = 5, Name = "Fatima Adel", Email = "fatima@example.com", DepartmentId = 4, ProjectId = 2 },
                new Employee { Id = 6, Name = "Kareem Saad", Email = "kareem@example.com", DepartmentId = 2, ProjectId = 3 },
                new Employee { Id = 7, Name = "Laila Noor", Email = "laila@example.com", DepartmentId = 3, ProjectId = 3 },
                new Employee { Id = 8, Name = "Ayman Reda", Email = "ayman@example.com", DepartmentId = 1, ProjectId = null } // No project assigned
            );
        }
    }

}
