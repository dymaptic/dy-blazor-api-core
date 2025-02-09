// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GeoRSSLayer from '@arcgis/core/layers/GeoRSSLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GeoRSSLayerGenerated implements IPropertyWrapper {
    public layer: GeoRSSLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: GeoRSSLayer) {
        this.layer = layer;
        // set all properties from layer
        for (let prop in layer) {
            if (layer.hasOwnProperty(prop)) {
                this[prop] = layer[prop];
            }
        }
    }
    
    // region methods
   
    unwrap() {
        return this.layer;
    }
    
    async load(options: AbortSignal): Promise<void> {
        await this.layer.load(options);
    }

    async createLayerView(view: any,
        options: any): Promise<any> {
        let result = await this.layer.createLayerView(view,
            options);
        let { buildDotNetLayerView } = await import('./layerView');
        return buildDotNetLayerView(result);
    }

    async fetchAttributionData(): Promise<any> {
        return await this.layer.fetchAttributionData();
    }

    async refresh(): Promise<void> {
        this.layer.refresh();
    }

    // region properties
    
    async getLineSymbol(): Promise<any> {
        let { buildDotNetSimpleLineSymbol } = await import('./simpleLineSymbol');
        return await buildDotNetSimpleLineSymbol(this.layer.lineSymbol, this.layerId, this.viewId);
    }
    async setLineSymbol(value: any): Promise<void> {
        let { buildJsSimpleLineSymbol } = await import('./simpleLineSymbol');
        this.layer.lineSymbol = await  buildJsSimpleLineSymbol(value, this.layerId, this.viewId);
    }
    async getPolygonSymbol(): Promise<any> {
        let { buildDotNetSimpleFillSymbol } = await import('./simpleFillSymbol');
        return await buildDotNetSimpleFillSymbol(this.layer.polygonSymbol, this.layerId, this.viewId);
    }
    async setPolygonSymbol(value: any): Promise<void> {
        let { buildJsSimpleFillSymbol } = await import('./simpleFillSymbol');
        this.layer.polygonSymbol = await  buildJsSimpleFillSymbol(value, this.layerId, this.viewId);
    }
    async getVisibilityTimeExtent(): Promise<any> {
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return buildDotNetTimeExtent(this.layer.visibilityTimeExtent);
    }
    async setVisibilityTimeExtent(value: any): Promise<void> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        this.layer.visibilityTimeExtent = await  buildJsTimeExtent(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.layer[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.layer[prop] = value;
    }
}

export async function buildJsGeoRSSLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGeoRSSLayer = new GeoRSSLayer();
    if (hasValue(dotNetObject.fullExtent)) {
        jsGeoRSSLayer.fullExtent = dotNetObject.extent;
    }
    if (hasValue(dotNetObject.lineSymbol)) {
        let { buildJsSimpleLineSymbol } = await import('./simpleLineSymbol');
        jsGeoRSSLayer.lineSymbol = await buildJsSimpleLineSymbol(dotNetObject.lineSymbol, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.pointSymbol)) {
        jsGeoRSSLayer.pointSymbol = dotNetObject.markerSymbol;
    }
    if (hasValue(dotNetObject.polygonSymbol)) {
        let { buildJsSimpleFillSymbol } = await import('./simpleFillSymbol');
        jsGeoRSSLayer.polygonSymbol = await buildJsSimpleFillSymbol(dotNetObject.polygonSymbol, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsGeoRSSLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsGeoRSSLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsGeoRSSLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.effect)) {
        jsGeoRSSLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsGeoRSSLayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsGeoRSSLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsGeoRSSLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsGeoRSSLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsGeoRSSLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsGeoRSSLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.refreshInterval)) {
        jsGeoRSSLayer.refreshInterval = dotNetObject.refreshInterval;
    }
    if (hasValue(dotNetObject.title)) {
        jsGeoRSSLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.type)) {
        jsGeoRSSLayer.type = dotNetObject.type;
    }
    if (hasValue(dotNetObject.url)) {
        jsGeoRSSLayer.url = dotNetObject.url;
    }
    jsGeoRSSLayer.on('refresh', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsRefresh', evt);
    });
    
    let { default: GeoRSSLayerWrapper } = await import('./geoRSSLayer');
    let geoRSSLayerWrapper = new GeoRSSLayerWrapper(jsGeoRSSLayer);
    geoRSSLayerWrapper.geoBlazorId = dotNetObject.id;
    geoRSSLayerWrapper.viewId = viewId;
    geoRSSLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(geoRSSLayerWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = geoRSSLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsGeoRSSLayer;
    
    return jsGeoRSSLayer;
}

export async function buildDotNetGeoRSSLayerGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGeoRSSLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.lineSymbol)) {
            let { buildDotNetSimpleLineSymbol } = await import('./simpleLineSymbol');
            dotNetGeoRSSLayer.lineSymbol = await buildDotNetSimpleLineSymbol(jsObject.lineSymbol, layerId, viewId);
        }
        dotNetGeoRSSLayer.pointSymbol = jsObject.pointSymbol;
        if (hasValue(jsObject.polygonSymbol)) {
            let { buildDotNetSimpleFillSymbol } = await import('./simpleFillSymbol');
            dotNetGeoRSSLayer.polygonSymbol = await buildDotNetSimpleFillSymbol(jsObject.polygonSymbol, layerId, viewId);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./dotNetBuilder');
            dotNetGeoRSSLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        dotNetGeoRSSLayer.arcGISLayerId = jsObject.id;
        dotNetGeoRSSLayer.blendMode = jsObject.blendMode;
        dotNetGeoRSSLayer.effect = jsObject.effect;
        dotNetGeoRSSLayer.fullExtent = jsObject.fullExtent;
        dotNetGeoRSSLayer.legendEnabled = jsObject.legendEnabled;
        dotNetGeoRSSLayer.listMode = jsObject.listMode;
        dotNetGeoRSSLayer.loaded = jsObject.loaded;
        dotNetGeoRSSLayer.maxScale = jsObject.maxScale;
        dotNetGeoRSSLayer.minScale = jsObject.minScale;
        dotNetGeoRSSLayer.opacity = jsObject.opacity;
        dotNetGeoRSSLayer.persistenceEnabled = jsObject.persistenceEnabled;
        dotNetGeoRSSLayer.refreshInterval = jsObject.refreshInterval;
        dotNetGeoRSSLayer.title = jsObject.title;
        dotNetGeoRSSLayer.type = jsObject.type;
        dotNetGeoRSSLayer.url = jsObject.url;

    return dotNetGeoRSSLayer;
}

