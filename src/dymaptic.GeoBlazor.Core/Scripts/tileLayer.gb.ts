// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import TileLayer from '@arcgis/core/layers/TileLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class TileLayerGenerated implements IPropertyWrapper {
    public layer: TileLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: TileLayer) {
        this.layer = layer;
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
        return await buildDotNetLayerView(result);
    }

    async createServiceSublayers(): Promise<any> {
        let result = this.layer.createServiceSublayers();
        let { buildDotNetSublayer } = await import('./sublayer');
        return result.map(async i => await buildDotNetSublayer(i));
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

    async findSublayerById(id: any): Promise<any> {
        let result = this.layer.findSublayerById(id);
        let { buildDotNetSublayer } = await import('./sublayer');
        return await buildDotNetSublayer(result);
    }

    async getTileUrl(level: any,
        row: any,
        col: any): Promise<any> {
        return this.layer.getTileUrl(level,
            row,
            col);
    }

    async loadAll(): Promise<any> {
        let result = await this.layer.loadAll();
        let { buildDotNetSublayer } = await import('./sublayer');
        return await buildDotNetSublayer(result);
    }

    async refresh(): Promise<void> {
        this.layer.refresh();
    }

    // region properties
    
    async getAllSublayers(): Promise<any> {
        let { buildDotNetSublayer } = await import('./sublayer');
        return await Promise.all(this.layer.allSublayers.map(async i => await buildDotNetSublayer(i)));
    }
    
    async getPortalItem(): Promise<any> {
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.layer.portalItem);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.layer.portalItem = await  buildJsPortalItem(value, this.layerId, this.viewId);
    }
    async getSublayers(): Promise<any> {
        let { buildDotNetSublayer } = await import('./sublayer');
        return await Promise.all(this.layer.sublayers.map(async i => await buildDotNetSublayer(i)));
    }
    
    async getSubtables(): Promise<any> {
        let { buildDotNetSublayer } = await import('./sublayer');
        return await Promise.all(this.layer.subtables.map(async i => await buildDotNetSublayer(i)));
    }
    
    async setSubtables(value: any): Promise<void> {
        let { buildJsSublayer } = await import('./sublayer');
        this.layer.subtables = value.map(async i => await buildJsSublayer(i, this.layerId, this.viewId));
    }
    
    async getTileInfo(): Promise<any> {
        let { buildDotNetTileInfo } = await import('./tileInfo');
        return await buildDotNetTileInfo(this.layer.tileInfo);
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

export async function buildJsTileLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsTileLayer = new TileLayer();
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsTileLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.subtables)) {
        let { buildJsSublayer } = await import('./jsBuilder');
        jsTileLayer.subtables = await Promise.all(dotNetObject.subtables.map(async i => await buildJsSublayer(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.tileInfo)) {
        let { buildJsTileInfo } = await import('./tileInfo');
        jsTileLayer.tileInfo = await buildJsTileInfo(dotNetObject.tileInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsTileLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.apiKey)) {
        jsTileLayer.apiKey = dotNetObject.apiKey;
    }
    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsTileLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsTileLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.copyright)) {
        jsTileLayer.copyright = dotNetObject.copyright;
    }
    if (hasValue(dotNetObject.customParameters)) {
        jsTileLayer.customParameters = dotNetObject.customParameters;
    }
    if (hasValue(dotNetObject.effect)) {
        jsTileLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.fullExtent)) {
        jsTileLayer.fullExtent = dotNetObject.fullExtent;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsTileLayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsTileLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsTileLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsTileLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsTileLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsTileLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.refreshInterval)) {
        jsTileLayer.refreshInterval = dotNetObject.refreshInterval;
    }
    if (hasValue(dotNetObject.resampling)) {
        jsTileLayer.resampling = dotNetObject.resampling;
    }
    if (hasValue(dotNetObject.tileServers)) {
        jsTileLayer.tileServers = dotNetObject.tileServers;
    }
    if (hasValue(dotNetObject.title)) {
        jsTileLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.url)) {
        jsTileLayer.url = dotNetObject.url;
    }
    jsTileLayer.on('refresh', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsRefresh', evt);
    });
    
    let { default: TileLayerWrapper } = await import('./tileLayer');
    let tileLayerWrapper = new TileLayerWrapper(jsTileLayer);
    tileLayerWrapper.geoBlazorId = dotNetObject.id;
    tileLayerWrapper.viewId = viewId;
    tileLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(tileLayerWrapper);
    jsObjectRefs[dotNetObject.id] = tileLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsTileLayer;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for TileLayer', e);
    }
    
    return jsTileLayer;
}

