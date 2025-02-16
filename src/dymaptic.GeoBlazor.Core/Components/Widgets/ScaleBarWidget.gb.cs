// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Widgets;


/// <summary>
///    The ScaleBar widget displays a scale bar on the map or in a specified HTML node.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-ScaleBar.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class ScaleBarWidget
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public ScaleBarWidget()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="icon">
    ///     Icon which represents the widget.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Widget.html#icon">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="label">
    ///     The widget's label.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Widget.html#label">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="style">
    ///     The style for the scale bar.
    ///     default "line"
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-ScaleBar.html#style">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="unit">
    ///     Units to use for the scale bar.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-ScaleBar.html#unit">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="viewModel">
    ///     The view model for this widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-ScaleBar.html#viewModel">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="widgetId">
    ///     The unique ID assigned to the widget when the widget is created.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Widget.html#id">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public ScaleBarWidget(
        string? icon = null,
        string? label = null,
        ScaleBarWidgetStyle? style = null,
        ScaleUnit? unit = null,
        ScaleBarViewModel? viewModel = null,
        string? widgetId = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Icon = icon;
        Label = label;
        Style = style;
        Unit = unit;
        ViewModel = viewModel;
        WidgetId = widgetId;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The style for the scale bar.
    ///     default "line"
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-ScaleBar.html#style">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ScaleBarWidgetStyle? Style { get; set; }
    
    /// <summary>
    ///     The view model for this widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-ScaleBar.html#viewModel">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ScaleBarViewModel? ViewModel { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Style property.
    /// </summary>
    public async Task<ScaleBarWidgetStyle?> GetStyle()
    {
        if (CoreJsModule is null)
        {
            return Style;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Style;
        }

        // get the property value
        JsNullableEnumWrapper<ScaleBarWidgetStyle>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<ScaleBarWidgetStyle>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "style");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Style = (ScaleBarWidgetStyle)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Style)] = Style;
        }
         
        return Style;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Unit property.
    /// </summary>
    public async Task<ScaleUnit?> GetUnit()
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
        JsNullableEnumWrapper<ScaleUnit>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<ScaleUnit>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "unit");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Unit = (ScaleUnit)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Unit)] = Unit;
        }
         
        return Unit;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the View property.
    /// </summary>
    public async Task<MapView?> GetView()
    {
        if (CoreJsModule is null)
        {
            return View;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return View;
        }

        // get the property value
        MapView? result = await JsComponentReference!.InvokeAsync<MapView?>("getProperty",
            CancellationTokenSource.Token, "view");
        if (result is not null)
        {
#pragma warning disable BL0005
             View = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(View)] = View;
        }
         
        return View;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ViewModel property.
    /// </summary>
    public async Task<ScaleBarViewModel?> GetViewModel()
    {
        if (CoreJsModule is null)
        {
            return ViewModel;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ViewModel;
        }

        // get the property value
        ScaleBarViewModel? result = await JsComponentReference!.InvokeAsync<ScaleBarViewModel?>("getProperty",
            CancellationTokenSource.Token, "viewModel");
        if (result is not null)
        {
#pragma warning disable BL0005
             ViewModel = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ViewModel)] = ViewModel;
        }
         
        return ViewModel;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Style property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetStyle(ScaleBarWidgetStyle? value)
    {
#pragma warning disable BL0005
        Style = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Style)] = value;
        
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
            JsComponentReference, "style", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Unit property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetUnit(ScaleUnit? value)
    {
#pragma warning disable BL0005
        Unit = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Unit)] = value;
        
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
            JsComponentReference, "unit", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the View property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetView(MapView? value)
    {
#pragma warning disable BL0005
        View = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(View)] = value;
        
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
            JsComponentReference, "view", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ViewModel property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetViewModel(ScaleBarViewModel? value)
    {
#pragma warning disable BL0005
        ViewModel = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ViewModel)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setViewModel", 
            CancellationTokenSource.Token, value);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case ScaleBarViewModel viewModel:
                if (viewModel != ViewModel)
                {
                    ViewModel = viewModel;
                    WidgetChanged = true;
                    ModifiedParameters[nameof(ViewModel)] = ViewModel;
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
            case ScaleBarViewModel _:
                ViewModel = null;
                WidgetChanged = true;
                ModifiedParameters[nameof(ViewModel)] = ViewModel;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
    
        ViewModel?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
