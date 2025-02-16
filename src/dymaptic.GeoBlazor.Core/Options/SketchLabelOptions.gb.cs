// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    The `SketchLabelOptions` allows users to configure the labels which are shown next to each segment of a graphic while sketching and editing.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-interactive-sketch-SketchLabelOptions.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Enabled">
///     Whether labels are shown next to each segment of the graphic being sketched.
///     default false
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-interactive-sketch-SketchLabelOptions.html#enabled">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record SketchLabelOptions(
    bool Enabled);
