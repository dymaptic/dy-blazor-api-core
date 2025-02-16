// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    The spatial extent dimensions.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV201">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class CoverageDescriptionV201BoundedByEnvelopeAllDims : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public CoverageDescriptionV201BoundedByEnvelopeAllDims()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="maxs">
    ///     Spatial extent min x and y.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV201">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="mins">
    ///     Spatial extent min x and y.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV201">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public CoverageDescriptionV201BoundedByEnvelopeAllDims(
        IReadOnlyList<double>? maxs = null,
        IReadOnlyList<double>? mins = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Maxs = maxs;
        Mins = mins;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Spatial extent min x and y.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV201">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<double>? Maxs { get; set; }
    
    /// <summary>
    ///     Spatial extent min x and y.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-WCSLayer.html#CoverageDescriptionV201">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<double>? Mins { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Maxs property.
    /// </summary>
    public async Task<IReadOnlyList<double>?> GetMaxs()
    {
        if (CoreJsModule is null)
        {
            return Maxs;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Maxs;
        }

        // get the property value
        IReadOnlyList<double>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<double>?>("getProperty",
            CancellationTokenSource.Token, "maxs");
        if (result is not null)
        {
#pragma warning disable BL0005
             Maxs = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Maxs)] = Maxs;
        }
         
        return Maxs;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Mins property.
    /// </summary>
    public async Task<IReadOnlyList<double>?> GetMins()
    {
        if (CoreJsModule is null)
        {
            return Mins;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Mins;
        }

        // get the property value
        IReadOnlyList<double>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<double>?>("getProperty",
            CancellationTokenSource.Token, "mins");
        if (result is not null)
        {
#pragma warning disable BL0005
             Mins = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Mins)] = Mins;
        }
         
        return Mins;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Maxs property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMaxs(IReadOnlyList<double>? value)
    {
#pragma warning disable BL0005
        Maxs = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Maxs)] = value;
        
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
            JsComponentReference, "maxs", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Mins property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetMins(IReadOnlyList<double>? value)
    {
#pragma warning disable BL0005
        Mins = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Mins)] = value;
        
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
            JsComponentReference, "mins", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the Maxs property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToMaxs(params double[] values)
    {
        double[] join = Maxs is null
            ? values
            : [..Maxs, ..values];
        await SetMaxs(join);
    }
    
    /// <summary>
    ///     Asynchronously adds elements to the Mins property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToMins(params double[] values)
    {
        double[] join = Mins is null
            ? values
            : [..Mins, ..values];
        await SetMins(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the Maxs property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromMaxs(params double[] values)
    {
        if (Maxs is null)
        {
            return;
        }
        await SetMaxs(Maxs.Except(values).ToArray());
    }
    
    
    /// <summary>
    ///     Asynchronously remove an element from the Mins property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromMins(params double[] values)
    {
        if (Mins is null)
        {
            return;
        }
        await SetMins(Mins.Except(values).ToArray());
    }
    
#endregion

}
