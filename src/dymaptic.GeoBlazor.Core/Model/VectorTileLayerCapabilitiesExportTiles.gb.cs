// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Indicates options supported by the exportTiles operation.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-VectorTileLayer.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="MaxExportTilesCount">
///     Specifies the maximum number of tiles that can be exported to a cache dataset or a tile package.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-VectorTileLayer.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record VectorTileLayerCapabilitiesExportTiles(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    int? MaxExportTilesCount = null);

