using Deploye.Domain.Abstractions;

namespace Deploye.Web.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddModule(this IServiceCollection services, IModule module)
    {
        if (services is null) throw new ArgumentNullException(nameof(services));
        if (module is null) throw new ArgumentNullException(nameof(module));

        module.Load(services);
        return services;
    }
}
