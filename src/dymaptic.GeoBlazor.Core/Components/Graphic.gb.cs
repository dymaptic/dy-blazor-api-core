// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    A Graphic is a vector representation of real world geographic phenomena.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class Graphic : IHitTestItem,
    IIntersectItem
{

#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Indicates whether the graphic refers to an aggregate, or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureReductionCluster.html">cluster</a> graphic.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html#isAggregate">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? IsAggregate { get; protected set; }
    
    /// <summary>
    ///     If applicable, references the layer in which the graphic is stored.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html#layer">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [AncestorPropertyReference]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Layer? Layer { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the AggregateGeometries property.
    /// </summary>
    public async Task<string?> GetAggregateGeometries()
    {
        if (CoreJsModule is null)
        {
            return AggregateGeometries;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return AggregateGeometries;
        }

        // get the property value
        string? result = await CoreJsModule!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "aggregateGeometries");
        if (result is not null)
        {
#pragma warning disable BL0005
             AggregateGeometries = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(AggregateGeometries)] = AggregateGeometries;
        }
         
        return AggregateGeometries;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the IsAggregate property.
    /// </summary>
    public async Task<bool?> GetIsAggregate()
    {
        if (CoreJsModule is null)
        {
            return IsAggregate;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return IsAggregate;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "isAggregate");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             IsAggregate = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(IsAggregate)] = IsAggregate;
        }
         
        return IsAggregate;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Origin property.
    /// </summary>
    public async Task<GraphicOrigin?> GetOrigin()
    {
        if (CoreJsModule is null)
        {
            return Origin;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Origin;
        }

        // get the property value
        GraphicOrigin? result = await CoreJsModule!.InvokeAsync<GraphicOrigin?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "origin");
        if (result is not null)
        {
#pragma warning disable BL0005
             Origin = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Origin)] = Origin;
        }
         
        return Origin;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the AggregateGeometries property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetAggregateGeometries(string value)
    {
#pragma warning disable BL0005
        AggregateGeometries = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(AggregateGeometries)] = value;
        
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
            JsComponentReference, "aggregateGeometries", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Origin property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetOrigin(GraphicOrigin value)
    {
#pragma warning disable BL0005
        Origin = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Origin)] = value;
        
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
            JsComponentReference, "origin", value);
    }
    
#endregion


#region Public Methods

    /// <summary>
    ///     Returns the value of the specified attribute.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html#getAttribute">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="name">
    ///     The name of the attribute.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> GetAttribute(string name)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "getAttribute", 
            CancellationTokenSource.Token,
            name);
    }
    
    /// <summary>
    ///     Returns the popup template applicable for the graphic.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html#getEffectivePopupTemplate">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="defaultPopupTemplateEnabled">
    ///     Whether support for default popup templates
    ///     is enabled. When true, a default popup template may be created automatically if neither
    ///     the graphic nor its layer have a popup template defined.
    /// </param>
    [ArcGISMethod]
    public async Task<PopupTemplate?> GetEffectivePopupTemplate(bool defaultPopupTemplateEnabled)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<PopupTemplate?>(
            "getEffectivePopupTemplate", 
            CancellationTokenSource.Token,
            defaultPopupTemplateEnabled);
    }
    
    /// <summary>
    ///     Returns the Object ID of the feature associated with the graphic, if it exists.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html#getObjectId">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public async Task<long?> GetObjectId()
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<long?>(
            "getObjectId", 
            CancellationTokenSource.Token);
    }
    
    /// <summary>
    ///     Sets a new value to the specified attribute.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html#setAttribute">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="name">
    ///     The name of the attribute to set.
    /// </param>
    /// <param name="newValue">
    ///     The new value to set on the named attribute.
    /// </param>
    [ArcGISMethod]
    public async Task SetAttribute(string name,
        string newValue)
    {
        if (JsComponentReference is null) return;
        
        await JsComponentReference!.InvokeVoidAsync(
            "setAttribute", 
            CancellationTokenSource.Token,
name,
            newValue);
    }
    
#endregion




    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case Layer layer:
                if (layer != Layer)
                {
                    Layer = layer;
                    
                    ModifiedParameters[nameof(Layer)] = Layer;
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
            case Layer _:
                Layer = null;
                
                ModifiedParameters[nameof(Layer)] = Layer;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        Layer?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
