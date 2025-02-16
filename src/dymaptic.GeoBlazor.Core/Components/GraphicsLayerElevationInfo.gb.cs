// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Specifies how graphics are placed on the vertical axis (z).
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GraphicsLayer.html#elevationInfo">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class GraphicsLayerElevationInfo : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public GraphicsLayerElevationInfo()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="featureExpressionInfo">
    ///     Defines how to override a feature's Z-value based on its attributes.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GraphicsLayer.html#elevationInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="mode">
    ///     Defines how the feature is placed with respect to the terrain surface or 3D objects in the scene.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GraphicsLayer.html#elevationInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="offset">
    ///     An elevation offset, which is added to the vertical position of the graphic.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GraphicsLayer.html#elevationInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="unit">
    ///     The unit for `featureExpressionInfo` and `offset` values.
    ///     <a target="_blank" href="global.html#unit">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public GraphicsLayerElevationInfo(
        GraphicsLayerElevationInfoFeatureExpressionInfo? featureExpressionInfo = null,
        ElevationInfoMode? mode = null,
        double? offset = null,
        ElevationUnit? unit = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        FeatureExpressionInfo = featureExpressionInfo;
        Mode = mode;
        Offset = offset;
        Unit = unit;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Defines how to override a feature's Z-value based on its attributes.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GraphicsLayer.html#elevationInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public GraphicsLayerElevationInfoFeatureExpressionInfo? FeatureExpressionInfo { get; set; }
    
    /// <summary>
    ///     Defines how the feature is placed with respect to the terrain surface or 3D objects in the scene.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GraphicsLayer.html#elevationInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ElevationInfoMode? Mode { get; set; }
    
    /// <summary>
    ///     An elevation offset, which is added to the vertical position of the graphic.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GraphicsLayer.html#elevationInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Offset { get; set; }
    
    /// <summary>
    ///     The unit for `featureExpressionInfo` and `offset` values.
    ///     <a target="_blank" href="global.html#unit">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ElevationUnit? Unit { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the FeatureExpressionInfo property.
    /// </summary>
    public async Task<GraphicsLayerElevationInfoFeatureExpressionInfo?> GetFeatureExpressionInfo()
    {
        if (CoreJsModule is null)
        {
            return FeatureExpressionInfo;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return FeatureExpressionInfo;
        }

        // get the property value
        GraphicsLayerElevationInfoFeatureExpressionInfo? result = await JsComponentReference!.InvokeAsync<GraphicsLayerElevationInfoFeatureExpressionInfo?>("getProperty",
            CancellationTokenSource.Token, "featureExpressionInfo");
        if (result is not null)
        {
#pragma warning disable BL0005
             FeatureExpressionInfo = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(FeatureExpressionInfo)] = FeatureExpressionInfo;
        }
         
        return FeatureExpressionInfo;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Mode property.
    /// </summary>
    public async Task<ElevationInfoMode?> GetMode()
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
        JsNullableEnumWrapper<ElevationInfoMode>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<ElevationInfoMode>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "mode");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Mode = (ElevationInfoMode)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Mode)] = Mode;
        }
         
        return Mode;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Offset property.
    /// </summary>
    public async Task<double?> GetOffset()
    {
        if (CoreJsModule is null)
        {
            return Offset;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Offset;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "offset");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Offset = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Offset)] = Offset;
        }
         
        return Offset;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Unit property.
    /// </summary>
    public async Task<ElevationUnit?> GetUnit()
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
        JsNullableEnumWrapper<ElevationUnit>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<ElevationUnit>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "unit");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Unit = (ElevationUnit)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Unit)] = Unit;
        }
         
        return Unit;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the FeatureExpressionInfo property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetFeatureExpressionInfo(GraphicsLayerElevationInfoFeatureExpressionInfo? value)
    {
#pragma warning disable BL0005
        FeatureExpressionInfo = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(FeatureExpressionInfo)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setFeatureExpressionInfo", 
            CancellationTokenSource.Token, value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Mode property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMode(ElevationInfoMode? value)
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
    
    /// <summary>
    ///    Asynchronously set the value of the Offset property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetOffset(double? value)
    {
#pragma warning disable BL0005
        Offset = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Offset)] = value;
        
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
            JsComponentReference, "offset", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Unit property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetUnit(ElevationUnit? value)
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
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case GraphicsLayerElevationInfoFeatureExpressionInfo featureExpressionInfo:
                if (featureExpressionInfo != FeatureExpressionInfo)
                {
                    FeatureExpressionInfo = featureExpressionInfo;
                    
                    ModifiedParameters[nameof(FeatureExpressionInfo)] = FeatureExpressionInfo;
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
            case GraphicsLayerElevationInfoFeatureExpressionInfo _:
                FeatureExpressionInfo = null;
                
                ModifiedParameters[nameof(FeatureExpressionInfo)] = FeatureExpressionInfo;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
    
        FeatureExpressionInfo?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
