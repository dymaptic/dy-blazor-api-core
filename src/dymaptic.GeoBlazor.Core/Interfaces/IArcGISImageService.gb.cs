// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

using dymaptic.GeoBlazor.Core.Functions;


namespace dymaptic.GeoBlazor.Core.Interfaces;

/// <summary>
///    Interface for types ImageryLayer
/// </summary>
public partial interface IArcGISImageService 
{
#region Properties

    /// <summary>
    ///     Defines a band combination using 0-based band indexes.
    ///     default null
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#bandIds">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IReadOnlyList<long>? BandIds { get; set; }
    
    /// <summary>
    ///     Describes the layer's supported capabilities.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#capabilities">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    ArcGISImageServiceCapabilities? Capabilities { get; set; }
    
    /// <summary>
    ///     The compression quality value.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#compressionQuality">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    double? CompressionQuality { get; set; }
    
    /// <summary>
    ///     Controls the tolerance of the lerc compression algorithm.
    ///     default 0.01
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#compressionTolerance">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    double? CompressionTolerance { get; set; }
    
    /// <summary>
    ///     The copyright text as defined by the service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#copyright">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? Copyright { get; set; }
    
    /// <summary>
    ///     The SQL where clause used to filter rasters.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#definitionExpression">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? DefinitionExpression { get; set; }
    
    /// <summary>
    ///     An array of fields in the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#fields">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IReadOnlyList<Field>? Fields { get; set; }
    
    /// <summary>
    ///     The format of the exported image.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#format">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    ImageFormat? Format { get; set; }
    
    /// <summary>
    ///     Indicates if the layer has <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#multidimensionalInfo">multidimensionalInfo</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#hasMultidimensions">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    bool? HasMultidimensions { get; set; }
    
    /// <summary>
    ///     Indicates the maximum height of the image exported by the service.
    ///     default 4100
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#imageMaxHeight">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    int? ImageMaxHeight { get; set; }
    
    /// <summary>
    ///     Indicates the maximum width of the image exported by the service.
    ///     default 15000
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#imageMaxWidth">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    int? ImageMaxWidth { get; set; }
    
    /// <summary>
    ///     Defines how to interpolate pixel values.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#interpolation">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    Interpolation? Interpolation { get; set; }
    
    /// <summary>
    ///     Defines how overlapping images should be mosaicked.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#mosaicRule">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    MosaicRule? MosaicRule { get; set; }
    
    /// <summary>
    ///     Represents a multidimensional subset of raster data.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#multidimensionalSubset">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    MultidimensionalSubset? MultidimensionalSubset { get; set; }
    
    /// <summary>
    ///     The pixel value representing no available information.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#noData">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    NoData? NoData { get; set; }
    
    /// <summary>
    ///     Interpretation of the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#noData">noData</a> setting.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#noDataInterpretation">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    NoDataInterpretation? NoDataInterpretation { get; set; }
    
    /// <summary>
    ///     The name of an `oid` <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#fields">field</a> containing a unique value or identifier for each raster in the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#objectIdField">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? ObjectIdField { get; set; }
    
    /// <summary>
    ///     A function that processes <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-views-layers-ImageryLayerView.html#pixelData">pixelData</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#pixelFilter">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    PixelFilterFunction? PixelFilter { get; set; }
    
    /// <summary>
    ///     Raster source pixel type.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#pixelType">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    PixelType? PixelType { get; set; }
    
    /// <summary>
    ///     Specifies the rule for how the requested image should be processed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#rasterFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    RasterFunction? RasterFunction { get; set; }
    
    /// <summary>
    ///     The renderer assigned to the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#renderer">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    IImageryRenderer? Renderer { get; set; }
    
    /// <summary>
    ///     The <a target="_blank" href="https://developers.arcgis.com/rest/services-reference/image-service.htm">image service's metadata JSON</a> exposed by the ArcGIS REST API.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#sourceJSON">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? SourceJSON { get; set; }
    
    /// <summary>
    ///     The URL to the REST endpoint of the layer.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#url">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    string? Url { get; set; }
    
#endregion

#region Property Setters

    /// <summary>
    ///    Asynchronously set the value of the BandIds property after render.
    /// </summary>
    Task SetBandIds(IReadOnlyList<long> value);
    
    /// <summary>
    ///    Asynchronously set the value of the Capabilities property after render.
    /// </summary>
    Task SetCapabilities(ArcGISImageServiceCapabilities value);
    
    /// <summary>
    ///    Asynchronously set the value of the CompressionQuality property after render.
    /// </summary>
    Task SetCompressionQuality(double value);
    
    /// <summary>
    ///    Asynchronously set the value of the CompressionTolerance property after render.
    /// </summary>
    Task SetCompressionTolerance(double value);
    
    /// <summary>
    ///    Asynchronously set the value of the Copyright property after render.
    /// </summary>
    Task SetCopyright(string value);
    
