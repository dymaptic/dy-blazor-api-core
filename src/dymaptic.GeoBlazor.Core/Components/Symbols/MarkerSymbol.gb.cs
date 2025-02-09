// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Symbols;


/// <summary>
///    Marker symbols are used to draw <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Point.html">Point</a> graphics in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html">FeatureLayer</a> or individual <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Graphic.html">graphics</a> in a 2D <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html">MapView</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-symbols-MarkerSymbol.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public abstract partial class MarkerSymbol
{

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Angle property.
    /// </summary>
    public async Task<double?> GetAngle()
    {
        if (CoreJsModule is null)
        {
            return Angle;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Angle;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "angle");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Angle = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Angle)] = Angle;
        }
         
        return Angle;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Xoffset property.
    /// </summary>
    public async Task<Dimension?> GetXoffset()
    {
        if (CoreJsModule is null)
        {
            return Xoffset;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Xoffset;
        }

        // get the property value
        Dimension? result = await JsComponentReference!.InvokeAsync<Dimension?>("getProperty",
            CancellationTokenSource.Token, "xoffset");
        if (result is not null)
        {
#pragma warning disable BL0005
             Xoffset = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Xoffset)] = Xoffset;
        }
         
        return Xoffset;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Yoffset property.
    /// </summary>
    public async Task<Dimension?> GetYoffset()
    {
        if (CoreJsModule is null)
        {
            return Yoffset;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Yoffset;
        }

        // get the property value
        Dimension? result = await JsComponentReference!.InvokeAsync<Dimension?>("getProperty",
            CancellationTokenSource.Token, "yoffset");
        if (result is not null)
        {
#pragma warning disable BL0005
             Yoffset = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Yoffset)] = Yoffset;
        }
         
        return Yoffset;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Angle property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetAngle(double value)
    {
#pragma warning disable BL0005
        Angle = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Angle)] = value;
        
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
            JsComponentReference, "angle", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Xoffset property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetXoffset(Dimension value)
    {
#pragma warning disable BL0005
        Xoffset = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Xoffset)] = value;
        
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
            JsComponentReference, "xoffset", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Yoffset property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetYoffset(Dimension value)
    {
#pragma warning disable BL0005
        Yoffset = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Yoffset)] = value;
        
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
            JsComponentReference, "yoffset", value);
    }
    
#endregion

}
