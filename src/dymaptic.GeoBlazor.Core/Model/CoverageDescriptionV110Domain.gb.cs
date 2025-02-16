// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Describes the spatial and temporal domain of a coverage.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV110">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="SpatialDomain">
///     Spatial extent or domain of a coverage.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV110">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="TemporalDomain">
///     Temporal domain or extent of the coverage.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV110">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record CoverageDescriptionV110Domain(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    CoverageDescriptionV110DomainSpatialDomain? SpatialDomain = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    TemporalDomain? TemporalDomain = null);
