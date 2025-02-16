// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Defines the categories of a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-UniqueValueRenderer.html">UniqueValueRenderer</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class UniqueValueInfo
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public UniqueValueInfo()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="label">
    ///     Describes the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#value">value</a> represented by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#symbol">symbol</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#label">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="symbol">
    ///     Defines the symbol used to render features with the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#value">value</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#symbol">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="value">
    ///     Features with this value will be rendered with the given <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#symbol">symbol</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#value">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public UniqueValueInfo(
        string? label = null,
        Symbol? symbol = null,
        string? value = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Label = label;
        Symbol = symbol;
        Value = value;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Defines the symbol used to render features with the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#value">value</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-UniqueValueInfo.html#symbol">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Symbol? Symbol { get; set; }
    
#endregion

#region Property Getters

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
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "label");
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
    public async Task<string?> GetValue()
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
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "value");
        if (result is not null)
        {
#pragma warning disable BL0005
             Value = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Value)] = Value;
        }
         
        return Value;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Label property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLabel(string? value)
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
    public async Task SetValue(string? value)
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


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case Symbol symbol:
                if (symbol != Symbol)
                {
                    Symbol = symbol;
                    
                    ModifiedParameters[nameof(Symbol)] = Symbol;
                }
                
                return true;
            default:
                return await base.RegisterGeneratedChildComponent(child);
        }
    }

    protected override async ValueTask<bool> UnregisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case Symbol _:
                Symbol = null;
                
                ModifiedParameters[nameof(Symbol)] = Symbol;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
    
        Symbol?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
