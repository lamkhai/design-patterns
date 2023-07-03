using FactoryMethod.Core.Services;
using FactoryMethod.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod.Infrastructure;

public static class Startup
{
    public static void AddFactoryMethodServices(this IServiceCollection services)
    {
        services.AddScoped<IFactoryMethodService, FactoryMethodService>();
    }
}