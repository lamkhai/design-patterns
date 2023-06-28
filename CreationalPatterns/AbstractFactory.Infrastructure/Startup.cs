using AbstractFactory.Core.Services;
using AbstractFactory.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactory.Infrastructure;

public static class Startup
{
    public static void AddAbstractFactoryServices(this IServiceCollection services)
    {
        services.AddScoped<IAbstractFactoryService, AbstractFactoryService>();
    }
}