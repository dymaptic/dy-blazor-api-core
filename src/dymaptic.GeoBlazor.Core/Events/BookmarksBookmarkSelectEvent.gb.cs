// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Events;

/// <summary>
///    Event result type for the BookmarksWidget.OnBookmarkSelect event.
/// </summary>
/// <param name="Bookmark">
/// </param>
public partial record BookmarksBookmarkSelectEvent(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    Bookmark? Bookmark = null);
