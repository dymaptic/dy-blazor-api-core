// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    The `LayerOptions` class defines additional options that can be defined for a layer's <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-PopupTemplate.html">PopupTemplate</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-LayerOptions.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class LayerOptions : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public LayerOptions()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="returnTopmostRaster">
    ///     Applicable to <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html">Imagery Layers</a>.
    ///     default false
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-LayerOptions.html#returnTopmostRaster">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="showNoDataRecords">
    ///     Applicable to <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html">Imagery Layers</a>.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-LayerOptions.html#showNoDataRecords">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public LayerOptions(
        bool? returnTopmostRaster = null,
        bool? showNoDataRecords = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        ReturnTopmostRaster = returnTopmostRaster;
        ShowNoDataRecords = showNoDataRecords;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Applicable to <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html">Imagery Layers</a>.
    ///     default false
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-LayerOptions.html#returnTopmostRaster">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ReturnTopmostRaster { get; set; }
    
    /// <summary>
    ///     Applicable to <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html">Imagery Layers</a>.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-LayerOptions.html#showNoDataRecords">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ShowNoDataRecords { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the ReturnTopmostRaster property.
    /// </summary>
    public async Task<bool?> GetReturnTopmostRaster()
    {
        if (CoreJsModule is null)
        {
            return ReturnTopmostRaster;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ReturnTopmostRaster;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "returnTopmostRaster");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             ReturnTopmostRaster = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ReturnTopmostRaster)] = ReturnTopmostRaster;
        }
         
        return ReturnTopmostRaster;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ShowNoDataRecords property.
    /// </summary>
    public async Task<bool?> GetShowNoDataRecords()
    {
        if (CoreJsModule is null)
        {
            return ShowNoDataRecords;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ShowNoDataRecords;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "showNoDataRecords");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             ShowNoDataRecords = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ShowNoDataRecords)] = ShowNoDataRecords;
        }
         
        return ShowNoDataRecords;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the ReturnTopmostRaster property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetReturnTopmostRaster(bool value)
    {
#pragma warning disable BL0005
        ReturnTopmostRaster = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ReturnTopmostRaster)] = value;
        
        if (CoreJsModule is null)
        {
            return;
        }
    
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>("getJsComponent",
            CancellationTokenSource.Token, Id);
    
        if (JsComponentReference is null)
        {
            return;
        }
        
        await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
            JsComponentReference, "returnTopmostRaster", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ShowNoDataRecords property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetShowNoDataRecords(bool value)
    {
#pragma warning disable BL0005
        ShowNoDataRecords = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ShowNoDataRecords)] = value;
        
        if (CoreJsModule is null)
        {
            return;
        }
    
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>("getJsComponent",
            CancellationTokenSource.Token, Id);
    
        if (JsComponentReference is null)
        {
            return;
        }
        
        await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
            JsComponentReference, "showNoDataRecords", value);
    }
    
#endregion

}
