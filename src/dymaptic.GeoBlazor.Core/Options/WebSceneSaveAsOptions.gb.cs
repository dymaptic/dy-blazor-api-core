// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    
/// </summary>
/// <param name="Folder">
///     the folder in which to save the item.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-WebScene.html#saveAs">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="IgnoreUnsupported">
///     allow the scene to be saved even in the case it contains unsupported content (layers, renderers, symbols).
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-WebScene.html#saveAs">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record WebSceneSaveAsOptions(
    PortalFolder? Folder = null,
    bool? IgnoreUnsupported = null)
{
    /// <summary>
    ///     the folder in which to save the item.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-WebScene.html#saveAs">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public PortalFolder? Folder { get; set; } = Folder;
    
    /// <summary>
    ///     allow the scene to be saved even in the case it contains unsupported content (layers, renderers, symbols).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-WebScene.html#saveAs">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public bool? IgnoreUnsupported { get; set; } = IgnoreUnsupported;
    
}
