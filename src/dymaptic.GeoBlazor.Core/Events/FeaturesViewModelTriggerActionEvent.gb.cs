// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Events;

/// <summary>
///    Event result type for the FeaturesViewModel.OnTriggerAction event.
/// </summary>
/// <param name="Action">
///     The action clicked by the user. For a description
///     of this object and a specification of its properties,
///     see the <a href="#actions">actions</a> property of this class.
/// </param>
public partial record FeaturesViewModelTriggerActionEvent(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    ActionBase? Action = null);
