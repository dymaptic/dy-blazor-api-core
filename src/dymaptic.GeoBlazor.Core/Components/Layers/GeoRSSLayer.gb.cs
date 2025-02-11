// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Layers;


/// <summary>
///    The GeoRSSLayer class is used to create a layer based on <a target="_blank" href="https://www.ogc.org/standards/georss">GeoRSS</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class GeoRSSLayer : IBlendLayer,
    IOperationalLayer,
    IScaleRangeLayer
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public GeoRSSLayer()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="url">
    ///     The URL pointing to a GeoRSS file.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#url">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="title">
    ///     The title of the layer used to identify it in places such as the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Legend.html">Legend</a> and <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html">LayerList</a> widgets.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#title">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="opacity">
    ///     The opacity of the layer.
    ///     default 1
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#opacity">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="visible">
    ///     Indicates if the layer is visible in the View. When false, the layer may still be added to a Map instance that is
    ///              referenced in a view, but its features will not be visible in the view.
    /// </param>
    /// <param name="listMode">
    ///     Indicates how the layer should display in the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html">LayerList</a> widget.
    ///     default "show"
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#listMode">ArcGIS Maps SDK for JavaScript</a>
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
    /// <param name="legendEnabled">
    ///     Indicates whether the layer will be included in the legend.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#legendEnabled">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="lineSymbol">
    ///     Symbol used to represent line features from the GeoRSS feed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#lineSymbol">ArcGIS Maps SDK for JavaScript</a>
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
    /// <param name="persistenceEnabled">
    ///     When `true`, the layer can be persisted.
    ///     default false
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#persistenceEnabled">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="pointSymbol">
    ///     Symbol used to represent point features from the GeoRSS feed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#pointSymbol">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="polygonSymbol">
    ///     Symbol used to represent polygon features from the GeoRSS feed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#polygonSymbol">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="refreshInterval">
    ///     Refresh interval of the layer in minutes.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#refreshInterval">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="visibilityTimeExtent">
    ///     Specifies a fixed <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeExtent.html">time extent</a> during which a layer should be visible.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#visibilityTimeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public GeoRSSLayer(
        string url,
        string? title = null,
        double? opacity = null,
        bool? visible = null,
        ListMode? listMode = null,
        BlendMode? blendMode = null,
        Effect? effect = null,
        Extent? fullExtent = null,
        bool? legendEnabled = null,
        SimpleLineSymbol? lineSymbol = null,
        double? maxScale = null,
        double? minScale = null,
        bool? persistenceEnabled = null,
        MarkerSymbol? pointSymbol = null,
        SimpleFillSymbol? polygonSymbol = null,
        double? refreshInterval = null,
        TimeExtent? visibilityTimeExtent = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Url = url;
        Title = title;
        Opacity = opacity;
        if (visible is not null)
        {
            Visible = visible.Value;
        }
        ListMode = listMode;
        BlendMode = blendMode;
        Effect = effect;
        FullExtent = fullExtent;
        LegendEnabled = legendEnabled;
        LineSymbol = lineSymbol;
        MaxScale = maxScale;
        MinScale = minScale;
        PersistenceEnabled = persistenceEnabled;
        PointSymbol = pointSymbol;
        PolygonSymbol = polygonSymbol;
        RefreshInterval = refreshInterval;
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
    ///     Indicates whether the layer will be included in the legend.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#legendEnabled">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? LegendEnabled { get; set; }
    
    /// <summary>
    ///     Symbol used to represent line features from the GeoRSS feed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#lineSymbol">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SimpleLineSymbol? LineSymbol { get; set; }
    
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
    ///     Symbol used to represent point features from the GeoRSS feed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#pointSymbol">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MarkerSymbol? PointSymbol { get; set; }
    
    /// <summary>
    ///     Symbol used to represent polygon features from the GeoRSS feed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#polygonSymbol">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SimpleFillSymbol? PolygonSymbol { get; set; }
    
    /// <summary>
    ///     Refresh interval of the layer in minutes.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#refreshInterval">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? RefreshInterval { get; set; }
    
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
        JsNullableEnumWrapper<BlendMode>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<BlendMode>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "blendMode");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             BlendMode = (BlendMode)result.Value.Value!;
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
    ///     Asynchronously retrieve the current value of the LegendEnabled property.
    /// </summary>
    public async Task<bool?> GetLegendEnabled()
    {
        if (CoreJsModule is null)
        {
            return LegendEnabled;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return LegendEnabled;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "legendEnabled");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             LegendEnabled = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(LegendEnabled)] = LegendEnabled;
        }
         
        return LegendEnabled;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the LineSymbol property.
    /// </summary>
    public async Task<SimpleLineSymbol?> GetLineSymbol()
    {
        if (CoreJsModule is null)
        {
            return LineSymbol;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return LineSymbol;
        }

        // get the property value
        SimpleLineSymbol? result = await JsComponentReference!.InvokeAsync<SimpleLineSymbol?>("getProperty",
            CancellationTokenSource.Token, "lineSymbol");
        if (result is not null)
        {
#pragma warning disable BL0005
             LineSymbol = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(LineSymbol)] = LineSymbol;
        }
         
        return LineSymbol;
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
    ///     Asynchronously retrieve the current value of the PointSymbol property.
    /// </summary>
    public async Task<MarkerSymbol?> GetPointSymbol()
    {
        if (CoreJsModule is null)
        {
            return PointSymbol;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return PointSymbol;
        }

        // get the property value
        MarkerSymbol? result = await JsComponentReference!.InvokeAsync<MarkerSymbol?>("getProperty",
            CancellationTokenSource.Token, "pointSymbol");
        if (result is not null)
        {
#pragma warning disable BL0005
             PointSymbol = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(PointSymbol)] = PointSymbol;
        }
         
        return PointSymbol;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the PolygonSymbol property.
    /// </summary>
    public async Task<SimpleFillSymbol?> GetPolygonSymbol()
    {
        if (CoreJsModule is null)
        {
            return PolygonSymbol;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return PolygonSymbol;
        }

        // get the property value
        SimpleFillSymbol? result = await JsComponentReference!.InvokeAsync<SimpleFillSymbol?>("getProperty",
            CancellationTokenSource.Token, "polygonSymbol");
        if (result is not null)
        {
#pragma warning disable BL0005
             PolygonSymbol = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(PolygonSymbol)] = PolygonSymbol;
        }
         
        return PolygonSymbol;
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
    ///    Asynchronously set the value of the LegendEnabled property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLegendEnabled(bool value)
    {
#pragma warning disable BL0005
        LegendEnabled = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(LegendEnabled)] = value;
        
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
            JsComponentReference, "legendEnabled", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the LineSymbol property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLineSymbol(SimpleLineSymbol value)
    {
#pragma warning disable BL0005
        LineSymbol = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(LineSymbol)] = value;
        
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
            JsComponentReference, "lineSymbol", value);
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
    ///    Asynchronously set the value of the PointSymbol property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPointSymbol(MarkerSymbol value)
    {
#pragma warning disable BL0005
        PointSymbol = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(PointSymbol)] = value;
        
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
            JsComponentReference, "pointSymbol", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the PolygonSymbol property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPolygonSymbol(SimpleFillSymbol value)
    {
#pragma warning disable BL0005
        PolygonSymbol = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(PolygonSymbol)] = value;
        
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
            JsComponentReference, "polygonSymbol", value);
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

