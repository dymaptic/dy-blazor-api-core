// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    A numeric field used for generating a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-smartMapping-renderers-relationship.html">relationship renderer</a> along with <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field2">field2</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class AuthoringInfoField
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public AuthoringInfoField()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="classBreakInfos">
    ///     Describes the class breaks generated for this field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="field">
    ///     The name of a numeric field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="label">
    ///     The label used to describe the field or variable in the legend.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="normalizationField">
    ///     The name of a numeric field used to normalize the given `field`.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public AuthoringInfoField(
        IReadOnlyList<AuthoringInfoField1ClassBreakInfos>? classBreakInfos = null,
        string? field = null,
        string? label = null,
        string? normalizationField = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        ClassBreakInfos = classBreakInfos;
        Field = field;
        Label = label;
        NormalizationField = normalizationField;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Describes the class breaks generated for this field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<AuthoringInfoField1ClassBreakInfos>? ClassBreakInfos { get; set; }
    
    /// <summary>
    ///     The name of a numeric field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Field { get; set; }
    
    /// <summary>
    ///     The label used to describe the field or variable in the legend.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Label { get; set; }
    
    /// <summary>
    ///     The name of a numeric field used to normalize the given `field`.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-support-AuthoringInfo.html#field1">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NormalizationField { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the ClassBreakInfos property.
    /// </summary>
    public async Task<IReadOnlyList<AuthoringInfoField1ClassBreakInfos>?> GetClassBreakInfos()
    {
        if (CoreJsModule is null)
        {
            return ClassBreakInfos;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return ClassBreakInfos;
        }

        // get the property value
        IReadOnlyList<AuthoringInfoField1ClassBreakInfos>? result = await JsComponentReference!.InvokeAsync<IReadOnlyList<AuthoringInfoField1ClassBreakInfos>?>("getProperty",
            CancellationTokenSource.Token, "classBreakInfos");
        if (result is not null)
        {
#pragma warning disable BL0005
             ClassBreakInfos = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(ClassBreakInfos)] = ClassBreakInfos;
        }
         
        return ClassBreakInfos;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Field property.
    /// </summary>
    public async Task<string?> GetField()
    {
        if (CoreJsModule is null)
        {
            return Field;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Field;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "field");
        if (result is not null)
        {
#pragma warning disable BL0005
             Field = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Field)] = Field;
        }
         
        return Field;
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
    ///     Asynchronously retrieve the current value of the NormalizationField property.
    /// </summary>
    public async Task<string?> GetNormalizationField()
    {
        if (CoreJsModule is null)
        {
            return NormalizationField;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return NormalizationField;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "normalizationField");
        if (result is not null)
        {
#pragma warning disable BL0005
             NormalizationField = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(NormalizationField)] = NormalizationField;
        }
         
        return NormalizationField;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the ClassBreakInfos property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetClassBreakInfos(IReadOnlyList<AuthoringInfoField1ClassBreakInfos>? value)
    {
#pragma warning disable BL0005
        ClassBreakInfos = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(ClassBreakInfos)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setClassBreakInfos", 
            CancellationTokenSource.Token, value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Field property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetField(string? value)
    {
#pragma warning disable BL0005
        Field = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Field)] = value;
        
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
            JsComponentReference, "field", value);
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
    ///    Asynchronously set the value of the NormalizationField property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetNormalizationField(string? value)
    {
#pragma warning disable BL0005
        NormalizationField = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(NormalizationField)] = value;
        
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
            JsComponentReference, "normalizationField", value);
    }
    
#endregion

#region Add to Collection Methods

    /// <summary>
    ///     Asynchronously adds elements to the ClassBreakInfos property.
    /// </summary>
    /// <param name="values">
    ///    The elements to add.
    /// </param>
    public async Task AddToClassBreakInfos(params AuthoringInfoField1ClassBreakInfos[] values)
    {
        AuthoringInfoField1ClassBreakInfos[] join = ClassBreakInfos is null
            ? values
            : [..ClassBreakInfos, ..values];
        await SetClassBreakInfos(join);
    }
    
#endregion

#region Remove From Collection Methods

    
    /// <summary>
    ///     Asynchronously remove an element from the ClassBreakInfos property.
    /// </summary>
    /// <param name="values">
    ///    The elements to remove.
    /// </param>
    public async Task RemoveFromClassBreakInfos(params AuthoringInfoField1ClassBreakInfos[] values)
    {
        if (ClassBreakInfos is null)
        {
            return;
        }
        await SetClassBreakInfos(ClassBreakInfos.Except(values).ToArray());
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case AuthoringInfoField1ClassBreakInfos classBreakInfos:
                ClassBreakInfos ??= [];
                if (!ClassBreakInfos.Contains(classBreakInfos))
                {
                    ClassBreakInfos = [..ClassBreakInfos, classBreakInfos];
                    
                    ModifiedParameters[nameof(ClassBreakInfos)] = ClassBreakInfos;
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
            case AuthoringInfoField1ClassBreakInfos classBreakInfos:
                ClassBreakInfos = ClassBreakInfos?.Where(c => c != classBreakInfos).ToList();
                
                ModifiedParameters[nameof(ClassBreakInfos)] = ClassBreakInfos;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    public override void ValidateRequiredGeneratedChildren()
    {
    
        if (ClassBreakInfos is not null)
        {
            foreach (AuthoringInfoField1ClassBreakInfos child in ClassBreakInfos)
            {
                child.ValidateRequiredGeneratedChildren();
            }
        }
        base.ValidateRequiredGeneratedChildren();
    }
      
}
