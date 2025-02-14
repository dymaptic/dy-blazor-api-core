// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Time info represents the temporal data of a time-aware layer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class TimeInfo
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public TimeInfo()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="startField">
    ///     The name of the field containing the start time information.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#startField">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="endField">
    ///     The name of the field containing the end time information.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#endField">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="fullTimeExtent">
    ///     The time extent defines the start time and end time for all data in the layer.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#fullTimeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="interval">
    ///     The time interval defines the granularity of the temporal data and allows you to visualize the data at specified intervals using the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-TimeSlider.html">time slider widget</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#interval">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="stops">
    ///     Indicates the time instants that the layer has data for.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#stops">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="timeZone">
    ///     The IANA time zone that dates are stored in.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#timeZone">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="trackIdField">
    ///     The name of the field used to join or group discrete locations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#trackIdField">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public TimeInfo(
        string? startField = null,
        string? endField = null,
        TimeExtent? fullTimeExtent = null,
        TimeInterval? interval = null,
        IReadOnlyList<DateTime>? stops = null,
        string? timeZone = null,
        string? trackIdField = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        StartField = startField;
        EndField = endField;
        FullTimeExtent = fullTimeExtent;
        Interval = interval;
        Stops = stops;
        TimeZone = timeZone;
        TrackIdField = trackIdField;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The name of the field containing the end time information.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#endField">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EndField { get; set; }
    
    /// <summary>
    ///     The time extent defines the start time and end time for all data in the layer.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#fullTimeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TimeExtent? FullTimeExtent { get; set; }
    
    /// <summary>
    ///     The time interval defines the granularity of the temporal data and allows you to visualize the data at specified intervals using the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-TimeSlider.html">time slider widget</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#interval">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TimeInterval? Interval { get; set; }
    
    /// <summary>
    ///     The name of the field containing the start time information.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#startField">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StartField { get; set; }
    
    /// <summary>
    ///     Indicates the time instants that the layer has data for.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#stops">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<DateTime>? Stops { get; set; }
    
    /// <summary>
    ///     The IANA time zone that dates are stored in.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#timeZone">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? TimeZone { get; set; }
    
    /// <summary>
    ///     The name of the field used to join or group discrete locations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-TimeInfo.html#trackIdField">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? TrackIdField { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the EndField property.
    /// </summary>
    public async Task<string?> GetEndField()
    {
        if (CoreJsModule is null)
        {
            return EndField;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return EndField;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "endField");
        if (result is not null)
        {
#pragma warning disable BL0005
             EndField = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(EndField)] = EndField;
        }
         
        return EndField;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the FullTimeExtent property.
    /// </summary>
    public async Task<TimeExtent?> GetFullTimeExtent()
    {
        if (CoreJsModule is null)
        {
            return FullTimeExtent;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return FullTimeExtent;
        }

        TimeExtent? result = await JsComponentReference.InvokeAsync<TimeExtent?>(
            "getFullTimeExtent", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (FullTimeExtent is not null)
            {
                result.Id = FullTimeExtent.Id;
            }
            
#pragma warning disable BL0005
            FullTimeExtent = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(FullTimeExtent)] = FullTimeExtent;
        }
        
        return FullTimeExtent;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Interval property.
    /// </summary>
    public async Task<TimeInterval?> GetInterval()
    {
        if (CoreJsModule is null)
        {
            return Interval;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Interval;
        }

        // get the property value
        TimeInterval? result = await JsComponentReference!.InvokeAsync<TimeInterval?>("getProperty",
            CancellationTokenSource.Token, "interval");
        if (result is not null)
        {
#pragma warning disable BL0005
             Interval = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Interval)] = Interval;
        }
         
        return Interval;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the StartField property.
    /// </summary>
    public async Task<string?> GetStartField()
    {
        if (CoreJsModule is null)
        {
            return StartField;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return StartField;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "startField");
        if (result is not null)
        {
#pragma warning disable BL0005
             StartField = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(StartField)] = StartField;
        }
         
        return StartField;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Stops property.
    /// </summary>
    public async Task<IReadOnlyList<DateTime>?> GetStops()
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
        IReadOnlyList<DateTime>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<DateTime>?>("getProperty",
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
    ///     Asynchronously retrieve the current value of the TimeZone property.
    /// </summary>
    public async Task<string?> GetTimeZone()
    {
        if (CoreJsModule is null)
        {
            return TimeZone;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return TimeZone;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "timeZone");
        if (result is not null)
        {
#pragma warning disable BL0005
             TimeZone = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(TimeZone)] = TimeZone;
        }
         
        return TimeZone;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the TrackIdField property.
    /// </summary>
    public async Task<string?> GetTrackIdField()
    {
        if (CoreJsModule is null)
        {
            return TrackIdField;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return TrackIdField;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "trackIdField");
        if (result is not null)
        {
#pragma warning disable BL0005
             TrackIdField = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(TrackIdField)] = TrackIdField;
        }
         
        return TrackIdField;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the EndField property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetEndField(string? value)
    {
#pragma warning disable BL0005
        EndField = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(EndField)] = value;
        
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
            JsComponentReference, "endField", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the FullTimeExtent property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetFullTimeExtent(TimeExtent? value)
    {
#pragma warning disable BL0005
        FullTimeExtent = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(FullTimeExtent)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setFullTimeExtent", 
            CancellationTokenSource.Token, value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Interval property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetInterval(TimeInterval? value)
    {
#pragma warning disable BL0005
        Interval = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Interval)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setInterval", 
            CancellationTokenSource.Token, value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the StartField property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetStartField(string? value)
    {
#pragma warning disable BL0005
        StartField = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(StartField)] = value;
        
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
            JsComponentReference, "startField", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Stops property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetStops(IReadOnlyList<DateTime>? value)
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
    ///    Asynchronously set the value of the TimeZone property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTimeZone(string? value)
    {
#pragma warning disable BL0005
        TimeZone = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(TimeZone)] = value;
        
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
            JsComponentReference, "timeZone", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the TrackIdField property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTrackIdField(string? value)
    {
#pragma warning disable BL0005
        TrackIdField = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(TrackIdField)] = value;
        
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
            JsComponentReference, "trackIdField", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the Stops property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToStops(params DateTime[] values)
    {
        DateTime[] join = Stops is null
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
    public async Task RemoveFromStops(params DateTime[] values)
    {
        if (Stops is null)
        {
            return;
        }
        await SetStops(Stops.Except(values).ToArray());
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case TimeExtent fullTimeExtent:
                if (fullTimeExtent != FullTimeExtent)
                {
                    FullTimeExtent = fullTimeExtent;
                    
                    ModifiedParameters[nameof(FullTimeExtent)] = FullTimeExtent;
                }
                
                return true;
            case TimeInterval interval:
                if (interval != Interval)
                {
                    Interval = interval;
                    
                    ModifiedParameters[nameof(Interval)] = Interval;
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
            case TimeExtent _:
                FullTimeExtent = null;
                
                ModifiedParameters[nameof(FullTimeExtent)] = FullTimeExtent;
                return true;
            case TimeInterval _:
                Interval = null;
                
                ModifiedParameters[nameof(Interval)] = Interval;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        FullTimeExtent?.ValidateRequiredGeneratedChildren();
        Interval?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
