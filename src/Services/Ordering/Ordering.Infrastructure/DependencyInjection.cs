
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register your infrastructure services here
            // For example, if you have a DbContext or other services, register them here

            var connectionString = configuration.GetConnectionString("Database");
            return services;
        }
    }
}
