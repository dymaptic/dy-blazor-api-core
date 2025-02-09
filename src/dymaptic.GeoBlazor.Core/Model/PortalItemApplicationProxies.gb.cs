// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Contains an array of objects containing proxy information for premium platform services.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-portal-PortalItem.html#applicationProxies">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="ProxyId">
///     The proxy ID registered in ArcGIS Online or ArcGIS Enterprise Portal.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-portal-PortalItem.html#applicationProxies">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="ProxyUrl">
///     The proxy URL for the source URL.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-portal-PortalItem.html#applicationProxies">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SourceUrl">
///     The URL of the premium map service layer.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-portal-PortalItem.html#applicationProxies">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record PortalItemApplicationProxies(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? ProxyId = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? ProxyUrl = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? SourceUrl = null);
