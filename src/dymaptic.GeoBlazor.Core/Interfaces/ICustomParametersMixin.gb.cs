// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Interfaces;

/// <summary>
///    Interface for types CatalogLayer, FeatureLayer, MapImageLayer, SceneLayer, TileLayer
/// </summary>
public partial interface ICustomParametersMixin 
{
#region Properties

    /// <summary>
    ///     A list of custom parameters appended to the URL of all resources fetched by the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-CustomParametersMixin.html#customParameters">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    Dictionary<string, object>? CustomParameters { get; set; }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the CustomParameters property after render.
    /// </summary>
    Task SetCustomParameters(Dictionary<string, object>? value);
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the CustomParameters property.
    /// </summary>
    Task<Dictionary<string, object>?> GetCustomParameters();

#endregion

}
