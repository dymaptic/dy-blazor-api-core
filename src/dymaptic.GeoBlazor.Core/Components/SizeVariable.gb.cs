// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    The size visual variable defines the size of individual features in a layer based on a numeric (often thematic) value.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class SizeVariable : IColorSizeSliderUpdateVisualVariables,
    IColorSizeSliderVariables
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public SizeVariable()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="field">
    ///     The name of the numeric attribute field that contains the data values used to determine the color/opacity/size/rotation of each feature.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#field">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="minSize">
    ///     The size used to render a feature containing the minimum data value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#minSize">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="maxSize">
    ///     The size used to render a feature containing the maximum data value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#maxSize">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="minDataValue">
    ///     The minimum data value used in the size ramp.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#minDataValue">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="maxDataValue">
    ///     The maximum data value used in the size ramp.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#maxDataValue">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="valueRepresentation">
    ///     Specifies how to apply the data value when mapping real-world sizes.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#valueRepresentation">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="valueUnit">
    ///     Indicates the unit of measurement used to interpret the value returned by <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#field">field</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#valueExpression">valueExpression</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#valueUnit">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="normalizationField">
    ///     The name of the numeric attribute field used to normalize the data in the given <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#field">field</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#normalizationField">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="target">
    ///     This value must be `outline` when scaling polygon outline widths based on the view scale.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#target">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="useSymbolValue">
    ///     When setting a size visual variable on a renderer using an <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-symbols-ObjectSymbol3DLayer.html">ObjectSymbol3DLayer</a>, this property indicates whether to apply the value defined by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-symbols-ObjectSymbol3DLayer.html#height">height</a>, <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-symbols-ObjectSymbol3DLayer.html#width">width</a>, or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-symbols-ObjectSymbol3DLayer.html#depth">depth</a> properties to the corresponding <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#axis">axis</a> of this visual variable instead of proportionally scaling this axis' value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#useSymbolValue">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="axis">
    ///     Only applicable when working in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-SceneView.html">SceneView</a>.
    ///     default all
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#axis">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="valueExpression">
    ///     An <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/">Arcade</a> expression following the specification defined by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/#visualization">Arcade Visualization Profile</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#valueExpression">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="valueExpressionTitle">
    ///     The title identifying and describing the associated <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/">Arcade</a> expression as defined in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#valueExpression">valueExpression</a> property.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#valueExpressionTitle">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="legendOptions">
    ///     An object providing options for displaying the visual variable in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Legend.html">Legend</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-VisualVariable.html#legendOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="stops">
    ///     An array of objects that defines the mapping of data values returned from <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#field">field</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#valueExpression">valueExpression</a> to icon sizes.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#stops">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public SizeVariable(
        string field,
        Dimension? minSize = null,
        Dimension? maxSize = null,
        double? minDataValue = null,
        double? maxDataValue = null,
        VisualValueRepresentation? valueRepresentation = null,
        VisualValueUnit? valueUnit = null,
        string? normalizationField = null,
        string? target = null,
        bool? useSymbolValue = null,
        VisualAxis? axis = null,
        string? valueExpression = null,
        string? valueExpressionTitle = null,
        VisualVariableLegendOptions? legendOptions = null,
        IReadOnlyList<SizeStop>? stops = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Field = field;
        MinSize = minSize;
        MaxSize = maxSize;
        MinDataValue = minDataValue;
        MaxDataValue = maxDataValue;
        ValueRepresentation = valueRepresentation;
        ValueUnit = valueUnit;
        NormalizationField = normalizationField;
        Target = target;
        UseSymbolValue = useSymbolValue;
        Axis = axis;
        ValueExpression = valueExpression;
        ValueExpressionTitle = valueExpressionTitle;
        LegendOptions = legendOptions;
        Stops = stops;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     An array of objects that defines the mapping of data values returned from <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#field">field</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#valueExpression">valueExpression</a> to icon sizes.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#stops">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<SizeStop>? Stops { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Axis property.
    /// </summary>
    public async Task<VisualAxis?> GetAxis()
    {
        if (CoreJsModule is null)
        {
            return Axis;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Axis;
        }

        // get the property value
        VisualAxis? result = await JsComponentReference!.InvokeAsync<VisualAxis?>("getProperty",
            CancellationTokenSource.Token, "axis");
        if (result is not null)
        {
#pragma warning disable BL0005
             Axis = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Axis)] = Axis;
        }
         
        return Axis;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MaxDataValue property.
    /// </summary>
    public async Task<double?> GetMaxDataValue()
    {
        if (CoreJsModule is null)
        {
            return MaxDataValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MaxDataValue;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "maxDataValue");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             MaxDataValue = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MaxDataValue)] = MaxDataValue;
        }
         
        return MaxDataValue;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MaxSize property.
    /// </summary>
    public async Task<Dimension?> GetMaxSize()
    {
        if (CoreJsModule is null)
        {
            return MaxSize;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MaxSize;
        }

        // get the property value
        Dimension? result = await JsComponentReference!.InvokeAsync<Dimension?>("getProperty",
            CancellationTokenSource.Token, "maxSize");
        if (result is not null)
        {
#pragma warning disable BL0005
             MaxSize = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MaxSize)] = MaxSize;
        }
         
        return MaxSize;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MinDataValue property.
    /// </summary>
    public async Task<double?> GetMinDataValue()
    {
        if (CoreJsModule is null)
        {
            return MinDataValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MinDataValue;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "minDataValue");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             MinDataValue = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MinDataValue)] = MinDataValue;
        }
         
        return MinDataValue;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MinSize property.
    /// </summary>
    public async Task<Dimension?> GetMinSize()
    {
        if (CoreJsModule is null)
        {
            return MinSize;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MinSize;
        }

        // get the property value
        Dimension? result = await JsComponentReference!.InvokeAsync<Dimension?>("getProperty",
            CancellationTokenSource.Token, "minSize");
        if (result is not null)
        {
#pragma warning disable BL0005
             MinSize = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MinSize)] = MinSize;
        }
         
        return MinSize;
    }
    
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
    public async Task<IReadOnlyList<SizeStop>?> GetStops()
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
        IReadOnlyList<SizeStop>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<SizeStop>?>("getProperty",
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
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Target property.
    /// </summary>
    public async Task<string?> GetTarget()
    {
        if (CoreJsModule is null)
        {
            return Target;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Target;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "target");
        if (result is not null)
        {
#pragma warning disable BL0005
             Target = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Target)] = Target;
        }
         
        return Target;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the UseSymbolValue property.
    /// </summary>
    public async Task<bool?> GetUseSymbolValue()
    {
        if (CoreJsModule is null)
        {
            return UseSymbolValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return UseSymbolValue;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "useSymbolValue");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             UseSymbolValue = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(UseSymbolValue)] = UseSymbolValue;
        }
         
        return UseSymbolValue;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ValueRepresentation property.
    /// </summary>
    public async Task<VisualValueRepresentation?> GetValueRepresentation()
    {
        if (CoreJsModule is null)
        {
            return ValueRepresentation;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ValueRepresentation;
        }

        // get the property value
        VisualValueRepresentation? result = await JsComponentReference!.InvokeAsync<VisualValueRepresentation?>("getProperty",
            CancellationTokenSource.Token, "valueRepresentation");
        if (result is not null)
        {
#pragma warning disable BL0005
             ValueRepresentation = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ValueRepresentation)] = ValueRepresentation;
        }
         
        return ValueRepresentation;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ValueUnit property.
    /// </summary>
    public async Task<VisualValueUnit?> GetValueUnit()
    {
        if (CoreJsModule is null)
        {
            return ValueUnit;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ValueUnit;
        }

        // get the property value
        VisualValueUnit? result = await JsComponentReference!.InvokeAsync<VisualValueUnit?>("getProperty",
            CancellationTokenSource.Token, "valueUnit");
        if (result is not null)
        {
#pragma warning disable BL0005
             ValueUnit = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ValueUnit)] = ValueUnit;
        }
         
        return ValueUnit;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Axis property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetAxis(VisualAxis value)
    {
#pragma warning disable BL0005
        Axis = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Axis)] = value;
        
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
            JsComponentReference, "axis", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the MaxDataValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMaxDataValue(double value)
    {
#pragma warning disable BL0005
        MaxDataValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MaxDataValue)] = value;
        
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
            JsComponentReference, "maxDataValue", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the MaxSize property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMaxSize(Dimension value)
    {
#pragma warning disable BL0005
        MaxSize = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MaxSize)] = value;
        
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
            JsComponentReference, "maxSize", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the MinDataValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMinDataValue(double value)
    {
#pragma warning disable BL0005
        MinDataValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MinDataValue)] = value;
        
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
            JsComponentReference, "minDataValue", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the MinSize property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMinSize(Dimension value)
    {
#pragma warning disable BL0005
        MinSize = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MinSize)] = value;
        
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
            JsComponentReference, "minSize", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the NormalizationField property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetNormalizationField(string value)
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
    public async Task SetStops(IReadOnlyList<SizeStop> value)
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
        
        await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
            JsComponentReference, "stops", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Target property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTarget(string value)
    {
#pragma warning disable BL0005
        Target = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Target)] = value;
        
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
            JsComponentReference, "target", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the UseSymbolValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetUseSymbolValue(bool value)
    {
#pragma warning disable BL0005
        UseSymbolValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(UseSymbolValue)] = value;
        
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
            JsComponentReference, "useSymbolValue", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ValueRepresentation property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetValueRepresentation(VisualValueRepresentation value)
    {
#pragma warning disable BL0005
        ValueRepresentation = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ValueRepresentation)] = value;
        
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
            JsComponentReference, "valueRepresentation", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ValueUnit property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetValueUnit(VisualValueUnit value)
    {
#pragma warning disable BL0005
        ValueUnit = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ValueUnit)] = value;
        
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
            JsComponentReference, "valueUnit", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the Stops property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToStops(params SizeStop[] values)
    {
        SizeStop[] join = Stops is null
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
    public async Task RemoveFromStops(params SizeStop[] values)
    {
        if (Stops is null)
        {
            return;
        }
        await SetStops(Stops.Except(values).ToArray());
    }
    
#endregion

#region Public Methods

    /// <summary>
    ///     Modifies the SizeVariable in place by flipping the sizes in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#stops">stops</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-visualVariables-SizeVariable.html#flipSizes">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public async Task FlipSizes()
    {
        if (JsComponentReference is null) return;
        
        await JsComponentReference!.InvokeVoidAsync(
            "flipSizes", 
            CancellationTokenSource.Token);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case SizeStop stops:
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
            case SizeStop stops:
                Stops = Stops?.Where(s => s != stops).ToList();
                
                ModifiedParameters[nameof(Stops)] = Stops;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        if (Stops is not null)
        {
            foreach (SizeStop child in Stops)
            {
                child.ValidateRequiredGeneratedChildren();
            }
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
