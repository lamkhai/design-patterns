using AbstractFactory.Core.Services;
using AbstractFactory.Infratructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactory.Infratructure;

public static class Startup
{
    public static void AddAbstractFactoryServices(this IServiceCollection services)
    {
        services.AddScoped<IAbstractFactoryService, AbstractFactoryService>();
    }
}