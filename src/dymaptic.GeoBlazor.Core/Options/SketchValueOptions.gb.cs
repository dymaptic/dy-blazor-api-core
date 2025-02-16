// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    The `SketchValueOptions` allows users to configure how numerical values and constraints behave while sketching and editing.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-interactive-sketch-SketchValueOptions.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="DirectionMode">
///     How direction values are displayed and, in case of input, how they are interpreted.
///     default "relative"
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-interactive-sketch-SketchValueOptions.html#directionMode">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record SketchValueOptions(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    DirectionMode? DirectionMode = null);
