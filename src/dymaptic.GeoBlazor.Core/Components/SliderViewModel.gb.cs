// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Provides the logic for the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider.html">Slider</a> widget.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class SliderViewModel : IViewModel
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public SliderViewModel()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="effectiveMax">
    ///     When set, the user is restricted from moving slider thumbs to positions higher than this value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#effectiveMax">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="effectiveMin">
    ///     When set, the user is restricted from moving slider thumbs to positions less than this value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#effectiveMin">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="inputFormatFunction">
    ///     A function used to format user inputs.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#inputFormatFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="inputParseFunction">
    ///     Function used to parse slider inputs formatted by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#inputFormatFunction">inputFormatFunction</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#inputParseFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="labelFormatFunction">
    ///     A function used to format labels.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#labelFormatFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="max">
    ///     The maximum possible data/thumb value of the slider.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#max">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="min">
    ///     The minimum possible data/thumb value of the slider.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#min">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="precision">
    ///     Defines how slider values should be rounded.
    ///     default 4
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#precision">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="thumbsConstrained">
    ///     When `false`, the user can freely move any slider thumb to any position along the track.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#thumbsConstrained">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="values">
    ///     An array of numbers representing absolute thumb positions on the slider.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#values">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public SliderViewModel(
        double? effectiveMax = null,
        double? effectiveMin = null,
        SliderLabelFormatter? inputFormatFunction = null,
        InputParser? inputParseFunction = null,
        SliderLabelFormatter? labelFormatFunction = null,
        double? max = null,
        double? min = null,
        double? precision = null,
        bool? thumbsConstrained = null,
        IReadOnlyList<double>? values = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        EffectiveMax = effectiveMax;
        EffectiveMin = effectiveMin;
        InputFormatFunction = inputFormatFunction;
        InputParseFunction = inputParseFunction;
        LabelFormatFunction = labelFormatFunction;
        Max = max;
        Min = min;
        Precision = precision;
        ThumbsConstrained = thumbsConstrained;
        Values = values;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     When set, the user is restricted from moving slider thumbs to positions higher than this value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#effectiveMax">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? EffectiveMax { get; set; }
    
    /// <summary>
    ///     When set, the user is restricted from moving slider thumbs to positions less than this value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#effectiveMin">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? EffectiveMin { get; set; }
    
    /// <summary>
    ///     A function used to format user inputs.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#inputFormatFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    public SliderLabelFormatter? InputFormatFunction { get; set; }
    
    /// <summary>
    ///     A convenience property that signifies whether a custom <see cref="InputFormatFunction" /> function was registered.
    /// </summary>
    public bool HasInputFormatFunction => InputFormatFunction is not null;
    
    /// <summary>
    ///     Function used to parse slider inputs formatted by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#inputFormatFunction">inputFormatFunction</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#inputParseFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    public InputParser? InputParseFunction { get; set; }
    
    /// <summary>
    ///     A convenience property that signifies whether a custom <see cref="InputParseFunction" /> function was registered.
    /// </summary>
    public bool HasInputParseFunction => InputParseFunction is not null;
    
    /// <summary>
    ///     A function used to format labels.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#labelFormatFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    public SliderLabelFormatter? LabelFormatFunction { get; set; }
    
    /// <summary>
    ///     A convenience property that signifies whether a custom <see cref="LabelFormatFunction" /> function was registered.
    /// </summary>
    public bool HasLabelFormatFunction => LabelFormatFunction is not null;
    
    /// <summary>
    ///     An array of strings associated with <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#values">values</a> generated using an internal label formatter or the values returned from <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#labelFormatFunction">labelFormatFunction</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#labels">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<string>? Labels { get; protected set; }
    
    /// <summary>
    ///     The maximum possible data/thumb value of the slider.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#max">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Max { get; set; }
    
    /// <summary>
    ///     The minimum possible data/thumb value of the slider.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#min">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Min { get; set; }
    
    /// <summary>
    ///     Defines how slider values should be rounded.
    ///     default 4
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#precision">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Precision { get; set; }
    
    /// <summary>
    ///     The state of the view model.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#state">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public State? State { get; protected set; }
    
    /// <summary>
    ///     When `false`, the user can freely move any slider thumb to any position along the track.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#thumbsConstrained">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ThumbsConstrained { get; set; }
    
    /// <summary>
    ///     An array of numbers representing absolute thumb positions on the slider.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#values">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<double>? Values { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the EffectiveMax property.
    /// </summary>
    public async Task<double?> GetEffectiveMax()
    {
        if (CoreJsModule is null)
        {
            return EffectiveMax;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return EffectiveMax;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "effectiveMax");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             EffectiveMax = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(EffectiveMax)] = EffectiveMax;
        }
         
        return EffectiveMax;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the EffectiveMin property.
    /// </summary>
    public async Task<double?> GetEffectiveMin()
    {
        if (CoreJsModule is null)
        {
            return EffectiveMin;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return EffectiveMin;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "effectiveMin");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             EffectiveMin = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(EffectiveMin)] = EffectiveMin;
        }
         
        return EffectiveMin;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Labels property.
    /// </summary>
    public async Task<IReadOnlyList<string>?> GetLabels()
    {
        if (CoreJsModule is null)
        {
            return Labels;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Labels;
        }

        // get the property value
        IReadOnlyList<string>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<string>?>("getProperty",
            CancellationTokenSource.Token, "labels");
        if (result is not null)
        {
#pragma warning disable BL0005
             Labels = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Labels)] = Labels;
        }
         
        return Labels;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Max property.
    /// </summary>
    public async Task<double?> GetMax()
    {
        if (CoreJsModule is null)
        {
            return Max;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Max;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "max");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Max = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Max)] = Max;
        }
         
        return Max;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Min property.
    /// </summary>
    public async Task<double?> GetMin()
    {
        if (CoreJsModule is null)
        {
            return Min;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Min;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "min");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Min = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Min)] = Min;
        }
         
        return Min;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Precision property.
    /// </summary>
    public async Task<double?> GetPrecision()
    {
        if (CoreJsModule is null)
        {
            return Precision;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Precision;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "precision");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Precision = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Precision)] = Precision;
        }
         
        return Precision;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the State property.
    /// </summary>
    public async Task<State?> GetState()
    {
        if (CoreJsModule is null)
        {
            return State;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return State;
        }

        // get the property value
        JsNullableEnumWrapper<State>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<State>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "state");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             State = (State)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(State)] = State;
        }
         
        return State;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ThumbsConstrained property.
    /// </summary>
    public async Task<bool?> GetThumbsConstrained()
    {
        if (CoreJsModule is null)
        {
            return ThumbsConstrained;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ThumbsConstrained;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "thumbsConstrained");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             ThumbsConstrained = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ThumbsConstrained)] = ThumbsConstrained;
        }
         
        return ThumbsConstrained;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Values property.
    /// </summary>
    public async Task<IReadOnlyList<double>?> GetValues()
    {
        if (CoreJsModule is null)
        {
            return Values;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Values;
        }

        // get the property value
        IReadOnlyList<double>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<double>?>("getProperty",
            CancellationTokenSource.Token, "values");
        if (result is not null)
        {
#pragma warning disable BL0005
             Values = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Values)] = Values;
        }
         
        return Values;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the EffectiveMax property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetEffectiveMax(double? value)
    {
#pragma warning disable BL0005
        EffectiveMax = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(EffectiveMax)] = value;
        
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
            JsComponentReference, "effectiveMax", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the EffectiveMin property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetEffectiveMin(double? value)
    {
#pragma warning disable BL0005
        EffectiveMin = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(EffectiveMin)] = value;
        
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
            JsComponentReference, "effectiveMin", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Max property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMax(double? value)
    {
#pragma warning disable BL0005
        Max = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Max)] = value;
        
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
            JsComponentReference, "max", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Min property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMin(double? value)
    {
#pragma warning disable BL0005
        Min = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Min)] = value;
        
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
            JsComponentReference, "min", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Precision property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPrecision(double? value)
    {
#pragma warning disable BL0005
        Precision = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Precision)] = value;
        
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
            JsComponentReference, "precision", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ThumbsConstrained property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetThumbsConstrained(bool? value)
    {
#pragma warning disable BL0005
        ThumbsConstrained = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ThumbsConstrained)] = value;
        
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
            JsComponentReference, "thumbsConstrained", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Values property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetValues(IReadOnlyList<double>? value)
    {
#pragma warning disable BL0005
        Values = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Values)] = value;
        
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
            JsComponentReference, "values", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the Values property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToValues(params double[] values)
    {
        double[] join = Values is null
            ? values
            : [..Values, ..values];
        await SetValues(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the Values property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromValues(params double[] values)
    {
        if (Values is null)
        {
            return;
        }
        await SetValues(Values.Except(values).ToArray());
    }
    
#endregion

#region Public Methods

    /// <summary>
    ///     The default input format function available for use as a fallback in custom formatting implementations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#defaultInputFormatFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="value">
    ///     The input value to format.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> DefaultInputFormatFunction(double value)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "defaultInputFormatFunction", 
            CancellationTokenSource.Token,
            value);
    }
    
    /// <summary>
    ///     The default input parsing function available for use as a fallback in custom parsing implementations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#defaultInputParseFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="value">
    ///     The thumb value to parse.
    /// </param>
    [ArcGISMethod]
    public async Task<double?> DefaultInputParseFunction(string value)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<double?>(
            "defaultInputParseFunction", 
            CancellationTokenSource.Token,
            value);
    }
    
    /// <summary>
    ///     The default label format function, available for use as a fallback in custom formatting implementations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#defaultLabelFormatFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="value">
    ///     The thumb value to format.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> DefaultLabelFormatFunction(double value)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "defaultLabelFormatFunction", 
            CancellationTokenSource.Token,
            value);
    }
    
    /// <summary>
    ///     Returns the effective bounds of the slider.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#getBounds">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public async Task<Bounds?> GetBounds()
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Bounds?>(
            "getBounds", 
            CancellationTokenSource.Token);
    }
    
    /// <summary>
    ///     Returns the min and max bounds for a 'value' at the provided index.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#getBoundsForValueAtIndex">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="index">
    ///     The index of the associated value.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> GetBoundsForValueAtIndex(int index)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "getBoundsForValueAtIndex", 
            CancellationTokenSource.Token,
            index);
    }
    
    /// <summary>
    ///     Returns the formatted label for a provided value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#getLabelForValue">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="value">
    ///     The value from which to retrieve a formatted label.
    /// </param>
    /// <param name="type">
    ///     The label type.
    /// </param>
    /// <param name="index">
    ///     The index of the label.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> GetLabelForValue(double value,
        SliderViewModelType type,
        int index)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "getLabelForValue", 
            CancellationTokenSource.Token,
            value,
            type,
            index);
    }
    
    /// <summary>
    ///     Updates a thumb <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#values">value</a> based on the provided index.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#setValue">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="index">
    ///     The index of the thumb value in the associated <a href="#values">values</a> array.
    /// </param>
    /// <param name="value">
    ///     The new value to replace with the old value.
    /// </param>
    [ArcGISMethod]
    public async Task SetValue(int index,
        double value)
    {
        if (JsComponentReference is null) return;
        
        await JsComponentReference!.InvokeVoidAsync(
            "setValue", 
            CancellationTokenSource.Token,
index,
            value);
    }
    
    /// <summary>
    ///     Rounds the given value to the number of decimal places specified in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#precision">precision</a> property set on the view model.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Slider-SliderViewModel.html#toPrecision">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="value">
    ///     The thumb value to format.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> ToPrecision(double value)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "toPrecision", 
            CancellationTokenSource.Token,
            value);
    }
    
#endregion

}
