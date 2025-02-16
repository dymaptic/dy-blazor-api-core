// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Events;

/// <summary>
///    Event result type for the LocateViewModel.OnLocateError event.
/// </summary>
/// <param name="Error">
///     The Error object that occurred while locating.
/// </param>
/// <param name="StringError">
///     The Error object that occurred while locating.
/// </param>
public partial record LocateViewModelLocateErrorEvent(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    Error? Error = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? StringError = null);
