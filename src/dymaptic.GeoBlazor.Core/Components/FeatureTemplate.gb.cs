// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Feature templates define all the information required to create a new feature in a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-FeatureLayer.html">feature layer</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class FeatureTemplate
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public FeatureTemplate()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="description">
    ///     Description of the feature template.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#description">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="drawingTool">
    ///     Name of the default drawing tool defined for the template to create a feature.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#drawingTool">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="name">
    ///     Name of the feature template.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#name">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="prototype">
    ///     An instance of the prototypical feature described by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html">feature template</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#prototype">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="thumbnail">
    ///     An object used to create a thumbnail image that represents a feature type in the feature template.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#thumbnail">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public FeatureTemplate(
        string? description = null,
        DrawingTool? drawingTool = null,
        string? name = null,
        Graphic? prototype = null,
        Thumbnail? thumbnail = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        Description = description;
        DrawingTool = drawingTool;
        Name = name;
        Prototype = prototype;
        Thumbnail = thumbnail;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     Description of the feature template.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#description">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Description { get; set; }
    
    /// <summary>
    ///     Name of the default drawing tool defined for the template to create a feature.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#drawingTool">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DrawingTool? DrawingTool { get; set; }
    
    /// <summary>
    ///     Name of the feature template.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#name">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Name { get; set; }
    
    /// <summary>
    ///     An instance of the prototypical feature described by the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html">feature template</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#prototype">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Graphic? Prototype { get; set; }
    
    /// <summary>
    ///     An object used to create a thumbnail image that represents a feature type in the feature template.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FeatureTemplate.html#thumbnail">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Thumbnail? Thumbnail { get; set; }
    
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
    ///     Asynchronously retrieve the current value of the DrawingTool property.
    /// </summary>
    public async Task<DrawingTool?> GetDrawingTool()
    {
        if (CoreJsModule is null)
        {
            return DrawingTool;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DrawingTool;
        }

        // get the property value
        JsNullableEnumWrapper<DrawingTool>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<DrawingTool>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "drawingTool");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             DrawingTool = (DrawingTool)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DrawingTool)] = DrawingTool;
        }
         
        return DrawingTool;
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
    ///     Asynchronously retrieve the current value of the Prototype property.
    /// </summary>
    public async Task<Graphic?> GetPrototype()
    {
        if (CoreJsModule is null)
        {
            return Prototype;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Prototype;
        }

        Graphic? result = await JsComponentReference.InvokeAsync<Graphic?>(
            "getPrototype", CancellationTokenSource.Token);
        
        if (result is not null)
        {
            if (Prototype is not null)
            {
                result.Id = Prototype.Id;
            }
            
#pragma warning disable BL0005
            Prototype = result;
#pragma warning restore BL0005
            ModifiedParameters[nameof(Prototype)] = Prototype;
        }
        
        return Prototype;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the Thumbnail property.
    /// </summary>
    public async Task<Thumbnail?> GetThumbnail()
    {
        if (CoreJsModule is null)
        {
            return Thumbnail;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return Thumbnail;
        }

        // get the property value
        Thumbnail? result = await JsComponentReference!.InvokeAsync<Thumbnail?>("getProperty",
            CancellationTokenSource.Token, "thumbnail");
        if (result is not null)
        {
#pragma warning disable BL0005
             Thumbnail = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(Thumbnail)] = Thumbnail;
        }
         
        return Thumbnail;
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
    ///    Asynchronously set the value of the DrawingTool property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDrawingTool(DrawingTool value)
    {
#pragma warning disable BL0005
        DrawingTool = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DrawingTool)] = value;
        
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
            JsComponentReference, "drawingTool", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Name property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetName(string value)
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
    ///    Asynchronously set the value of the Prototype property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetPrototype(Graphic value)
    {
#pragma warning disable BL0005
        Prototype = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Prototype)] = value;
        
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
        
        await JsComponentReference.InvokeVoidAsync("setPrototype", 
            CancellationTokenSource.Token, value);
 
        Prototype.Parent = this;
        Prototype.View = View;
        
        if (Prototype.JsComponentReference is null)
        {
            // new MapComponent, needs to be built and registered in JS
            // this also calls back to OnJsComponentCreated
            IJSObjectReference jsObjectReference = await CoreJsModule.InvokeAsync<IJSObjectReference>(
                $"buildJsGraphic", CancellationTokenSource.Token, 
                    Prototype, Layer?.Id, View?.Id);
            // in case the fallback failed, set this here.
            Prototype.JsComponentReference ??= jsObjectReference;
            
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference, "prototype", jsObjectReference);
        }
        else
        {
            // this component has already been registered, but we'll call setProperty to make sure
            // it is attached to the parent
            await CoreJsModule.InvokeVoidAsync("setProperty", CancellationTokenSource.Token,
                JsComponentReference,
                "prototype", Prototype.JsComponentReference);
        }
    }
    
    /// <summary>
    ///    Asynchronously set the value of the Thumbnail property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetThumbnail(Thumbnail value)
    {
#pragma warning disable BL0005
        Thumbnail = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(Thumbnail)] = value;
        
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
            JsComponentReference, "thumbnail", value);
    }
    
#endregion


    protected override async ValueTask<bool> RegisterGeneratedChildComponent(MapComponent child)
    {
        switch (child)
        {
            case Graphic prototype:
                if (prototype != Prototype)
                {
                    Prototype = prototype;
                    
                    ModifiedParameters[nameof(Prototype)] = Prototype;
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
            case Graphic _:
                Prototype = null;
                
                ModifiedParameters[nameof(Prototype)] = Prototype;
                return true;
            default:
                return await base.UnregisterGeneratedChildComponent(child);
        }
    }
    
    /// <inheritdoc />
    internal override void ValidateRequiredGeneratedChildren()
    {
    
        Prototype?.ValidateRequiredGeneratedChildren();
        base.ValidateRequiredGeneratedChildren();
    }
      
}
