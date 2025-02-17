// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    
/// </summary>
/// <param name="ValidationOptions">
///     Options for validating the save operation.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GroupLayer.html#save">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record GroupLayerSaveOptions(
    GroupLayerSaveOptionsValidationOptions? ValidationOptions = null)
{
    /// <summary>
    ///     Options for validating the save operation.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GroupLayer.html#save">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public GroupLayerSaveOptionsValidationOptions? ValidationOptions { get; set; } = ValidationOptions;
    
}
