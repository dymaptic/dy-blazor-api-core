// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Information about each field in a layer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class Field
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public Field()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="type">
    ///     The data type of the field.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#type">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="name">
    ///     The name of the field.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#name">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="alias">
    ///     The display name for the field.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#alias">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="description">
    ///     Contains information describing the purpose of each field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#description">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="length">
    ///     The field length.
    ///     default undefined
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#length">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="editable">
    ///     Indicates whether the field is editable.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#editable">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="nullable">
    ///     Indicates if the field can accept `null` values.
    ///     default true
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#nullable">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="defaultValue">
    ///     The default value set for the field.
    ///     default undefined
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#defaultValue">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="valueType">
    ///     The types of values that can be assigned to a field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#valueType">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="domain">
    ///     The domain associated with the field.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#domain">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public Field(
        FieldType? type,
        string? name = null,
        string? alias = null,
        string? description = null,
        int? length = null,
        bool? editable = null,
        bool? nullable = null,
        object? defaultValue = null,
        FieldValueType? valueType = null,
        Domain? domain = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Type = type;
        Name = name;
        Alias = alias;
        Description = description;
        Length = length;
        Editable = editable;
        Nullable = nullable;
        DefaultValue = defaultValue;
        ValueType = valueType;
        Domain = domain;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The domain associated with the field.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Field.html#domain">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Domain? Domain { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the Alias property.
    /// </summary>
    public async Task<string?> GetAlias()
    {
        if (CoreJsModule is null)
        {
            return Alias;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Alias;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "alias");
        if (result is not null)
        {
#pragma warning disable BL0005
             Alias = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Alias)] = Alias;
        }
         
        return Alias;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the DefaultValue property.
    /// </summary>
    public async Task<object?> GetDefaultValue()
    {
        if (CoreJsModule is null)
        {
            return DefaultValue;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DefaultValue;
        }

        // get the property value
        object? result = await JsComponentReference!.InvokeAsync<object?>("getProperty",
            CancellationTokenSource.Token, "defaultValue");
        if (result is not null)
        {
#pragma warning disable BL0005
             DefaultValue = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DefaultValue)] = DefaultValue;
        }
         
        return DefaultValue;
    }
    
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
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "description");
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
    ///     Asynchronously retrieve the current value of the Domain property.
    /// </summary>
    public async Task<Domain?> GetDomain()
    {
        if (CoreJsModule is null)
        {
            return Domain;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Domain;
        }

        // get the property value
        Domain? result = await JsComponentReference!.InvokeAsync<Domain?>("getProperty",
            CancellationTokenSource.Token, "domain");
        if (result is not null)
        {
#pragma warning disable BL0005
             Domain = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Domain)] = Domain;
        }
         
        return Domain;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Editable property.
    /// </summary>
    public async Task<bool?> GetEditable()
    {
        if (CoreJsModule is null)
        {
            return Editable;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Editable;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "editable");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Editable = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Editable)] = Editable;
        }
         
        return Editable;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Length property.
    /// </summary>
    public async Task<int?> GetLength()
    {
        if (CoreJsModule is null)
        {
            return Length;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Length;
        }

        // get the property value
        JsNullableIntWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableIntWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "length");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Length = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Length)] = Length;
        }
         
        return Length;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Name property.
    /// </summary>
    public async Task<string?> GetName()
    {
        if (CoreJsModule is null)
        {
            return Name;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Name;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "name");
        if (result is not null)
        {
#pragma warning disable BL0005
             Name = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Name)] = Name;
        }
         
        return Name;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Nullable property.
    /// </summary>
    public async Task<bool?> GetNullable()
    {
        if (CoreJsModule is null)
        {
            return Nullable;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Nullable;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "nullable");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             Nullable = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Nullable)] = Nullable;
        }
         
        return Nullable;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ValueType property.
    /// </summary>
    public async Task<FieldValueType?> GetValueType()
    {
        if (CoreJsModule is null)
        {
            return ValueType;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ValueType;
        }

        // get the property value
        JsNullableEnumWrapper<FieldValueType>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<FieldValueType>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "valueType");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             ValueType = (FieldValueType)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ValueType)] = ValueType;
        }
         
        return ValueType;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the Alias property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetAlias(string? value)
    {
#pragma warning disable BL0005
        Alias = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Alias)] = value;
        
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
            JsComponentReference, "alias", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the DefaultValue property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDefaultValue(object? value)
    {
#pragma warning disable BL0005
        DefaultValue = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DefaultValue)] = value;
        
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
            JsComponentReference, "defaultValue", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Description property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDescription(string? value)
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
    ///    Asynchronously set the value of the Domain property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDomain(Domain? value)
    {
#pragma warning disable BL0005
        Domain = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Domain)] = value;
        
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
            JsComponentReference, "domain", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Editable property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetEditable(bool? value)
    {
#pragma warning disable BL0005
        Editable = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Editable)] = value;
        
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
            JsComponentReference, "editable", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Length property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetLength(int? value)
    {
#pragma warning disable BL0005
        Length = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Length)] = value;
        
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
            JsComponentReference, "length", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Name property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetName(string? value)
    {
#pragma warning disable BL0005
        Name = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Name)] = value;
        
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
            JsComponentReference, "name", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Nullable property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetNullable(bool? value)
    {
#pragma warning disable BL0005
        Nullable = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Nullable)] = value;
        
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
            JsComponentReference, "nullable", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ValueType property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetValueType(FieldValueType? value)
    {
#pragma warning disable BL0005
        ValueType = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ValueType)] = value;
        
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
            JsComponentReference, "valueType", value);
    }
    
#endregion

    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        if (Type is null)
        {
            throw new MissingRequiredChildElementException(nameof(Field), nameof(Type));
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
