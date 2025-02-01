// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    A `FormTemplate` formats and defines the content of a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-FeatureForm.html">FeatureForm</a> for a specific <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html">Featurelayer</a> or SubtypeSubLayer.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class FormTemplate
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public FormTemplate()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="title">
    ///     The string defining how to format the title displayed at the top of a form.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html#title">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="description">
    ///     The description of the form.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html#description">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="preserveFieldValuesWhenHidden">
    ///     Indicates whether to retain or clear a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-widgets-FeatureForm.html">form's</a> <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-elements-FieldElement.html">field element</a> values.
    ///     default false
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html#preserveFieldValuesWhenHidden">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="elements">
    ///     An array of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-elements-Element.html">form element</a> objects that represent an ordered list of form elements.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html#elements">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="expressionInfos">
    ///     An array of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-ExpressionInfo.html">ExpressionInfo</a> objects that reference <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/">Arcade</a> expressions following the specification defined by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/#constraint">Form Constraint Profile</a> or the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/#form-calculation">Form Calculation Profile</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html#expressionInfos">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public FormTemplate(
        string? title = null,
        string? description = null,
        bool? preserveFieldValuesWhenHidden = null,
        IReadOnlyList<FormElement>? elements = null,
        IReadOnlyList<ExpressionInfo>? expressionInfos = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Title = title;
        Description = description;
        PreserveFieldValuesWhenHidden = preserveFieldValuesWhenHidden;
        Elements = elements;
        ExpressionInfos = expressionInfos;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     An array of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-elements-Element.html">form element</a> objects that represent an ordered list of form elements.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html#elements">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<FormElement>? Elements { get; set; }
    
    /// <summary>
    ///     An array of <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-ExpressionInfo.html">ExpressionInfo</a> objects that reference <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/">Arcade</a> expressions following the specification defined by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/#constraint">Form Constraint Profile</a> or the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/arcade/#form-calculation">Form Calculation Profile</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-form-FormTemplate.html#expressionInfos">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<ExpressionInfo>? ExpressionInfos { get; set; }
    
#endregion

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
    ///     Asynchronously retrieve the current value of the Elements property.
    /// </summary>
    public async Task<IReadOnlyList<FormElement>?> GetElements()
    {
        if (CoreJsModule is null)
        {
            return Elements;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Elements;
        }

        // get the property value
        IReadOnlyList<FormElement>? result = await CoreJsModule!.InvokeAsync<IReadOnlyList<FormElement>?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "elements");
        if (result is not null)
        {
#pragma warning disable BL0005
             Elements = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Elements)] = Elements;
        }
         
        return Elements;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the ExpressionInfos property.
    /// </summary>
    public async Task<IReadOnlyList<ExpressionInfo>?> GetExpressionInfos()
    {
        if (CoreJsModule is null)
        {
            return ExpressionInfos;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ExpressionInfos;
        }

        // get the property value
        IReadOnlyList<ExpressionInfo>? result = await CoreJsModule!.InvokeAsync<IReadOnlyList<ExpressionInfo>?>("getProperty",
            CancellationTokenSource.Token, JsComponentReference, "expressionInfos");
        if (result is not null)
        {
#pragma warning disable BL0005
             ExpressionInfos = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ExpressionInfos)] = ExpressionInfos;
        }
         
        return ExpressionInfos;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the PreserveFieldValuesWhenHidden property.
    /// </summary>
    public async Task<bool?> GetPreserveFieldValuesWhenHidden()
    {
        if (CoreJsModule is null)
        {
            return PreserveFieldValuesWhenHidden;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return PreserveFieldValuesWhenHidden;
        }

        // get the property value
        JsNullableBoolWrapper? result = await CoreJsModule!.InvokeAsync<JsNullableBoolWrapper?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "preserveFieldValuesWhenHidden");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             PreserveFieldValuesWhenHidden = result.Value.Value;
#pragma warning restore BL0005
             ModifiedParameters[nameof(PreserveFieldValuesWhenHidden)] = PreserveFieldValuesWhenHidden;
        }
         
        return PreserveFieldValuesWhenHidden;
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
    ///    Asynchronously set the value of the Elements property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetElements(IReadOnlyList<FormElement> value)
    {
#pragma warning disable BL0005
        Elements = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Elements)] = value;
        
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
            JsComponentReference, "elements", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the ExpressionInfos property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetExpressionInfos(IReadOnlyList<ExpressionInfo> value)
    {
#pragma warning disable BL0005
        ExpressionInfos = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ExpressionInfos)] = value;
        
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
            JsComponentReference, "expressionInfos", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the PreserveFieldValuesWhenHidden property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPreserveFieldValuesWhenHidden(bool value)
    {
#pragma warning disable BL0005
        PreserveFieldValuesWhenHidden = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(PreserveFieldValuesWhenHidden)] = value;
        
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
            JsComponentReference, "preserveFieldValuesWhenHidden", value);
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
    ///     Asynchronously adds elements to the Elements property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToElements(params FormElement[] values)
    {
        FormElement[] join = Elements is null
            ? values
            : [..Elements, ..values];
        await SetElements(join);
    }
    
    /// <summary>
    ///     Asynchronously adds elements to the ExpressionInfos property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToExpressionInfos(params ExpressionInfo[] values)
    {
        ExpressionInfo[] join = ExpressionInfos is null
            ? values
            : [..ExpressionInfos, ..values];
        await SetExpressionInfos(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the Elements property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromElements(params FormElement[] values)
    {
        if (Elements is null)
        {
            return;
        }
        await SetElements(Elements.Except(values).ToArray());
    }
    
    
    /// <summary>
    ///     Asynchronously remove an element from the ExpressionInfos property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromExpressionInfos(params ExpressionInfo[] values)
    {
        if (ExpressionInfos is null)
        {
            return;
        }
        await SetExpressionInfos(ExpressionInfos.Except(values).ToArray());
    }
    
#endregion





    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case FormElement elements:
                Elements ??= [];
                if (!Elements.Contains(elements))
                {
                    Elements = [..Elements, elements];
                    
                    ModifiedParameters[nameof(Elements)] = Elements;
                }
                
                return true;
            case ExpressionInfo expressionInfos:
                ExpressionInfos ??= [];
                if (!ExpressionInfos.Contains(expressionInfos))
                {
                    ExpressionInfos = [..ExpressionInfos, expressionInfos];
                    
                    ModifiedParameters[nameof(ExpressionInfos)] = ExpressionInfos;
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
            case FormElement elements:
                Elements = Elements?.Where(e => e != elements).ToList();
                
                ModifiedParameters[nameof(Elements)] = Elements;
                return true;
            case ExpressionInfo expressionInfos:
                ExpressionInfos = ExpressionInfos?.Where(e => e != expressionInfos).ToList();
                
                ModifiedParameters[nameof(ExpressionInfos)] = ExpressionInfos;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        if (Elements is not null)
        {
            foreach (FormElement child in Elements)
            {
                child.ValidateRequiredGeneratedChildren();
            }
        }
        if (ExpressionInfos is not null)
        {
            foreach (ExpressionInfo child in ExpressionInfos)
            {
                child.ValidateRequiredGeneratedChildren();
            }
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
