using Microsoft.Extensions.DependencyInjection;
using North.Identity.Core.Factory;

namespace North.Identity.Core;

public static class CoreConfiguration
{
    public static IServiceCollection AddCoreConfigurations(this IServiceCollection services)
    {
        services.AddSingleton<IUserFactory, UserFactory>();
        return services;
    }
}
