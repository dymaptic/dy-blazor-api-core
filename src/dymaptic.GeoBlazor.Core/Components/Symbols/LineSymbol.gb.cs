// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Symbols;


/// <summary>
///    Line symbols are used to draw <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-geometry-Polyline.html">Polyline</a> features in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html">FeatureLayer</a> in a 2D <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html">MapView</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-symbols-LineSymbol.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public abstract partial class LineSymbol
{

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Width property.
    /// </summary>
    public async Task<Dimension?> GetWidth()
    {
        if (CoreJsModule is null)
        {
            return Width;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Width;
        }

        // get the property value
        Dimension? result = await JsComponentReference!.InvokeAsync<Dimension?>("getProperty",
            CancellationTokenSource.Token, "width");
        if (result is not null)
        {
#pragma warning disable BL0005
             Width = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Width)] = Width;
        }
         
        return Width;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Width property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetWidth(Dimension? value)
    {
#pragma warning disable BL0005
        Width = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Width)] = value;
        
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
            JsComponentReference, "width", value);
    }
    
#endregion

}
