// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    The area and perimeter of the measurement polygon in square meters and meters respectively.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-AreaMeasurement2D-AreaMeasurement2DViewModel.html#measurement">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class AreaMeasurement2DViewModelMeasurement : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public AreaMeasurement2DViewModelMeasurement()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="area">
    ///     The area (m²).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-AreaMeasurement2D-AreaMeasurement2DViewModel.html#measurement">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="geometry">
    ///     Measurement area.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-AreaMeasurement2D-AreaMeasurement2DViewModel.html#measurement">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="perimeter">
    ///     The perimeter (m).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-AreaMeasurement2D-AreaMeasurement2DViewModel.html#measurement">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public AreaMeasurement2DViewModelMeasurement(
        double? area = null,
        string? geometry = null,
        double? perimeter = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Area = area;
        Geometry = geometry;
        Perimeter = perimeter;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The area (m²).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-AreaMeasurement2D-AreaMeasurement2DViewModel.html#measurement">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Area { get; set; }
    
    /// <summary>
    ///     Measurement area.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-AreaMeasurement2D-AreaMeasurement2DViewModel.html#measurement">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Geometry { get; set; }
    
    /// <summary>
    ///     The perimeter (m).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-AreaMeasurement2D-AreaMeasurement2DViewModel.html#measurement">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Perimeter { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Area property.
    /// </summary>
    public async Task<double?> GetArea()
    {
        if (CoreJsModule is null)
        {
            return Area;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Area;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "area");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Area = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Area)] = Area;
        }
         
        return Area;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Geometry property.
    /// </summary>
    public async Task<string?> GetGeometry()
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
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
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
    ///     Asynchronously retrieve the current value of the Perimeter property.
    /// </summary>
    public async Task<double?> GetPerimeter()
    {
        if (CoreJsModule is null)
        {
            return Perimeter;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Perimeter;
        }

        // get the property value
        JsNullableDoubleWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableDoubleWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "perimeter");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Perimeter = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Perimeter)] = Perimeter;
        }
         
        return Perimeter;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Area property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetArea(double? value)
    {
#pragma warning disable BL0005
        Area = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Area)] = value;
        
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
            JsComponentReference, "area", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Geometry property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetGeometry(string? value)
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
    ///    Asynchronously set the value of the Perimeter property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPerimeter(double? value)
    {
#pragma warning disable BL0005
        Perimeter = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Perimeter)] = value;
        
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
            JsComponentReference, "perimeter", value);
    }
    
#endregion

}
