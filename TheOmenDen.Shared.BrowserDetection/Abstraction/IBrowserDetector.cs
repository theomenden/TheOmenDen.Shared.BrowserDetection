namespace TheOmenDen.Shared.BrowserDetection.Abstraction;
/// <summary>
/// Defines asynchronous methods for detecting browser properties.
/// </summary>
public interface IBrowserDetector
{
    /// <summary>
    /// Gets the name of the browser asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous operation. The task result contains the browser name.</returns>
    Task<string> GetBrowserNameAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Gets the version of the browser asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous operation. The task result contains the browser version.</returns>
    Task<string> GetBrowserVersionAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Gets the platform of the device asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous operation. The task result contains the platform of the device.</returns>
    Task<string> GetPlatformAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Determines whether the device is a touch device asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous operation. The task result contains a <see cref="bool"/> indicating if the device is a touch device.</returns>
    Task<bool> IsTouchDeviceAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Determines whether the browser is running on a mobile device asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="Task"/> that represents the asynchronous operation. The task result contains a <see cref="bool"/> indicating if the browser is running on a mobile device.</returns>
    Task<bool> IsMobileAsync(CancellationToken cancellationToken = default);
}