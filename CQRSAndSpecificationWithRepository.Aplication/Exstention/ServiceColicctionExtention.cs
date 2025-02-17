using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CQRSAndSpecificationWithRepository.Aplication.Exstention
{
    public static class ServiceColicctionExtention
    {
        public static void AddApplicationExtention(this IServiceCollection services)
        {
            services.AddMediatR(con => con.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
