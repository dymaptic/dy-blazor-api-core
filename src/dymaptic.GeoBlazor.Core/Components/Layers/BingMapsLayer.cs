﻿using dymaptic.GeoBlazor.Core.Components.Geometries;
using dymaptic.GeoBlazor.Core.Serialization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System.Globalization;
using System.Text.Json.Serialization;


namespace dymaptic.GeoBlazor.Core.Components.Layers;

/// <summary>
///     This layer supports Microsoft's Bing tiled map content. Three map styles are supported - road, aerial and hybrid.
///     Please note that a valid Bing Maps key is required to use this layer.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-BingMapsLayer.html">ArcGIS Maps SDK for JavaScript</a>
/// </summary>
public class BingMapsLayer : BaseTileLayer
{
    /// <summary>
    ///     Parameterless constructor for use as a razor component
    /// </summary>
    [ActivatorUtilitiesConstructor]
    public BingMapsLayer()
    {
    }
    
    /// <summary>
    ///     Constructor for use in code
    /// </summary>
    /// <param name="key">
    ///     Bing Maps Key.
    /// </param>
    /// <param name="style">
    ///     For more information on Bing map styles please visit: <a target="_blank" href="https://learn.microsoft.com/en-us/bingmaps/rest-services/imagery/get-imagery-metadata">https://learn.microsoft.com/en-us/bingmaps/rest-services/imagery/get-imagery-metadata</a>
    /// </param>
    /// <param name="blendMode">
    ///     Blend mode for the layer. Default Value: "normal"
    /// </param>
    /// <param name="effect">
    ///     The blend effect applied to the layer. Default Value: "none"
    /// </param>
    /// <param name="maxScale">
    ///     The maximum scale (most zoomed in) at which the layer is visible. If the map is zoomed in beyond this scale, the layer will not be visible. A value of 0 means the layer does not have a maximum scale. Default Value: 0
    /// </param>
    /// <param name="minScale">
    ///     The minimum scale (most zoomed out) at which the layer is visible. If the map is zoomed out beyond this scale, the layer will not be visible. A value of 0 means the layer does not have a minimum scale. Default Value: 0
    /// </param>
    /// <param name="refreshInterval">
    ///     Refresh interval of the layer in minutes. Non-zero value indicates automatic layer refresh at the specified interval. Value of 0 indicates auto refresh is not enabled. Default Value: 0
    /// </param>
    /// <param name="spatialReference">
    ///     The spatial reference of the layer. Default Value: 102100
    /// </param>
    public BingMapsLayer(string key, BingImageryStyle? style = null, BlendMode? blendMode = null, Effect? effect = null, 
        double? maxScale = null, double? minScale = null, double? refreshInterval = null, 
        SpatialReference? spatialReference = null)
        : base(blendMode, effect, maxScale, minScale, refreshInterval, spatialReference)
    {
#pragma warning disable BL0005
        Key = key;
        Style = style;
#pragma warning restore BL0005
    }

    /// <inheritdoc />
    [JsonPropertyName("type")]
    public override string LayerType => "bing-maps";

    /// <summary>
    ///     Bing Maps Key.
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Key { get; set; }

    /// <summary>
    ///     For more information on Bing map styles please visit: <a target="_blank" href="https://learn.microsoft.com/en-us/bingmaps/rest-services/imagery/get-imagery-metadata">https://learn.microsoft.com/en-us/bingmaps/rest-services/imagery/get-imagery-metadata</a>
    ///     Default Value: "Road"
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BingImageryStyle? Style { get; set; }

    /// <summary>
    ///     Provides culture specific map labels. For more information visit: https://learn.microsoft.com/en-us/bingmaps/rest-services/common-parameters-and-types/culture-parameter
    ///     For a list of supported culture codes please visit: https://learn.microsoft.com/en-us/bingmaps/rest-services/common-parameters-and-types/supported-culture-codes
    ///     Default Value: "en-US"
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CultureInfo? Culture { get; set; }
    
    /// <summary>
    ///     This will alter Geopolitical disputed borders and labels to align with the specified user region.
    ///     For more information on Bing's region setting please visit: https://learn.microsoft.com/en-us/bingmaps/rest-services/common-parameters-and-types/user-context-parameters
    ///     For a list of supported country codes please visit: see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2
    /// </summary>
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Region { get; set; }

    /// <summary>
    ///     Exposes Bing logo url.
    /// </summary>
    public async Task<string> GetBingLogo()
    {
        return await JsLayerReference!.InvokeAsync<string>("getBingLogo");
    }

    /// <summary>
    ///     Copyright information.
    /// </summary>
    public async Task<string> GetCopyright()
    {
        return await JsLayerReference!.InvokeAsync<string>("getCopyright");
    }

    /// <summary>
    ///     Indicates if the layer has attribution data.
    /// </summary>
    public async Task<bool> HasAttributionData()
    {
        return await JsLayerReference!.InvokeAsync<bool>("hasAttributionData");
    }
}

/// <summary>
///     The Bing Maps Imagery Set Styles. ArcGIS currently only supports 3 options.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-layers-BingMapsLayer.html#style">ArcGIS Maps SDK for JavaScript</a>
///     <a target="_blank" href="https://learn.microsoft.com/en-us/bingmaps/rest-services/imagery/get-imagery-metadata#template-parameters">Bing Maps Imagery Set Styles</a>
/// </summary>
[JsonConverter(typeof(EnumToKebabCaseStringConverter<BingImageryStyle>))]
public enum BingImageryStyle
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    Road,
    Aerial,
    Hybrid
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}