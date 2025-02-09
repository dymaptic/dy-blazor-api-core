// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    
/// </summary>
/// <param name="NoDataValue">
///     The value representing pixels in the tile that don't contain an elevation value.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ElevationLayer.html#fetchTile">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Signal">
///     An <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/API/AbortSignal">AbortSignal</a> to abort the request.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ElevationLayer.html#fetchTile">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record ElevationLayerFetchTileOptions(
    double? NoDataValue = null)
{
    /// <summary>
    ///     The value representing pixels in the tile that don't contain an elevation value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ElevationLayer.html#fetchTile">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public double? NoDataValue { get; set; } = NoDataValue;
    
}
