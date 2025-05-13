namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            // Register your API services here
            // For example, if you have controllers or other services, register them here
            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app) 
        {
        
            return app;
        }
    }
}
