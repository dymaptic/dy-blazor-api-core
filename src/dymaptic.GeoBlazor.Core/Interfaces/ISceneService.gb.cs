// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Interfaces;

/// <summary>
///    Interface for types SceneLayer
/// </summary>
public partial interface ISceneService 
{
#region Properties

    /// <summary>
    ///     The copyright text as defined by the scene service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SceneService.html#copyright">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? Copyright { get; set; }
    
    /// <summary>
    ///     The layer ID, or layer index, of a Scene Service layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SceneService.html#layerId">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    long? LayerId { get; set; }
    
    /// <summary>
    ///     The spatial reference of the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SceneService.html#spatialReference">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    SpatialReference? SpatialReference { get; set; }
    
    /// <summary>
    ///     The URL of the REST endpoint of the layer or scene service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SceneService.html#url">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? Url { get; set; }
    
    /// <summary>
    ///     The version of the scene service specification used for this service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SceneService.html#version">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    SceneServiceVersion? Version { get; }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Copyright property after render.
    /// </summary>
    Task SetCopyright(string? value);
    
    /// <summary>
    ///    Asynchronously set the value of the LayerId property after render.
    /// </summary>
    Task SetLayerId(long? value);
    
    /// <summary>
    ///    Asynchronously set the value of the SpatialReference property after render.
    /// </summary>
    Task SetSpatialReference(SpatialReference? value);
    
    /// <summary>
    ///    Asynchronously set the value of the Url property after render.
    /// </summary>
    Task SetUrl(string? value);
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Copyright property.
    /// </summary>
    Task<string?> GetCopyright();

    /// <summary>
    ///     Asynchronously retrieve the current value of the LayerId property.
    /// </summary>
    Task<long?> GetLayerId();

    /// <summary>
    ///     Asynchronously retrieve the current value of the SpatialReference property.
    /// </summary>
    Task<SpatialReference?> GetSpatialReference();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Url property.
    /// </summary>
    Task<string?> GetUrl();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Version property.
    /// </summary>
    Task<SceneServiceVersion?> GetVersion();

#endregion

}
