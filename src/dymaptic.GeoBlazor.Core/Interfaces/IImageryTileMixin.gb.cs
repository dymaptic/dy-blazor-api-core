// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Interfaces;

/// <summary>
///    Interface for types ImageryTileLayer, WCSLayer
/// </summary>
public partial interface IImageryTileMixin 
{
#region Properties

    /// <summary>
    ///     Defines a band combination using 0-based band indexes.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#bandIds">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IReadOnlyList<long>? BandIds { get; set; }
    
    /// <summary>
    ///     The copyright text as defined by the service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#copyright">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? Copyright { get; set; }
    
    /// <summary>
    ///     Indicates whether the layer will be included in the legend.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#legendEnabled">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    bool? LegendEnabled { get; set; }
    
    /// <summary>
    ///     The multidimensional definitions associated with the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#multidimensionalDefinition">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IReadOnlyList<DimensionalDefinition>? MultidimensionalDefinition { get; set; }
    
    /// <summary>
    ///     Represents a multidimensional subset of raster data.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#multidimensionalSubset">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    MultidimensionalSubset? MultidimensionalSubset { get; set; }
    
    /// <summary>
    ///     Indicates whether to display popups when features in the layer are clicked.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#popupEnabled">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    bool? PopupEnabled { get; set; }
    
    /// <summary>
    ///     The popup template for the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#popupTemplate">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    PopupTemplate? PopupTemplate { get; set; }
    
    /// <summary>
    ///     The renderer assigned to the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#renderer">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IImageryRenderer? Renderer { get; set; }
    
    /// <summary>
    ///     The layer's time extent.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#timeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    TimeExtent? TimeExtent { get; set; }
    
    /// <summary>
    ///     TimeInfo provides information such as date fields that store <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#startField">start</a> and <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#endField">end</a> time for each feature and the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#fullTimeExtent">fullTimeExtent</a> for the layer.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#timeInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    TimeInfo? TimeInfo { get; set; }
    
    /// <summary>
    ///     A temporary offset of the time data based on a certain <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeInterval.html">TimeInterval</a>.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#timeOffset">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    TimeInterval? TimeOffset { get; set; }
    
    /// <summary>
    ///     Determines if the layer will update its temporal data based on the view's <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-View.html#timeExtent">timeExtent</a>.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#useViewTime">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    bool? UseViewTime { get; set; }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the BandIds property after render.
    /// </summary>
    Task SetBandIds(IReadOnlyList<long>? value);
    
    /// <summary>
    ///    Asynchronously set the value of the Copyright property after render.
    /// </summary>
    Task SetCopyright(string? value);
    
    /// <summary>
    ///    Asynchronously set the value of the LegendEnabled property after render.
    /// </summary>
    Task SetLegendEnabled(bool? value);
    
    /// <summary>
    ///    Asynchronously set the value of the MultidimensionalDefinition property after render.
    /// </summary>
    Task SetMultidimensionalDefinition(IReadOnlyList<DimensionalDefinition>? value);
    
    /// <summary>
    ///    Asynchronously set the value of the MultidimensionalSubset property after render.
    /// </summary>
    Task SetMultidimensionalSubset(MultidimensionalSubset? value);
    
    /// <summary>
    ///    Asynchronously set the value of the PopupEnabled property after render.
    /// </summary>
    Task SetPopupEnabled(bool? value);
    
    /// <summary>
    ///    Asynchronously set the value of the PopupTemplate property after render.
    /// </summary>
    Task SetPopupTemplate(PopupTemplate? value);
    
    /// <summary>
    ///    Asynchronously set the value of the Renderer property after render.
    /// </summary>
    Task SetRenderer(IImageryRenderer? value);
    
    /// <summary>
    ///    Asynchronously set the value of the TimeExtent property after render.
    /// </summary>
    Task SetTimeExtent(TimeExtent? value);
    
    /// <summary>
    ///    Asynchronously set the value of the TimeInfo property after render.
    /// </summary>
    Task SetTimeInfo(TimeInfo? value);
    
