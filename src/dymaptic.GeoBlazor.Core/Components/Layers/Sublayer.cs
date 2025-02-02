namespace dymaptic.GeoBlazor.Core.Components.Layers;

public partial class Sublayer: MapComponent, IPopupTemplateLayer
{

    
    /// <summary>
    ///     A SQL where clause used to filter features in the image. Only the features that satisfy the definition expression are displayed in the View. Definition expressions may be set when a Sublayer is constructed prior to it loading in the view or after it has been added to the MapImageLayer. To see if you can use this property, check the supportsSublayerDefinitionExpression property of MapImageLayer.capabilities.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DefinitionExpression { get; set; }
    
    /// <summary>
    ///     If a map image layer contains a sublayer which is meant to be floor-aware, then that sublayer must have a floorInfo property, containing a LayerFloorInfo object which has a string property to represent the floorField.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LayerFloorInfo? FloorInfo { get; set; }

    
    /// <summary>
    ///     Indicates if labels for the sublayer will be visible in the view.
    ///     Default Value: true
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? LabelsVisible { get; set; }
    
    /// <summary>
    ///     Indicates whether the layer will be included in the legend. When false, the layer will be excluded from the legend.
    ///     Default Value: true
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? LegendEnabled { get; set; }
    
    /// <summary>
    ///     Indicates how the layer should display in the LayerList widget. The possible values are listed below.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ListMode? ListMode { get; set; }
    
    /// <summary>
    ///     The maximum scale (most zoomed in) at which the layer is visible in the view. If the map is zoomed in beyond this scale, the layer will not be visible. A value of 0 means the layer does not have a maximum scale. The maxScale value should always be smaller than the minScale value, and greater than or equal to the service specification.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MaxScale { get; set; }
    
    /// <summary>
    ///     The minimum scale (most zoomed out) at which the layer is visible in the view. If the map is zoomed out beyond this scale, the layer will not be visible. A value of 0 means the layer does not have a minimum scale. The minScale value should always be larger than the maxScale value, and less than or equal to the service specification.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? MinScale { get; set; }
    
    /// <summary>
    ///     The level of opacity to set on the sublayer on a scale from 0.0 - 1.0 where 0 is fully transparent and 1.0 is fully opaque. If the MapImageLayer.opacity is set, the actual opacity value of the sublayer will be the value of MapImageLayer.opacity multiplied by the sublayer's opacity.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Opacity { get; set; }
    
    /// <summary>
    ///     Indicates whether to display popups when features in the layer are clicked. The layer needs to have a popupTemplate to define what information should be displayed in the popup. Alternatively, a default popup template may be automatically used if Popup.defaultPopupTemplateEnabled is set to true.
    ///     Default Value: true
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? PopupEnabled { get; set; }
    
    /// <summary>
    ///     The title of the sublayer used to identify it in places such as the LayerList and Legend widgets. This value can be defined in the map service or programmatically by the developer. It can also be useful for finding a specific sublayer.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Title { get; set; }

    
    /// <summary>
    ///     An object that allows you to create a dynamic layer with data either from the map service sublayers or data from a registered workspace. See DynamicMapLayer for creating dynamic layers from map service layers for on the fly rendering, labeling, and filtering (definition expressions). To create dynamic layers from other sources in registered workspaces such as tables and table joins, see DynamicDataLayer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DynamicLayer? Source { get; set; }

    /// <summary>
    ///     Returns a flattened list of sublayers
    /// </summary>
    public IReadOnlyList<Sublayer>? GetAllSublayers()
    {
        return Sublayers?
            .SelectMany(s => new[] { s }.Concat(s.GetAllSublayers() ?? []))
            .ToList();
    }

    /// <inheritdoc />
    public override ValueTask Refresh()
    {
        if (Layer is not null)
        {
            Layer.LayerChanged = true;
        }
        return base.Refresh();
    }

