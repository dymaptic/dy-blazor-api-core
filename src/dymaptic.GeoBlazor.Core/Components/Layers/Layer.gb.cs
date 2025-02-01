// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Layers;


/// <summary>
///    The layer is the most fundamental component of a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Map.html">Map</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public abstract partial class Layer : IHitTestItem,
    IIntersectItem,
    ISliceViewModelExcludedLayers
{

#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The unique ID assigned to the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#id">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ArcGISLayerId { get; set; }
    
    /// <summary>
    ///     Indicates whether the layer's resources have loaded.
    ///     default false
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#loaded">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Loaded { get; protected set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the ArcGISLayerId property.
    /// </summary>
    public async Task<string?> GetArcGISLayerId()
    {
        if (CoreJsModule is null)
        {
            return ArcGISLayerId;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ArcGISLayerId;
        }

        // get the property value
        string? result = await CoreJsModule!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "arcGISLayerId");
        if (result is not null)
        {
#pragma warning disable BL0005
             ArcGISLayerId = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ArcGISLayerId)] = ArcGISLayerId;
        }
         
        return ArcGISLayerId;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ListMode property.
    /// </summary>
    public async Task<ListMode?> GetListMode()
    {
        if (CoreJsModule is null)
        {
            return ListMode;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ListMode;
        }

        // get the property value
        ListMode? result = await CoreJsModule!.InvokeAsync<ListMode?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "listMode");
        if (result is not null)
        {
#pragma warning disable BL0005
             ListMode = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ListMode)] = ListMode;
        }
         
        return ListMode;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Loaded property.
    /// </summary>
    public async Task<bool?> GetLoaded()
    {
        if (CoreJsModule is null)
        {
            return Loaded;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Loaded;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "loaded");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Loaded = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Loaded)] = Loaded;
        }
         
        return Loaded;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the PersistenceEnabled property.
    /// </summary>
    public async Task<bool?> GetPersistenceEnabled()
    {
        if (CoreJsModule is null)
        {
            return PersistenceEnabled;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return PersistenceEnabled;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "persistenceEnabled");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             PersistenceEnabled = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(PersistenceEnabled)] = PersistenceEnabled;
        }
         
        return PersistenceEnabled;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Title property.
    /// </summary>
    public async Task<string?> GetTitle()
    {
        if (CoreJsModule is null)
        {
            return Title;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Title;
        }

        // get the property value
        string? result = await CoreJsModule!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "title");
        if (result is not null)
        {
#pragma warning disable BL0005
             Title = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Title)] = Title;
        }
         
        return Title;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the VisibilityTimeExtent property.
    /// </summary>
    public async Task<TimeExtent?> GetVisibilityTimeExtent()
    {
        if (CoreJsModule is null)
        {
            return VisibilityTimeExtent;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return VisibilityTimeExtent;
        }

        // get the JS object reference
        IJSObjectReference? refResult = (await CoreJsModule!.InvokeAsync<JsObjectRefWrapper?>(
            "getObjectRefForProperty", CancellationTokenSource.Token, JsComponentReference, 
            "visibilityTimeExtent"))?.Value;
            
        if (refResult is null)
        {
            return null;
        }
        
        // Try to deserialize the object. This might fail if we don't have the
        // all deserialization edge cases handled.
        try
        {
            TimeExtent? result = await CoreJsModule.InvokeAsync<TimeExtent?>(
                "createGeoBlazorObject", CancellationTokenSource.Token, refResult);
            if (result is not null)
            {
#pragma warning disable BL0005
                VisibilityTimeExtent = result;
#pragma warning restore BL0005
                ModifiedParameters[nameof(VisibilityTimeExtent)] = VisibilityTimeExtent;
            }
            
            if (VisibilityTimeExtent is not null)
            {
                VisibilityTimeExtent.Parent = this;
                VisibilityTimeExtent.View = View;
                VisibilityTimeExtent.JsComponentReference = refResult;
                await CoreJsModule!.InvokeVoidAsync("registerGeoBlazorObject",
                    CancellationTokenSource.Token, refResult, VisibilityTimeExtent.Id);
                return VisibilityTimeExtent;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Failed to deserialize VisibilityTimeExtent. Error: {ex}");
        }
#pragma warning disable BL0005
        VisibilityTimeExtent = new TimeExtent();
#pragma warning restore BL0005
        ModifiedParameters[nameof(VisibilityTimeExtent)] = VisibilityTimeExtent;
        VisibilityTimeExtent.Parent = this;
        VisibilityTimeExtent.View = View;
        VisibilityTimeExtent.JsComponentReference = refResult;
        // register this type in JS
        await CoreJsModule!.InvokeVoidAsync("registerGeoBlazorObject",
            CancellationTokenSource.Token, refResult, VisibilityTimeExtent.Id);
        await VisibilityTimeExtent.GetProperty<DateTime>(nameof(TimeExtent.End));
        await VisibilityTimeExtent.GetProperty<DateTime>(nameof(TimeExtent.Start));
        return VisibilityTimeExtent;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the ArcGISLayerId property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetArcGISLayerId(string value)
    {
#pragma warning disable BL0005
        ArcGISLayerId = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ArcGISLayerId)] = value;
        
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
            JsComponentReference, "arcGISLayerId", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ListMode property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetListMode(ListMode value)
    {
#pragma warning disable BL0005
        ListMode = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ListMode)] = value;
        
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
            JsComponentReference, "listMode", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the PersistenceEnabled property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPersistenceEnabled(bool value)
    {
#pragma warning disable BL0005
        PersistenceEnabled = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(PersistenceEnabled)] = value;
        
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
            JsComponentReference, "persistenceEnabled", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Title property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTitle(string value)
    {
#pragma warning disable BL0005
        Title = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Title)] = value;
        
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
            JsComponentReference, "title", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the VisibilityTimeExtent property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetVisibilityTimeExtent(TimeExtent value)
    {
#pragma warning disable BL0005
        VisibilityTimeExtent = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(VisibilityTimeExtent)] = value;
        
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
        
        VisibilityTimeExtent.Parent = this;
        VisibilityTimeExtent.View = View;
        
        if (VisibilityTimeExtent.JsComponentReference is null)
        {
            // new MapComponent, needs to be built and registered in JS
            // this also calls back to OnJsComponentCreated
            IJSObjectReference jsObjectReference = await CoreJsModule.InvokeAsync<IJSObjectReference>(
                $"buildJsTimeExtent", CancellationTokenSource.Token, 
                    VisibilityTimeExtent, View?.Id);
            // in case the fallback failed, set this here.
            VisibilityTimeExtent.JsComponentReference ??= jsObjectReference;
            
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference, "visibilityTimeExtent", jsObjectReference);
        }
        else
        {
            // this component has already been registered, but we'll call setProperty to make sure
            // it is attached to the parent
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference,
                "visibilityTimeExtent", VisibilityTimeExtent.JsComponentReference);
        }
    }
    
#endregion


#region Public Methods

    /// <summary>
    ///     Called by the views, such as <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html">MapView</a> and <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-SceneView.html">SceneView</a>, when the layer is added to the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Map.html#layers">Map.layers</a> collection and a layer view must be created for it.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#createLayerView">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="view">
    ///     The parent view.
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    public async Task<LayerView?> CreateLayerView(string view,
        CancellationToken cancellationToken = default)
    {
        if (JsComponentReference is null) return null;
        
        IJSObjectReference abortSignal = await AbortManager!.CreateAbortSignal(cancellationToken);
        LayerView? result = await JsComponentReference!.InvokeAsync<LayerView?>(
            "createLayerView", 
            CancellationTokenSource.Token,
            view,
            new { signal = abortSignal });
                
        await AbortManager.DisposeAbortController(cancellationToken);
        
        return result;
    }
    
    /// <summary>
    ///     Fetches custom attribution data for the layer when it becomes available.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-Layer.html#fetchAttributionData">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public async Task<string?> FetchAttributionData()
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "fetchAttributionData", 
            CancellationTokenSource.Token);
    }
    
#endregion



}
