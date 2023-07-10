using Microsoft.Extensions.DependencyInjection;
using Prototype.Core.Services;
using Prototype.Infrastructure.Services;

namespace Prototype.Infrastructure;

public static class Startup
{
    public static void AddPrototypeServices(this IServiceCollection services)
    {
        services.AddScoped<IPrototypeService, PrototypeService>();
    }
}