// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Events;

/// <summary>
///    Event result type for the BasemapLayerListWidget.OnTriggerAction event.
/// </summary>
/// <param name="Action">
/// </param>
/// <param name="Item">
/// </param>
public partial record BasemapLayerListTriggerActionEvent(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    ActionBase? Action = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    ListItem? Item = null);
