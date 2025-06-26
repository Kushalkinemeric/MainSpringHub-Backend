using MainSpringBridge.Application.Interfaces;
using MainSpringBridge.Infrastructure.Database;
using MainSpringBridge.Infrastructure.Repositories;

namespace MainSpringBridge.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectServices(this IServiceCollection services)
    {
        services.AddSingleton<DbConnectionFactory>();
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}
