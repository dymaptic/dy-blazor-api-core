// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Specific permissions for relationship operations.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#RelationshipCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Enabled">
///     Indicates whether the layer contains at least one relationship, in addition to having child <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-Workflow.html">workflow</a> permissions.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Editor-support-EditorItem.html#RelationshipCapabilities">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record RelationshipCapabilities(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? Enabled = null);
