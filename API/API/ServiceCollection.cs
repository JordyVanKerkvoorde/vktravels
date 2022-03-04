namespace API.API;

public static class ServiceCollection
{
    /*
     * Whithin this class all services are registered via extension methods to the webAPI service.
     * To keep it organized, multiple serviceCollection methods can be created to keep things clean and readable.
     */
    public static void ConfigureSwaggerServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
    
    public static void ConfigureDependencyInjection(this IServiceCollection services)
    {
        // Add DI via the AddScoped methods
    }
}