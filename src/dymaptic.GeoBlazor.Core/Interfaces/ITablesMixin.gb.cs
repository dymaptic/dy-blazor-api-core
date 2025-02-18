// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Interfaces;

/// <summary>
///    Interface for types GroupLayer
/// </summary>
public partial interface ITablesMixin 
{
#region Properties

    /// <summary>
    ///     A collection of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html">layer</a> instances that are tables saved in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Map.html">Map</a> and/or a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-WebMap.html">WebMap</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-support-TablesMixin.html#tables">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IReadOnlyList<Layer>? Tables { get; set; }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Tables property after render.
    /// </summary>
    Task SetTables(IReadOnlyList<Layer>? value);
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Tables property.
    /// </summary>
    Task<IReadOnlyList<Layer>?> GetTables();

#endregion

#region Collection Property Adders

    /// <summary>
    ///     Asynchronously add elements to the Tables property.
    /// </summary>
    Task AddToTables(params Layer[] values);
    
#endregion

#region Collection Property Removers

    /// <summary>
    ///     Asynchronously remove elements from the Tables property.
    /// </summary>
    Task RemoveFromTables(params Layer[] values);
    
#endregion

#region Public Methods

    /// <summary>
    ///     Returns a table based on the given table ID.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-support-TablesMixin.html#findTableById">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="tableId">
    /// </param>
    [ArcGISMethod]
    Task<Layer?> FindTableById(string tableId);
    
#endregion

}
