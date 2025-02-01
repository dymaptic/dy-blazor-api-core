// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Object containing all edited features belonging to the specified layer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#EditedFeatureResult">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Adds">
///     Newly added features as a result of editing a feature that participates in a composite relationship.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#EditedFeatureResult">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Deletes">
///     Deleted features as a result of editing a feature that participates in a composite relationship.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#EditedFeatureResult">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SpatialReference">
///     Edited features are returned in the spatial reference of the feature service.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#EditedFeatureResult">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Updates">
///     Object containing original and updated features as a result of editing a feature that participates in a composite relationship.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#EditedFeatureResult">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record EditedFeatureResultEditedFeatures(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<Graphic>? Adds = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<Graphic>? Deletes = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    SpatialReference? SpatialReference = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<EditedFeatureResultEditedFeaturesUpdates>? Updates = null);

