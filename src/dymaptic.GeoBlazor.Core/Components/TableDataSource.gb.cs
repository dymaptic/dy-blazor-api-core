// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Components;


/// <summary>
///    A table or feature class that resides in a registered workspace (either a folder or geodatabase).
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Sublayer.html#TableDataSource">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public partial class TableDataSource : IDynamicDataLayerDataSource
{

    /// <summary>
    ///     Parameterless constructor for use as a Razor Component.
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public TableDataSource()
    {
    }

    /// <summary>
    ///     Constructor for use in C# code. Use named parameters (e.g., item1: value1, item2: value2) to set properties in any order.
    /// </summary>
    /// <param name="workspaceId">
    ///     The workspace where the table resides as defined in the ArcGIS Server Manager.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Sublayer.html#TableDataSource">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="dataSourceName">
    ///     The name of the table in the registered workspace.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Sublayer.html#TableDataSource">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    /// <param name="gdbVersion">
    ///     References the geodatabase version if multiple versions exist in the geodatabase.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-Sublayer.html#TableDataSource">ArcGIS Maps SDK for JavaScript</a>
    /// </param>
    public TableDataSource(
        string workspaceId,
        string dataSourceName,
        string? gdbVersion = null)
    {
        AllowRender = false;
#pragma warning disable BL0005
        WorkspaceId = workspaceId;
        DataSourceName = dataSourceName;
        GdbVersion = gdbVersion;
#pragma warning restore BL0005    
    }
    
    
#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the DataSourceName property.
    /// </summary>
    public async Task<string?> GetDataSourceName()
    {
        if (CoreJsModule is null)
        {
            return DataSourceName;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return DataSourceName;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "dataSourceName");
        if (result is not null)
        {
#pragma warning disable BL0005
             DataSourceName = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(DataSourceName)] = DataSourceName;
        }
         
        return DataSourceName;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the GdbVersion property.
    /// </summary>
    public async Task<string?> GetGdbVersion()
    {
        if (CoreJsModule is null)
        {
            return GdbVersion;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return GdbVersion;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "gdbVersion");
        if (result is not null)
        {
#pragma warning disable BL0005
             GdbVersion = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(GdbVersion)] = GdbVersion;
        }
         
        return GdbVersion;
    }
    
    /// <summary>
    ///     Asynchronously retrieve the current value of the WorkspaceId property.
    /// </summary>
    public async Task<string?> GetWorkspaceId()
    {
        if (CoreJsModule is null)
        {
            return WorkspaceId;
        }
        JsComponentReference ??= await CoreJsModule.InvokeAsync<IJSObjectReference?>(
            "getJsComponent", CancellationTokenSource.Token, Id);
        if (JsComponentReference is null)
        {
            return WorkspaceId;
        }

        // get the property value
        string? result = await JsComponentReference!.InvokeAsync<string?>("getProperty",
            CancellationTokenSource.Token, "workspaceId");
        if (result is not null)
        {
#pragma warning disable BL0005
             WorkspaceId = result;
#pragma warning restore BL0005
             ModifiedParameters[nameof(WorkspaceId)] = WorkspaceId;
        }
         
        return WorkspaceId;
    }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the DataSourceName property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetDataSourceName(string value)
    {
#pragma warning disable BL0005
        DataSourceName = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(DataSourceName)] = value;
        
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
            JsComponentReference, "dataSourceName", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the GdbVersion property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetGdbVersion(string value)
    {
#pragma warning disable BL0005
        GdbVersion = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(GdbVersion)] = value;
        
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
            JsComponentReference, "gdbVersion", value);
    }
    
    /// <summary>
    ///    Asynchronously set the value of the WorkspaceId property after render.
    /// </summary>
    /// <param name="value">
    ///     The value to set.
    /// </param>
    public async Task SetWorkspaceId(string value)
    {
#pragma warning disable BL0005
        WorkspaceId = value;
#pragma warning restore BL0005
        ModifiedParameters[nameof(WorkspaceId)] = value;
        
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
            JsComponentReference, "workspaceId", value);
    }
    
#endregion

}
