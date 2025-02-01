// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Defines a color stop used for creating a continuous color visualization in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-ColorVariable.html#stops">color visual variable</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class ColorStop
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public ColorStop()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="value">
    ///     Specifies the data value to map to the given <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html#color">color</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html#value">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="color">
    ///     The <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Color.html">Color</a> used to render features with the given <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html#value">value</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html#color">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="label">
    ///     A string value used to label the stop along the color ramp in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Legend.html">Legend</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html#label">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public ColorStop(
        double value,
        MapColor color,
        string? label = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Value = value;
        Color = color;
        Label = label;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Color.html">Color</a> used to render features with the given <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html#value">value</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-support-ColorStop.html#color">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [RequiredProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapColor Color { get; set; } = null!;
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Color property.
    /// </summary>
    public async Task<MapColor?> GetColor()
    {
        if (CoreJsModule is null)
        {
            return Color;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Color;
        }

        // get the property value
        MapColor? result = await CoreJsModule!.InvokeAsync<MapColor?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "color");
        if (result is not null)
        {
#pragma warning disable BL0005
             Color = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Color)] = Color;
        }
         
        return Color;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Label property.
    /// </summary>
    public async Task<string?> GetLabel()
    {
        if (CoreJsModule is null)
        {
            return Label;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Label;
        }

        // get the property value
        string? result = await CoreJsModule!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "label");
        if (result is not null)
        {
#pragma warning disable BL0005
             Label = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Label)] = Label;
        }
         
        return Label;
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
    ///    Asynchronously set the value of the Color property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetColor(MapColor value)
    {
#pragma warning disable BL0005
        Color = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Color)] = value;
        
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
            JsComponentReference, "color", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Label property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLabel(string value)
    {
#pragma warning disable BL0005
        Label = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Label)] = value;
        
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
            JsComponentReference, "label", value);
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




    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        if (Color is null)
        {
            throw new MissingRequiredChildElementException(nameof(ColorStop), nameof(Color));
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