    /// <summary>
    ///    Asynchronously set the value of the DefinitionExpression property after render.
    /// </summary>
    Task SetDefinitionExpression(string value);
    
    /// <summary>
    ///    Asynchronously set the value of the Fields property after render.
    /// </summary>
    Task SetFields(IReadOnlyList<Field> value);
    
    /// <summary>
    ///    Asynchronously set the value of the Format property after render.
    /// </summary>
    Task SetFormat(ImageFormat value);
    
    /// <summary>
    ///    Asynchronously set the value of the HasMultidimensions property after render.
    /// </summary>
    Task SetHasMultidimensions(bool value);
    
    /// <summary>
    ///    Asynchronously set the value of the ImageMaxHeight property after render.
    /// </summary>
    Task SetImageMaxHeight(int value);
    
    /// <summary>
    ///    Asynchronously set the value of the ImageMaxWidth property after render.
    /// </summary>
    Task SetImageMaxWidth(int value);
    
    /// <summary>
    ///    Asynchronously set the value of the Interpolation property after render.
    /// </summary>
    Task SetInterpolation(Interpolation value);
    
    /// <summary>
    ///    Asynchronously set the value of the MosaicRule property after render.
    /// </summary>
    Task SetMosaicRule(MosaicRule value);
    
    /// <summary>
    ///    Asynchronously set the value of the MultidimensionalSubset property after render.
    /// </summary>
    Task SetMultidimensionalSubset(MultidimensionalSubset value);
    
    /// <summary>
    ///    Asynchronously set the value of the NoData property after render.
    /// </summary>
    Task SetNoData(NoData value);
    
    /// <summary>
    ///    Asynchronously set the value of the NoDataInterpretation property after render.
    /// </summary>
    Task SetNoDataInterpretation(NoDataInterpretation value);
    
    /// <summary>
    ///    Asynchronously set the value of the ObjectIdField property after render.
    /// </summary>
    Task SetObjectIdField(string value);
    
    /// <summary>
    ///    Asynchronously set the value of the PixelFilter property after render.
    /// </summary>
    Task SetPixelFilter(PixelFilterFunction value);
    
    /// <summary>
    ///    Asynchronously set the value of the PixelType property after render.
    /// </summary>
    Task SetPixelType(PixelType value);
    
    /// <summary>
    ///    Asynchronously set the value of the RasterFunction property after render.
    /// </summary>
    Task SetRasterFunction(RasterFunction value);
    
    /// <summary>
    ///    Asynchronously set the value of the Renderer property after render.
    /// </summary>
    Task SetRenderer(IImageryRenderer value);
    
    /// <summary>
    ///    Asynchronously set the value of the SourceJSON property after render.
    /// </summary>
    Task SetSourceJSON(string value);
    
    /// <summary>
    ///    Asynchronously set the value of the Url property after render.
    /// </summary>
    Task SetUrl(string value);
    
#endregion

#region Property Getters

    /// <summary>
    ///     Asynchronously retrieve the current value of the BandIds property.
    /// </summary>
    Task<IReadOnlyList<long>?> GetBandIds();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Capabilities property.
    /// </summary>
    Task<ArcGISImageServiceCapabilities?> GetCapabilities();

    /// <summary>
    ///     Asynchronously retrieve the current value of the CompressionQuality property.
    /// </summary>
    Task<double?> GetCompressionQuality();

    /// <summary>
    ///     Asynchronously retrieve the current value of the CompressionTolerance property.
    /// </summary>
    Task<double?> GetCompressionTolerance();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Copyright property.
    /// </summary>
    Task<string?> GetCopyright();

    /// <summary>
    ///     Asynchronously retrieve the current value of the DefaultMosaicRule property.
    /// </summary>
    Task<MosaicRule?> GetDefaultMosaicRule();

    /// <summary>
    ///     Asynchronously retrieve the current value of the DefinitionExpression property.
    /// </summary>
    Task<string?> GetDefinitionExpression();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Fields property.
    /// </summary>
    Task<IReadOnlyList<Field>?> GetFields();

    /// <summary>
    ///     Asynchronously retrieve the current value of the FieldsIndex property.
    /// </summary>
    Task<FieldsIndex?> GetFieldsIndex();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Format property.
    /// </summary>
    Task<ImageFormat?> GetFormat();

    /// <summary>
    ///     Asynchronously retrieve the current value of the HasMultidimensions property.
    /// </summary>
    Task<bool?> GetHasMultidimensions();

    /// <summary>
    ///     Asynchronously retrieve the current value of the ImageMaxHeight property.
    /// </summary>
    Task<int?> GetImageMaxHeight();

