﻿using dymaptic.GeoBlazor.Core.Components.Geometries;
using dymaptic.GeoBlazor.Core.Objects;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using ProtoBuf;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace dymaptic.GeoBlazor.Core.Components.Layers;

/// <summary>
///     The FeatureLayerView is responsible for rendering a FeatureLayer's features as graphics in the View. The methods in
///     the FeatureLayerView provide developers with the ability to query and highlight graphics in the view. See the code
///     snippets in the methods below for examples of how to access client-side graphics from the view.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html#whenLayerView">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public class FeatureLayerView : LayerView
{
    internal FeatureLayerView(LayerView layerView, AbortManager abortManager)
    {
        _abortManager = abortManager;
        JsObjectReference = layerView.JsObjectReference;
        SpatialReferenceSupported = layerView.SpatialReferenceSupported;
        Suspended = layerView.Suspended;
        Updating = layerView.Updating;
        Visible = layerView.Visible;
    }

    /// <summary>
    ///     The attribute, geometry, and time extent filter. Only the features that satisfy the filter are displayed on the
    ///     view.
    /// </summary>
    public FeatureFilter? Filter { get; private set; }


    /// <summary>
    ///     The featureEffect can be used to draw attention features of interest.
    /// </summary>
    public FeatureEffect? FeatureEffect { get; private set; }

    /// <summary>
    ///     Sets the <see cref="FeatureFilter" /> for this view.
    /// </summary>
    /// <param name="filter">
    ///     The new filter (or null to clear) to apply to this view.
    /// </param>
    public async Task SetFilter(FeatureFilter? filter)
    {
        await JsObjectReference!.InvokeVoidAsync("setFilter", CancellationTokenSource.Token, filter);
        Filter = filter;
    }


    /// <summary>
    ///  Sets the <see cref="FeatureEffect" /> for this view.
    /// </summary>
    /// <param name="featureEffect">
    /// The new effect (or null to clear) to apply to this view.
    /// </param>

    public async Task SetFeatureEffect(FeatureEffect? featureEffect)
    {
        await JsObjectReference!.InvokeVoidAsync("setFeatureEffect", CancellationTokenSource.Token, featureEffect);
        FeatureEffect = featureEffect;
    }

    /// <summary>
    ///     Highlights the given feature(s).
    /// </summary>
    /// <param name="objectId">
    ///     The ObjectID of the graphic to highlight.
    /// </param>
    /// <returns>
    ///     A handle that allows the highlight to be removed later.
    /// </returns>
    public async Task<HighlightHandle> Highlight(int objectId)
    {
        IJSObjectReference objectRef =
            await JsObjectReference!.InvokeAsync<IJSObjectReference>("highlight",
                CancellationTokenSource.Token, objectId);

        return new HighlightHandle(objectRef);
    }

    /// <summary>
    ///     Highlights the given feature(s).
    /// </summary>
    /// <param name="objectIds">
    ///     The ObjectIDs of the graphics to highlight.
    /// </param>
    /// <returns>
    ///     A handle that allows the highlight to be removed later.
    /// </returns>
    public async Task<HighlightHandle> Highlight(IEnumerable<int> objectIds)
    {
        IJSObjectReference objectRef =
            await JsObjectReference!.InvokeAsync<IJSObjectReference>("highlight",
                CancellationTokenSource.Token, objectIds);

        return new HighlightHandle(objectRef);
    }

    /// <summary>
    ///     Highlights the given feature(s).
    /// </summary>
    /// <param name="graphic">
    ///     The <see cref="Graphic" /> to highlight.
    /// </param>
    /// <returns>
    ///     A handle that allows the highlight to be removed later.
    /// </returns>
    public async Task<HighlightHandle> Highlight(Graphic graphic)
    {
        IJSObjectReference objectRef =
            await JsObjectReference!.InvokeAsync<IJSObjectReference>("highlight",
                CancellationTokenSource.Token, graphic);

        return new HighlightHandle(objectRef);
    }

    /// <summary>
    ///     Highlights the given feature(s).
    /// </summary>
    /// <param name="graphics">
    ///     The graphics to highlight.
    /// </param>
    /// <returns>
    ///     A handle that allows the highlight to be removed later.
    /// </returns>
    public async Task<HighlightHandle> Highlight(IEnumerable<Graphic> graphics)
    {
        IJSObjectReference objectRef =
            await JsObjectReference!.InvokeAsync<IJSObjectReference>("highlight",
                CancellationTokenSource.Token, graphics);

        return new HighlightHandle(objectRef);
    }

    /// <summary>
    ///     Creates query parameter object that can be used to fetch features as they are being displayed. It sets the query
    ///     parameter's outFields property to ["*"] and returnGeometry to true. The output spatial reference
    ///     outSpatialReference is set to the spatial reference of the view. Parameters of the filter currently applied to the
    ///     layerview are also incorporated in the returned query object. The results will include geometries of features and
    ///     values for availableFields.
    /// </summary>
    public async Task<Query> CreateQuery()
    {
        return await JsObjectReference!.InvokeAsync<Query>("createQuery", CancellationTokenSource.Token);
    }

    /// <summary>
    ///     Executes a Query against features available for drawing in the layerView and returns the Extent of features that
    ///     satisfy the query. Valid only for hosted feature services on arcgis.com and for ArcGIS Server 10.3.1 and later. If
    ///     query parameters are not provided, the extent and count of all features available for drawing are returned.
    ///     To query for the extent of features directly from a Feature Service rather than those visible in the view, you must
    ///     use the <see cref="FeatureLayer.QueryExtent" /> method.
    /// </summary>
    /// <remarks>
    ///     Spatial queries are executed against quantized geometries in the layerView. The resolution of layerView geometries,
    ///     is only as precise as the scale resolution of the view. Therefore, the results of the same query could be different
    ///     when executed at different scales. This also means that geometries returned from any layerView query will likewise
    ///     be at the same scale resolution of the view.
    ///     Spatial queries have the same limitations as those listed in the projection engine documentation.
    ///     Spatial queries are not currently supported if the FeatureLayerView has any of the following SpatialReferences:
    ///     GDM 2000 (4742) – Malaysia,
    ///     Gusterberg (Ferro) (8042) – Austria/Czech Republic,
    ///     ISN2016 (8086) - Iceland,
    ///     SVY21 (4757) - Singapore
    /// </remarks>
    /// <param name="query">
    ///     Specifies the attributes and spatial filter of the query. When no parameters are passed to this method, all
    ///     features in the client are returned. To only return features visible in the view, set the geometry parameter in the
    ///     query object to the view's extent.
    /// </param>
    /// <param name="cancellationToken">
    ///     A cancellation token that can be used to cancel the query operation.
    /// </param>
    public async Task<ExtentQueryResult> QueryExtent(Query query, CancellationToken cancellationToken = default)
    {
        IJSObjectReference abortSignal = await _abortManager.CreateAbortSignal(cancellationToken);

        ExtentQueryResult result = await JsObjectReference!.InvokeAsync<ExtentQueryResult>("queryExtent",
            cancellationToken, query, new { signal = abortSignal });

        await _abortManager.DisposeAbortController(cancellationToken);

        return result;
    }

    /// <summary>
    ///     Executes a Query against features available for drawing in the layerView and returns the number of features that
    ///     satisfy the query. If query parameters are not provided, the count of all features available for drawing is
    ///     returned.
    ///     To query for the count of features directly from a Feature Service rather than those visible in the view, you must
    ///     use the <see cref="FeatureLayer.QueryFeatureCount" /> method.
    /// </summary>
    /// <remarks>
    ///     Spatial queries are executed against quantized geometries in the layerView. The resolution of layerView geometries,
    ///     is only as precise as the scale resolution of the view. Therefore, the results of the same query could be different
    ///     when executed at different scales. This also means that geometries returned from any layerView query will likewise
    ///     be at the same scale resolution of the view.
    ///     Spatial queries have the same limitations as those listed in the projection engine documentation.
    ///     Spatial queries are not currently supported if the FeatureLayerView has any of the following SpatialReferences:
    ///     GDM 2000 (4742) – Malaysia,
    ///     Gusterberg (Ferro) (8042) – Austria/Czech Republic,
    ///     ISN2016 (8086) - Iceland,
    ///     SVY21 (4757) - Singapore
    /// </remarks>
    /// <param name="query">
    ///     Specifies the attributes and spatial filter of the query. When no parameters are passed to this method, all
    ///     features in the client are returned. To only return features visible in the view, set the geometry parameter in the
    ///     query object to the view's extent.
    /// </param>
    /// <param name="cancellationToken">
    ///     A cancellation token that can be used to cancel the query operation.
    /// </param>
    /// <returns></returns>
    public async Task<int> QueryFeatureCount(Query? query = null, CancellationToken cancellationToken = default)
    {
        IJSObjectReference abortSignal = await _abortManager.CreateAbortSignal(cancellationToken);

        int result = await JsObjectReference!.InvokeAsync<int>("queryFeatureCount", cancellationToken,
            query, new { signal = abortSignal });

        await _abortManager.DisposeAbortController(cancellationToken);

        return result;
    }

    /// <summary>
    ///     Executes a Query against features available for drawing in the layerView and returns a FeatureSet. If query
    ///     parameters are not provided, all features available for drawing are returned along with their attributes that are
    ///     available on the client. For client-side attribute queries, relevant fields should exist in availableFields list
    ///     for the query to be successful.
    ///     To execute a query against all the features in a feature service rather than only those in the client, you must use
    ///     the <see cref="FeatureLayer.QueryFeatures" /> method.
    /// </summary>
    /// <remarks>
    ///     Attribute values used in attribute queries executed against layerViews are case sensitive.
    ///     Spatial queries are executed against quantized geometries in the layerView. The resolution of layerView geometries,
    ///     is only as precise as the scale resolution of the view. Therefore, the results of the same query could be different
    ///     when executed at different scales. This also means that geometries returned from any layerView query will likewise
    ///     be at the same scale resolution of the view.
    ///     Spatial queries have the same limitations as those listed in the projection engine documentation.
    ///     Spatial queries are not currently supported if the FeatureLayerView has any of the following SpatialReferences:
    ///     GDM 2000 (4742) – Malaysia,
    ///     Gsterberg (Ferro) (8042) – Austria/Czech Republic,
    ///     ISN2016 (8086) - Iceland,
    ///     SVY21 (4757) - Singapore
    /// </remarks>
    /// <param name="query">
    ///     Specifies the attributes and spatial filter of the query. When this parameter is not passed to queryFeatures()
    ///     method, all features available for drawing are returned along with their attributes that are available on the
    ///     client. To only return features visible in the view, set the geometry parameter in the query object to the view's
    ///     extent.
    /// </param>
    /// <param name="cancellationToken">
    ///     A cancellation token that can be used to cancel the query operation.
    /// </param>
    /// <returns></returns>
    public async Task<FeatureSet?> QueryFeatures(Query? query = null, CancellationToken cancellationToken = default)
    {
        IJSObjectReference abortSignal =
            await _abortManager.CreateAbortSignal(cancellationToken);
        Guid queryId = Guid.NewGuid();

        FeatureSet result = await JsObjectReference!.InvokeAsync<FeatureSet>("queryFeatures", cancellationToken,
            query, new { signal = abortSignal }, DotNetObjectReference.Create(this), Layer.View?.Id, queryId);

        if (_activeQueries.ContainsKey(queryId))
        {
            result.Features = _activeQueries[queryId];
            _activeQueries.Remove(queryId);
        }
        
        foreach (Graphic graphic in result.Features!)
        {
            graphic.LayerId = Layer.Id;
        }

        await _abortManager.DisposeAbortController(cancellationToken);

        return result;
    }

    /// <summary>
    ///     Internal use callback from JavaScript
    /// </summary>
    [JSInvokable]
    public async Task OnQueryFeaturesStreamCallback(IJSStreamReference streamReference, Guid queryId)
    {
        try
        {
            await using Stream stream = await streamReference
                .OpenReadStreamAsync(Layer.View?.QueryResultsMaxSizeLimit ?? 1_000_000_000L);
            using var ms = new MemoryStream();
            await stream.CopyToAsync(ms);
            ms.Seek(0, SeekOrigin.Begin);
            ProtoGraphicCollection collection = Serializer.Deserialize<ProtoGraphicCollection>(ms);
            Graphic[] graphics = collection?.Graphics.Select(g => g.FromSerializationRecord()).ToArray()!;

            _activeQueries[queryId] = graphics;
        }
        catch (Exception ex)
        {
            throw new SerializationException("Error deserializing graphics from stream.", ex);   
        }
    }

    /// <summary>
    ///     Executes a Query against features available for drawing in the layerView and returns array of the ObjectIDs of
    ///     features that satisfy the input query. If query parameters are not provided, the ObjectIDs of all features
    ///     available for drawing are returned.
    ///     To query for ObjectIDs of features directly from a Feature Service rather than those visible in the view, you must
    ///     use the <see cref="FeatureLayer.QueryObjectIds" /> method.
    /// </summary>
    /// <param name="query">
    ///     Specifies the attributes and spatial filter of the query. When no parameters are passed to this method, all
    ///     features in the client are returned. To only return features visible in the view, set the geometry parameter in the
    ///     query object to the view's extent.
    /// </param>
    /// <param name="cancellationToken">
    ///     A cancellation token that can be used to cancel the query operation.
    /// </param>
    public async Task<int[]> QueryObjectIds(Query query, CancellationToken cancellationToken = default)
    {
        IJSObjectReference abortSignal = await _abortManager.CreateAbortSignal(cancellationToken);

        int[] queryResult = await JsObjectReference!.InvokeAsync<int[]>("queryObjectIds", cancellationToken,
            query, new { signal = abortSignal });

        await _abortManager.DisposeAbortController(cancellationToken);

        return queryResult;
    }

    private readonly AbortManager _abortManager;
    private Dictionary<Guid, Graphic[]> _activeQueries = new();
}

