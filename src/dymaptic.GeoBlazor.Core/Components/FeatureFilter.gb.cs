// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    This class defines parameters for setting a client-side filter on a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#featureEffect">featureEffect</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-layers-FeatureLayerView.html#filter">layer view</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class FeatureFilter
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public FeatureFilter()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="distance">
    ///     Specifies a search distance from a given <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#geometry">geometry</a> in a spatial filter.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#distance">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="geometry">
    ///     The geometry to apply to the spatial filter.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#geometry">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="objectIds">
    ///     An array of objectIds of the features to be filtered.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#objectIds">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="spatialRelationship">
    ///     For spatial filters, this parameter defines the spatial relationship to filter features in the layer view against the filter <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#geometry">geometry</a>.
    ///     default intersects
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#spatialRelationship">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="timeExtent">
    ///     A range of time with start and end date.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#timeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="units">
    ///     The unit for calculating the buffer distance when <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#distance">distance</a> is specified in a spatial filter.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#units">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="where">
    ///     A where clause for the feature filter.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#where">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public FeatureFilter(
        double? distance = null,
        Geometry? geometry = null,
        IReadOnlyList<long>? objectIds = null,
        SpatialRelationship? spatialRelationship = null,
        TimeExtent? timeExtent = null,
        QueryUnits? units = null,
        string? where = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Distance = distance;
        Geometry = geometry;
        ObjectIds = objectIds;
        SpatialRelationship = spatialRelationship;
        TimeExtent = timeExtent;
        Units = units;
        Where = where;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     An array of objectIds of the features to be filtered.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#objectIds">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<long>? ObjectIds { get; set; }
    
    /// <summary>
    ///     The unit for calculating the buffer distance when <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#distance">distance</a> is specified in a spatial filter.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#units">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public QueryUnits? Units { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Distance property.
    /// </summary>
    public async Task<double?> GetDistance()
    {
        if (CoreJsModule is null)
        {
            return Distance;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Distance;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "distance");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Distance = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Distance)] = Distance;
        }
         
        return Distance;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Geometry property.
    /// </summary>
    public async Task<Geometry?> GetGeometry()
    {
        if (CoreJsModule is null)
        {
            return Geometry;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Geometry;
        }

        // get the property value
        Geometry? result = await JsComponentReference!.InvokeAsync<Geometry?>("getProperty",
            CancellationTokenSource.Token, "geometry");
        if (result is not null)
        {
#pragma warning disable BL0005
             Geometry = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Geometry)] = Geometry;
        }
         
        return Geometry;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ObjectIds property.
    /// </summary>
    public async Task<IReadOnlyList<long>?> GetObjectIds()
    {
        if (CoreJsModule is null)
        {
            return ObjectIds;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ObjectIds;
        }

        // get the property value
        IReadOnlyList<long>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<long>?>("getProperty",
            CancellationTokenSource.Token, "objectIds");
        if (result is not null)
        {
#pragma warning disable BL0005
             ObjectIds = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ObjectIds)] = ObjectIds;
        }
         
        return ObjectIds;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SpatialRelationship property.
    /// </summary>
    public async Task<SpatialRelationship?> GetSpatialRelationship()
    {
        if (CoreJsModule is null)
        {
            return SpatialRelationship;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SpatialRelationship;
        }

        // get the property value
        SpatialRelationship? result = await JsComponentReference!.InvokeAsync<SpatialRelationship?>("getProperty",
            CancellationTokenSource.Token, "spatialRelationship");
        if (result is not null)
        {
#pragma warning disable BL0005
             SpatialRelationship = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SpatialRelationship)] = SpatialRelationship;
        }
         
        return SpatialRelationship;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the TimeExtent property.
    /// </summary>
    public async Task<TimeExtent?> GetTimeExtent()
    {
        if (CoreJsModule is null)
        {
            return TimeExtent;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return TimeExtent;
        }

        TimeExtent? result = await JsComponentReference.InvokeAsync<TimeExtent?>(
            "getTimeExtent", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (TimeExtent is not null)
            {
                result.Id = TimeExtent.Id;
            }
            
#pragma warning disable BL0005
            TimeExtent = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(TimeExtent)] = TimeExtent;
        }
        
        return TimeExtent;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Units property.
    /// </summary>
    public async Task<QueryUnits?> GetUnits()
    {
        if (CoreJsModule is null)
        {
            return Units;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Units;
        }

        // get the property value
        QueryUnits? result = await JsComponentReference!.InvokeAsync<QueryUnits?>("getProperty",
            CancellationTokenSource.Token, "units");
        if (result is not null)
        {
#pragma warning disable BL0005
             Units = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Units)] = Units;
        }
         
        return Units;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Where property.
    /// </summary>
    public async Task<string?> GetWhere()
    {
        if (CoreJsModule is null)
        {
            return Where;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Where;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "where");
        if (result is not null)
        {
#pragma warning disable BL0005
             Where = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Where)] = Where;
        }
         
        return Where;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Distance property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDistance(double value)
    {
#pragma warning disable BL0005
        Distance = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Distance)] = value;
        
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
            JsComponentReference, "distance", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Geometry property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetGeometry(Geometry value)
    {
#pragma warning disable BL0005
        Geometry = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Geometry)] = value;
        
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
            JsComponentReference, "geometry", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ObjectIds property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetObjectIds(IReadOnlyList<long> value)
    {
#pragma warning disable BL0005
        ObjectIds = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ObjectIds)] = value;
        
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
            JsComponentReference, "objectIds", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SpatialRelationship property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSpatialRelationship(SpatialRelationship value)
    {
#pragma warning disable BL0005
        SpatialRelationship = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SpatialRelationship)] = value;
        
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
            JsComponentReference, "spatialRelationship", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the TimeExtent property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTimeExtent(TimeExtent value)
    {
#pragma warning disable BL0005
        TimeExtent = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(TimeExtent)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setTimeExtent", 
            CancellationTokenSource.Token, value);
 
        TimeExtent.Parent = this;
        TimeExtent.View = View;
        
        if (TimeExtent.JsComponentReference is null)
        {
            // new MapComponent, needs to be built and registered in JS
            // this also calls back to OnJsComponentCreated
            IJSObjectReference jsObjectReference = await CoreJsModule.InvokeAsync<IJSObjectReference>(
                $"buildJsTimeExtent", CancellationTokenSource.Token, 
                    TimeExtent, Layer?.Id, View?.Id);
            // in case the fallback failed, set this here.
            TimeExtent.JsComponentReference ??= jsObjectReference;
            
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference, "timeExtent", jsObjectReference);
        }
        else
        {
            // this component has already been registered, but we'll call setProperty to make sure
            // it is attached to the parent
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference,
                "timeExtent", TimeExtent.JsComponentReference);
        }
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Units property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetUnits(QueryUnits value)
    {
#pragma warning disable BL0005
        Units = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Units)] = value;
        
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
            JsComponentReference, "units", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Where property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetWhere(string value)
    {
#pragma warning disable BL0005
        Where = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Where)] = value;
        
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
            JsComponentReference, "where", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the ObjectIds property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToObjectIds(params long[] values)
    {
        long[] join = ObjectIds is null
            ? values
            : [..ObjectIds, ..values];
        await SetObjectIds(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the ObjectIds property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromObjectIds(params long[] values)
    {
        if (ObjectIds is null)
        {
            return;
        }
        await SetObjectIds(ObjectIds.Except(values).ToArray());
    }
    
#endregion


#region Public Methods

    /// <summary>
    ///     Creates <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html">query</a> parameters that can be used to fetch features that satisfy the layer's current filters and definitions.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html#createQuery">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public async Task<Query?> CreateQuery()
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Query?>(
            "createQuery", 
            CancellationTokenSource.Token);
    }
    
#endregion



}