    /// <summary>
    ///     Asynchronously retrieve the current value of the ImageMaxWidth property.
    /// </summary>
    Task<int?> GetImageMaxWidth();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Interpolation property.
    /// </summary>
    Task<Interpolation?> GetInterpolation();

    /// <summary>
    ///     Asynchronously retrieve the current value of the MosaicRule property.
    /// </summary>
    Task<MosaicRule?> GetMosaicRule();

    /// <summary>
    ///     Asynchronously retrieve the current value of the MultidimensionalInfo property.
    /// </summary>
    Task<RasterMultidimensionalInfo?> GetMultidimensionalInfo();

    /// <summary>
    ///     Asynchronously retrieve the current value of the MultidimensionalSubset property.
    /// </summary>
    Task<MultidimensionalSubset?> GetMultidimensionalSubset();

    /// <summary>
    ///     Asynchronously retrieve the current value of the NoData property.
    /// </summary>
    Task<NoData?> GetNoData();

    /// <summary>
    ///     Asynchronously retrieve the current value of the NoDataInterpretation property.
    /// </summary>
    Task<NoDataInterpretation?> GetNoDataInterpretation();

    /// <summary>
    ///     Asynchronously retrieve the current value of the ObjectIdField property.
    /// </summary>
    Task<string?> GetObjectIdField();

    /// <summary>
    ///     Asynchronously retrieve the current value of the PixelFilter property.
    /// </summary>
    Task<PixelFilterFunction?> GetPixelFilter();

    /// <summary>
    ///     Asynchronously retrieve the current value of the PixelType property.
    /// </summary>
    Task<PixelType?> GetPixelType();

    /// <summary>
    ///     Asynchronously retrieve the current value of the RasterFields property.
    /// </summary>
    Task<IReadOnlyList<Field>?> GetRasterFields();

    /// <summary>
    ///     Asynchronously retrieve the current value of the RasterFunction property.
    /// </summary>
    Task<RasterFunction?> GetRasterFunction();

    /// <summary>
    ///     Asynchronously retrieve the current value of the RasterFunctionInfos property.
    /// </summary>
    Task<IReadOnlyList<RasterFunctionInfo>?> GetRasterFunctionInfos();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Renderer property.
    /// </summary>
    Task<IImageryRenderer?> GetRenderer();

    /// <summary>
    ///     Asynchronously retrieve the current value of the ServiceRasterInfo property.
    /// </summary>
    Task<RasterInfo?> GetServiceRasterInfo();

    /// <summary>
    ///     Asynchronously retrieve the current value of the SourceJSON property.
    /// </summary>
    Task<string?> GetSourceJSON();

    /// <summary>
    ///     Asynchronously retrieve the current value of the SourceType property.
    /// </summary>
    Task<SourceType?> GetSourceType();

    /// <summary>
    ///     Asynchronously retrieve the current value of the SpatialReference property.
    /// </summary>
    Task<SpatialReference?> GetSpatialReference();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Url property.
    /// </summary>
    Task<string?> GetUrl();

    /// <summary>
    ///     Asynchronously retrieve the current value of the Version property.
    /// </summary>
    Task<double?> GetVersion();

#endregion

#region Collection Property Adders

    /// <summary>
    ///     Asynchronously add elements to the BandIds property.
    /// </summary>
    Task AddToBandIds(params long[] values);
    
    /// <summary>
    ///     Asynchronously add elements to the Fields property.
    /// </summary>
    Task AddToFields(params Field[] values);
    
#endregion

#region Collection Property Removers

    /// <summary>
    ///     Asynchronously remove elements from the BandIds property.
    /// </summary>
    Task RemoveFromBandIds(params long[] values);
    
    /// <summary>
    ///     Asynchronously remove elements from the Fields property.
    /// </summary>
    Task RemoveFromFields(params Field[] values);
    
#endregion

#region Public Methods