/// <summary>
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureFilter.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public class FeatureFilter
{
    /// <summary>
    ///     Specifies a search distance from a given geometry in a spatial filter. The units property indicates the unit of
    ///     measurement. In essence, setting this property creates a buffer at the specified size around the input geometry.
    ///     The filter will use that buffer to display features in the layer or layer view that adhere to the to the indicated
    ///     spatial relationship.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Distance { get; set; }

    /// <summary>
    ///     The geometry to apply to the spatial filter. The spatial relationship as specified by spatialRelationship will
    ///     indicate how the geometry should be used to filter features.
    /// </summary>
    /// <remarks>
    ///     Known Limitations: Mesh geometry types are currently not supported.
    /// </remarks>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Geometry? Geometry { get; set; }

    /// <summary>
    ///     An array of objectIds of the features to be filtered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<int>? ObjectIds { get; set; }

    /// <summary>
    ///     For spatial filters, this parameter defines the spatial relationship to filter features in the layer view against
    ///     the filter geometry. The spatial relationships discover how features are spatially related to each other. For
    ///     example, you may want to know if a polygon representing a county completely contains points representing
    ///     settlements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SpatialRelationship? SpatialRelationship { get; set; }

    /// <summary>
    ///     A range of time with start and end date. Only the features that fall within this time extent will be displayed. The
    ///     Date field to be used for timeExtent should be added to outFields list when the layer is initialized. This ensures
    ///     the best user experience when switching or updating fields for time filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TimeExtent? TimeExtent { get; set; }

    /// <summary>
    ///     The unit for calculating the buffer distance when distance is specified in a spatial filter. If units is not
    ///     specified, the unit is derived from the filter geometry's spatial reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LinearUnit? Units { get; set; }

    /// <summary>
    ///     A where clause for the feature filter. Any legal SQL92 where clause operating on the fields in the layer is
    ///     allowed. Be sure to have the correct sequence of single and double quotes when writing the where clause in
    ///     JavaScript.
    ///     For apps where users can interactively change fields used for attribute filter, we suggest you include all possible
    ///     fields in the outFields of the layer. This ensures the best user experience when switching or updating fields for
    ///     attribute filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Where { get; set; }
}

