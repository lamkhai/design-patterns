using Builder.Core.Services;
using Builder.Infratructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Builder.Infratructure;

public static class Startup
{
    public static void AddBuilderServices(this IServiceCollection services)
    {
        services.AddScoped<IBuilderService, BuilderService>();
    }
}