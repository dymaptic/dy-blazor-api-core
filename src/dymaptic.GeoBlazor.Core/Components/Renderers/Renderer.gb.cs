// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Renderers;


/// <summary>
///    Renderers define how to visually represent each feature in one of the following layer types:
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-Renderer.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public abstract partial class Renderer
{

#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Authoring metadata only included in renderers generated from one of the Smart Mapping creator methods, such as <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-smartMapping-renderers-size.html#createContinuousRenderer">sizeRendererCreator.createContinuousRenderer()</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-smartMapping-renderers-color.html#createContinuousRenderer">colorRendererCreator.createContinuousRenderer()</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-Renderer.html#authoringInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AuthoringInfo? AuthoringInfo { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the AuthoringInfo property.
    /// </summary>
    public async Task<AuthoringInfo?> GetAuthoringInfo()
    {
        if (CoreJsModule is null)
        {
            return AuthoringInfo;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return AuthoringInfo;
        }

        // get the property value
        AuthoringInfo? result = await JsComponentReference!.InvokeAsync<AuthoringInfo?>("getProperty",
            CancellationTokenSource.Token, "authoringInfo");
        if (result is not null)
        {
#pragma warning disable BL0005
             AuthoringInfo = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(AuthoringInfo)] = AuthoringInfo;
        }
         
        return AuthoringInfo;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the AuthoringInfo property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetAuthoringInfo(AuthoringInfo value)
    {
#pragma warning disable BL0005
        AuthoringInfo = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(AuthoringInfo)] = value;
        
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
            JsComponentReference, "authoringInfo", value);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case AuthoringInfo authoringInfo:
                if (authoringInfo != AuthoringInfo)
                {
                    AuthoringInfo = authoringInfo;
                    
                    ModifiedParameters[nameof(AuthoringInfo)] = AuthoringInfo;
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
            case AuthoringInfo _:
                AuthoringInfo = null;
                
                ModifiedParameters[nameof(AuthoringInfo)] = AuthoringInfo;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        AuthoringInfo?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
