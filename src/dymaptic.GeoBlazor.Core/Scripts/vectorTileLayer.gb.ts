// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import VectorTileLayer from '@arcgis/core/layers/VectorTileLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class VectorTileLayerGenerated implements IPropertyWrapper {
    public layer: VectorTileLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: VectorTileLayer) {
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

    async deleteStyleLayer(layerId: any): Promise<void> {
        this.layer.deleteStyleLayer(layerId);
    }

    async fetchAttributionData(): Promise<any> {
        return await this.layer.fetchAttributionData();
    }

    async getLayoutProperties(layerId: any): Promise<any> {
        return this.layer.getLayoutProperties(layerId);
    }

    async getPaintProperties(layerId: any): Promise<any> {
        return this.layer.getPaintProperties(layerId);
    }

    async getStyleLayer(layerId: any): Promise<any> {
        return this.layer.getStyleLayer(layerId);
    }

    async getStyleLayerId(index: any): Promise<any> {
        return this.layer.getStyleLayerId(index);
    }

    async getStyleLayerIndex(layerId: any): Promise<any> {
        return this.layer.getStyleLayerIndex(layerId);
    }

    async getStyleLayerVisibility(layerId: any): Promise<any> {
        return this.layer.getStyleLayerVisibility(layerId);
    }

    async loadStyle(style: any,
        options: any): Promise<any> {
        return await this.layer.loadStyle(style,
            options);
    }

    async setLayoutProperties(layerId: any,
        layout: any): Promise<void> {
        this.layer.setLayoutProperties(layerId,
            layout);
    }

    async setPaintProperties(layerId: any,
        painter: any): Promise<void> {
        this.layer.setPaintProperties(layerId,
            painter);
    }

    async setSpriteSource(spriteSourceInfo: any): Promise<any> {
        return await this.layer.setSpriteSource(spriteSourceInfo);
    }

    async setStyleLayer(layer: any,
        index: any): Promise<void> {
        this.layer.setStyleLayer(layer,
            index);
    }

    async setStyleLayerVisibility(layerId: any,
        visibility: any): Promise<void> {
        this.layer.setStyleLayerVisibility(layerId,
            visibility);
    }

    // region properties
    
    async getPortalItem(): Promise<any> {
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.layer.portalItem, this.layerId, this.viewId);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.layer.portalItem = await  buildJsPortalItem(value, this.layerId, this.viewId);
    }
    async getTileInfo(): Promise<any> {
        let { buildDotNetTileInfo } = await import('./tileInfo');
        return buildDotNetTileInfo(this.layer.tileInfo);
    }
    async setTileInfo(value: any): Promise<void> {
        let { buildJsTileInfo } = await import('./tileInfo');
        this.layer.tileInfo = await  buildJsTileInfo(value, this.layerId, this.viewId);
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

export async function buildJsVectorTileLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsVectorTileLayer = new VectorTileLayer();
    if (hasValue(dotNetObject.fullExtent)) {
        jsVectorTileLayer.fullExtent = dotNetObject.extent;
    }
    if (hasValue(dotNetObject.initialExtent)) {
        jsVectorTileLayer.initialExtent = dotNetObject.extent;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./jsBuilder');
        jsVectorTileLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.tileInfo)) {
        let { buildJsTileInfo } = await import('./tileInfo');
        jsVectorTileLayer.tileInfo = await buildJsTileInfo(dotNetObject.tileInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsVectorTileLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.apiKey)) {
        jsVectorTileLayer.apiKey = dotNetObject.apiKey;
    }
    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsVectorTileLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsVectorTileLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.customParameters)) {
        jsVectorTileLayer.customParameters = dotNetObject.customParameters;
    }
    if (hasValue(dotNetObject.effect)) {
        jsVectorTileLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsVectorTileLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsVectorTileLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsVectorTileLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsVectorTileLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsVectorTileLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        jsVectorTileLayer.spatialReference = dotNetObject.spatialReference;
    }
    if (hasValue(dotNetObject.style)) {
        jsVectorTileLayer.style = dotNetObject.style;
    }
    if (hasValue(dotNetObject.title)) {
        jsVectorTileLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.type)) {
        jsVectorTileLayer.type = dotNetObject.type;
    }
    if (hasValue(dotNetObject.url)) {
        jsVectorTileLayer.url = dotNetObject.url;
    }
    let { default: VectorTileLayerWrapper } = await import('./vectorTileLayer');
    let vectorTileLayerWrapper = new VectorTileLayerWrapper(jsVectorTileLayer);
    vectorTileLayerWrapper.geoBlazorId = dotNetObject.id;
    vectorTileLayerWrapper.viewId = viewId;
    vectorTileLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(vectorTileLayerWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = vectorTileLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsVectorTileLayer;
    
    return jsVectorTileLayer;
}

export async function buildDotNetVectorTileLayerGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetVectorTileLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./dotNetBuilder');
            dotNetVectorTileLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem, layerId, viewId);
        }
        if (hasValue(jsObject.tileInfo)) {
            let { buildDotNetTileInfo } = await import('./dotNetBuilder');
            dotNetVectorTileLayer.tileInfo = buildDotNetTileInfo(jsObject.tileInfo);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./dotNetBuilder');
            dotNetVectorTileLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        dotNetVectorTileLayer.apiKey = jsObject.apiKey;
        dotNetVectorTileLayer.arcGISLayerId = jsObject.id;
        dotNetVectorTileLayer.attributionDataUrl = jsObject.attributionDataUrl;
        dotNetVectorTileLayer.blendMode = jsObject.blendMode;
        dotNetVectorTileLayer.capabilities = jsObject.capabilities;
        dotNetVectorTileLayer.currentStyleInfo = jsObject.currentStyleInfo;
        dotNetVectorTileLayer.customParameters = jsObject.customParameters;
        dotNetVectorTileLayer.effect = jsObject.effect;
        dotNetVectorTileLayer.fullExtent = jsObject.fullExtent;
        dotNetVectorTileLayer.initialExtent = jsObject.initialExtent;
        dotNetVectorTileLayer.listMode = jsObject.listMode;
        dotNetVectorTileLayer.loaded = jsObject.loaded;
        dotNetVectorTileLayer.maxScale = jsObject.maxScale;
        dotNetVectorTileLayer.minScale = jsObject.minScale;
        dotNetVectorTileLayer.opacity = jsObject.opacity;
        dotNetVectorTileLayer.persistenceEnabled = jsObject.persistenceEnabled;
        dotNetVectorTileLayer.spatialReference = jsObject.spatialReference;
        dotNetVectorTileLayer.style = jsObject.style;
        dotNetVectorTileLayer.title = jsObject.title;
        dotNetVectorTileLayer.type = jsObject.type;
        dotNetVectorTileLayer.url = jsObject.url;

    return dotNetVectorTileLayer;
}

