// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Events;

/// <summary>
///    Event result type for the SearchViewModel.OnSuggestComplete event.
/// </summary>
/// <param name="ActiveSourceIndex">
///     The index of the source from which suggestions are obtained. This value is <code>-1</code> when all sources are selected.
/// </param>
/// <param name="Errors">
///     An array of error objects returned from the suggest results.
/// </param>
/// <param name="NumResults">
///     The number of suggest results.
/// </param>
/// <param name="Results">
///     An array of objects representing the results of suggest. See object specification
///     table below for more information about the result object.
/// </param>
/// <param name="SearchTerm">
///     The search expression used for the suggest.
/// </param>
public partial record SearchViewModelSuggestCompleteEvent(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    int? ActiveSourceIndex = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<Error>? Errors = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    double? NumResults = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    IReadOnlyCollection<SearchViewModelSuggestCompleteEventResults>? Results = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? SearchTerm = null);
