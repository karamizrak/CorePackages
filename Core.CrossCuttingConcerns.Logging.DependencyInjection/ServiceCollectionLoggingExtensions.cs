using Microsoft.Extensions.DependencyInjection;
using MinistryOfHealth.Core.CrossCuttingConcerns.Logging.Abstraction;

namespace MinistryOfHealth.Core.CrossCuttingConcerns.Logging.DependencyInjection;

public static class ServiceCollectionLoggingExtensions
{
    public static IServiceCollection AddLogging(this IServiceCollection services, ILogger logger)
    {
        services.AddSingleton(logger);

        return services;
    }
}
