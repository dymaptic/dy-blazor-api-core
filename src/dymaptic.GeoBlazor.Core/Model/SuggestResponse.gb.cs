// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    When resolved, returns this response after calling <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Search.html#suggest">suggest</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Search.html#SuggestResponse">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="ActiveSourceIndex">
///     The index of the source from which suggestions are obtained.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Search.html#SuggestResponse">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="Errors">
///     An array of error objects returned from the suggest results.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Search.html#SuggestResponse">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="NumResults">
///     The number of suggest results.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Search.html#SuggestResponse">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SuggestTerm">
///     The suggested expression.
/// </param>
/// <param name="Results">
///     An array of objects representing the results of suggest.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Search.html#SuggestResponse">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="SearchTerm">
///     The search expression used for the suggest.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Search.html#SuggestResponse">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record SuggestResponse(
    int ActiveSourceIndex,
    IReadOnlyCollection<Error> Errors,
    double NumResults,
    string SuggestTerm,
    IReadOnlyCollection<SuggestResponseResults> Results,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? SearchTerm = null);
