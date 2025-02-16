namespace dymaptic.GeoBlazor.Core.Components.Widgets;

public partial class PopupWidget : Widget
{
    /// <summary>
    ///     Defines actions that may be executed by clicking the icon or image symbolizing them in the popup. By default, every
    ///     popup has a zoom-to action styled with a magnifying glass icon. When this icon is clicked, the view zooms in four
    ///     LODs and centers on the selected feature.
    /// </summary>
    [CodeGenerationIgnore]
    [Parameter]
    [JsonConverter(typeof(ActionBaseConverter))]
    public IReadOnlyList<ActionBase>? Actions { get; set; }

    /// <summary>
    ///     Position of the popup in relation to the selected feature. The default behavior is to display above the feature and
    ///     adjust if not enough room. If needing to explicitly control where the popup displays in relation to the feature,
    ///     choose an option besides auto.
    /// </summary>
    [Parameter]
    public PopupAlignment? Alignment { get; set; }

    /// <summary>
    ///     This closes the popup when the View camera or Viewpoint changes.
    /// </summary>
    [Parameter]
    public bool? AutoCloseEnabled { get; set; }

    /// <summary>
    ///     This property indicates to the Popup that it needs to allow or disallow the click event propagation. Use
    ///     view.popup.autoOpenEnabled = false; when needing to stop the click event propagation.
    ///     DefaultValue: true
    /// </summary>
    [Parameter]
    [Obsolete("Use MapView.PopupEnabled instead")]
    public bool? AutoOpenEnabled { get; set; }

    /// <summary>
    ///     Indicates whether the popup displays its content. If true, only the header displays.
    /// </summary>
    [Parameter]
    public bool? Collapsed { get; set; }

    /// <summary>
    ///     Indicates whether to enable collapse functionality for the popup.
    ///     DefaultValue: true
    /// </summary>
    [Parameter]
    public bool? CollapseEnabled { get; set; }

    /// <summary>
    ///     The html string content of the popup. When set directly on the Popup, this content is static and cannot use fields
    ///     to set content templates. To set a template for the content based on field or attribute names, see
    ///     <see cref="PopupTemplate.Content" />.
    /// </summary>
    [Parameter]
    public string? StringContent { get; set; }

    /// <summary>
    ///     Enables automatic creation of a popup template for layers that have popups enabled but no popupTemplate defined.
    ///     Automatic popup templates are supported for layers that support the createPopupTemplate method. (Supported for
    ///     FeatureLayer, GeoJSONLayer, OGCFeatureLayer, SceneLayer, CSVLayer, PointCloudLayer, StreamLayer, and ImageryLayer).
    /// </summary>
    [Parameter]
    public bool? DefaultPopupTemplateEnabled { get; set; }

    /// <summary>
    ///     Indicates whether the placement of the popup is docked to the side of the view.
    ///     Docking the popup allows for a better user experience, particularly when opening popups in apps on mobile devices.
    ///     When a popup is "dockEnabled" it means the popup no longer points to the selected feature or the location assigned
    ///     to it. Rather it is attached to a side, the top, or the bottom of the view.
    ///     See <see cref="DockOptions" /> to override default options related to docking the popup.
    /// </summary>
    [Parameter]
    public bool? DockEnabled { get; set; }

    /// <summary>
    ///     Indicates the heading level to use for the title of the popup. By default, the title is rendered as a level 2
    ///     heading (e.g. <h2>Popup title</h2>). Depending on the widget's placement in your app, you may need to adjust this
    ///     heading for proper semantics. This is important for meeting accessibility standards.
    ///     DefaultValue:2
    /// </summary>
    [Parameter]
    public int? HeadingLevel { get; set; }

    /// <summary>
    ///     Highlight the selected popup feature using the highlightOptions set on the MapView or the highlightOptions set on
    ///     the SceneView.
    /// </summary>
    [Parameter]
    public bool? HighlightEnabled { get; set; }


    /// <summary>
    ///     Defines the maximum icons displayed at one time in the action area.
    ///     DefaultValue: 3
    /// </summary>
    [Parameter]
    public int? MaxInlineActions { get; set; }

    /// <summary>
    ///     Indicates whether to display a spinner at the popup location prior to its display when it has pending promises.
    /// </summary>
    [Parameter]
    public bool? SpinnerEnabled { get; set; }

    /// <summary>
    ///     The title of the popup. This can be set generically on the popup no matter the features that are selected. If the
    ///     selected feature has a PopupTemplate, then the title set in the corresponding template is used here.
    /// </summary>
    [Parameter]
    public string? Title { get; set; }


    /// <inheritdoc />
    public override WidgetType Type => WidgetType.Popup;

    /// <summary>
    ///     The selected feature accessed by the popup. The content of the Popup is determined based on the PopupTemplate
    ///     assigned to this feature.
    /// </summary>
    public async Task<Graphic?> GetSelectedFeature()
    {
        return await JsComponentReference!.InvokeAsync<Graphic?>("getSelectedFeature",
            CancellationTokenSource.Token, View?.Id);
    }

    /// <summary>
    ///     Sets the string content of the popup.
    /// </summary>
    public async Task SetContent(string stringContent)
    {
        await JsComponentReference!.InvokeVoidAsync("setContent", CancellationTokenSource.Token, stringContent);
    }

    /// <summary>
    ///     Removes promises, features, content, title and location from the Popup.
    /// </summary>
    [ArcGISMethod]
public async Task Clear()
    {
        await JsComponentReference!.InvokeVoidAsync("clear", CancellationTokenSource.Token);
    }

    /// <summary>
    ///     Use this method to return feature(s) at a given screen location. These features are fetched from all of the
    ///     LayerViews in the view. In order to use this, a layer must already have an associated PopupTemplate and have its
    ///     popupEnabled. These features can then be used within a custom Popup or Feature widget experience.
    /// </summary>
    [CodeGenerationIgnore]
public async Task<Graphic[]> FetchFeatures()
    {
        return await JsComponentReference!.InvokeAsync<Graphic[]>("fetchFeatures", CancellationTokenSource.Token);
    }

    /// <summary>
    ///     The number of selected features available to the popup.
    /// </summary>
    public async Task<int> GetFeatureCount()
    {
        return await JsComponentReference!.InvokeAsync<int>("getFeatureCount", CancellationTokenSource.Token);
    }

    /// <summary>
    ///     Index of the feature that is selected. When features are set, the first index is automatically selected.
    /// </summary>
    public async Task<int> GetSelectedFeatureIndex()
    {
        return await JsComponentReference!.InvokeAsync<int>("getSelectedFeatureIndex", CancellationTokenSource.Token);
    }

    /// <summary>
    ///     Index of the feature that is selected. When features are set, the first index is automatically selected.
    /// </summary>
    public async Task<bool> GetVisibility()
    {
        return await JsComponentReference!.InvokeAsync<bool>("getVisibility", CancellationTokenSource.Token);
    }


    /// <summary>
    ///     Closes the popup by setting its visible property to false. Users can alternatively close the popup by directly
    ///     setting the visible property to false.
    /// </summary>
    [ArcGISMethod]
public async Task Close()
    {
        await JsComponentReference!.InvokeVoidAsync("close", CancellationTokenSource.Token);
    }

    /// <summary>
    ///     JS-invokable method for triggering actions.
    /// </summary>
    /// <param name="actionId">
    ///     The action ID.
    /// </param>
    [JSInvokable]
    public async Task OnTriggerAction(string actionId)
    {
        ActionBase? action = Actions?.FirstOrDefault(a => a.Id == actionId);

        if (action is not null)
        {
            await action.CallbackFunction!.Invoke();
        }
    }
}