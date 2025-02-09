// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Contains additional information about how the geometry was sampled.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ElevationLayer.html#ElevationQueryResult">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="DemResolution">
///     The resolution at which the z-value was sampled.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ElevationLayer.html#ElevationQueryResult">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record ElevationLayerElevationQueryResultSampleInfo(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? DemResolution = null);
