using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using TheOmenDen.Shared.BrowserDetection.Abstraction;

namespace TheOmenDen.Shared.BrowserDetection.Infrastructure;

/// <inheritdoc />
[SupportedOSPlatform("browser")]
internal partial class SynchronousBrowserDetector : ISyncBrowserDetector
{
    [JSImport("window.browserDetector.getBrowserName", "browserDetector.js")]
    private static partial string DetectBrowserName();

    [JSImport("window.browserDetector.getBrowserVersion", "browserDetector.js")]
    private static partial string DetectBrowserVersion();

    [JSImport("window.browserDetector.getPlatform", "browserDetector.js")]
    private static partial string DetectPlatform();

    [JSImport("window.browserDetector.isTouchDevice", "browserDetector.js")]
    private static partial bool DetectIsTouchDevice();

    [JSImport("window.browserDetector.isMobile", "browserDetector.js")]
    private static partial bool DetectIsMobile();

    [JSImport("window.browserDetector.hasWebGL", "browserDetector.js")]
    private static partial bool DetectHasWebGL();

    [JSImport("window.browserDetector.hasServiceWorker", "browserDetector.js")]
    private static partial bool DetectHasServiceWorker();

    [JSImport("window.browserDetector.supportsLocalStorage", "browserDetector.js")]
    private static partial bool DetectSupportsLocalStorage();

    [JSImport("window.browserDetector.supportsSessionStorage", "browserDetector.js")]
    private static partial bool DetectSupportsSessionStorage();

    /// <inheritdoc />
    public string GetBrowserName() => DetectBrowserName();
    /// <inheritdoc />
    public string GetBrowserVersion() => DetectBrowserVersion();
    /// <inheritdoc />
    public string GetPlatform() => DetectPlatform();
    /// <inheritdoc />
    public bool IsTouchDevice() => DetectIsTouchDevice();
    /// <inheritdoc />
    public bool IsMobile() => DetectIsMobile();

    /// <inheritdoc />
    public bool HasWebGL() => DetectHasWebGL();

    /// <inheritdoc />
    public bool HasServiceWorker() => DetectHasServiceWorker();

    /// <inheritdoc />
    public bool SupportsLocalStorage() => DetectSupportsLocalStorage();

    /// <inheritdoc />
    public bool SupportsSessionStorage() => DetectSupportsSessionStorage();
}