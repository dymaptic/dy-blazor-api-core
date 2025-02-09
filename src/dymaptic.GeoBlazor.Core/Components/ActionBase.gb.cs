// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Actions are customizable behavior which can be executed in certain widgets such as <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Popup.html">Popups</a>, a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-BasemapLayerList.html">BasemapLayerList</a>, or a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-LayerList.html">LayerList</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-support-actions-ActionBase.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public abstract partial class ActionBase
{

#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The name of the ID assigned to this action.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-support-actions-ActionBase.html#id">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ActionId { get; set; }
    
    /// <summary>
    ///     Calcite icon used for the action.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-support-actions-ActionBase.html#icon">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Icon { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the ActionId property.
    /// </summary>
    public async Task<string?> GetActionId()
    {
        if (CoreJsModule is null)
        {
            return ActionId;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ActionId;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "actionId");
        if (result is not null)
        {
#pragma warning disable BL0005
             ActionId = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ActionId)] = ActionId;
        }
         
        return ActionId;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Active property.
    /// </summary>
    public async Task<bool?> GetActive()
    {
        if (CoreJsModule is null)
        {
            return Active;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Active;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "active");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Active = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Active)] = Active;
        }
         
        return Active;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ClassName property.
    /// </summary>
    public async Task<string?> GetClassName()
    {
        if (CoreJsModule is null)
        {
            return ClassName;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ClassName;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "className");
        if (result is not null)
        {
#pragma warning disable BL0005
             ClassName = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ClassName)] = ClassName;
        }
         
        return ClassName;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Disabled property.
    /// </summary>
    public async Task<bool?> GetDisabled()
    {
        if (CoreJsModule is null)
        {
            return Disabled;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Disabled;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "disabled");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Disabled = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Disabled)] = Disabled;
        }
         
        return Disabled;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Icon property.
    /// </summary>
    public async Task<string?> GetIcon()
    {
        if (CoreJsModule is null)
        {
            return Icon;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Icon;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "icon");
        if (result is not null)
        {
#pragma warning disable BL0005
             Icon = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Icon)] = Icon;
        }
         
        return Icon;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Title property.
    /// </summary>
    public async Task<string?> GetTitle()
    {
        if (CoreJsModule is null)
        {
            return Title;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Title;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "title");
        if (result is not null)
        {
#pragma warning disable BL0005
             Title = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Title)] = Title;
        }
         
        return Title;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the ActionId property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetActionId(string value)
    {
#pragma warning disable BL0005
        ActionId = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ActionId)] = value;
        
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
            JsComponentReference, "actionId", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Active property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetActive(bool value)
    {
#pragma warning disable BL0005
        Active = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Active)] = value;
        
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
            JsComponentReference, "active", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ClassName property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetClassName(string value)
    {
#pragma warning disable BL0005
        ClassName = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ClassName)] = value;
        
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
            JsComponentReference, "className", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Disabled property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDisabled(bool value)
    {
#pragma warning disable BL0005
        Disabled = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Disabled)] = value;
        
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
            JsComponentReference, "disabled", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Icon property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetIcon(string value)
    {
#pragma warning disable BL0005
        Icon = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Icon)] = value;
        
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
            JsComponentReference, "icon", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Title property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTitle(string value)
    {
#pragma warning disable BL0005
        Title = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Title)] = value;
        
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
            JsComponentReference, "title", value);
    }
    
#endregion

    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        if (CallbackFunction is null)
        {
            throw new MissingRequiredChildElementException(nameof(ActionBase), nameof(CallbackFunction));
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
