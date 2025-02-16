// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Events;

/// <summary>
///    Event result type for the SceneLayer.OnEdits event.
/// </summary>
/// <param name="AddedFeatures">
///     An array of successfully added features.
/// </param>
/// <param name="DeletedFeatures">
///     An array of successfully deleted features.
/// </param>
/// <param name="ExceededTransferLimit">
///     Returns <code>true</code> when the number of records returned exceeds the maximum number configured on the service.
/// </param>
/// <param name="UpdatedFeatures">
///     An array of successfully updated features.
/// </param>
public partial record SceneLayerEditsEvent(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<FeatureEditResult>? AddedFeatures = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<FeatureEditResult>? DeletedFeatures = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? ExceededTransferLimit = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<FeatureEditResult>? UpdatedFeatures = null);
