// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    An array of objects containing numeric statistical properties.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#statistics">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class PixelBlockStatistics : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public PixelBlockStatistics()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="maxValue">
    ///     The maximum pixel value in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#pixels">pixels</a> array.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#statistics">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="minValue">
    ///     The minimum pixel value in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#pixels">pixels</a> array.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#statistics">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="noDataValue">
    ///     Value representing areas of no data.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#statistics">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public PixelBlockStatistics(
        double? maxValue = null,
        double? minValue = null,
        double? noDataValue = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        MaxValue = maxValue;
        MinValue = minValue;
        NoDataValue = noDataValue;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The maximum pixel value in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#pixels">pixels</a> array.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#statistics">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MaxValue { get; set; }
    
    /// <summary>
    ///     The minimum pixel value in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#pixels">pixels</a> array.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#statistics">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MinValue { get; set; }
    
    /// <summary>
    ///     Value representing areas of no data.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#statistics">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? NoDataValue { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the MaxValue property.
    /// </summary>
    public async Task<double?> GetMaxValue()
    {
        if (CoreJsModule is null)
        {
            return MaxValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MaxValue;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "maxValue");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             MaxValue = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MaxValue)] = MaxValue;
        }
         
        return MaxValue;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MinValue property.
    /// </summary>
    public async Task<double?> GetMinValue()
    {
        if (CoreJsModule is null)
        {
            return MinValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MinValue;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "minValue");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             MinValue = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MinValue)] = MinValue;
        }
         
        return MinValue;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the NoDataValue property.
    /// </summary>
    public async Task<double?> GetNoDataValue()
    {
        if (CoreJsModule is null)
        {
            return NoDataValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return NoDataValue;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "noDataValue");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             NoDataValue = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(NoDataValue)] = NoDataValue;
        }
         
        return NoDataValue;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the MaxValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMaxValue(double? value)
    {
#pragma warning disable BL0005
        MaxValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MaxValue)] = value;
        
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
            JsComponentReference, "maxValue", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the MinValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMinValue(double? value)
    {
#pragma warning disable BL0005
        MinValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MinValue)] = value;
        
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
            JsComponentReference, "minValue", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the NoDataValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetNoDataValue(double? value)
    {
#pragma warning disable BL0005
        NoDataValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(NoDataValue)] = value;
        
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
            JsComponentReference, "noDataValue", value);
    }
    
#endregion

}
