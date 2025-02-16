// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    The color visual variable is used to visualize features along a continuous color ramp based on the values of a numeric attribute <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-ColorVariable.html#field">field</a> or an <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-ColorVariable.html#valueExpression">expression</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-ColorVariable.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class ColorVariable : IColorSizeSliderUpdateVisualVariables,
    IColorSizeSliderVariables
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public ColorVariable()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="field">
    ///     The name of the numeric attribute field that contains the data values used to determine the color/opacity/size/rotation of each feature.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#field">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="normalizationField">
    ///     Name of the numeric attribute field by which to normalize the data.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-ColorVariable.html#normalizationField">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="stops">
    ///     An array of sequential objects, or stops, that defines a continuous color ramp.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-ColorVariable.html#stops">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="legendOptions">
    ///     An object providing options for displaying the visual variable in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Legend.html">Legend</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#legendOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="valueExpression">
    ///     An <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/">Arcade</a> expression following the specification defined by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/#visualization">Arcade Visualization Profile</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#valueExpression">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="valueExpressionTitle">
    ///     The title identifying and describing the associated <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/">Arcade</a> expression as defined in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#valueExpression">valueExpression</a> property.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#valueExpressionTitle">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public ColorVariable(
        string field,
        string? normalizationField = null,
        IReadOnlyList<ColorStop>? stops = null,
        VisualVariableLegendOptions? legendOptions = null,
        string? valueExpression = null,
        string? valueExpressionTitle = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Field = field;
        NormalizationField = normalizationField;
        Stops = stops;
        LegendOptions = legendOptions;
        ValueExpression = valueExpression;
        ValueExpressionTitle = valueExpressionTitle;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     An array of sequential objects, or stops, that defines a continuous color ramp.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-ColorVariable.html#stops">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<ColorStop>? Stops { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the NormalizationField property.
    /// </summary>
    public async Task<string?> GetNormalizationField()
    {
        if (CoreJsModule is null)
        {
            return NormalizationField;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return NormalizationField;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "normalizationField");
        if (result is not null)
        {
#pragma warning disable BL0005
             NormalizationField = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(NormalizationField)] = NormalizationField;
        }
         
        return NormalizationField;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Stops property.
    /// </summary>
    public async Task<IReadOnlyList<ColorStop>?> GetStops()
    {
        if (CoreJsModule is null)
        {
            return Stops;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Stops;
        }

        // get the property value
        IReadOnlyList<ColorStop>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<ColorStop>?>("getProperty",
            CancellationTokenSource.Token, "stops");
        if (result is not null)
        {
#pragma warning disable BL0005
             Stops = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Stops)] = Stops;
        }
         
        return Stops;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the NormalizationField property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetNormalizationField(string? value)
    {
#pragma warning disable BL0005
        NormalizationField = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(NormalizationField)] = value;
        
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
            JsComponentReference, "normalizationField", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Stops property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetStops(IReadOnlyList<ColorStop>? value)
    {
#pragma warning disable BL0005
        Stops = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Stops)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setStops", 
            CancellationTokenSource.Token, value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the Stops property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToStops(params ColorStop[] values)
    {
        ColorStop[] join = Stops is null
            ? values
            : [..Stops, ..values];
        await SetStops(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the Stops property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromStops(params ColorStop[] values)
    {
        if (Stops is null)
        {
            return;
        }
        await SetStops(Stops.Except(values).ToArray());
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case ColorStop stops:
                Stops ??= [];
                if (!Stops.Contains(stops))
                {
                    Stops = [..Stops, stops];
                    
                    ModifiedParameters[nameof(Stops)] = Stops;
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
            case ColorStop stops:
                Stops = Stops?.Where(s => s != stops).ToList();
                
                ModifiedParameters[nameof(Stops)] = Stops;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
    
        if (Stops is not null)
        {
            foreach (ColorStop child in Stops)
            {
                child.ValidateRequiredGeneratedChildren();
            }
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