    /// <summary>
    ///     Copies values when returning from ArcGIS JavaScript. For internal use only.
    /// </summary>
    public async Task UpdateFromJavaScript(Sublayer renderedSublayer)
    {
        DefinitionExpression ??= renderedSublayer.DefinitionExpression;
        FloorInfo ??= renderedSublayer.FloorInfo;
        SublayerId ??= renderedSublayer.SublayerId;
        LabelsVisible ??= renderedSublayer.LabelsVisible;
        LegendEnabled ??= renderedSublayer.LegendEnabled;
        ListMode ??= renderedSublayer.ListMode;
        MaxScale ??= renderedSublayer.MaxScale;
        MinScale ??= renderedSublayer.MinScale;
        Opacity ??= renderedSublayer.Opacity;
        PopupEnabled ??= renderedSublayer.PopupEnabled;
        Title ??= renderedSublayer.Title;
        Visible ??= renderedSublayer.Visible;
        PopupTemplate ??= renderedSublayer.PopupTemplate;
        Renderer ??= renderedSublayer.Renderer;
        Source ??= renderedSublayer.Source;
        Capabilities ??= renderedSublayer.Capabilities;
        Fields ??= renderedSublayer.Fields;
        FieldsIndex ??= renderedSublayer.FieldsIndex;
        FullExtent ??= renderedSublayer.FullExtent;
        ObjectIdField ??= renderedSublayer.ObjectIdField;
        SourceJSON ??= renderedSublayer.SourceJSON;
        TypeIdField ??= renderedSublayer.TypeIdField;
        Types ??= renderedSublayer.Types;
        Url ??= renderedSublayer.Url;
        
        await CoreJsModule!.InvokeVoidAsync("registerGeoBlazorSublayer", Layer!.Id,
            renderedSublayer.SublayerId, renderedSublayer.Id);

        if (renderedSublayer.Sublayers is null)
        {
            return;
        }
        
        foreach (Sublayer childSublayer in renderedSublayer.Sublayers)
        {
            Sublayer? matchingLayer = Sublayers?.FirstOrDefault(l => l.Id == childSublayer.Id);

            if (matchingLayer is not null)
            {
                await matchingLayer.UpdateFromJavaScript(childSublayer);
            }
            else
            {
                Sublayers ??= [];
                Sublayers = [..Sublayers, childSublayer];
            }
        }
    }


    /// <summary>
    ///     Sets any property to a new value after initial render. Supports all basic types (strings, numbers, booleans, dictionaries) and properties.
    /// </summary>
    /// <param name="propertyName">
    ///     The name of the property to set.
    /// </param>
    /// <param name="value">
    ///     The new value.
    /// </param>
    public async Task SetProperty(string propertyName, object? value)
    {
        if (CoreJsModule is null) return;
        ModifiedParameters[propertyName] = value;
        await CoreJsModule!.InvokeVoidAsync("setSublayerProperty", Layer?.JsComponentReference, 
            SublayerId, propertyName.ToLowerFirstChar(), value);
    }
    
    /// <summary>
    ///     Update LegendEnabled after render.
    /// </summary>
    public async Task SetLegendEnabled(bool enabled)
    {
        await SetProperty(nameof(LegendEnabled).ToLowerFirstChar(), enabled);
    }

    /// <summary>
    ///     Update PopupEnabled after render.
    /// </summary>
    public async Task SetPopupEnabled(bool enabled)
    {
        await SetProperty(nameof(PopupEnabled).ToLowerFirstChar(), enabled);
    }
    
    /// <summary>
    ///     Update PopupTemplate after render.
    /// </summary>
    public async Task SetPopupTemplate(PopupTemplate popupTemplate)
    {
        if (CoreJsModule is null) return;
        ModifiedParameters[nameof(PopupTemplate)] = popupTemplate;
        await CoreJsModule!.InvokeVoidAsync("setSublayerPopupTemplate", Layer?.JsComponentReference, 
            SublayerId, popupTemplate, Layer?.Id, View?.Id);
    }
    
    /// <inheritdoc />
    public override async Task RegisterChildComponent(MapComponent child)
    {
        switch (child)
        {
            case LayerFloorInfo floorInfo:
                FloorInfo = floorInfo;
                
                break;
            case Label label:
                LabelingInfo ??= [];
                LabelingInfo = [..LabelingInfo, label];

                break;

            case Sublayer sublayer:
                Sublayers ??= [];
                Sublayers = [..Sublayers, sublayer];

                break;
            case DynamicLayer dynamicLayer:
                Source = dynamicLayer;

                break;
            default:
                await base.RegisterChildComponent(child);

                break;
        }
    }
    
    /// <inheritdoc />
    public override async Task UnregisterChildComponent(MapComponent child)
    {
        switch (child)
        {
            case LayerFloorInfo:
                FloorInfo = null;
                
                break;
            case Label label:
                LabelingInfo = LabelingInfo?.Except([label]).ToList();

                break;

            case DynamicLayer:
                Source = null;

                break;
            case Sublayer sublayer:
                Sublayers = Sublayers?.Except([sublayer]).ToList();

                break;

            default:
                await base.UnregisterChildComponent(child);

                break;
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredChildren()
    {
        FloorInfo?.ValidateRequiredChildren();

        Source?.ValidateRequiredChildren();

        base.ValidateRequiredChildren();
    }
}