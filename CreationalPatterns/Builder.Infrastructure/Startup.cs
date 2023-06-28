using Builder.Core.Services;
using Builder.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Builder.Infrastructure;

public static class Startup
{
    public static void AddBuilderServices(this IServiceCollection services)
    {
        services.AddScoped<IBuilderService, BuilderService>();
    }
}