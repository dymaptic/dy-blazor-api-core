// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Filters features from the layer that are within the specified range values.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html#rangeValues">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="DoubleCollectionValues">
///     Single value or value range.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html#rangeValues">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="DoubleValues">
///     Single value or value range.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html#rangeValues">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Name">
///     The range id.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html#rangeValues">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record QueryRangeValues(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<double>? DoubleCollectionValues = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? DoubleValues = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Name = null);
