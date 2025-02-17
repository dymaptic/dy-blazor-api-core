// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Temporal domain or extent of a coverage.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#TemporalDomain">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Begin">
///     Start date for the temporal domain of a coverage.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#TemporalDomain">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="End">
///     End date for the temporal domain of a coverage.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#TemporalDomain">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Resolution">
///     The numerical value of the temporal domain or extent.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#TemporalDomain">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Units">
///     Temporal units such as day, month, year etc.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#TemporalDomain">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Values">
///     Date values available in the temporal domain.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#TemporalDomain">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record TemporalDomain(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    DateTime? Begin = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    DateTime? End = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? Resolution = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Units = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<DateTime>? Values = null);
