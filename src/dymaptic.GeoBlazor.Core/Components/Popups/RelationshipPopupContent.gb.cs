// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components.Popups;


/// <summary>
///    A `RelationshipContent` popup element represents a relationship element associated with a feature.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-content-RelationshipContent.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class RelationshipPopupContent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public RelationshipPopupContent()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="title">
    ///     A heading indicating what the relationship's content represents.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-content-RelationshipContent.html#title">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="description">
    ///     Describes the relationship's content in detail.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-content-RelationshipContent.html#description">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="displayCount">
    ///     A numeric value indicating the maximum number of related features to display in the list of related records.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-content-RelationshipContent.html#displayCount">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="displayType">
    ///     A string value indicating how to display related records within the relationship content.
    ///     default "list"
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-content-RelationshipContent.html#displayType">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="orderByFields">
    ///     An array of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-support-RelatedRecordsInfoFieldOrder.html">RelatedRecordsInfoFieldOrder</a> indicating the display order for the related records, and whether they should be sorted in ascending `asc` or descending `desc` order.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-content-RelationshipContent.html#orderByFields">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="relationshipId">
    ///     The numeric id value for the defined relationship.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-popup-content-RelationshipContent.html#relationshipId">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public RelationshipPopupContent(
        string? title = null,
        string? description = null,
        int? displayCount = null,
        string? displayType = null,
        IReadOnlyList<RelatedRecordsInfoFieldOrder>? orderByFields = null,
        long? relationshipId = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Title = title;
        Description = description;
        DisplayCount = displayCount;
        DisplayType = displayType;
        OrderByFields = orderByFields;
        RelationshipId = relationshipId;
#pragma warning restore BL0005    
    }
    
    
#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Description property.
    /// </summary>
    public async Task<string?> GetDescription()
    {
        if (CoreJsModule is null)
        {
            return Description;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Description;
        }

        // get the property value
        string? result = await CoreJsModule!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "description");
        if (result is not null)
        {
#pragma warning disable BL0005
             Description = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Description)] = Description;
        }
         
        return Description;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the DisplayCount property.
    /// </summary>
    public async Task<int?> GetDisplayCount()
    {
        if (CoreJsModule is null)
        {
            return DisplayCount;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DisplayCount;
        }

        // get the property value
        JsNullableIntWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableIntWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "displayCount");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             DisplayCount = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DisplayCount)] = DisplayCount;
        }
         
        return DisplayCount;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the DisplayType property.
    /// </summary>
    public async Task<string?> GetDisplayType()
    {
        if (CoreJsModule is null)
        {
            return DisplayType;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DisplayType;
        }

        // get the property value
        string? result = await CoreJsModule!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "displayType");
        if (result is not null)
        {
#pragma warning disable BL0005
             DisplayType = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DisplayType)] = DisplayType;
        }
         
        return DisplayType;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the OrderByFields property.
    /// </summary>
    public async Task<IReadOnlyList<RelatedRecordsInfoFieldOrder>?> GetOrderByFields()
    {
        if (CoreJsModule is null)
        {
            return OrderByFields;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return OrderByFields;
        }

        // get the property value
        IReadOnlyList<RelatedRecordsInfoFieldOrder>? result = await CoreJsModule!.InvokeAsync<IReadOnlyList<RelatedRecordsInfoFieldOrder>?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "orderByFields");
        if (result is not null)
        {
#pragma warning disable BL0005
             OrderByFields = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(OrderByFields)] = OrderByFields;
        }
         
        return OrderByFields;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the RelationshipId property.
    /// </summary>
    public async Task<long?> GetRelationshipId()
    {
        if (CoreJsModule is null)
        {
            return RelationshipId;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return RelationshipId;
        }

        // get the property value
        long? result = await CoreJsModule!.InvokeAsync<long?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "relationshipId");
        if (result is not null)
        {
#pragma warning disable BL0005
             RelationshipId = result.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(RelationshipId)] = RelationshipId;
        }
         
        return RelationshipId;
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
        string? result = await CoreJsModule!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "title");
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
    ///    Asynchronously set the value of the Description property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDescription(string value)
    {
#pragma warning disable BL0005
        Description = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Description)] = value;
        
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
            JsComponentReference, "description", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the DisplayCount property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDisplayCount(int value)
    {
#pragma warning disable BL0005
        DisplayCount = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DisplayCount)] = value;
        
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
            JsComponentReference, "displayCount", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the DisplayType property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDisplayType(string value)
    {
#pragma warning disable BL0005
        DisplayType = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DisplayType)] = value;
        
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
            JsComponentReference, "displayType", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the OrderByFields property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetOrderByFields(IReadOnlyList<RelatedRecordsInfoFieldOrder> value)
    {
#pragma warning disable BL0005
        OrderByFields = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(OrderByFields)] = value;
        
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
            JsComponentReference, "orderByFields", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the RelationshipId property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetRelationshipId(long value)
    {
#pragma warning disable BL0005
        RelationshipId = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(RelationshipId)] = value;
        
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
            JsComponentReference, "relationshipId", value);
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

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the OrderByFields property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToOrderByFields(params RelatedRecordsInfoFieldOrder[] values)
    {
        RelatedRecordsInfoFieldOrder[] join = OrderByFields is null
            ? values
            : [..OrderByFields, ..values];
        await SetOrderByFields(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the OrderByFields property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromOrderByFields(params RelatedRecordsInfoFieldOrder[] values)
    {
        if (OrderByFields is null)
        {
            return;
        }
        await SetOrderByFields(OrderByFields.Except(values).ToArray());
    }
    
#endregion




}