export async function buildDotNetTileLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetTileLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.allSublayers)) {
            let { buildDotNetSublayer } = await import('./sublayer');
            dotNetTileLayer.allSublayers = await Promise.all(jsObject.allSublayers.map(async i => await buildDotNetSublayer(i)));
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetTileLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.sublayers)) {
            let { buildDotNetSublayer } = await import('./sublayer');
            dotNetTileLayer.sublayers = await Promise.all(jsObject.sublayers.map(async i => await buildDotNetSublayer(i)));
        }
        if (hasValue(jsObject.subtables)) {
            let { buildDotNetSublayer } = await import('./sublayer');
            dotNetTileLayer.subtables = await Promise.all(jsObject.subtables.map(async i => await buildDotNetSublayer(i)));
        }
        if (hasValue(jsObject.tileInfo)) {
            let { buildDotNetTileInfo } = await import('./tileInfo');
            dotNetTileLayer.tileInfo = await buildDotNetTileInfo(jsObject.tileInfo);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetTileLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.apiKey)) {
            dotNetTileLayer.apiKey = jsObject.apiKey;
        }
        if (hasValue(jsObject.id)) {
            dotNetTileLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.attributionDataUrl)) {
            dotNetTileLayer.attributionDataUrl = jsObject.attributionDataUrl;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetTileLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.capabilities)) {
            dotNetTileLayer.capabilities = jsObject.capabilities;
        }
        if (hasValue(jsObject.copyright)) {
            dotNetTileLayer.copyright = jsObject.copyright;
        }
        if (hasValue(jsObject.customParameters)) {
            dotNetTileLayer.customParameters = jsObject.customParameters;
        }
        if (hasValue(jsObject.effect)) {
            dotNetTileLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.fullExtent)) {
            dotNetTileLayer.fullExtent = jsObject.fullExtent;
        }
        if (hasValue(jsObject.hasAttributionData)) {
            dotNetTileLayer.hasAttributionData = jsObject.hasAttributionData;
        }
        if (hasValue(jsObject.legendEnabled)) {
            dotNetTileLayer.legendEnabled = jsObject.legendEnabled;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetTileLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetTileLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetTileLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetTileLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetTileLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetTileLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.refreshInterval)) {
            dotNetTileLayer.refreshInterval = jsObject.refreshInterval;
        }
        if (hasValue(jsObject.resampling)) {
            dotNetTileLayer.resampling = jsObject.resampling;
        }
        if (hasValue(jsObject.sourceJSON)) {
            dotNetTileLayer.sourceJSON = jsObject.sourceJSON;
        }
        if (hasValue(jsObject.spatialReference)) {
            dotNetTileLayer.spatialReference = jsObject.spatialReference;
        }
        if (hasValue(jsObject.tileServers)) {
            dotNetTileLayer.tileServers = jsObject.tileServers;
        }
        if (hasValue(jsObject.title)) {
            dotNetTileLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetTileLayer.type = jsObject.type;
        }
        if (hasValue(jsObject.url)) {
            dotNetTileLayer.url = jsObject.url;
        }
        if (hasValue(jsObject.version)) {
            dotNetTileLayer.version = jsObject.version;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetTileLayer.id = k;
                break;
            }
        }
    }

    return dotNetTileLayer;
}

