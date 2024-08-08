using Microsoft.JSInterop;
using TheOmenDen.Shared.BrowserDetection.Abstraction;

namespace TheOmenDen.Shared.BrowserDetection.Infrastructure;

/// <inheritdoc />
internal sealed class BrowserDetector : IBrowserDetector
{
    private readonly IJSRuntime _jsRuntime;

    public BrowserDetector(IJSRuntime jsRuntime) => _jsRuntime = jsRuntime;

    /// <inheritdoc />
    public async Task<string> GetBrowserNameAsync(CancellationToken cancellationToken = default) =>
        await _jsRuntime.InvokeAsync<string>("window.browserDetector.getBrowserName", cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<string> GetBrowserVersionAsync(CancellationToken cancellationToken = default) =>
        await _jsRuntime.InvokeAsync<string>("window.browserDetector.getBrowserVersion", cancellationToken).ConfigureAwait(false);
    /// <inheritdoc />
    public async Task<string> GetPlatformAsync(CancellationToken cancellationToken = default) =>
        await _jsRuntime.InvokeAsync<string>("window.browserDetector.getPlatform", cancellationToken).ConfigureAwait(false);
    /// <inheritdoc />
    public async Task<bool> IsTouchDeviceAsync(CancellationToken cancellationToken = default) =>
        await _jsRuntime.InvokeAsync<bool>("window.browserDetector.isTouchDevice", cancellationToken).ConfigureAwait(false);
    /// <inheritdoc />
    public async Task<bool> IsMobileAsync(CancellationToken cancellationToken = default) =>
        await _jsRuntime.InvokeAsync<bool>("window.browserDetector.isMobile", cancellationToken).ConfigureAwait(false);
}