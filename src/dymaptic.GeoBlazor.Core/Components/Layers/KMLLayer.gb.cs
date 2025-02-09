// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Layers;


/// <summary>
///    The KMLLayer class is used to create a layer based on a KML file (.kml, .kmz).
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-KMLLayer.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class KMLLayer : IBlendLayer,
    IOperationalLayer,
    IPortalLayer,
    IScaleRangeLayer
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public KMLLayer()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="url">
    ///     The publicly accessible URL for a .kml or .kmz file.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-KMLLayer.html#url">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="portalItem">
    ///     The portal item from which the layer is loaded.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-PortalLayer.html#portalItem">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="blendMode">
    ///     Blend modes are used to blend layers together to create an interesting effect in a layer, or even to produce what seems like a new layer.
    ///     default normal
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-BlendLayer.html#blendMode">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="effect">
    ///     Effect provides various filter functions that can be performed on the layer to achieve different visual effects similar to how image filters work.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-BlendLayer.html#effect">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="fullExtent">
    ///     The full extent of the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#fullExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="listMode">
    ///     Indicates how the layer should display in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html">LayerList</a> widget.
    ///     default "show"
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#listMode">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="maxScale">
    ///     The maximum scale (most zoomed in) at which the layer is visible in the view.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ScaleRangeLayer.html#maxScale">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="minScale">
    ///     The minimum scale (most zoomed out) at which the layer is visible in the view.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ScaleRangeLayer.html#minScale">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="opacity">
    ///     The opacity of the layer.
    ///     default 1
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#opacity">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="persistenceEnabled">
    ///     When `true`, the layer can be persisted.
    ///     default false
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#persistenceEnabled">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="sublayers">
    ///     A collection of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-KMLSublayer.html">KMLSublayer</a>s.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-KMLLayer.html#sublayers">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="title">
    ///     The title of the layer used to identify it in places such as the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html">LayerList</a> widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-KMLLayer.html#title">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="visibilityTimeExtent">
    ///     Specifies a fixed <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeExtent.html">time extent</a> during which a layer should be visible.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#visibilityTimeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public KMLLayer(
        string? url = null,
        PortalItem? portalItem = null,
        BlendMode? blendMode = null,
        Effect? effect = null,
        Extent? fullExtent = null,
        ListMode? listMode = null,
        double? maxScale = null,
        double? minScale = null,
        double? opacity = null,
        bool? persistenceEnabled = null,
        IReadOnlyList<KMLSublayer>? sublayers = null,
        string? title = null,
        TimeExtent? visibilityTimeExtent = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Url = url;
        PortalItem = portalItem;
        BlendMode = blendMode;
        Effect = effect;
        FullExtent = fullExtent;
        ListMode = listMode;
        MaxScale = maxScale;
        MinScale = minScale;
        Opacity = opacity;
        PersistenceEnabled = persistenceEnabled;
        Sublayers = sublayers;
        Title = title;
        VisibilityTimeExtent = visibilityTimeExtent;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Blend modes are used to blend layers together to create an interesting effect in a layer, or even to produce what seems like a new layer.
    ///     default normal
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-BlendLayer.html#blendMode">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BlendMode? BlendMode { get; set; }
    
    /// <summary>
    ///     Effect provides various filter functions that can be performed on the layer to achieve different visual effects similar to how image filters work.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-BlendLayer.html#effect">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Effect? Effect { get; set; }
    
    /// <summary>
    ///     The maximum scale (most zoomed in) at which the layer is visible in the view.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ScaleRangeLayer.html#maxScale">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MaxScale { get; set; }
    
    /// <summary>
    ///     The minimum scale (most zoomed out) at which the layer is visible in the view.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ScaleRangeLayer.html#minScale">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MinScale { get; set; }
    
    /// <summary>
    ///     The portal item from which the layer is loaded.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-PortalLayer.html#portalItem">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [RequiredProperty(nameof(Url))]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PortalItem? PortalItem { get; set; }
    
    /// <summary>
    ///     A collection of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-KMLSublayer.html">KMLSublayer</a>s.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-KMLLayer.html#sublayers">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<KMLSublayer>? Sublayers { get; set; }
    
    /// <summary>
    ///     The publicly accessible URL for a .kml or .kmz file.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-KMLLayer.html#url">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [RequiredProperty(nameof(PortalItem))]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Url { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the BlendMode property.
    /// </summary>
    public async Task<BlendMode?> GetBlendMode()
    {
        if (CoreJsModule is null)
        {
            return BlendMode;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return BlendMode;
        }

        // get the property value
        BlendMode? result = await JsComponentReference!.InvokeAsync<BlendMode?>("getProperty",
            CancellationTokenSource.Token, "blendMode");
        if (result is not null)
        {
#pragma warning disable BL0005
             BlendMode = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(BlendMode)] = BlendMode;
        }
         
        return BlendMode;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Effect property.
    /// </summary>
    public async Task<Effect?> GetEffect()
    {
        if (CoreJsModule is null)
        {
            return Effect;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Effect;
        }

        // get the property value
        Effect? result = await JsComponentReference!.InvokeAsync<Effect?>("getProperty",
            CancellationTokenSource.Token, "effect");
        if (result is not null)
        {
#pragma warning disable BL0005
             Effect = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Effect)] = Effect;
        }
         
        return Effect;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MaxScale property.
    /// </summary>
    public async Task<double?> GetMaxScale()
    {
        if (CoreJsModule is null)
        {
            return MaxScale;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MaxScale;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "maxScale");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             MaxScale = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MaxScale)] = MaxScale;
        }
         
        return MaxScale;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MinScale property.
    /// </summary>
    public async Task<double?> GetMinScale()
    {
        if (CoreJsModule is null)
        {
            return MinScale;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MinScale;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "minScale");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             MinScale = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MinScale)] = MinScale;
        }
         
        return MinScale;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the PortalItem property.
    /// </summary>
    public async Task<PortalItem?> GetPortalItem()
    {
        if (CoreJsModule is null)
        {
            return PortalItem;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return PortalItem;
        }

        PortalItem? result = await JsComponentReference.InvokeAsync<PortalItem?>(
            "getPortalItem", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (PortalItem is not null)
            {
                result.Id = PortalItem.Id;
            }
            
#pragma warning disable BL0005
            PortalItem = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(PortalItem)] = PortalItem;
        }
        
        return PortalItem;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Sublayers property.
    /// </summary>
    public async Task<IReadOnlyList<KMLSublayer>?> GetSublayers()
    {
        if (CoreJsModule is null)
        {
            return Sublayers;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Sublayers;
        }

        // get the property value
        IReadOnlyList<KMLSublayer>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<KMLSublayer>?>("getProperty",
            CancellationTokenSource.Token, "sublayers");
        if (result is not null)
        {
#pragma warning disable BL0005
             Sublayers = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Sublayers)] = Sublayers;
        }
         
        return Sublayers;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Url property.
    /// </summary>
    public async Task<string?> GetUrl()
    {
        if (CoreJsModule is null)
        {
            return Url;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Url;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "url");
        if (result is not null)
        {
#pragma warning disable BL0005
             Url = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Url)] = Url;
        }
         
        return Url;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the BlendMode property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetBlendMode(BlendMode value)
    {
#pragma warning disable BL0005
        BlendMode = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(BlendMode)] = value;
        
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
            JsComponentReference, "blendMode", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Effect property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetEffect(Effect value)
    {
#pragma warning disable BL0005
        Effect = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Effect)] = value;
        
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
            JsComponentReference, "effect", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the MaxScale property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMaxScale(double value)
    {
#pragma warning disable BL0005
        MaxScale = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MaxScale)] = value;
        
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
            JsComponentReference, "maxScale", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the MinScale property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMinScale(double value)
    {
#pragma warning disable BL0005
        MinScale = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(MinScale)] = value;
        
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
            JsComponentReference, "minScale", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the PortalItem property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPortalItem(PortalItem value)
    {
#pragma warning disable BL0005
        PortalItem = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(PortalItem)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setPortalItem", 
            CancellationTokenSource.Token, value);
 
        PortalItem.Parent = this;
        PortalItem.View = View;
        
        if (PortalItem.JsComponentReference is null)
        {
            // new MapComponent, needs to be built and registered in JS
            // this also calls back to OnJsComponentCreated
            IJSObjectReference jsObjectReference = await CoreJsModule.InvokeAsync<IJSObjectReference>(
                $"buildJsPortalItem", CancellationTokenSource.Token, 
                    PortalItem, Layer?.Id, View?.Id);
            // in case the fallback failed, set this here.
            PortalItem.JsComponentReference ??= jsObjectReference;
            
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference, "portalItem", jsObjectReference);
        }
        else
        {
            // this component has already been registered, but we'll call setProperty to make sure
            // it is attached to the parent
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference,
                "portalItem", PortalItem.JsComponentReference);
        }
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Sublayers property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSublayers(IReadOnlyList<KMLSublayer> value)
    {
#pragma warning disable BL0005
        Sublayers = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Sublayers)] = value;
        
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
            JsComponentReference, "sublayers", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Url property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetUrl(string value)
    {
#pragma warning disable BL0005
        Url = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Url)] = value;
        
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
            JsComponentReference, "url", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the Sublayers property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToSublayers(params KMLSublayer[] values)
    {
        KMLSublayer[] join = Sublayers is null
            ? values
            : [..Sublayers, ..values];
        await SetSublayers(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the Sublayers property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromSublayers(params KMLSublayer[] values)
    {
        if (Sublayers is null)
        {
            return;
        }
        await SetSublayers(Sublayers.Except(values).ToArray());
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case PortalItem portalItem:
                if (portalItem != PortalItem)
                {
                    PortalItem = portalItem;
                    LayerChanged = true;
                    ModifiedParameters[nameof(PortalItem)] = PortalItem;
                }
                
                return true;
            case KMLSublayer sublayers:
                Sublayers ??= [];
                if (!Sublayers.Contains(sublayers))
                {
                    Sublayers = [..Sublayers, sublayers];
                    LayerChanged = true;
                    ModifiedParameters[nameof(Sublayers)] = Sublayers;
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
            case PortalItem _:
                PortalItem = null;
                LayerChanged = true;
                ModifiedParameters[nameof(PortalItem)] = PortalItem;
                return true;
            case KMLSublayer sublayers:
                Sublayers = Sublayers?.Where(s => s != sublayers).ToList();
                LayerChanged = true;
                ModifiedParameters[nameof(Sublayers)] = Sublayers;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        if (PortalItem is null && Url is null)
        {
            throw new MissingRequiredOptionsChildElementException(nameof(KMLLayer), [nameof(PortalItem), nameof(Url)]);
        }
        if (Sublayers is not null)
        {
            foreach (KMLSublayer child in Sublayers)
            {
                child.ValidateRequiredGeneratedChildren();
            }
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
