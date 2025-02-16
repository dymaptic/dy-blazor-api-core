// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Results;

/// <summary>
///    This class defines the results of the function <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-synthesizeAssociationGeometries.html">synthesizeAssociationGeometries</a> which takes an extent and returns an <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-AggregatedGeometry.html">AggregatedGeometry</a> of all <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-Association.html">associations</a> within the extent based on the defined parameters.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-AssociationGeometriesResult.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Associations">
///     List of returned <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-Association.html">associations</a> filtered based on the input parameters in <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-SynthesizeAssociationGeometriesParameters.html">SynthesizeAssociationGeometriesParameters</a>.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-AssociationGeometriesResult.html#associations">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="MaxGeometryCountExceeded">
///     Indicates whether the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-SynthesizeAssociationGeometriesParameters.html#maxGeometryCount">maxGeometryCount</a> has exceeded.
///     default false
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-networks-support-AssociationGeometriesResult.html#maxGeometryCountExceeded">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record AssociationGeometriesResult(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<Association>? Associations = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    bool? MaxGeometryCountExceeded = null);
