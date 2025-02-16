// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Interfaces;

/// <summary>
///    Interface for types CatalogLayer, CSVLayer, FeatureLayer, ImageryLayer, MapImageLayer
/// </summary>
public partial interface ITemporalLayer 
{
#region Properties

    /// <summary>
    ///     The layer's time extent.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-TemporalLayer.html#timeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    TimeExtent? TimeExtent { get; set; }
    
    /// <summary>
    ///     TimeInfo provides information such as date fields that store <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#startField">start</a> and <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#endField">end</a> time for each feature and the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#fullTimeExtent">fullTimeExtent</a> for the layer.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-TemporalLayer.html#timeInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    TimeInfo? TimeInfo { get; set; }
    
    /// <summary>
    ///     A temporary offset of the time data based on a certain <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeInterval.html">TimeInterval</a>.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-TemporalLayer.html#timeOffset">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    TimeInterval? TimeOffset { get; set; }
    
    /// <summary>
    ///     Determines if the time enabled layer will update its temporal data based on the view's <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-View.html#timeExtent">timeExtent</a>.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-TemporalLayer.html#useViewTime">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    bool? UseViewTime { get; set; }
    
#endregion

#region Property Setters

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

}
