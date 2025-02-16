// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    
/// </summary>
/// <param name="Material">
///     The material to be used for the mesh.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Mesh.html#createFromPolygon">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record MeshCreateFromPolygonParameters(
    MeshMaterial? Material = null)
{
    /// <summary>
    ///     The material to be used for the mesh.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Mesh.html#createFromPolygon">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public MeshMaterial? Material { get; set; } = Material;
    
}
