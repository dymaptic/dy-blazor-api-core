// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    An array of date fields or field json objects.
/// </summary>
/// <param name="DateFields">
///     An array of date fields or field json objects.
///     default []
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FieldsIndex.html#dateFields">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record FieldsIndex(
    IReadOnlyList<Field>? DateFields = null)
{
    /// <summary>
    ///     An array of date fields or field json objects.
    ///     default []
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FieldsIndex.html#dateFields">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public IReadOnlyList<Field>? DateFields { get; set; } = DateFields;
    
    internal IJSObjectReference? JsComponentReference { get; set; }
    internal AbortManager? AbortManager { get; set; }
    private readonly CancellationTokenSource _cancellationTokenSource = new();
#region Public Methods

    /// <summary>
    ///     Returns a field with the specified field name.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FieldsIndex.html#get">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="fieldName">
    ///     The name of the field. The name is case-insensitive.
    /// </param>
    [ArcGISMethod]
    public async Task<Field?> Get(string fieldName)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<Field?>(
            "get", 
            _cancellationTokenSource.Token,
            fieldName);
    }
    
    /// <summary>
    ///     Returns a <a target="_blank" href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">time zone</a> for a field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FieldsIndex.html#getTimeZone">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="fieldOrFieldName">
    ///     The name of the field or the field instance.
    /// </param>
    [ArcGISMethod]
    public async Task<string?> GetTimeZone(string fieldOrFieldName)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<string?>(
            "getTimeZone", 
            _cancellationTokenSource.Token,
            fieldOrFieldName);
    }
    
    /// <summary>
    ///     Checks if a field with the specified field name exists in the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FieldsIndex.html#has">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="fieldName">
    ///     The name of the field. The name is case-insensitive.
    /// </param>
    [ArcGISMethod]
    public async Task<bool?> Has(string fieldName)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<bool?>(
            "has", 
            _cancellationTokenSource.Token,
            fieldName);
    }
    
    /// <summary>
    ///     Checks if a field with the specified field name is a date field.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-FieldsIndex.html#isDateField">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="fieldName">
    ///     The name of the field.
    /// </param>
    [ArcGISMethod]
    public async Task<bool?> IsDateField(string fieldName)
    {
        if (JsComponentReference is null) return null;
        
        return await JsComponentReference!.InvokeAsync<bool?>(
            "isDateField", 
            _cancellationTokenSource.Token,
            fieldName);
    }
    
#endregion

}
