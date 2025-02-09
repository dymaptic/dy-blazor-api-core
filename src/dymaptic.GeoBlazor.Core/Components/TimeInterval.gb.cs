// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    TimeInterval is a class that describes a length of time in one of ten temporal units such as seconds, days, or years.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeInterval.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class TimeInterval
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public TimeInterval()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="unit">
    ///     Temporal units.
    ///     default milliseconds
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeInterval.html#unit">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="value">
    ///     The numerical value of the time extent.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeInterval.html#value">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public TimeInterval(
        TemporalTime unit,
        double value)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Unit = unit;
        Value = value;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Temporal units.
    ///     default milliseconds
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeInterval.html#unit">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TemporalTime? Unit { get; set; }
    
    /// <summary>
    ///     The numerical value of the time extent.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeInterval.html#value">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Value { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Unit property.
    /// </summary>
    public async Task<TemporalTime?> GetUnit()
    {
        if (CoreJsModule is null)
        {
            return Unit;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Unit;
        }

        // get the property value
        TemporalTime? result = await JsComponentReference!.InvokeAsync<TemporalTime?>("getProperty",
            CancellationTokenSource.Token, "unit");
        if (result is not null)
        {
#pragma warning disable BL0005
             Unit = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Unit)] = Unit;
        }
         
        return Unit;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Value property.
    /// </summary>
    public async Task<double?> GetValue()
    {
        if (CoreJsModule is null)
        {
            return Value;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Value;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "value");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Value = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Value)] = Value;
        }
         
        return Value;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Unit property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetUnit(TemporalTime value)
    {
#pragma warning disable BL0005
        Unit = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Unit)] = value;
        
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
            JsComponentReference, "unit", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Value property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetValue(double value)
    {
#pragma warning disable BL0005
        Value = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Value)] = value;
        
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
            JsComponentReference, "value", value);
    }
    
#endregion

}
