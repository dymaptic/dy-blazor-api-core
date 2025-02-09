// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    Options for validating the save operation.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#saveAs">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="IgnoreUnsupported">
///     Indicates whether to ignore saving unsupported layers or layers with unsupported content, such as unsupported symbology.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#saveAs">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record ImageryLayerSaveAsOptionsValidationOptions(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? IgnoreUnsupported = null);
