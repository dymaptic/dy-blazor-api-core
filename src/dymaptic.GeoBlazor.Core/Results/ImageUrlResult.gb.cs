// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Results;

/// <summary>
///    The result returned when the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#getImageUrl">ImageryLayer.getImageUrl()</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-imageService.html#getImageUrl">imageService.getImageUrl()</a> method resolves successfully.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageUrlResult.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Url">
///     Image's url
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageUrlResult.html#url">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record ImageUrlResult(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Url = null);
