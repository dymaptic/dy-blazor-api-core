// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    A <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-TileLayer.html">TileLayer</a> has a number of LODs (Levels of Detail).
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-LOD.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class LOD
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public LOD()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="level">
    ///     ID for each level.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-LOD.html#level">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="levelValue">
    ///     String to be used when constructing a URL to access a tile from this LOD.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-LOD.html#levelValue">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="resolution">
    ///     Resolution in map units of each pixel in a tile for each level.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-LOD.html#resolution">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="scale">
    ///     Scale for each level.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-LOD.html#scale">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public LOD(
        int? level = null,
        string? levelValue = null,
        double? resolution = null,
        double? scale = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Level = level;
        LevelValue = levelValue;
        Resolution = resolution;
        Scale = scale;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     ID for each level.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-LOD.html#level">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Level { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Level property.
    /// </summary>
    public async Task<int?> GetLevel()
    {
        if (CoreJsModule is null)
        {
            return Level;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Level;
        }

        // get the property value
        JsNullableIntWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableIntWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "level");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Level = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Level)] = Level;
        }
         
        return Level;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the LevelValue property.
    /// </summary>
    public async Task<string?> GetLevelValue()
    {
        if (CoreJsModule is null)
        {
            return LevelValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return LevelValue;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "levelValue");
        if (result is not null)
        {
#pragma warning disable BL0005
             LevelValue = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(LevelValue)] = LevelValue;
        }
         
        return LevelValue;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Resolution property.
    /// </summary>
    public async Task<double?> GetResolution()
    {
        if (CoreJsModule is null)
        {
            return Resolution;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Resolution;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "resolution");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Resolution = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Resolution)] = Resolution;
        }
         
        return Resolution;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Scale property.
    /// </summary>
    public async Task<double?> GetScale()
    {
        if (CoreJsModule is null)
        {
            return Scale;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Scale;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "scale");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Scale = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Scale)] = Scale;
        }
         
        return Scale;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Level property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLevel(int value)
    {
#pragma warning disable BL0005
        Level = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Level)] = value;
        
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
            JsComponentReference, "level", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the LevelValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLevelValue(string value)
    {
#pragma warning disable BL0005
        LevelValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(LevelValue)] = value;
        
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
            JsComponentReference, "levelValue", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Resolution property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetResolution(double value)
    {
#pragma warning disable BL0005
        Resolution = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Resolution)] = value;
        
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
            JsComponentReference, "resolution", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Scale property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetScale(double value)
    {
#pragma warning disable BL0005
        Scale = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Scale)] = value;
        
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
            JsComponentReference, "scale", value);
    }
    
#endregion

}
