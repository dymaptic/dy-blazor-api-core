// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Interfaces;

/// <summary>
///    Interface for types MapImageLayer, TileLayer
/// </summary>
public partial interface ISublayersOwner 
{
#region Properties

    /// <summary>
    ///     A flat <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-core-Collection.html">Collection</a> of all the tables in the layer including the tables of its sublayers.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SublayersOwner.html#subtables">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IReadOnlyList<Sublayer>? Subtables { get; set; }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Subtables property after render.
    /// </summary>
    Task SetSubtables(IReadOnlyList<Sublayer>? value);
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Subtables property.
    /// </summary>
    Task<IReadOnlyList<Sublayer>?> GetSubtables();

#endregion

#region Collection Property Adders

    /// <summary>
    ///     Asynchronously add elements to the Subtables property.
    /// </summary>
    Task AddToSubtables(params Sublayer[] values);
    
#endregion

#region Collection Property Removers

    /// <summary>
    ///     Asynchronously remove elements from the Subtables property.
    /// </summary>
    Task RemoveFromSubtables(params Sublayer[] values);
    
#endregion

#region Public Methods

    /// <summary>
    ///     Returns a deep clone of a map service's <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Sublayer.html">sublayers</a> as defined by the service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SublayersOwner.html#createServiceSublayers">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    Task<Sublayer[]?> CreateServiceSublayers();
    
    /// <summary>
    ///     Returns the sublayer with the given layerId.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-SublayersOwner.html#findSublayerById">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="id">
    /// </param>
    [ArcGISMethod]
    Task<Sublayer?> FindSublayerById(long id);
    
#endregion

}
