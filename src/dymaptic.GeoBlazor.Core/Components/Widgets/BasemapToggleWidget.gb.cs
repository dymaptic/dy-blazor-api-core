// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Widgets;


/// <summary>
///    The BasemapToggle provides a widget which allows an end-user to switch between two basemaps.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class BasemapToggleWidget
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public BasemapToggleWidget()
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
    /// <param name="nextBasemap">
    ///     The next basemap for toggling.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#nextBasemap">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="viewModel">
    ///     The view model for this widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#viewModel">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="visibleElements">
    ///     The visible elements that are displayed within the widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#visibleElements">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="widgetId">
    ///     The unique ID assigned to the widget when the widget is created.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Widget.html#id">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public BasemapToggleWidget(
        string? icon = null,
        string? label = null,
        Basemap? nextBasemap = null,
        BasemapToggleViewModel? viewModel = null,
        BasemapToggleVisibleElements? visibleElements = null,
        string? widgetId = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Icon = icon;
        Label = label;
        NextBasemap = nextBasemap;
        ViewModel = viewModel;
        VisibleElements = visibleElements;
        WidgetId = widgetId;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The map's <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-Map.html#basemap">basemap</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#activeBasemap">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Basemap? ActiveBasemap { get; protected set; }
    
    /// <summary>
    ///     The view model for this widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#viewModel">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BasemapToggleViewModel? ViewModel { get; set; }
    
    /// <summary>
    ///     The visible elements that are displayed within the widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#visibleElements">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BasemapToggleVisibleElements? VisibleElements { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the ActiveBasemap property.
    /// </summary>
    public async Task<Basemap?> GetActiveBasemap()
    {
        if (CoreJsModule is null)
        {
            return ActiveBasemap;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ActiveBasemap;
        }

        Basemap? result = await JsComponentReference.InvokeAsync<Basemap?>(
            "getActiveBasemap", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (ActiveBasemap is not null)
            {
                result.Id = ActiveBasemap.Id;
            }
            
#pragma warning disable BL0005
            ActiveBasemap = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(ActiveBasemap)] = ActiveBasemap;
        }
        
        return ActiveBasemap;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the NextBasemap property.
    /// </summary>
    public async Task<Basemap?> GetNextBasemap()
    {
        if (CoreJsModule is null)
        {
            return NextBasemap;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return NextBasemap;
        }

        Basemap? result = await JsComponentReference.InvokeAsync<Basemap?>(
            "getNextBasemap", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (NextBasemap is not null)
            {
                result.Id = NextBasemap.Id;
            }
            
#pragma warning disable BL0005
            NextBasemap = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(NextBasemap)] = NextBasemap;
        }
        
        return NextBasemap;
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
    public async Task<BasemapToggleViewModel?> GetViewModel()
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

        BasemapToggleViewModel? result = await JsComponentReference.InvokeAsync<BasemapToggleViewModel?>(
            "getViewModel", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (ViewModel is not null)
            {
                result.Id = ViewModel.Id;
            }
            
#pragma warning disable BL0005
            ViewModel = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(ViewModel)] = ViewModel;
        }
        
        return ViewModel;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the VisibleElements property.
    /// </summary>
    public async Task<BasemapToggleVisibleElements?> GetVisibleElements()
    {
        if (CoreJsModule is null)
        {
            return VisibleElements;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return VisibleElements;
        }

        // get the property value
        BasemapToggleVisibleElements? result = await JsComponentReference!.InvokeAsync<BasemapToggleVisibleElements?>("getProperty",
            CancellationTokenSource.Token, "visibleElements");
        if (result is not null)
        {
#pragma warning disable BL0005
             VisibleElements = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(VisibleElements)] = VisibleElements;
        }
         
        return VisibleElements;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the NextBasemap property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetNextBasemap(Basemap? value)
    {
#pragma warning disable BL0005
        NextBasemap = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(NextBasemap)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setNextBasemap", 
            CancellationTokenSource.Token, value);
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
    public async Task SetViewModel(BasemapToggleViewModel? value)
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
    
    /// <summary>
    ///    Asynchronously set the value of the VisibleElements property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetVisibleElements(BasemapToggleVisibleElements? value)
    {
#pragma warning disable BL0005
        VisibleElements = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(VisibleElements)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setVisibleElements", 
            CancellationTokenSource.Token, value);
    }
    
#endregion

#region Public Methods

    /// <summary>
    ///     Toggles to the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#nextBasemap">next basemap</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapToggle.html#toggle">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISMethod]
    public async Task<string?> Toggle()
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "toggle", 
            CancellationTokenSource.Token);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case BasemapToggleViewModel viewModel:
                if (viewModel != ViewModel)
                {
                    ViewModel = viewModel;
                    WidgetChanged = true;
                    ModifiedParameters[nameof(ViewModel)] = ViewModel;
                }
                
                return true;
            case BasemapToggleVisibleElements visibleElements:
                if (visibleElements != VisibleElements)
                {
                    VisibleElements = visibleElements;
                    WidgetChanged = true;
                    ModifiedParameters[nameof(VisibleElements)] = VisibleElements;
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
            case BasemapToggleViewModel _:
                ViewModel = null;
                WidgetChanged = true;
                ModifiedParameters[nameof(ViewModel)] = ViewModel;
                return true;
            case BasemapToggleVisibleElements _:
                VisibleElements = null;
                WidgetChanged = true;
                ModifiedParameters[nameof(VisibleElements)] = VisibleElements;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
        ViewModel?.ValidateRequiredGeneratedChildren();
        VisibleElements?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
