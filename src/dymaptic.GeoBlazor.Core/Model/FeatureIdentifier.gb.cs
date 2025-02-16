// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Alternative representation of features to be deleted with applyEdits.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-SceneLayer.html#FeatureIdentifier">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="GlobalId">
///     The globalId of the feature to be deleted.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-SceneLayer.html#FeatureIdentifier">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="LongObjectId">
///     The objectId of the feature to be deleted.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-SceneLayer.html#FeatureIdentifier">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="StringObjectId">
///     The objectId of the feature to be deleted.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-SceneLayer.html#FeatureIdentifier">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record FeatureIdentifier(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? GlobalId = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    long? LongObjectId = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? StringObjectId = null);
