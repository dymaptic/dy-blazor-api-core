// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    If the edit failed, the edit result includes an error.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#FeatureEditResult">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Message">
///     Message describing the error.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#FeatureEditResult">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Name">
///     Error name.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#FeatureEditResult">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record FeatureEditResultError(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Message = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Name = null);
