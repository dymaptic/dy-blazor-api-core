// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    
/// </summary>
/// <param name="EnableRotation">
///     Indicates if the `rotation` operation will be enabled when updating graphics.
///     default true
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="EnableScaling">
///     Indicates if the `scale` operation will be enabled when updating graphics.
///     default true
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="EnableZ">
///     Indicates if z-values can be modified when updating the graphic.
///     default true
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="MultipleSelectionEnabled">
///     Indicates whether more than one selection can be made at once.
///     default true
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="PreserveAspectRatio">
///     Indicates if the uniform scale operation will be enabled when updating graphics.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="ToggleToolOnClick">
///     Indicates if the graphic being updated can be toggled between `transform` and `reshape` update options.
///     default true
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Tool">
///     Name of the update tool.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record SketchUpdateUpdateOptions(
    bool? EnableRotation = null,
    bool? EnableScaling = null,
    bool? EnableZ = null,
    bool? MultipleSelectionEnabled = null,
    bool? PreserveAspectRatio = null,
    bool? ToggleToolOnClick = null,
    Tool? Tool = null)
{
    /// <summary>
    ///     Indicates if the `rotation` operation will be enabled when updating graphics.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public bool? EnableRotation { get; set; } = EnableRotation;
    
    /// <summary>
    ///     Indicates if the `scale` operation will be enabled when updating graphics.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public bool? EnableScaling { get; set; } = EnableScaling;
    
    /// <summary>
    ///     Indicates if z-values can be modified when updating the graphic.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public bool? EnableZ { get; set; } = EnableZ;
    
    /// <summary>
    ///     Indicates whether more than one selection can be made at once.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public bool? MultipleSelectionEnabled { get; set; } = MultipleSelectionEnabled;
    
    /// <summary>
    ///     Indicates if the uniform scale operation will be enabled when updating graphics.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public bool? PreserveAspectRatio { get; set; } = PreserveAspectRatio;
    
    /// <summary>
    ///     Indicates if the graphic being updated can be toggled between `transform` and `reshape` update options.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public bool? ToggleToolOnClick { get; set; } = ToggleToolOnClick;
    
    /// <summary>
    ///     Name of the update tool.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Sketch.html#update">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public Tool? Tool { get; set; } = Tool;
    
}
