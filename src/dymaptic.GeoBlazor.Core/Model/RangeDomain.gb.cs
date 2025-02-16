// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;


/// <summary>
///    Range domains specify a valid <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RangeDomain.html#minValue">minimum</a> and <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RangeDomain.html#maxValue">maximum</a> valid value that can be stored in numeric and date <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#type">fields</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RangeDomain.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class RangeDomain : IFieldColumnTemplateDomain,
    IFieldInputDomain
{

#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The maximum valid value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RangeDomain.html#maxValue">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MaxValue { get; set; }
    
    /// <summary>
    ///     The minimum valid value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RangeDomain.html#minValue">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MinValue { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the MaxValue property.
    /// </summary>
    public async Task<string?> GetMaxValue()
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
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "maxValue");
        if (result is not null)
        {
#pragma warning disable BL0005
             MaxValue = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MaxValue)] = MaxValue;
        }
         
        return MaxValue;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MinValue property.
    /// </summary>
    public async Task<string?> GetMinValue()
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
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "minValue");
        if (result is not null)
        {
#pragma warning disable BL0005
             MinValue = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MinValue)] = MinValue;
        }
         
        return MinValue;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the MaxValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMaxValue(string? value)
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
    public async Task SetMinValue(string? value)
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
    
#endregion

}
