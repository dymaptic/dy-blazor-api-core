// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Events;

/// <summary>
///    Event result type for the SliderWidget.OnThumbDrag event.
/// </summary>
/// <param name="Index">
/// </param>
/// <param name="State">
/// </param>
/// <param name="Value">
/// </param>
public partial record SliderThumbDragEvent(
    int Index,
    State State,
    double Value);
