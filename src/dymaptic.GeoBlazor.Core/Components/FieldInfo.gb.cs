// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    The `FieldInfo` class defines how a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html">Field</a> participates, or in some cases, does not participate, in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-PopupTemplate.html">PopupTemplate</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class FieldInfo
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public FieldInfo()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="fieldName">
    ///     The field name as defined by the service or the name of an <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/">Arcade</a> expression.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#fieldName">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="label">
    ///     A string containing the field alias.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#label">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="tooltip">
    ///     A string providing an editing hint for editors of the field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#tooltip">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="stringFieldOption">
    ///     A string determining what type of input box editors see when editing the field.
    ///     default text-box
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#stringFieldOption">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="format">
    ///     Class which provides formatting options for numerical or date fields and how they should display within a popup.
    ///     If displaying a `timestamp-offset` or `date` <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#type">type</a> field in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Popup.html">Popup</a>, <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Features.html">Features</a>, or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Feature.html">Feature</a> widget and the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html">MapView</a> has a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html#timeZone">timezone</a> set other than `unknown`, the abbreviated time zone suffix will be omitted from the attribute value. For example, the attribute value will display as `9/28/2014, 7:58 PM`. To display an abbreviated time zone suffix, see the `Read more` section. >>>esri-read-more<a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#format">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="isEditable">
    ///     A Boolean determining whether users can edit this field.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#isEditable">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="visible">
    ///     Indicates whether the field is visible in the popup window.
    /// </param>
    /// <param name="statisticType">
    ///     Used in a `one:many` or `many:many` relationship to compute the statistics on the field to show in the popup.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#statisticType">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public FieldInfo(
        string? fieldName = null,
        string? label = null,
        string? tooltip = null,
        StringFieldOption? stringFieldOption = null,
        FieldInfoFormat? format = null,
        bool? isEditable = null,
        bool? visible = null,
        StatisticType? statisticType = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        FieldName = fieldName;
        Label = label;
        Tooltip = tooltip;
        StringFieldOption = stringFieldOption;
        Format = format;
        IsEditable = isEditable;
        if (visible is not null)
        {
            Visible = visible.Value;
        }
        StatisticType = statisticType;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Class which provides formatting options for numerical or date fields and how they should display within a popup.
    ///     If displaying a `timestamp-offset` or `date` <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#type">type</a> field in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Popup.html">Popup</a>, <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Features.html">Features</a>, or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-Feature.html">Feature</a> widget and the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html">MapView</a> has a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-MapView.html#timeZone">timezone</a> set other than `unknown`, the abbreviated time zone suffix will be omitted from the attribute value. For example, the attribute value will display as `9/28/2014, 7:58 PM`. To display an abbreviated time zone suffix, see the `Read more` section. >>>esri-read-more<a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#format">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public FieldInfoFormat? Format { get; set; }
    
    /// <summary>
    ///     Used in a `one:many` or `many:many` relationship to compute the statistics on the field to show in the popup.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-FieldInfo.html#statisticType">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public StatisticType? StatisticType { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the FieldName property.
    /// </summary>
    public async Task<string?> GetFieldName()
    {
        if (CoreJsModule is null)
        {
            return FieldName;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return FieldName;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "fieldName");
        if (result is not null)
        {
#pragma warning disable BL0005
             FieldName = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(FieldName)] = FieldName;
        }
         
        return FieldName;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Format property.
    /// </summary>
    public async Task<FieldInfoFormat?> GetFormat()
    {
        if (CoreJsModule is null)
        {
            return Format;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Format;
        }

        // get the property value
        FieldInfoFormat? result = await JsComponentReference!.InvokeAsync<FieldInfoFormat?>("getProperty",
            CancellationTokenSource.Token, "format");
        if (result is not null)
        {
#pragma warning disable BL0005
             Format = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Format)] = Format;
        }
         
        return Format;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the IsEditable property.
    /// </summary>
    public async Task<bool?> GetIsEditable()
    {
        if (CoreJsModule is null)
        {
            return IsEditable;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return IsEditable;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "isEditable");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             IsEditable = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(IsEditable)] = IsEditable;
        }
         
        return IsEditable;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Label property.
    /// </summary>
    public async Task<string?> GetLabel()
    {
        if (CoreJsModule is null)
        {
            return Label;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Label;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "label");
        if (result is not null)
        {
#pragma warning disable BL0005
             Label = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Label)] = Label;
        }
         
        return Label;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the StatisticType property.
    /// </summary>
    public async Task<StatisticType?> GetStatisticType()
    {
        if (CoreJsModule is null)
        {
            return StatisticType;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return StatisticType;
        }

        // get the property value
        JsNullableEnumWrapper<StatisticType>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<StatisticType>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "statisticType");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             StatisticType = (StatisticType)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(StatisticType)] = StatisticType;
        }
         
        return StatisticType;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the StringFieldOption property.
    /// </summary>
    public async Task<StringFieldOption?> GetStringFieldOption()
    {
        if (CoreJsModule is null)
        {
            return StringFieldOption;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return StringFieldOption;
        }

        // get the property value
        JsNullableEnumWrapper<StringFieldOption>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<StringFieldOption>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "stringFieldOption");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             StringFieldOption = (StringFieldOption)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(StringFieldOption)] = StringFieldOption;
        }
         
        return StringFieldOption;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Tooltip property.
    /// </summary>
    public async Task<string?> GetTooltip()
    {
        if (CoreJsModule is null)
        {
            return Tooltip;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Tooltip;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "tooltip");
        if (result is not null)
        {
#pragma warning disable BL0005
             Tooltip = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Tooltip)] = Tooltip;
        }
         
        return Tooltip;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the FieldName property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetFieldName(string? value)
    {
#pragma warning disable BL0005
        FieldName = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(FieldName)] = value;
        
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
            JsComponentReference, "fieldName", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Format property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetFormat(FieldInfoFormat? value)
    {
#pragma warning disable BL0005
        Format = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Format)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setFormat", 
            CancellationTokenSource.Token, value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the IsEditable property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetIsEditable(bool? value)
    {
#pragma warning disable BL0005
        IsEditable = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(IsEditable)] = value;
        
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
            JsComponentReference, "isEditable", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Label property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLabel(string? value)
    {
#pragma warning disable BL0005
        Label = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Label)] = value;
        
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
            JsComponentReference, "label", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the StatisticType property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetStatisticType(StatisticType? value)
    {
#pragma warning disable BL0005
        StatisticType = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(StatisticType)] = value;
        
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
            JsComponentReference, "statisticType", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the StringFieldOption property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetStringFieldOption(StringFieldOption? value)
    {
#pragma warning disable BL0005
        StringFieldOption = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(StringFieldOption)] = value;
        
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
            JsComponentReference, "stringFieldOption", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Tooltip property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetTooltip(string? value)
    {
#pragma warning disable BL0005
        Tooltip = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Tooltip)] = value;
        
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
            JsComponentReference, "tooltip", value);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case FieldInfoFormat format:
                if (format != Format)
                {
                    Format = format;
                    
                    ModifiedParameters[nameof(Format)] = Format;
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
            case FieldInfoFormat _:
                Format = null;
                
                ModifiedParameters[nameof(Format)] = Format;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        Format?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
