// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import WebTileLayer from '@arcgis/core/layers/WebTileLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class WebTileLayerGenerated implements IPropertyWrapper {
    public layer: WebTileLayer;
    public readonly geoBlazorId: string = '';

    constructor(layer: WebTileLayer) {
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

    async fetchTile(level: any,
        row: any,
        col: any,
        options: any): Promise<any> {
        return await this.layer.fetchTile(level,
            row,
            col,
            options);
    }

    async getTileUrl(level: any,
        row: any,
        col: any): Promise<any> {
        return this.layer.getTileUrl(level,
            row,
            col);
    }

    async refresh(): Promise<void> {
        this.layer.refresh();
    }

    // region properties
    
    async getPortalItem(): Promise<any> {
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.layer.portalItem);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.layer.portalItem = await buildJsPortalItem(value);
    }
    async getTileInfo(): Promise<any> {
        let { buildDotNetTileInfo } = await import('./tileInfo');
        return await buildDotNetTileInfo(this.layer.tileInfo);
    }
    async setTileInfo(value: any): Promise<void> {
        let { buildJsTileInfo } = await import('./tileInfo');
        this.layer.tileInfo = await buildJsTileInfo(value);
    }
    async getVisibilityTimeExtent(): Promise<any> {
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return await buildDotNetTimeExtent(this.layer.visibilityTimeExtent);
    }
    async setVisibilityTimeExtent(value: any): Promise<void> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        this.layer.visibilityTimeExtent = await buildJsTimeExtent(value);
    }
    getProperty(prop: string): any {
        return this.layer[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.layer[prop] = value;
    }
}

export async function buildJsWebTileLayerGenerated(dotNetObject: any): Promise<any> {
    let { default: WebTileLayer } = await import('@arcgis/core/layers/WebTileLayer');
    let jsWebTileLayer = new WebTileLayer();
    if (hasValue(dotNetObject.fullExtent)) {
        let { buildJsExtent } = await import('./extent');
        jsWebTileLayer.fullExtent = buildJsExtent(dotNetObject.fullExtent) as any;

    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsWebTileLayer.portalItem = buildJsPortalItem(dotNetObject.portalItem) as any;

    }
    if (hasValue(dotNetObject.tileInfo)) {
        let { buildJsTileInfo } = await import('./tileInfo');
        jsWebTileLayer.tileInfo = await buildJsTileInfo(dotNetObject.tileInfo) as any;

    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsWebTileLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent) as any;

    }
    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsWebTileLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsWebTileLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.copyright)) {
        jsWebTileLayer.copyright = dotNetObject.copyright;
    }
    if (hasValue(dotNetObject.effect)) {
        jsWebTileLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsWebTileLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsWebTileLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsWebTileLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsWebTileLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsWebTileLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.refreshInterval)) {
        jsWebTileLayer.refreshInterval = dotNetObject.refreshInterval;
    }
    if (hasValue(dotNetObject.subDomains)) {
        jsWebTileLayer.subDomains = dotNetObject.subDomains;
    }
    if (hasValue(dotNetObject.title)) {
        jsWebTileLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.urlTemplate)) {
        jsWebTileLayer.urlTemplate = dotNetObject.urlTemplate;
    }
    jsWebTileLayer.on('refresh', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsRefresh', evt);
    });
    
    let { default: WebTileLayerWrapper } = await import('./webTileLayer');
    let webTileLayerWrapper = new WebTileLayerWrapper(jsWebTileLayer);
    jsWebTileLayer.id = dotNetObject.id;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(webTileLayerWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = webTileLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsWebTileLayer;
    
    return jsWebTileLayer;
}

export async function buildDotNetWebTileLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetWebTileLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.fullExtent)) {
            let { buildDotNetExtent } = await import('./dotNetBuilder');
            dotNetWebTileLayer.fullExtent = await buildDotNetExtent(jsObject.fullExtent);
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./dotNetBuilder');
            dotNetWebTileLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.tileInfo)) {
            let { buildDotNetTileInfo } = await import('./dotNetBuilder');
            dotNetWebTileLayer.tileInfo = await buildDotNetTileInfo(jsObject.tileInfo);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./dotNetBuilder');
            dotNetWebTileLayer.visibilityTimeExtent = await buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        dotNetWebTileLayer.arcGISLayerId = jsObject.id;
        dotNetWebTileLayer.blendMode = jsObject.blendMode;
        dotNetWebTileLayer.copyright = jsObject.copyright;
        dotNetWebTileLayer.effect = jsObject.effect;
        dotNetWebTileLayer.listMode = jsObject.listMode;
        dotNetWebTileLayer.loaded = jsObject.loaded;
        dotNetWebTileLayer.maxScale = jsObject.maxScale;
        dotNetWebTileLayer.minScale = jsObject.minScale;
        dotNetWebTileLayer.opacity = jsObject.opacity;
        dotNetWebTileLayer.persistenceEnabled = jsObject.persistenceEnabled;
        dotNetWebTileLayer.refreshInterval = jsObject.refreshInterval;
        dotNetWebTileLayer.spatialReference = jsObject.spatialReference;
        dotNetWebTileLayer.subDomains = jsObject.subDomains;
        dotNetWebTileLayer.tileServers = jsObject.tileServers;
        dotNetWebTileLayer.title = jsObject.title;
        dotNetWebTileLayer.type = jsObject.type;
        dotNetWebTileLayer.urlTemplate = jsObject.urlTemplate;
    return dotNetWebTileLayer;
}

