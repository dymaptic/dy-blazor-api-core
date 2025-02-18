// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Provides the logic for the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks.html">Bookmarks</a> widget.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class BookmarksViewModel : IGoTo,
    IViewModel
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public BookmarksViewModel()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="bookmarks">
    ///     A collection of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-webmap-Bookmark.html">Bookmark</a>s.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#bookmarks">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="capabilities">
    ///     Defines the capabilities of the widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="defaultCreateOptions">
    ///     Specifies how new bookmarks will be created.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#defaultCreateOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="defaultEditOptions">
    ///     Specifies how bookmarks will be edited.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#defaultEditOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="goToOverride">
    ///     This function provides the ability to override either the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html#goTo">MapView goTo()</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-SceneView.html#goTo">SceneView goTo()</a> methods.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-support-GoTo.html#goToOverride">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public BookmarksViewModel(
        IReadOnlyList<Bookmark>? bookmarks = null,
        BookmarksCapabilities? capabilities = null,
        BookmarkOptions? defaultCreateOptions = null,
        BookmarkOptions? defaultEditOptions = null,
        GoToOverride? goToOverride = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Bookmarks = bookmarks;
        Capabilities = capabilities;
        DefaultCreateOptions = defaultCreateOptions;
        DefaultEditOptions = defaultEditOptions;
        GoToOverride = goToOverride;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-webmap-Bookmark.html">Bookmark</a> that is being navigated to.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#activeBookmark">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Bookmark? ActiveBookmark { get; protected set; }
    
    /// <summary>
    ///     A collection of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-webmap-Bookmark.html">Bookmark</a>s.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#bookmarks">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<Bookmark>? Bookmarks { get; set; }
    
    /// <summary>
    ///     Defines the capabilities of the widget.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BookmarksCapabilities? Capabilities { get; set; }
    
    /// <summary>
    ///     Specifies how new bookmarks will be created.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#defaultCreateOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BookmarkOptions? DefaultCreateOptions { get; set; }
    
    /// <summary>
    ///     Specifies how bookmarks will be edited.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#defaultEditOptions">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BookmarkOptions? DefaultEditOptions { get; set; }
    
    /// <summary>
    ///     The view model's state.
    ///     default ready
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#state">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public State? State { get; protected set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the ActiveBookmark property.
    /// </summary>
    public async Task<Bookmark?> GetActiveBookmark()
    {
        if (CoreJsModule is null)
        {
            return ActiveBookmark;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ActiveBookmark;
        }

        // get the property value
        Bookmark? result = await JsComponentReference!.InvokeAsync<Bookmark?>("getProperty",
            CancellationTokenSource.Token, "activeBookmark");
        if (result is not null)
        {
#pragma warning disable BL0005
             ActiveBookmark = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ActiveBookmark)] = ActiveBookmark;
        }
         
        return ActiveBookmark;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Bookmarks property.
    /// </summary>
    public async Task<IReadOnlyList<Bookmark>?> GetBookmarks()
    {
        if (CoreJsModule is null)
        {
            return Bookmarks;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Bookmarks;
        }

        // get the property value
        IReadOnlyList<Bookmark>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<Bookmark>?>("getProperty",
            CancellationTokenSource.Token, "bookmarks");
        if (result is not null)
        {
#pragma warning disable BL0005
             Bookmarks = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Bookmarks)] = Bookmarks;
        }
         
        return Bookmarks;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Capabilities property.
    /// </summary>
    public async Task<BookmarksCapabilities?> GetCapabilities()
    {
        if (CoreJsModule is null)
        {
            return Capabilities;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Capabilities;
        }

        // get the property value
        BookmarksCapabilities? result = await JsComponentReference!.InvokeAsync<BookmarksCapabilities?>("getProperty",
            CancellationTokenSource.Token, "capabilities");
        if (result is not null)
        {
#pragma warning disable BL0005
             Capabilities = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Capabilities)] = Capabilities;
        }
         
        return Capabilities;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the DefaultCreateOptions property.
    /// </summary>
    public async Task<BookmarkOptions?> GetDefaultCreateOptions()
    {
        if (CoreJsModule is null)
        {
            return DefaultCreateOptions;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DefaultCreateOptions;
        }

        // get the property value
        BookmarkOptions? result = await JsComponentReference!.InvokeAsync<BookmarkOptions?>("getProperty",
            CancellationTokenSource.Token, "defaultCreateOptions");
        if (result is not null)
        {
#pragma warning disable BL0005
             DefaultCreateOptions = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DefaultCreateOptions)] = DefaultCreateOptions;
        }
         
        return DefaultCreateOptions;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the DefaultEditOptions property.
    /// </summary>
    public async Task<BookmarkOptions?> GetDefaultEditOptions()
    {
        if (CoreJsModule is null)
        {
            return DefaultEditOptions;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DefaultEditOptions;
        }

        // get the property value
        BookmarkOptions? result = await JsComponentReference!.InvokeAsync<BookmarkOptions?>("getProperty",
            CancellationTokenSource.Token, "defaultEditOptions");
        if (result is not null)
        {
#pragma warning disable BL0005
             DefaultEditOptions = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DefaultEditOptions)] = DefaultEditOptions;
        }
         
        return DefaultEditOptions;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the State property.
    /// </summary>
    public async Task<State?> GetState()
    {
        if (CoreJsModule is null)
        {
            return State;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return State;
        }

        // get the property value
        JsNullableEnumWrapper<State>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<State>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "state");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             State = (State)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(State)] = State;
        }
         
        return State;
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
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Bookmarks property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetBookmarks(IReadOnlyList<Bookmark>? value)
    {
#pragma warning disable BL0005
        Bookmarks = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Bookmarks)] = value;
        
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
            JsComponentReference, "bookmarks", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Capabilities property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetCapabilities(BookmarksCapabilities? value)
    {
#pragma warning disable BL0005
        Capabilities = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Capabilities)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setCapabilities", 
            CancellationTokenSource.Token, value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the DefaultCreateOptions property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDefaultCreateOptions(BookmarkOptions? value)
    {
#pragma warning disable BL0005
        DefaultCreateOptions = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DefaultCreateOptions)] = value;
        
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
            JsComponentReference, "defaultCreateOptions", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the DefaultEditOptions property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDefaultEditOptions(BookmarkOptions? value)
    {
#pragma warning disable BL0005
        DefaultEditOptions = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DefaultEditOptions)] = value;
        
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
            JsComponentReference, "defaultEditOptions", value);
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
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the Bookmarks property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToBookmarks(params Bookmark[] values)
    {
        Bookmark[] join = Bookmarks is null
            ? values
            : [..Bookmarks, ..values];
        await SetBookmarks(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the Bookmarks property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromBookmarks(params Bookmark[] values)
    {
        if (Bookmarks is null)
        {
            return;
        }
        await SetBookmarks(Bookmarks.Except(values).ToArray());
    }
    
#endregion

#region Public Methods

    /// <summary>
    ///     Creates a new bookmark from the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#defaultCreateOptions">defaultCreateOptions</a>, unless otherwise specified.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#createBookmark">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="options">
    ///     Specifies
    ///     how new bookmarks will be created. Can be used to enable/disable taking screenshots or capturing the extent when a new bookmark is added.
    /// </param>
    [ArcGISMethod]
    public async Task<Bookmark?> CreateBookmark(BookmarkOptions options)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Bookmark?>(
            "createBookmark", 
            CancellationTokenSource.Token,
            options);
    }
    
    /// <summary>
    ///     Edits the given bookmark.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#editBookmark">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="bookmark">
    ///     The bookmark to be edited.
    /// </param>
    /// <param name="options">
    ///     Specifies
    ///     how bookmarks will be edited. Can be used to enable/disable taking screenshots or capturing the extent when a bookmark is edited.
    ///     If not specified, the <a href="#defaultEditOptions">defaultEditOptions</a> will be used.
    /// </param>
    [ArcGISMethod]
    public async Task<Bookmark?> EditBookmark(Bookmark bookmark,
        BookmarkOptions options)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Bookmark?>(
            "editBookmark", 
            CancellationTokenSource.Token,
            bookmark,
            options);
    }
    
    /// <summary>
    ///     Zoom to a specific bookmark.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Bookmarks-BookmarksViewModel.html#goTo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="bookmark">
    ///     The bookmark to zoom to.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> GoTo(Bookmark bookmark)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "goTo", 
            CancellationTokenSource.Token,
            bookmark);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case BookmarksCapabilities capabilities:
                if (capabilities != Capabilities)
                {
                    Capabilities = capabilities;
                    
                    ModifiedParameters[nameof(Capabilities)] = Capabilities;
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
            case BookmarksCapabilities _:
                Capabilities = null;
                
                ModifiedParameters[nameof(Capabilities)] = Capabilities;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
    
        Capabilities?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
