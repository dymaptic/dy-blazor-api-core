// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Geometries;


/// <summary>
///    A polygon contains an array of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#rings">rings</a> and a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#spatialReference">spatialReference</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class Polygon
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public Polygon()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="rings">
    ///     An array of rings.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#rings">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="spatialReference">
    ///     The spatial reference of the geometry.
    ///     default WGS84 (wkid: 4326)
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html#spatialReference">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="centroid">
    ///     The centroid of the polygon.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#centroid">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="hasM">
    ///     Indicates if the geometry has M values.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html#hasM">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="hasZ">
    ///     Indicates if the geometry has z-values (elevation).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html#hasZ">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="isSelfIntersecting">
    ///     Checks to see if polygon rings cross each other and indicates if the polygon is self-intersecting, which means the ring of the polygon crosses itself.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#isSelfIntersecting">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public Polygon(
        IReadOnlyList<MapPath> rings,
        SpatialReference? spatialReference = null,
        Point? centroid = null,
        bool? hasM = null,
        bool? hasZ = null,
        bool? isSelfIntersecting = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Rings = rings;
        SpatialReference = spatialReference;
        Centroid = centroid;
        HasM = hasM;
        HasZ = hasZ;
        IsSelfIntersecting = isSelfIntersecting;
#pragma warning restore BL0005    
    }
    
    
#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Centroid property.
    /// </summary>
    public async Task<Point?> GetCentroid()
    {
        if (CoreJsModule is null)
        {
            return Centroid;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Centroid;
        }

        // get the property value
        Point? result = await CoreJsModule!.InvokeAsync<Point?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "centroid");
        if (result is not null)
        {
#pragma warning disable BL0005
             Centroid = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Centroid)] = Centroid;
        }
         
        return Centroid;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the IsSelfIntersecting property.
    /// </summary>
    public async Task<bool?> GetIsSelfIntersecting()
    {
        if (CoreJsModule is null)
        {
            return IsSelfIntersecting;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return IsSelfIntersecting;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "isSelfIntersecting");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             IsSelfIntersecting = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(IsSelfIntersecting)] = IsSelfIntersecting;
        }
         
        return IsSelfIntersecting;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Centroid property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetCentroid(Point value)
    {
#pragma warning disable BL0005
        Centroid = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Centroid)] = value;
        
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
            JsComponentReference, "centroid", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the IsSelfIntersecting property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetIsSelfIntersecting(bool value)
    {
#pragma warning disable BL0005
        IsSelfIntersecting = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(IsSelfIntersecting)] = value;
        
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
            JsComponentReference, "isSelfIntersecting", value);
    }
    
#endregion


#region Public Methods

    /// <summary>
    ///     Adds a ring to the Polygon.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#addRing">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="points">
    ///     A polygon ring. The first and last coordinates/points
    ///     in the ring must be the same. This can either be defined as an array of
    ///     Point geometries or an array of XY coordinates.
    /// </param>
    [ArcGISMethod]
    public async Task<Polygon?> AddRing(IReadOnlyCollection<Point> points)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Polygon?>(
            "addRing", 
            CancellationTokenSource.Token,
            points);
    }
    
    /// <summary>
    ///     Checks on the client if the input point is inside the polygon.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#contains">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="point">
    ///     The point to test whether it is contained within the testing polygon.
    /// </param>
    [ArcGISMethod]
    public async Task<bool?> Contains(Point point)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<bool?>(
            "contains", 
            CancellationTokenSource.Token,
            point);
    }
    
    /// <summary>
    ///     Returns a point specified by a ring and point in the path.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#getPoint">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="ringIndex">
    ///     The index of the ring containing the desired point.
    /// </param>
    /// <param name="pointIndex">
    ///     The index of the desired point within the ring.
    /// </param>
    [ArcGISMethod]
    public async Task<Point?> GetPoint(int ringIndex,
        int pointIndex)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Point?>(
            "getPoint", 
            CancellationTokenSource.Token,
            ringIndex,
            pointIndex);
    }
    
    /// <summary>
    ///     Inserts a new point into the polygon.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#insertPoint">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="ringIndex">
    ///     The index of the ring in which to insert the point.
    /// </param>
    /// <param name="pointIndex">
    ///     The index of the point to insert within the ring.
    /// </param>
    /// <param name="point">
    ///     The point to insert.
    /// </param>
    [ArcGISMethod]
    public async Task<Polygon?> InsertPoint(int ringIndex,
        int pointIndex,
        Point point)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Polygon?>(
            "insertPoint", 
            CancellationTokenSource.Token,
            ringIndex,
            pointIndex,
            point);
    }
    
    /// <summary>
    ///     Checks if a Polygon ring is clockwise.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#isClockwise">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="ring">
    ///     A polygon ring. It can either be defined as an array of
    ///     Point geometries or an array of XY coordinates.
    /// </param>
    [ArcGISMethod]
    public async Task<bool?> IsClockwise(IReadOnlyCollection<Point> ring)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<bool?>(
            "isClockwise", 
            CancellationTokenSource.Token,
            ring);
    }
    
    /// <summary>
    ///     Removes a point from the polygon at the given `pointIndex` within the ring identified by `ringIndex`.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#removePoint">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="ringIndex">
    ///     The index of the ring containing the point to remove.
    /// </param>
    /// <param name="pointIndex">
    ///     The index of the point to remove within the ring.
    /// </param>
    [ArcGISMethod]
    public async Task<Point[]?> RemovePoint(int ringIndex,
        int pointIndex)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Point[]?>(
            "removePoint", 
            CancellationTokenSource.Token,
            ringIndex,
            pointIndex);
    }
    
    /// <summary>
    ///     Removes a ring from the Polygon.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#removeRing">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="index">
    ///     The index of the ring to remove.
    /// </param>
    [ArcGISMethod]
    public async Task<Point[]?> RemoveRing(int index)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Point[]?>(
            "removeRing", 
            CancellationTokenSource.Token,
            index);
    }
    
    /// <summary>
    ///     Updates a point in the polygon.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polygon.html#setPoint">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="ringIndex">
    ///     The index of the ring containing the point to update.
    /// </param>
    /// <param name="pointIndex">
    ///     The index of the point to update within the ring.
    /// </param>
    /// <param name="point">
    ///     The new point geometry.
    /// </param>
    [ArcGISMethod]
    public async Task<Polygon?> SetPoint(int ringIndex,
        int pointIndex,
        Point point)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Polygon?>(
            "setPoint", 
            CancellationTokenSource.Token,
            ringIndex,
            pointIndex,
            point);
    }
    
#endregion



}
