using CQRSAndSpecificationWithRepository.Aplication.Contracts.IUnitOfWork;
using CQRSAndSpecificationWithRepository.Aplication.Contracts.RepositorisEnterfaces;
using CQRSAndSpecificationWithRepository.Infrastructure.Comman;
using CQRSAndSpecificationWithRepository.Infrastructure.DataHelper;
using CQRSAndSpecificationWithRepository.Infrastructure.Repositoris;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSAndSpecificationWithRepository.Infrastructure.Extensions
{
    static public class CoolectionServicesExtention
    {
        static public IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationContext>(op => op.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;

        }
    }
}
