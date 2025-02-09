// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Image GPS info parameters for <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#queryGPSInfo">ImageryLayer.queryGPSInfo()</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-imageService.html#queryGPSInfo">imageService.queryGPSInfo()</a> methods.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Geometry">
///     The geometry to query images.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#geometry">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="ObjectIds">
///     An array of ObjectIDs to be used to query images.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#objectIds">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SpatialRelationship">
///     For spatial queries, this parameter defines the spatial relationship to query image footprints in the layer against the input <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#geometry">geometry</a>.
///     default intersects
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#spatialRelationship">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="TimeExtent">
///     A time extent for a temporal query to query images.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#timeExtent">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Where">
///     A where clause for the query.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#where">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record ImageGPSInfoParameters(
    Geometry? Geometry = null,
    IReadOnlyCollection<long>? ObjectIds = null,
    SpatialRelationship? SpatialRelationship = null,
    TimeExtent? TimeExtent = null,
    string? Where = null)
{
    /// <summary>
    ///     The geometry to query images.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#geometry">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public Geometry? Geometry { get; set; } = Geometry;
    
    /// <summary>
    ///     An array of ObjectIDs to be used to query images.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#objectIds">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public IReadOnlyCollection<long>? ObjectIds { get; set; } = ObjectIds;
    
    /// <summary>
    ///     For spatial queries, this parameter defines the spatial relationship to query image footprints in the layer against the input <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#geometry">geometry</a>.
    ///     default intersects
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#spatialRelationship">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public SpatialRelationship? SpatialRelationship { get; set; } = SpatialRelationship;
    
    /// <summary>
    ///     A time extent for a temporal query to query images.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#timeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public TimeExtent? TimeExtent { get; set; } = TimeExtent;
    
    /// <summary>
    ///     A where clause for the query.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html#where">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public string? Where { get; set; } = Where;
    
}
