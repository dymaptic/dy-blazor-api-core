// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    The `FieldInfoFormat` class is used with numerical or date fields to provide more detail about how the value should be displayed in a popup.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-support-FieldInfoFormat.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class FieldInfoFormat
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public FieldInfoFormat()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="places">
    ///     Used only with `Number` fields to specify the number of supported decimal places that should appear in popups.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-support-FieldInfoFormat.html#places">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="digitSeparator">
    ///     Used only with `Number` fields.
    ///     default false
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-support-FieldInfoFormat.html#digitSeparator">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="dateFormat">
    ///     Used only with `Date` fields.
    ///     If displaying a `timestamp-offset` or `date` <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#type">type</a> field in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Popup.html">Popup</a>, <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Features.html">Features</a>, or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Feature.html">Feature</a> widget and the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html">MapView</a> has a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html#timeZone">timezone</a> set other than `unknown`, the abbreviated time zone suffix will be omitted from the attribute value. For example, the attribute value will display as `9/28/2014, 7:58 PM`. To display an abbreviated time zone suffix, see the `Read more` section. >>>esri-read-more<a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-support-FieldInfoFormat.html#dateFormat">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public FieldInfoFormat(
        int? places = null,
        bool? digitSeparator = null,
        DateFormat? dateFormat = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Places = places;
        DigitSeparator = digitSeparator;
        DateFormat = dateFormat;
#pragma warning restore BL0005    
    }
    
    
#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the DateFormat property.
    /// </summary>
    public async Task<DateFormat?> GetDateFormat()
    {
        if (CoreJsModule is null)
        {
            return DateFormat;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DateFormat;
        }

        // get the property value
        DateFormat? result = await CoreJsModule!.InvokeAsync<DateFormat?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "dateFormat");
        if (result is not null)
        {
#pragma warning disable BL0005
             DateFormat = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DateFormat)] = DateFormat;
        }
         
        return DateFormat;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the DigitSeparator property.
    /// </summary>
    public async Task<bool?> GetDigitSeparator()
    {
        if (CoreJsModule is null)
        {
            return DigitSeparator;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DigitSeparator;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "digitSeparator");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             DigitSeparator = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DigitSeparator)] = DigitSeparator;
        }
         
        return DigitSeparator;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Places property.
    /// </summary>
    public async Task<int?> GetPlaces()
    {
        if (CoreJsModule is null)
        {
            return Places;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Places;
        }

        // get the property value
        JsNullableIntWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableIntWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "places");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Places = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Places)] = Places;
        }
         
        return Places;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the DateFormat property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDateFormat(DateFormat value)
    {
#pragma warning disable BL0005
        DateFormat = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DateFormat)] = value;
        
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
            JsComponentReference, "dateFormat", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the DigitSeparator property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDigitSeparator(bool value)
    {
#pragma warning disable BL0005
        DigitSeparator = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DigitSeparator)] = value;
        
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
            JsComponentReference, "digitSeparator", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Places property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPlaces(int value)
    {
#pragma warning disable BL0005
        Places = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Places)] = value;
        
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
            JsComponentReference, "places", value);
    }
    
#endregion




}
