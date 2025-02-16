// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;

/// <summary>
///    A device feature can be assigned a terminal configuration, which could have one or more terminals.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-networks-support-Terminal.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Name">
///     The name of the terminal.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-networks-support-Terminal.html#name">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="TerminalId">
///     A unique numeric identifier for the terminal.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-networks-support-Terminal.html#id">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record Terminal(
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Name = null,
    [property:JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    long? TerminalId = null);
