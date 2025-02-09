// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .cs file.

namespace dymaptic.GeoBlazor.Core.Model;

/// <summary>
///    Input parameters for the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#computeHistograms">computeHistograms</a> or <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html#computeStatisticsHistograms">computeStatisticsHistograms</a> method on <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryLayer.html">ImageryLayer</a>, or the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html#computeStatisticsHistograms">computeStatisticsHistograms</a> method on <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-ImageryTileLayer.html">ImageryTileLayer</a>.
///    <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
/// <param name="Geometry">
///     Input geometry that defines the area of interest for which the histograms and statistics will be computed.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#geometry">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="MosaicRule">
///     Specifies the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-MosaicRule.html">mosaic rule</a> on how individual images should be mosaicked when the histogram is computed.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#mosaicRule">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="PixelSize">
///     Specifies the pixel size (or the resolution).
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#pixelSize">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="RasterFunction">
///     Specifies the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html">raster function</a> from which to compute the statistics and histogram.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#rasterFunction">ArcGIS Maps SDK for JavaScript</a>
/// </param>
/// <param name="TimeExtent">
///     The <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeExtent.html">time extent</a> for which to compute the statistics and histogram.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#timeExtent">ArcGIS Maps SDK for JavaScript</a>
/// </param>
public partial record ImageHistogramParameters(
    Geometry? Geometry = null,
    MosaicRule? MosaicRule = null,
    PixelSize? PixelSize = null,
    RasterFunction? RasterFunction = null,
    TimeExtent? TimeExtent = null)
{
    /// <summary>
    ///     Input geometry that defines the area of interest for which the histograms and statistics will be computed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#geometry">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public Geometry? Geometry { get; set; } = Geometry;
    
    /// <summary>
    ///     Specifies the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-MosaicRule.html">mosaic rule</a> on how individual images should be mosaicked when the histogram is computed.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#mosaicRule">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public MosaicRule? MosaicRule { get; set; } = MosaicRule;
    
    /// <summary>
    ///     Specifies the pixel size (or the resolution).
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#pixelSize">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public PixelSize? PixelSize { get; set; } = PixelSize;
    
    /// <summary>
    ///     Specifies the <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-support-RasterFunction.html">raster function</a> from which to compute the statistics and histogram.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#rasterFunction">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public RasterFunction? RasterFunction { get; set; } = RasterFunction;
    
    /// <summary>
    ///     The <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-TimeExtent.html">time extent</a> for which to compute the statistics and histogram.
    ///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-ImageHistogramParameters.html#timeExtent">ArcGIS Maps SDK for JavaScript</a>
    /// </summary>
    public TimeExtent? TimeExtent { get; set; } = TimeExtent;
    
}
