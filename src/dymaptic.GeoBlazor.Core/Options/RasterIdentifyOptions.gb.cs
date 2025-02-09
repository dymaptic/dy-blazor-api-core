// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    Additional options to set for `identify()` method on <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#identify">ImageryTileLayer</a> and <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#identify">WCSLayer</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterIdentifyOptions">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="MultidimensionalDefinition">
///     A dimensional definition used for the `identify` operation.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterIdentifyOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Signal">
///     <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/API/AbortSignal">AbortSignal</a> allows for cancelable requests.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterIdentifyOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="TransposedVariableName">
///     Name of the transposed variable.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterIdentifyOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record RasterIdentifyOptions(
    IReadOnlyCollection<DimensionalDefinition>? MultidimensionalDefinition = null,
    string? TransposedVariableName = null)
{
    /// <summary>
    ///     A dimensional definition used for the `identify` operation.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterIdentifyOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public IReadOnlyCollection<DimensionalDefinition>? MultidimensionalDefinition { get; set; } = MultidimensionalDefinition;
    
    /// <summary>
    ///     Name of the transposed variable.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterIdentifyOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public string? TransposedVariableName { get; set; } = TransposedVariableName;
    
}