    /// <summary>
    ///     Computes the rotation angle of a ImageryLayer at a given location.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#computeAngles">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageAngleResult?> ComputeAngles(ImageAngleParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Computes histograms based on the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html">ImageHistogramParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#computeHistograms">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<HistogramsResult?> ComputeHistograms(ImageHistogramParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Computes the corresponding pixel location in columns and rows for an image based on input geometry.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#computePixelSpaceLocations">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImagePixelLocationResult?> ComputePixelSpaceLocations(ImagePixelLocationParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Computes <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#RasterBandStatistics">statistics</a> and <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#RasterHistogram">histograms</a> for the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html">ImageHistogramParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#computeStatisticsHistograms">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<string?> ComputeStatisticsHistograms(ImageHistogramParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Returns an image using the <a target="_blank" href="https://developers.arcgis.com/rest/services-reference/export-image.htm">export REST operation</a> that displays data from an <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html">ImageryLayer</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#fetchImage">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="extent">
    /// </param>
    /// <param name="width">
    /// </param>
    /// <param name="height">
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    Task<string?> FetchImage(Extent extent,
        int width,
        int height,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    ///     Finds images based on the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-FindImagesParameters.html">FindImagesParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#findImages">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<FindImagesResult?> FindImages(FindImagesParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Generates raster info for the specified raster function.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#generateRasterInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="rasterFunction">
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    Task<RasterInfo?> GenerateRasterInfo(RasterFunction rasterFunction,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    ///     Gets the <a target="_blank" href="https://developers.arcgis.com/rest/services-reference/raster-ics.htm">image coordinate system</a> information of a catalog item in an image service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#getCatalogItemICSInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="rasterId">
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    Task<string?> GetCatalogItemICSInfo(long rasterId,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    ///     Get the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterInfo.html">raster info</a> of a <a target="_blank" href="https://developers.arcgis.com/rest/services-reference/raster-catalog-item.htm">catalog item</a> in an image service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#getCatalogItemRasterInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="rasterId">
    /// </param>
    /// <param name="cancellationToken">
    ///     The CancellationToken to cancel an asynchronous operation.
    /// </param>
    [ArcGISMethod]
    Task<RasterInfo?> GetCatalogItemRasterInfo(long rasterId,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    ///     Retrieves an image's url using the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageUrlParameters.html">ImageUrlParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#getImageUrl">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageUrlResult?> GetImageUrl(ImageUrlParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Returns sample point locations, pixel values and corresponding resolutions of the source data for a given geometry.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#getSamples">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageSampleResult?> GetSamples(ImageSampleParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Sends a request to the ArcGIS REST image service to identify content based on the specified <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageIdentifyParameters.html">ImageIdentifyParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#identify">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageIdentifyResult?> Identify(ImageIdentifyParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Converts a geometry from an image space to a map space using the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageToMapParameters.html">ImageToMapParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#imageToMap">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<Geometry?> ImageToMap(ImageToMapParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Creates a map space geometry from multiray image space geometries using the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageToMapMultirayParameters.html">ImageToMapMultirayParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#imageToMapMultiray">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<Geometry?> ImageToMapMultiray(ImageToMapMultirayParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Converts a given geometry from a map space to an image space using the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-MapToImageParameters.html">MapToImageParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#mapToImage">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<Geometry?> MapToImage(MapToImageParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Calculates the area and perimeter of a given geometry on an image service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#measureAreaAndPerimeter">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageAreaResult?> MeasureAreaAndPerimeter(ImageAreaParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Measures the area and the perimeter of a polygon in an image space on a selected raster when the following conditions are met:
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#measureAreaFromImage">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<MeasureAreaFromImageResult?> MeasureAreaFromImage(MeasureFromImageParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Calculates the distance and angle between two points on an image service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#measureDistanceAndAngle">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageDistanceResult?> MeasureDistanceAndAngle(ImageDistanceParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Calculates the height of an object between two points on an image service if the sensor info is available.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#measureHeight">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageHeightResult?> MeasureHeight(ImageHeightParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Measures the length of a polyline in an image space on a selected raster when the following conditions are met:
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#measureLengthFromImage">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<MeasureLengthFromImageResult?> MeasureLengthFromImage(MeasureFromImageParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Returns the location for a given point or centroid of a given area on an image service.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#measurePointOrCentroid">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImagePointResult?> MeasurePointOrCentroid(ImagePointParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Returns the boundary of an image for the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageBoundaryParameters.html">ImageBoundaryParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#queryBoundary">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageBoundaryResult?> QueryBoundary(ImageBoundaryParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Returns GPS information for the provided <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageGPSInfoParameters.html">ImageGPSInfoParameters</a>.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#queryGPSInfo">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="parameters">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<ImageGPSInfoResult?> QueryGPSInfo(ImageGPSInfoParameters parameters,
        string requestOptions);
    
    /// <summary>
    ///     Executes a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html">Query</a> against the image service and returns an array of Object IDs for the rasters.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#queryObjectIds">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="query">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<long[]?> QueryObjectIds(Query query,
        string requestOptions);
    
    /// <summary>
    ///     Executes a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html">Query</a> against the image service and returns the number of rasters that satisfy the query.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#queryRasterCount">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="query">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<int?> QueryRasterCount(Query query,
        string requestOptions);
    
    /// <summary>
    ///     Executes a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-Query.html">Query</a> against an image service and returns a <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-FeatureSet.html">FeatureSet</a>, which can be accessed using the `.then()` method once the promise resolves.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-mixins-ArcGISImageService.html#queryRasters">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    /// <param name="query">
    /// </param>
    /// <param name="requestOptions">
    /// </param>
    [ArcGISMethod]
    Task<FeatureSet?> QueryRasters(Query query,
        string requestOptions);
    
#endregion

}
