// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    Raster functions specify processing to be done to the image service.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class RasterFunction : MapComponent
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public RasterFunction()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="functionArguments">
    ///     The arguments for the raster function.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#functionArguments">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="functionName">
    ///     The raster function name.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#functionName">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="outputPixelType">
    ///     Defines the pixel type of the output image.
    ///     default unknown
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#outputPixelType">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="rasterFunctionDefinition">
    ///     Property where Raster Function template is passed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#rasterFunctionDefinition">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="variableName">
    ///     The variable name for the raster function.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#variableName">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public RasterFunction(
        string? functionArguments = null,
        string? functionName = null,
        OutputPixelType? outputPixelType = null,
        string? rasterFunctionDefinition = null,
        string? variableName = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        FunctionArguments = functionArguments;
        FunctionName = functionName;
        OutputPixelType = outputPixelType;
        RasterFunctionDefinition = rasterFunctionDefinition;
        VariableName = variableName;
#pragma warning restore BL0005    
    }
    
    
#region Public Properties / Blazor Parameters

    /// <summary>
    ///     The arguments for the raster function.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#functionArguments">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FunctionArguments { get; set; }
    
    /// <summary>
    ///     The raster function name.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#functionName">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FunctionName { get; set; }
    
    /// <summary>
    ///     Defines the pixel type of the output image.
    ///     default unknown
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#outputPixelType">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OutputPixelType? OutputPixelType { get; set; }
    
    /// <summary>
    ///     Property where Raster Function template is passed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#rasterFunctionDefinition">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RasterFunctionDefinition { get; set; }
    
    /// <summary>
    ///     The variable name for the raster function.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html#variableName">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    [ArcGISProperty]
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? VariableName { get; set; }
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the FunctionArguments property.
    /// </summary>
    public async Task<string?> GetFunctionArguments()
    {
        if (CoreJsModule is null)
        {
            return FunctionArguments;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return FunctionArguments;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "functionArguments");
        if (result is not null)
        {
#pragma warning disable BL0005
             FunctionArguments = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(FunctionArguments)] = FunctionArguments;
        }
         
        return FunctionArguments;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the FunctionName property.
    /// </summary>
    public async Task<string?> GetFunctionName()
    {
        if (CoreJsModule is null)
        {
            return FunctionName;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return FunctionName;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "functionName");
        if (result is not null)
        {
#pragma warning disable BL0005
             FunctionName = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(FunctionName)] = FunctionName;
        }
         
        return FunctionName;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the OutputPixelType property.
    /// </summary>
    public async Task<OutputPixelType?> GetOutputPixelType()
    {
        if (CoreJsModule is null)
        {
            return OutputPixelType;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return OutputPixelType;
        }

        // get the property value
        JsNullableEnumWrapper<OutputPixelType>? result = await CoreJsModule!.InvokeAsync<JsNullableEnumWrapper<OutputPixelType>?>("getNullableValueTypedProperty",
            CancellationTokenSource.Token, JsComponentReference, "outputPixelType");
        if (result is { Value: not null })
        {
#pragma warning disable BL0005
             OutputPixelType = (OutputPixelType)result.Value.Value!;
#pragma warning restore BL0005
             ModifiedParameters[nameof(OutputPixelType)] = OutputPixelType;
        }
         
        return OutputPixelType;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the RasterFunctionDefinition property.
    /// </summary>
    public async Task<string?> GetRasterFunctionDefinition()
    {
        if (CoreJsModule is null)
        {
            return RasterFunctionDefinition;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return RasterFunctionDefinition;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "rasterFunctionDefinition");
        if (result is not null)
        {
#pragma warning disable BL0005
             RasterFunctionDefinition = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(RasterFunctionDefinition)] = RasterFunctionDefinition;
        }
         
        return RasterFunctionDefinition;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the VariableName property.
    /// </summary>
    public async Task<string?> GetVariableName()
    {
        if (CoreJsModule is null)
        {
            return VariableName;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return VariableName;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "variableName");
        if (result is not null)
        {
#pragma warning disable BL0005
             VariableName = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(VariableName)] = VariableName;
        }
         
        return VariableName;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the FunctionArguments property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetFunctionArguments(string value)
    {
#pragma warning disable BL0005
        FunctionArguments = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(FunctionArguments)] = value;
        
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
            JsComponentReference, "functionArguments", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the FunctionName property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetFunctionName(string value)
    {
#pragma warning disable BL0005
        FunctionName = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(FunctionName)] = value;
        
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
            JsComponentReference, "functionName", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the OutputPixelType property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetOutputPixelType(OutputPixelType value)
    {
#pragma warning disable BL0005
        OutputPixelType = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(OutputPixelType)] = value;
        
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
            JsComponentReference, "outputPixelType", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the RasterFunctionDefinition property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetRasterFunctionDefinition(string value)
    {
#pragma warning disable BL0005
        RasterFunctionDefinition = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(RasterFunctionDefinition)] = value;
        
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
            JsComponentReference, "rasterFunctionDefinition", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the VariableName property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetVariableName(string value)
    {
#pragma warning disable BL0005
        VariableName = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(VariableName)] = value;
        
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
            JsComponentReference, "variableName", value);
    }
    
#endregion

}
