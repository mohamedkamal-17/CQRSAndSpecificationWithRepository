using CQRSAndSpecificationWithRepository.Domain.Models;
using CQRSAndSpecificationWithRepository.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndSpecificationWithRepository.Infrastructure.DataHelper
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            // Call Seed Data
            modelBuilder.Seed();
        }
    }
}
