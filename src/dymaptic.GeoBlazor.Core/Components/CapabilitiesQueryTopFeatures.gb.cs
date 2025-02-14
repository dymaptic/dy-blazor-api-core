// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Describes <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-TopFeaturesQuery.html">top features query</a> operations that can be performed on features in the layer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#Capabilities">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class CapabilitiesQueryTopFeatures : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public CapabilitiesQueryTopFeatures()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="supportsCacheHint">
    ///     Indicates if the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-TopFeaturesQuery.html">top query operation</a> supports a cache hint.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#Capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public CapabilitiesQueryTopFeatures(
        bool? supportsCacheHint = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        SupportsCacheHint = supportsCacheHint;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Indicates if the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-TopFeaturesQuery.html">top query operation</a> supports a cache hint.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html#Capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsCacheHint { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the SupportsCacheHint property.
    /// </summary>
    public async Task<bool?> GetSupportsCacheHint()
    {
        if (CoreJsModule is null)
        {
            return SupportsCacheHint;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return SupportsCacheHint;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "supportsCacheHint");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             SupportsCacheHint = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(SupportsCacheHint)] = SupportsCacheHint;
        }
         
        return SupportsCacheHint;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the SupportsCacheHint property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetSupportsCacheHint(bool? value)
    {
#pragma warning disable BL0005
        SupportsCacheHint = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(SupportsCacheHint)] = value;
        
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
            JsComponentReference, "supportsCacheHint", value);
    }
    
#endregion

}
