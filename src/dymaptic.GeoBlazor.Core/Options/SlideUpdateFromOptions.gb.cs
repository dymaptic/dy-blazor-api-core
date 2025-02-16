// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    
/// </summary>
/// <param name="Screenshot">
///     Screenshot options to use.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-webscene-Slide.html#updateFrom">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record SlideUpdateFromOptions(
    SlideUpdateFromOptionsScreenshot? Screenshot = null)
{
    /// <summary>
    ///     Screenshot options to use.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-webscene-Slide.html#updateFrom">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public SlideUpdateFromOptionsScreenshot? Screenshot { get; set; } = Screenshot;
    
}
