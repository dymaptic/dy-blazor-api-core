// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Options;

/// <summary>
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-KnowledgeGraphLayer.html">KnowledgeGraphLayer</a> specific properties.
///    default null
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html#knowledgeGraphOptions">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="FilterPlaceholder">
///     Placeholder text used in the filter input box.
///     default ""
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html#knowledgeGraphOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="ListItemCreatedFunction">
///     A function that executes each time a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-TableList-ListItem.html">ListItem</a> is created.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html#knowledgeGraphOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="MinFilterItems">
///     The minimum number of list items required to display the filter input box.
///     default 10
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html#knowledgeGraphOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SelectionMode">
///     The selection mode for the table list.
///     default "none"
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html#knowledgeGraphOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="VisibleElements">
///     The visible elements that are displayed within the table list.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html#knowledgeGraphOptions">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record LayerListKnowledgeGraphOptions(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? FilterPlaceholder = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    TableListListItemCreatedHandler? ListItemCreatedFunction = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? MinFilterItems = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? SelectionMode = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    LayerListKnowledgeGraphOptionsVisibleElements? VisibleElements = null);
