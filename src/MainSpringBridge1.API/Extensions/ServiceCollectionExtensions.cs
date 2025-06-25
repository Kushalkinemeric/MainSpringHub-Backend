using MainSpringBridge1.Application.Interfaces;
using MainSpringBridge1.Infrastructure.Database;
using MainSpringBridge1.Infrastructure.Repositories;

namespace MainSpringBridge1.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectServices(this IServiceCollection services)
    {
        services.AddSingleton<DbConnectionFactory>();
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}