#region Public Methods

    /// <summary>
    ///     Fetches all the data for the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-GeoRSSLayer.html#refresh">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public override async ValueTask Refresh()
    {
        await base.Refresh();
        if (JsComponentReference is null) return;
        
        await JsComponentReference!.InvokeVoidAsync(
            "refresh", 
            CancellationTokenSource.Token);
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
            case SimpleLineSymbol lineSymbol:
                if (lineSymbol != LineSymbol)
                {
                    LineSymbol = lineSymbol;
                    LayerChanged = true;
                    ModifiedParameters[nameof(LineSymbol)] = LineSymbol;
                }
                
                return true;
            case MarkerSymbol pointSymbol:
                if (pointSymbol != PointSymbol)
                {
                    PointSymbol = pointSymbol;
                    LayerChanged = true;
                    ModifiedParameters[nameof(PointSymbol)] = PointSymbol;
                }
                
                return true;
            case SimpleFillSymbol polygonSymbol:
                if (polygonSymbol != PolygonSymbol)
                {
                    PolygonSymbol = polygonSymbol;
                    LayerChanged = true;
                    ModifiedParameters[nameof(PolygonSymbol)] = PolygonSymbol;
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
            case SimpleLineSymbol _:
                LineSymbol = null;
                LayerChanged = true;
                ModifiedParameters[nameof(LineSymbol)] = LineSymbol;
                return true;
            case MarkerSymbol _:
                PointSymbol = null;
                LayerChanged = true;
                ModifiedParameters[nameof(PointSymbol)] = PointSymbol;
                return true;
            case SimpleFillSymbol _:
                PolygonSymbol = null;
                LayerChanged = true;
                ModifiedParameters[nameof(PolygonSymbol)] = PolygonSymbol;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        LineSymbol?.ValidateRequiredGeneratedChildren();
        PointSymbol?.ValidateRequiredGeneratedChildren();
        PolygonSymbol?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
