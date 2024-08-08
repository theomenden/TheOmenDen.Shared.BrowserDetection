using System.Runtime.Versioning;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using TheOmenDen.Shared.BrowserDetection.Abstraction;
using TheOmenDen.Shared.BrowserDetection.Infrastructure;

namespace TheOmenDen.Shared.BrowserDetection.DependencyInjection;
/// <summary>
/// Extension methods for registering browser detector services.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds the asynchronous browser detector service to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddAsyncBrowserDetector(this IServiceCollection services)
    {
        services.AddScoped<IBrowserDetector>(serviceProvider =>
        {
            var jsRuntime = serviceProvider.GetRequiredService<IJSRuntime>();
            return new BrowserDetector(jsRuntime);
        });
        return services;
    }

    /// <summary>
    /// Adds the synchronous browser detector service to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The updated service collection.</returns>
    [SupportedOSPlatform("browser")]
    public static IServiceCollection AddSyncBrowserDetector(this IServiceCollection services)
    {
        services.AddScoped<ISyncBrowserDetector>(serviceProvider =>
        {
            var jsRuntime = serviceProvider.GetRequiredService<IJSRuntime>();
            return new SynchronousBrowserDetector();
        });
        return services;
    }
}