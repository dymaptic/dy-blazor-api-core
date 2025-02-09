// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Describes <a target="_blank" href="https://developers.arcgis.com/rest/services-reference/enterprise/measure.htm">mensuration operations</a> supported by the ImageryLayer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class ArcGISImageServiceCapabilitiesMensuration : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public ArcGISImageServiceCapabilitiesMensuration()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="supports3D">
    ///     Indicates if the layer supports 3D mensuration operations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="supportsAreaAndPerimeter">
    ///     Indicates if the layer supports area and perimeter mensuration operation.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="supportsDistanceAndAngle">
    ///     Indicates if the layer supports distance and angle mensuration operation.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="supportsHeightFromBaseAndTop">
    ///     Indicates if the layer supports a mensuration operation for calculating a height of a ground feature by measuring from the base of the object to the top of the object.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="supportsHeightFromBaseAndTopShadow">
    ///     Indicates if the layer supports a mensuration operation for calculating a height of a feature by measuring from the base of the object to the top of the object's shadow on the ground.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="supportsHeightFromTopAndTopShadow">
    ///     Indicates if the layer supports mensuration operation for calculating a height from the top of the object to the top of the objects's shadow on the ground.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="supportsPointOrCentroid">
    ///     Indicates if the layer supports point or centroid mensuration operations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public ArcGISImageServiceCapabilitiesMensuration(
        bool? supports3D = null,
        bool? supportsAreaAndPerimeter = null,
        bool? supportsDistanceAndAngle = null,
        bool? supportsHeightFromBaseAndTop = null,
        bool? supportsHeightFromBaseAndTopShadow = null,
        bool? supportsHeightFromTopAndTopShadow = null,
        bool? supportsPointOrCentroid = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Supports3D = supports3D;
        SupportsAreaAndPerimeter = supportsAreaAndPerimeter;
        SupportsDistanceAndAngle = supportsDistanceAndAngle;
        SupportsHeightFromBaseAndTop = supportsHeightFromBaseAndTop;
        SupportsHeightFromBaseAndTopShadow = supportsHeightFromBaseAndTopShadow;
        SupportsHeightFromTopAndTopShadow = supportsHeightFromTopAndTopShadow;
        SupportsPointOrCentroid = supportsPointOrCentroid;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Indicates if the layer supports 3D mensuration operations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Supports3D { get; set; }
    
    /// <summary>
    ///     Indicates if the layer supports area and perimeter mensuration operation.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsAreaAndPerimeter { get; set; }
    
    /// <summary>
    ///     Indicates if the layer supports distance and angle mensuration operation.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsDistanceAndAngle { get; set; }
    
    /// <summary>
    ///     Indicates if the layer supports a mensuration operation for calculating a height of a ground feature by measuring from the base of the object to the top of the object.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsHeightFromBaseAndTop { get; set; }
    
    /// <summary>
    ///     Indicates if the layer supports a mensuration operation for calculating a height of a feature by measuring from the base of the object to the top of the object's shadow on the ground.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsHeightFromBaseAndTopShadow { get; set; }
    
    /// <summary>
    ///     Indicates if the layer supports mensuration operation for calculating a height from the top of the object to the top of the objects's shadow on the ground.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsHeightFromTopAndTopShadow { get; set; }
    
    /// <summary>
    ///     Indicates if the layer supports point or centroid mensuration operations.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsPointOrCentroid { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Supports3D property.
    /// </summary>
    public async Task<bool?> GetSupports3D()
    {
        if (CoreJsModule is null)
        {
            return Supports3D;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Supports3D;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supports3D");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Supports3D = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Supports3D)] = Supports3D;
        }
         
        return Supports3D;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SupportsAreaAndPerimeter property.
    /// </summary>
    public async Task<bool?> GetSupportsAreaAndPerimeter()
    {
        if (CoreJsModule is null)
        {
            return SupportsAreaAndPerimeter;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SupportsAreaAndPerimeter;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supportsAreaAndPerimeter");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             SupportsAreaAndPerimeter = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SupportsAreaAndPerimeter)] = SupportsAreaAndPerimeter;
        }
         
        return SupportsAreaAndPerimeter;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SupportsDistanceAndAngle property.
    /// </summary>
    public async Task<bool?> GetSupportsDistanceAndAngle()
    {
        if (CoreJsModule is null)
        {
            return SupportsDistanceAndAngle;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SupportsDistanceAndAngle;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supportsDistanceAndAngle");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             SupportsDistanceAndAngle = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SupportsDistanceAndAngle)] = SupportsDistanceAndAngle;
        }
         
        return SupportsDistanceAndAngle;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SupportsHeightFromBaseAndTop property.
    /// </summary>
    public async Task<bool?> GetSupportsHeightFromBaseAndTop()
    {
        if (CoreJsModule is null)
        {
            return SupportsHeightFromBaseAndTop;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SupportsHeightFromBaseAndTop;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supportsHeightFromBaseAndTop");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             SupportsHeightFromBaseAndTop = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SupportsHeightFromBaseAndTop)] = SupportsHeightFromBaseAndTop;
        }
         
        return SupportsHeightFromBaseAndTop;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SupportsHeightFromBaseAndTopShadow property.
    /// </summary>
    public async Task<bool?> GetSupportsHeightFromBaseAndTopShadow()
    {
        if (CoreJsModule is null)
        {
            return SupportsHeightFromBaseAndTopShadow;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SupportsHeightFromBaseAndTopShadow;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supportsHeightFromBaseAndTopShadow");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             SupportsHeightFromBaseAndTopShadow = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SupportsHeightFromBaseAndTopShadow)] = SupportsHeightFromBaseAndTopShadow;
        }
         
        return SupportsHeightFromBaseAndTopShadow;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SupportsHeightFromTopAndTopShadow property.
    /// </summary>
    public async Task<bool?> GetSupportsHeightFromTopAndTopShadow()
    {
        if (CoreJsModule is null)
        {
            return SupportsHeightFromTopAndTopShadow;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SupportsHeightFromTopAndTopShadow;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supportsHeightFromTopAndTopShadow");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             SupportsHeightFromTopAndTopShadow = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SupportsHeightFromTopAndTopShadow)] = SupportsHeightFromTopAndTopShadow;
        }
         
        return SupportsHeightFromTopAndTopShadow;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the SupportsPointOrCentroid property.
    /// </summary>
    public async Task<bool?> GetSupportsPointOrCentroid()
    {
        if (CoreJsModule is null)
        {
            return SupportsPointOrCentroid;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SupportsPointOrCentroid;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supportsPointOrCentroid");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             SupportsPointOrCentroid = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SupportsPointOrCentroid)] = SupportsPointOrCentroid;
        }
         
        return SupportsPointOrCentroid;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Supports3D property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupports3D(bool value)
    {
#pragma warning disable BL0005
        Supports3D = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Supports3D)] = value;
        
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
            JsComponentReference, "supports3D", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SupportsAreaAndPerimeter property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupportsAreaAndPerimeter(bool value)
    {
#pragma warning disable BL0005
        SupportsAreaAndPerimeter = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SupportsAreaAndPerimeter)] = value;
        
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
            JsComponentReference, "supportsAreaAndPerimeter", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SupportsDistanceAndAngle property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupportsDistanceAndAngle(bool value)
    {
#pragma warning disable BL0005
        SupportsDistanceAndAngle = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SupportsDistanceAndAngle)] = value;
        
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
            JsComponentReference, "supportsDistanceAndAngle", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SupportsHeightFromBaseAndTop property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupportsHeightFromBaseAndTop(bool value)
    {
#pragma warning disable BL0005
        SupportsHeightFromBaseAndTop = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SupportsHeightFromBaseAndTop)] = value;
        
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
            JsComponentReference, "supportsHeightFromBaseAndTop", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SupportsHeightFromBaseAndTopShadow property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupportsHeightFromBaseAndTopShadow(bool value)
    {
#pragma warning disable BL0005
        SupportsHeightFromBaseAndTopShadow = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SupportsHeightFromBaseAndTopShadow)] = value;
        
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
            JsComponentReference, "supportsHeightFromBaseAndTopShadow", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SupportsHeightFromTopAndTopShadow property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupportsHeightFromTopAndTopShadow(bool value)
    {
#pragma warning disable BL0005
        SupportsHeightFromTopAndTopShadow = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SupportsHeightFromTopAndTopShadow)] = value;
        
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
            JsComponentReference, "supportsHeightFromTopAndTopShadow", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the SupportsPointOrCentroid property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupportsPointOrCentroid(bool value)
    {
#pragma warning disable BL0005
        SupportsPointOrCentroid = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SupportsPointOrCentroid)] = value;
        
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
            JsComponentReference, "supportsPointOrCentroid", value);
    }
    
#endregion

}
