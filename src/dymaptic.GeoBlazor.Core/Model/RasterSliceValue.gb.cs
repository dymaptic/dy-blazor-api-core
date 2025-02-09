// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Data series returned in <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterIdentifyResult">RasterIdentifyResult</a> when <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#identify">identify()</a> is called on a transposed multidimensional ImageryTileLayer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterSliceValue">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="MagdirValue">
///     The magnitude and direction values for services containing vector data.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterSliceValue">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="MultidimensionalDefinition">
///     A dimensional definition associated with a given slice.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterSliceValue">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Value">
///     Image service pixel values for a given slice.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#RasterSliceValue">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record RasterSliceValue(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<double>? MagdirValue = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<DimensionalDefinition>? MultidimensionalDefinition = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<double>? Value = null);
