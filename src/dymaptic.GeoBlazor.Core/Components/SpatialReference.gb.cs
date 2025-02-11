// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Defines the spatial reference of a view, layer, or method parameters.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-SpatialReference.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class SpatialReference
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public SpatialReference()
    {
    }

#region Public Properties / Blazor Parameters

    /// <summary>
    ///     An <a target="_blank" href="https://developers.arcgis.com/rest/services-reference/raster-ics.htm">image coordinate system</a> defines the spatial reference used to display the image in its original coordinates without distortion, map transformations or ortho-rectification.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-SpatialReference.html#imageCoordinateSystem">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ImageCoordinateSystem { get; set; }
    
    /// <summary>
    ///     The factor to convert one unit value in the spatial reference's <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-SpatialReference.html#unit">unit</a> to meters.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-SpatialReference.html#metersPerUnit">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MetersPerUnit { get; protected set; }
    
    /// <summary>
    ///     The unit of the spatial reference.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-SpatialReference.html#unit">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SpatialReferenceUnit? Unit { get; protected set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the ImageCoordinateSystem property.
    /// </summary>
    public async Task<string?> GetImageCoordinateSystem()
    {
        if (CoreJsModule is null)
        {
            return ImageCoordinateSystem;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ImageCoordinateSystem;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "imageCoordinateSystem");
        if (result is not null)
        {
#pragma warning disable BL0005
             ImageCoordinateSystem = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ImageCoordinateSystem)] = ImageCoordinateSystem;
        }
         
        return ImageCoordinateSystem;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the MetersPerUnit property.
    /// </summary>
    public async Task<double?> GetMetersPerUnit()
    {
        if (CoreJsModule is null)
        {
            return MetersPerUnit;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return MetersPerUnit;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "metersPerUnit");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             MetersPerUnit = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(MetersPerUnit)] = MetersPerUnit;
        }
         
        return MetersPerUnit;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Unit property.
    /// </summary>
    public async Task<SpatialReferenceUnit?> GetUnit()
    {
        if (CoreJsModule is null)
        {
            return Unit;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Unit;
        }

        // get the property value
        JsNullableEnumWrapper<SpatialReferenceUnit>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<SpatialReferenceUnit>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "unit");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Unit = (SpatialReferenceUnit)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Unit)] = Unit;
        }
         
        return Unit;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Wkid property.
    /// </summary>
    public async Task<int?> GetWkid()
    {
        if (CoreJsModule is null)
        {
            return Wkid;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Wkid;
        }

        // get the property value
        JsNullableIntWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableIntWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "wkid");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Wkid = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Wkid)] = Wkid;
        }
         
        return Wkid;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Wkt property.
    /// </summary>
    public async Task<string?> GetWkt()
    {
        if (CoreJsModule is null)
        {
            return Wkt;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Wkt;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "wkt");
        if (result is not null)
        {
#pragma warning disable BL0005
             Wkt = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Wkt)] = Wkt;
        }
         
        return Wkt;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Wkt2 property.
    /// </summary>
    public async Task<string?> GetWkt2()
    {
        if (CoreJsModule is null)
        {
            return Wkt2;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Wkt2;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "wkt2");
        if (result is not null)
        {
#pragma warning disable BL0005
             Wkt2 = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Wkt2)] = Wkt2;
        }
         
        return Wkt2;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the ImageCoordinateSystem property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetImageCoordinateSystem(string value)
    {
#pragma warning disable BL0005
        ImageCoordinateSystem = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ImageCoordinateSystem)] = value;
        
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
            JsComponentReference, "imageCoordinateSystem", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Wkid property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetWkid(int value)
    {
#pragma warning disable BL0005
        Wkid = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Wkid)] = value;
        
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
            JsComponentReference, "wkid", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Wkt property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetWkt(string value)
    {
#pragma warning disable BL0005
        Wkt = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Wkt)] = value;
        
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
            JsComponentReference, "wkt", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Wkt2 property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetWkt2(string value)
    {
#pragma warning disable BL0005
        Wkt2 = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Wkt2)] = value;
        
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
            JsComponentReference, "wkt2", value);
    }
    
#endregion

    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        if (Wkid is null && Wkt is null && Wkt2 is null)
        {
            throw new MissingRequiredOptionsChildElementException(nameof(SpatialReference), [nameof(Wkid), nameof(Wkt), nameof(Wkt2)]);
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
