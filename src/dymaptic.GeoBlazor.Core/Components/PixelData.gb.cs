// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    An object that provides the user access to <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-PixelBlock.html#pixels">pixels</a> and their values in the layer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#PixelData">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class PixelData : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public PixelData()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="extent">
    ///     The extent of the `pixelBlock`.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#PixelData">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="pixelBlock">
    ///     An object representing the pixels in the view.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#PixelData">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public PixelData(
        Extent? extent = null,
        PixelBlock? pixelBlock = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Extent = extent;
        PixelBlock = pixelBlock;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The extent of the `pixelBlock`.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#PixelData">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Extent? Extent { get; set; }
    
    /// <summary>
    ///     An object representing the pixels in the view.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#PixelData">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PixelBlock? PixelBlock { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Extent property.
    /// </summary>
    public async Task<Extent?> GetExtent()
    {
        if (CoreJsModule is null)
        {
            return Extent;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Extent;
        }

        Extent? result = await JsComponentReference.InvokeAsync<Extent?>(
            "getExtent", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (Extent is not null)
            {
                result.Id = Extent.Id;
            }
            
#pragma warning disable BL0005
            Extent = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(Extent)] = Extent;
        }
        
        return Extent;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the PixelBlock property.
    /// </summary>
    public async Task<PixelBlock?> GetPixelBlock()
    {
        if (CoreJsModule is null)
        {
            return PixelBlock;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return PixelBlock;
        }

        PixelBlock? result = await JsComponentReference.InvokeAsync<PixelBlock?>(
            "getPixelBlock", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (PixelBlock is not null)
            {
                result.Id = PixelBlock.Id;
            }
            
#pragma warning disable BL0005
            PixelBlock = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(PixelBlock)] = PixelBlock;
        }
        
        return PixelBlock;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Extent property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetExtent(Extent? value)
    {
#pragma warning disable BL0005
        Extent = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Extent)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setExtent", 
            CancellationTokenSource.Token, value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the PixelBlock property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPixelBlock(PixelBlock? value)
    {
#pragma warning disable BL0005
        PixelBlock = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(PixelBlock)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setPixelBlock", 
            CancellationTokenSource.Token, value);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case Extent extent:
                if (extent != Extent)
                {
                    Extent = extent;
                    
                    ModifiedParameters[nameof(Extent)] = Extent;
                }
                
                return true;
            case PixelBlock pixelBlock:
                if (pixelBlock != PixelBlock)
                {
                    PixelBlock = pixelBlock;
                    
                    ModifiedParameters[nameof(PixelBlock)] = PixelBlock;
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
            case Extent _:
                Extent = null;
                
                ModifiedParameters[nameof(Extent)] = Extent;
                return true;
            case PixelBlock _:
                PixelBlock = null;
                
                ModifiedParameters[nameof(PixelBlock)] = PixelBlock;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
    
        Extent?.ValidateRequiredGeneratedChildren();
        PixelBlock?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
