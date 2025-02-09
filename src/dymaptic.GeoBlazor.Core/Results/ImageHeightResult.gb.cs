// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Results;

/// <summary>
///    Image service height mensuration result returned when the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#measureHeight">ImageryLayer.measureHeight()</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-imageService.html#measureHeight">imageService.measureHeight()</a> methods resolve successfully.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHeightResult.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Name">
///     Name of the raster dataset used in the area and height measurement.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-BaseImageMeasureResult.html#name">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SensorName">
///     Sensor name of the raster dataset used in the area and height measurement.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-BaseImageMeasureResult.html#sensorName">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Height">
///     An object containing results of the height measurement.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHeightResult.html#height">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record ImageHeightResult(
    string Name,
    string SensorName,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    MeasurementValue? Height = null) : BaseImageMeasureResult(
    Name,
    SensorName);
