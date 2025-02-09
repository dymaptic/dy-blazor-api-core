// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Results;

/// <summary>
///    The area and length result from a selected image's measurement in an image space when the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#measureAreaFromImage">ImageryLayer.measureAreaFromImage()</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-imageService.html#measureAreaFromImage">imageService.measureAreaFromImage()</a> methods resolve successfully.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-MeasureAreaFromImageResult.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Area">
///     The area of a polygon in square meters.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-MeasureAreaFromImageResult.html#area">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Center">
///     The polygon's center in a map space.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-MeasureAreaFromImageResult.html#center">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Geometry">
///     The polygon geometry in a map space.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-MeasureAreaFromImageResult.html#geometry">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Length">
///     The perimeter of a polygon in meters.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-MeasureAreaFromImageResult.html#length">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record MeasureAreaFromImageResult(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? Area = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    Point? Center = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    Polygon? Geometry = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? Length = null);