    /// <summary>
    ///    Asynchronously set the value of the TimeOffset property after render.
    /// </summary>
    Task SetTimeOffset(TimeInterval? value);
    
    /// <summary>
    ///    Asynchronously set the value of the UseViewTime property after render.
    /// </summary>
    Task SetUseViewTime(bool? value);
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the BandIds property.
    /// </summary>
    Task<IReadOnlyList<long>?> GetBandIds();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Copyright property.
    /// </summary>
    Task<string?> GetCopyright();

    /// <summary>
    ///     Asynchronously retrieve the current value of the LegendEnabled property.
    /// </summary>
    Task<bool?> GetLegendEnabled();

    /// <summary>
    ///     Asynchronously retrieve the current value of the MultidimensionalDefinition property.
    /// </summary>
    Task<IReadOnlyList<DimensionalDefinition>?> GetMultidimensionalDefinition();

    /// <summary>
    ///     Asynchronously retrieve the current value of the MultidimensionalSubset property.
    /// </summary>
    Task<MultidimensionalSubset?> GetMultidimensionalSubset();

    /// <summary>
    ///     Asynchronously retrieve the current value of the PopupEnabled property.
    /// </summary>
    Task<bool?> GetPopupEnabled();

    /// <summary>
    ///     Asynchronously retrieve the current value of the PopupTemplate property.
    /// </summary>
    Task<PopupTemplate?> GetPopupTemplate();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Renderer property.
    /// </summary>
    Task<IImageryRenderer?> GetRenderer();

    /// <summary>
    ///     Asynchronously retrieve the current value of the ServiceRasterInfo property.
    /// </summary>
    Task<RasterInfo?> GetServiceRasterInfo();

    /// <summary>
    ///     Asynchronously retrieve the current value of the TimeExtent property.
    /// </summary>
    Task<TimeExtent?> GetTimeExtent();

    /// <summary>
    ///     Asynchronously retrieve the current value of the TimeInfo property.
    /// </summary>
    Task<TimeInfo?> GetTimeInfo();

    /// <summary>
    ///     Asynchronously retrieve the current value of the TimeOffset property.
    /// </summary>
    Task<TimeInterval?> GetTimeOffset();

    /// <summary>
    ///     Asynchronously retrieve the current value of the UseViewTime property.
    /// </summary>
    Task<bool?> GetUseViewTime();

#endregion

#region Collection Property Adders

    /// <summary>
    ///     Asynchronously add elements to the BandIds property.
    /// </summary>
    Task AddToBandIds(params long[] values);
    
    /// <summary>
    ///     Asynchronously add elements to the MultidimensionalDefinition property.
    /// </summary>
    Task AddToMultidimensionalDefinition(params DimensionalDefinition[] values);
    
#endregion

#region Collection Property Removers

    /// <summary>
    ///     Asynchronously remove elements from the BandIds property.
    /// </summary>
    Task RemoveFromBandIds(params long[] values);
    
    /// <summary>
    ///     Asynchronously remove elements from the MultidimensionalDefinition property.
    /// </summary>
    Task RemoveFromMultidimensionalDefinition(params DimensionalDefinition[] values);
    
#endregion

#region Public Methods

    /// <summary>
    ///     Fetches pixels for a given extent.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#fetchPixels">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="extent">
    /// </param>
    /// <param name="width">
    /// </param>
    /// <param name="height">
    /// </param>
    /// <param name="options">
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    Task<PixelData?> FetchPixels(Extent extent,
        int width,
        int height,
        ImageryTileMixinFetchPixelsOptions options,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    ///     Identify pixel values at a given location.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ImageryTileMixin.html#identify">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="point">
    /// </param>
    /// <param name="options">
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    Task<RasterIdentifyResult?> Identify(Point point,
        RasterIdentifyOptions options,
        CancellationToken cancellationToken = default);
    
#endregion

}
