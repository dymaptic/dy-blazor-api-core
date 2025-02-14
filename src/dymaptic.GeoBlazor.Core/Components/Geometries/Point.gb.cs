// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Geometries;


/// <summary>
///    A location defined by X, Y, and Z coordinates.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class Point
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public Point()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="longitude">
    ///     The longitude of the point.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#longitude">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="latitude">
    ///     The latitude of the point.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#latitude">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="x">
    ///     The x-coordinate (easting) of the point in map units.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#x">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="y">
    ///     The y-coordinate (northing) of the point in map units.
    ///     default 0
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#y">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="z">
    ///     The z-coordinate (or elevation) of the point in map units.
    ///     default undefined
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#z">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="spatialReference">
    ///     The spatial reference of the geometry.
    ///     default WGS84 (wkid: 4326)
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html#spatialReference">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="hasM">
    ///     Indicates if the geometry has M values.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html#hasM">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="hasZ">
    ///     Indicates if the geometry has z-values (elevation).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Geometry.html#hasZ">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="m">
    ///     The m-coordinate of the point in map units.
    ///     default undefined
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#m">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public Point(
        double? longitude = null,
        double? latitude = null,
        double? x = null,
        double? y = null,
        double? z = null,
        SpatialReference? spatialReference = null,
        bool? hasM = null,
        bool? hasZ = null,
        double? m = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Longitude = longitude;
        Latitude = latitude;
        X = x;
        Y = y;
        Z = z;
        SpatialReference = spatialReference;
        HasM = hasM;
        HasZ = hasZ;
        M = m;
#pragma warning restore BL0005    
    }
    
    
#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Latitude property.
    /// </summary>
    public async Task<double?> GetLatitude()
    {
        if (CoreJsModule is null)
        {
            return Latitude;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Latitude;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "latitude");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Latitude = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Latitude)] = Latitude;
        }
         
        return Latitude;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Longitude property.
    /// </summary>
    public async Task<double?> GetLongitude()
    {
        if (CoreJsModule is null)
        {
            return Longitude;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Longitude;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "longitude");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Longitude = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Longitude)] = Longitude;
        }
         
        return Longitude;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the M property.
    /// </summary>
    public async Task<double?> GetM()
    {
        if (CoreJsModule is null)
        {
            return M;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return M;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "m");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             M = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(M)] = M;
        }
         
        return M;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the X property.
    /// </summary>
    public async Task<double?> GetX()
    {
        if (CoreJsModule is null)
        {
            return X;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return X;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "x");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             X = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(X)] = X;
        }
         
        return X;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Y property.
    /// </summary>
    public async Task<double?> GetY()
    {
        if (CoreJsModule is null)
        {
            return Y;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Y;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "y");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Y = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Y)] = Y;
        }
         
        return Y;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Z property.
    /// </summary>
    public async Task<double?> GetZ()
    {
        if (CoreJsModule is null)
        {
            return Z;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Z;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "z");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Z = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Z)] = Z;
        }
         
        return Z;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Latitude property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLatitude(double? value)
    {
#pragma warning disable BL0005
        Latitude = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Latitude)] = value;
        
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
            JsComponentReference, "latitude", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Longitude property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLongitude(double? value)
    {
#pragma warning disable BL0005
        Longitude = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Longitude)] = value;
        
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
            JsComponentReference, "longitude", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the M property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetM(double? value)
    {
#pragma warning disable BL0005
        M = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(M)] = value;
        
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
            JsComponentReference, "m", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the X property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetX(double? value)
    {
#pragma warning disable BL0005
        X = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(X)] = value;
        
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
            JsComponentReference, "x", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Y property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetY(double? value)
    {
#pragma warning disable BL0005
        Y = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Y)] = value;
        
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
            JsComponentReference, "y", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Z property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetZ(double? value)
    {
#pragma warning disable BL0005
        Z = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Z)] = value;
        
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
            JsComponentReference, "z", value);
    }
    
#endregion

#region Public Methods

    /// <summary>
    ///     Copies all values from another Point instance.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#copy">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="other">
    ///     The point to copy from.
    /// </param>
    [ArcGISMethod]
    public async Task<Point?> Copy(Point other)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Point?>(
            "copy", 
            CancellationTokenSource.Token,
            other);
    }
    
    /// <summary>
    ///     Computes the Euclidean distance between this Point and a given Point.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#distance">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="other">
    ///     The point to compute the distance to.
    /// </param>
    [ArcGISMethod]
    public async Task<double?> Distance(Point other)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<double?>(
            "distance", 
            CancellationTokenSource.Token,
            other);
    }
    
    /// <summary>
    ///     Modifies the point geometry in-place by shifting the X-coordinate to within +/- 180 span in map units.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html#normalize">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public async Task<Point?> Normalize()
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Point?>(
            "normalize", 
            CancellationTokenSource.Token);
    }
    
#endregion

}
