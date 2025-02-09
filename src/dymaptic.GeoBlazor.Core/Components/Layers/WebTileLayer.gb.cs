// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Layers;


/// <summary>
///    WebTileLayer provides a simple way to add non-ArcGIS Server map tiles as a layer to a map.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class WebTileLayer : IBlendLayer,
    IOperationalLayer,
    IPortalLayer,
    IRefreshableLayer,
    IScaleRangeLayer
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public WebTileLayer()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="blendMode">
    ///     Blend modes are used to blend layers together to create an interesting effect in a layer, or even to produce what seems like a new layer.
    ///     default normal
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-BlendLayer.html#blendMode">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="copyright">
    ///     The attribution information for the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#copyright">ArcGIS Maps SDK for JavaScript</a>
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
    /// <param name="portalItem">
    ///     The portal item from which the layer is loaded.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-PortalLayer.html#portalItem">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="refreshInterval">
    ///     Refresh interval of the layer in minutes.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-RefreshableLayer.html#refreshInterval">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="subDomains">
    ///     A string of subDomain names where tiles are served to speed up tile retrieval.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#subDomains">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="tileInfo">
    ///     The tiling scheme information for the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#tileInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="title">
    ///     The title of the layer used to identify it in places such as the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html">LayerList</a> widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#title">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="urlTemplate">
    ///     The url template is a string that specifies the URL of the hosted tile images to load.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#urlTemplate">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="visibilityTimeExtent">
    ///     Specifies a fixed <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeExtent.html">time extent</a> during which a layer should be visible.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#visibilityTimeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public WebTileLayer(
        BlendMode? blendMode = null,
        string? copyright = null,
        Effect? effect = null,
        Extent? fullExtent = null,
        ListMode? listMode = null,
        double? maxScale = null,
        double? minScale = null,
        double? opacity = null,
        bool? persistenceEnabled = null,
        PortalItem? portalItem = null,
        double? refreshInterval = null,
        IReadOnlyList<string>? subDomains = null,
        TileInfo? tileInfo = null,
        string? title = null,
        string? urlTemplate = null,
        TimeExtent? visibilityTimeExtent = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        BlendMode = blendMode;
        Copyright = copyright;
        Effect = effect;
        FullExtent = fullExtent;
        ListMode = listMode;
        MaxScale = maxScale;
        MinScale = minScale;
        Opacity = opacity;
        PersistenceEnabled = persistenceEnabled;
        PortalItem = portalItem;
        RefreshInterval = refreshInterval;
        SubDomains = subDomains;
        TileInfo = tileInfo;
        Title = title;
        UrlTemplate = urlTemplate;
        VisibilityTimeExtent = visibilityTimeExtent;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

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
    ///     The portal item from which the layer is loaded.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-PortalLayer.html#portalItem">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PortalItem? PortalItem { get; set; }
    
    /// <summary>
    ///     The spatial reference of the layer.
    ///     default Web Mercator Auxiliary Sphere (wkid: 3857)
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#spatialReference">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SpatialReference? SpatialReference { get; protected set; }
    
    /// <summary>
    ///     The tiling scheme information for the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#tileInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TileInfo? TileInfo { get; set; }
    
    /// <summary>
    ///     The list of tile server urls for the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#tileServers">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<string>? TileServers { get; protected set; }
    
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
    ///     Asynchronously retrieve the current value of the Copyright property.
    /// </summary>
    public async Task<string?> GetCopyright()
    {
        if (CoreJsModule is null)
        {
            return Copyright;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Copyright;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "copyright");
        if (result is not null)
        {
#pragma warning disable BL0005
             Copyright = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Copyright)] = Copyright;
        }
         
        return Copyright;
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
    ///     Asynchronously retrieve the current value of the RefreshInterval property.
    /// </summary>
    public async Task<double?> GetRefreshInterval()
    {
        if (CoreJsModule is null)
        {
            return RefreshInterval;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return RefreshInterval;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "refreshInterval");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             RefreshInterval = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(RefreshInterval)] = RefreshInterval;
        }
         
        return RefreshInterval;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SpatialReference property.
    /// </summary>
    public async Task<SpatialReference?> GetSpatialReference()
    {
        if (CoreJsModule is null)
        {
            return SpatialReference;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SpatialReference;
        }

        // get the property value
        SpatialReference? result = await JsComponentReference!.InvokeAsync<SpatialReference?>("getProperty",
            CancellationTokenSource.Token, "spatialReference");
        if (result is not null)
        {
#pragma warning disable BL0005
             SpatialReference = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SpatialReference)] = SpatialReference;
        }
         
        return SpatialReference;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SubDomains property.
    /// </summary>
    public async Task<IReadOnlyList<string>?> GetSubDomains()
    {
        if (CoreJsModule is null)
        {
            return SubDomains;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SubDomains;
        }

        // get the property value
        IReadOnlyList<string>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<string>?>("getProperty",
            CancellationTokenSource.Token, "subDomains");
        if (result is not null)
        {
#pragma warning disable BL0005
             SubDomains = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SubDomains)] = SubDomains;
        }
         
        return SubDomains;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the TileInfo property.
    /// </summary>
    public async Task<TileInfo?> GetTileInfo()
    {
        if (CoreJsModule is null)
        {
            return TileInfo;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return TileInfo;
        }

        TileInfo? result = await JsComponentReference.InvokeAsync<TileInfo?>(
            "getTileInfo", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (TileInfo is not null)
            {
                result.Id = TileInfo.Id;
            }
            
#pragma warning disable BL0005
            TileInfo = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(TileInfo)] = TileInfo;
        }
        
        return TileInfo;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the TileServers property.
    /// </summary>
    public async Task<IReadOnlyList<string>?> GetTileServers()
    {
        if (CoreJsModule is null)
        {
            return TileServers;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return TileServers;
        }

        // get the property value
        IReadOnlyList<string>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<string>?>("getProperty",
            CancellationTokenSource.Token, "tileServers");
        if (result is not null)
        {
#pragma warning disable BL0005
             TileServers = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(TileServers)] = TileServers;
        }
         
        return TileServers;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the UrlTemplate property.
    /// </summary>
    public async Task<string?> GetUrlTemplate()
    {
        if (CoreJsModule is null)
        {
            return UrlTemplate;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return UrlTemplate;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "urlTemplate");
        if (result is not null)
        {
#pragma warning disable BL0005
             UrlTemplate = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(UrlTemplate)] = UrlTemplate;
        }
         
        return UrlTemplate;
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
    ///    Asynchronously set the value of the Copyright property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetCopyright(string value)
    {
#pragma warning disable BL0005
        Copyright = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Copyright)] = value;
        
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
            JsComponentReference, "copyright", value);
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
    ///    Asynchronously set the value of the RefreshInterval property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetRefreshInterval(double value)
    {
#pragma warning disable BL0005
        RefreshInterval = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(RefreshInterval)] = value;
        
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
            JsComponentReference, "refreshInterval", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SubDomains property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSubDomains(IReadOnlyList<string> value)
    {
#pragma warning disable BL0005
        SubDomains = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SubDomains)] = value;
        
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
            JsComponentReference, "subDomains", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the TileInfo property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTileInfo(TileInfo value)
    {
#pragma warning disable BL0005
        TileInfo = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(TileInfo)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setTileInfo", 
            CancellationTokenSource.Token, value);
 
        TileInfo.Parent = this;
        TileInfo.View = View;
        
        if (TileInfo.JsComponentReference is null)
        {
            // new MapComponent, needs to be built and registered in JS
            // this also calls back to OnJsComponentCreated
            IJSObjectReference jsObjectReference = await CoreJsModule.InvokeAsync<IJSObjectReference>(
                $"buildJsTileInfo", CancellationTokenSource.Token, 
                    TileInfo, Layer?.Id, View?.Id);
            // in case the fallback failed, set this here.
            TileInfo.JsComponentReference ??= jsObjectReference;
            
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference, "tileInfo", jsObjectReference);
        }
        else
        {
            // this component has already been registered, but we'll call setProperty to make sure
            // it is attached to the parent
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference,
                "tileInfo", TileInfo.JsComponentReference);
        }
    }
    
    /// <summary>
    ///    Asynchronously set the value of the UrlTemplate property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetUrlTemplate(string value)
    {
#pragma warning disable BL0005
        UrlTemplate = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(UrlTemplate)] = value;
        
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
            JsComponentReference, "urlTemplate", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the SubDomains property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToSubDomains(params string[] values)
    {
        string[] join = SubDomains is null
            ? values
            : [..SubDomains, ..values];
        await SetSubDomains(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the SubDomains property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromSubDomains(params string[] values)
    {
        if (SubDomains is null)
        {
            return;
        }
        await SetSubDomains(SubDomains.Except(values).ToArray());
    }
    
#endregion

#region Public Methods

    /// <summary>
    ///     This method fetches a tile for the given level, row and column present in the view.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#fetchTile">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="level">
    ///     Level of detail of the tile to fetch. This value is provided by <a href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-layers-LayerView.html">LayerView</a>.
    /// </param>
    /// <param name="row">
    ///     The row(y) position of the tile fetch. This value is provided by <a href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-layers-LayerView.html">LayerView</a>.
    /// </param>
    /// <param name="col">
    ///     The column(x) position of the tile to fetch. This value is provided by <a href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-layers-LayerView.html">LayerView</a>.
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    public async Task<ElementReference?> FetchTile(double level,
        double row,
        double col,
        CancellationToken cancellationToken = default)
    {
        if (JsComponentReference is null) return null;
        
        IJSObjectReference abortSignal = await AbortManager!.CreateAbortSignal(cancellationToken);
        ElementReference? result = await JsComponentReference!.InvokeAsync<ElementReference?>(
            "fetchTile", 
            CancellationTokenSource.Token,
            level,
            row,
            col,
            new { signal = abortSignal });
                
        await AbortManager.DisposeAbortController(cancellationToken);
        
        return result;
    }
    
    /// <summary>
    ///     This method returns a URL to a tile for a given level, row and column.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WebTileLayer.html#getTileUrl">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="level">
    ///     The requested tile's level.
    /// </param>
    /// <param name="row">
    ///     The requested tile's row.
    /// </param>
    /// <param name="col">
    ///     The requested tile's column.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> GetTileUrl(double level,
        double row,
        double col)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "getTileUrl", 
            CancellationTokenSource.Token,
            level,
            row,
            col);
    }
    
#endregion

#region Event Handlers

    /// <summary>
    ///     JavaScript-Invokable Method for internal use only.
    /// </summary>
    [JSInvokable]
    public async Task OnJsRefresh(RefreshEvent refreshEvent)
    {
        await OnRefresh.InvokeAsync(refreshEvent);
    }
    
    /// <summary>
    ///     Fires if the layer has the <a href="#refreshInterval">refreshInterval</a> set or when <a href="#refresh">refresh()</a> method is called.
    ///     The event payload indicates if the layer's data has changed.
    /// </summary>
    [Parameter]
    public EventCallback<RefreshEvent> OnRefresh { get; set; }
   
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
            case TileInfo tileInfo:
                if (tileInfo != TileInfo)
                {
                    TileInfo = tileInfo;
                    LayerChanged = true;
                    ModifiedParameters[nameof(TileInfo)] = TileInfo;
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
            case TileInfo _:
                TileInfo = null;
                LayerChanged = true;
                ModifiedParameters[nameof(TileInfo)] = TileInfo;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        PortalItem?.ValidateRequiredGeneratedChildren();
        TileInfo?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