/// <summary>
///  <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureEffect.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public class FeatureEffect
{
    /// <summary>
    /// The effect applied to features that do not meet the filter requirements.
    /// </summary>
    public List<Effect>? ExcludedEffect { get; set; }

    /// <summary>
    /// Indicates if labels are visible for features that are excluded from the filter.
    /// </summary>
    public bool? ExcludedLabelsVisible { get; set; }

    /// <summary>
    ///  The filter that drives the effect.
    /// </summary>
    public FeatureFilter? Filter { get; set; }

    /// <summary>
    /// The effect applied to features that meet the filter requirements.
    /// </summary>
    public List<Effect>? IncludedEffect { get; set; }

}

/// <summary>
///  <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureEffect.html#Effect">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public class Effect
{
    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="value">
    ///     The effect to be applied to a layer or layerView at the corresponding scale. Use only when setting a scale dependent effect.
    /// </param>
    /// <param name="scale">
    ///     The scale of the view for the effect to take place. Use only when setting a scale dependent effect.
    /// </param>
    public Effect(string value, double? scale = null)
    {
        Value = value;
    }

    /// <summary>
    ///     Constructor
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public Effect()
    {
        
    }
    
    /// <summary>
    ///     Implicit conversion from string to Effect
    /// </summary>
    public static implicit operator Effect(string stringVal)
    {
        return new Effect(stringVal);
    }
    
    /// <summary>
    ///     The scale of the view for the effect to take place. Use only when setting a scale dependent effect.
    /// </summary>
    public double? Scale { get; set; }
    /// <summary>
    ///     The effect to be applied to a layer or layerView at the corresponding scale. Use only when setting a scale dependent effect.
    /// </summary>
    public string? Value { get; set; }
}