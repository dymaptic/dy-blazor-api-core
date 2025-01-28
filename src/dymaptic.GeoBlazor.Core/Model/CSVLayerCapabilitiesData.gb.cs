// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Describes characteristics of the data in the layer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-CSVLayer.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="SupportsAttachment">
///     Indicates if the attachment is enabled on the layer.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-CSVLayer.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SupportsM">
///     Indicates if the features in the layer support m-values.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-CSVLayer.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SupportsZ">
///     Indicates if the features in the layer support z-values.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-CSVLayer.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record CSVLayerCapabilitiesData(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? SupportsAttachment = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? SupportsM = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? SupportsZ = null);

