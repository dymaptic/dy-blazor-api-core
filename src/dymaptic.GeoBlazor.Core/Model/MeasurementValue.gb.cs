// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    An object containing measurement values returned from a mensuration operation.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#measurementValue">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="DisplayValue">
///     Measured value represented in significant figures in string format.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#measurementValue">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Uncertainty">
///     Uncertainty of the measurement.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#measurementValue">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Unit">
///     Unit used in the mensuration operation.
///     <a target="_blank" href="global.html#unit">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Value">
///     Measured value.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#measurementValue">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record MeasurementValue(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? DisplayValue = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? Uncertainty = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Unit = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? Value = null);
