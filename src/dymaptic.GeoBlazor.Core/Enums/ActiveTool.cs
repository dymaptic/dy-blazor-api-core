// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Enums;

/// <summary>
///     <summary>
///          Specifies the current measurement tool to display.
///      </summary>
/// </summary>
[JsonConverter(typeof(EnumToKebabCaseStringConverter<ActiveTool>))]
public enum ActiveTool
{
#pragma warning disable CS1591
    Point,
    Multipoint,
    Polyline,
    Polygon,
    Circle,
    Mesh,
    Rectangle,
    Move,
    Transform,
    Reshape,
    Area,
    Distance,
    DirectLine
#pragma warning restore CS1591
}
