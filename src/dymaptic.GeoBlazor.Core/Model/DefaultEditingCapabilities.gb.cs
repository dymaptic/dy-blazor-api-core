// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    The default editing capabilities for the provided layer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#DefaultEditingCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Attachments">
///     The editing capabilities for attachments.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#DefaultEditingCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Create">
///     The editing capabilities for creating features.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#DefaultEditingCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Delete">
///     The editing capabilities for deleting features.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#DefaultEditingCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Layer">
///     The <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html">FeatureLayer</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-SubtypeSublayer.html">SubtypeSublayer</a> currently being edited.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#DefaultEditingCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="ReliesOnOwnerAdminPrivileges">
///     Indicates when editing is enabled and is only due to administrative permissions.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#DefaultEditingCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Update">
///     The editing capabilities for updating features.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#DefaultEditingCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record DefaultEditingCapabilities(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    AttachmentCapabilities? Attachments = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    CreateCapabilities? Create = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    DeleteCapabilities? Delete = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    Layer? Layer = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? ReliesOnOwnerAdminPrivileges = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    UpdateCapabilities? Update = null);
