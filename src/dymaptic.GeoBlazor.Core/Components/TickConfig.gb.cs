// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Object specification for configuring ticks on the slider.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class TickConfig
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public TickConfig()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="mode">
    ///     The mode or method of positioning ticks along the slider track.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="doubleCollectionValues">
    ///     Indicates where ticks will be rendered below the track.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="doubleValues">
    ///     Indicates where ticks will be rendered below the track.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="labelFormatFunction">
    ///     Callback for formatting tick labels.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="labelsVisible">
    ///     Indicates whether to render labels for the ticks.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="tickCreatedFunction">
    ///     Callback that fires for each tick.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public TickConfig(
        TickConfigMode mode,
        IReadOnlyList<double>? doubleCollectionValues = null,
        double? doubleValues = null,
        SliderLabelFormatter? labelFormatFunction = null,
        bool? labelsVisible = null,
        TickCreatedFunction? tickCreatedFunction = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Mode = mode;
        DoubleCollectionValues = doubleCollectionValues;
        DoubleValues = doubleValues;
        LabelFormatFunction = labelFormatFunction;
        LabelsVisible = labelsVisible;
        TickCreatedFunction = tickCreatedFunction;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Indicates where ticks will be rendered below the track.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<double>? DoubleCollectionValues { get; set; }
    
    /// <summary>
    ///     Indicates where ticks will be rendered below the track.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? DoubleValues { get; set; }
    
    /// <summary>
    ///     Callback for formatting tick labels.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    public SliderLabelFormatter? LabelFormatFunction { get; set; }
    
    /// <summary>
    ///     A convenience property that signifies whether a custom <see cref="LabelFormatFunction" /> function was registered.
    /// </summary>
    public bool HasLabelFormatFunction => LabelFormatFunction is not null;
    /// <summary>
    ///     Callback that fires for each tick.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html#TickConfig">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore]
    public TickCreatedFunction? TickCreatedFunction { get; set; }
    
    /// <summary>
    ///    JS-invokable method that triggers the <see cref="TickCreatedFunction"/> function.
    ///     Should not be called by consuming code.
    /// </summary>
    [JSInvokable]
    public async Task OnJsTickCreatedFunction(double value,
        ElementReference tickElement,
        ElementReference labelElement)
    {
        if (TickCreatedFunction is not null)
        {
            await TickCreatedFunction.Invoke(value,
                tickElement,
                labelElement);
        }
    }
    /// <summary>
    ///     A convenience property that signifies whether a custom <see cref="TickCreatedFunction" /> function was registered.
    /// </summary>
    public bool HasTickCreatedFunction => TickCreatedFunction is not null;
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the DoubleCollectionValues property.
    /// </summary>
    public async Task<IReadOnlyList<double>?> GetDoubleCollectionValues()
    {
        if (CoreJsModule is null)
        {
            return DoubleCollectionValues;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DoubleCollectionValues;
        }

        // get the property value
        IReadOnlyList<double>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<double>?>("getProperty",
            CancellationTokenSource.Token, "doubleCollectionValues");
        if (result is not null)
        {
#pragma warning disable BL0005
             DoubleCollectionValues = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DoubleCollectionValues)] = DoubleCollectionValues;
        }
         
        return DoubleCollectionValues;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the DoubleValues property.
    /// </summary>
    public async Task<double?> GetDoubleValues()
    {
        if (CoreJsModule is null)
        {
            return DoubleValues;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DoubleValues;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "doubleValues");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             DoubleValues = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DoubleValues)] = DoubleValues;
        }
         
        return DoubleValues;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the LabelsVisible property.
    /// </summary>
    public async Task<bool?> GetLabelsVisible()
    {
        if (CoreJsModule is null)
        {
            return LabelsVisible;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return LabelsVisible;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "labelsVisible");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             LabelsVisible = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(LabelsVisible)] = LabelsVisible;
        }
         
        return LabelsVisible;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Mode property.
    /// </summary>
    public async Task<TickConfigMode?> GetMode()
    {
        if (CoreJsModule is null)
        {
            return Mode;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Mode;
        }

        // get the property value
        JsNullableEnumWrapper<TickConfigMode>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<TickConfigMode>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "mode");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Mode = (TickConfigMode)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Mode)] = Mode;
        }
         
        return Mode;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the DoubleCollectionValues property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDoubleCollectionValues(IReadOnlyList<double>? value)
    {
#pragma warning disable BL0005
        DoubleCollectionValues = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DoubleCollectionValues)] = value;
        
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
            JsComponentReference, "doubleCollectionValues", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the DoubleValues property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDoubleValues(double? value)
    {
#pragma warning disable BL0005
        DoubleValues = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DoubleValues)] = value;
        
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
            JsComponentReference, "doubleValues", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the LabelsVisible property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLabelsVisible(bool? value)
    {
#pragma warning disable BL0005
        LabelsVisible = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(LabelsVisible)] = value;
        
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
            JsComponentReference, "labelsVisible", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Mode property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMode(TickConfigMode value)
    {
#pragma warning disable BL0005
        Mode = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Mode)] = value;
        
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
            JsComponentReference, "mode", value);
    }
    
#endregion

}
