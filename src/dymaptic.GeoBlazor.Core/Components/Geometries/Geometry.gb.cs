// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Geometries;


/// <summary>
///    The base class for geometry objects.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public abstract partial class Geometry : ISearchViewModelSelectedSuggestion
{

#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The cache is used to store values computed from geometries that need to be cleared or recomputed upon mutation.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html#cache">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Cache { get; protected set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Cache property.
    /// </summary>
    public async Task<string?> GetCache()
    {
        if (CoreJsModule is null)
        {
            return Cache;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Cache;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "cache");
        if (result is not null)
        {
#pragma warning disable BL0005
             Cache = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Cache)] = Cache;
        }
         
        return Cache;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the HasM property.
    /// </summary>
    public async Task<bool?> GetHasM()
    {
        if (CoreJsModule is null)
        {
            return HasM;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return HasM;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "hasM");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             HasM = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(HasM)] = HasM;
        }
         
        return HasM;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the HasZ property.
    /// </summary>
    public async Task<bool?> GetHasZ()
    {
        if (CoreJsModule is null)
        {
            return HasZ;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return HasZ;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "hasZ");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             HasZ = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(HasZ)] = HasZ;
        }
         
        return HasZ;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the HasM property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetHasM(bool? value)
    {
#pragma warning disable BL0005
        HasM = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(HasM)] = value;
        
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
            JsComponentReference, "hasM", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the HasZ property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetHasZ(bool? value)
    {
#pragma warning disable BL0005
        HasZ = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(HasZ)] = value;
        
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
            JsComponentReference, "hasZ", value);
    }
    
#endregion

}
