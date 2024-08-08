using System.Runtime.Versioning;

namespace TheOmenDen.Shared.BrowserDetection.Abstraction;

/// <summary>
/// Defines synchronous methods for detecting browser properties.
/// </summary>
/// <remarks>Will only work with WebAssembly/ Strictly client sided</remarks>
[SupportedOSPlatform("browser")]
public interface ISyncBrowserDetector
{
    /// <summary>
    /// Gets the name of the browser.
    /// </summary>
    /// <returns>The name of the browser being used</returns>
    string GetBrowserName();
    /// <summary>
    /// Gets the version of the browser.
    /// </summary>
    /// <returns>The version of the browser that is being used</returns>
    string GetBrowserVersion();
    /// <summary>
    /// Gets the platform of the device.
    /// </summary>
    /// <returns>The name of the platform that is being used</returns>
    string GetPlatform();
    /// <summary>
    /// Determines whether the device is a touch device.
    /// </summary>
    /// <returns><see langword="true"/> when a touch screen compatible device is detected; <see langword="false"/> otherwise</returns>
    bool IsTouchDevice();

    /// <summary>
    /// Determines whether the browser is running on a mobile device.
    /// </summary>
    /// <returns><see langword="true"/> when a mobile device is detected; <see langword="false"/> otherwise</returns>
    bool IsMobile();

    /// <summary>
    /// Determines whether the browser supports WebGL.
    /// </summary>
    /// <returns></returns>
    bool HasWebGL();
    /// <summary>
    /// Determines whether the browser supports service workers.
    /// </summary>
    /// <returns></returns>
    bool HasServiceWorker();
    /// <summary>
    /// Determines whether the browser supports local storage.
    /// </summary>
    /// <returns></returns>
    bool SupportsLocalStorage();
    /// <summary>
    /// Determines whether the browser supports session storage.
    /// </summary>
    /// <returns></returns>
    bool SupportsSessionStorage();
}