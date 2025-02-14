// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import KMLLayer from '@arcgis/core/layers/KMLLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class KMLLayerGenerated implements IPropertyWrapper {
    public layer: KMLLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: KMLLayer) {
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

    async fetchAttributionData(): Promise<any> {
        return await this.layer.fetchAttributionData();
    }

    // region properties
    
    async getFullExtent(): Promise<any> {
        if (!hasValue(this.layer.fullExtent)) {
            return null;
        }
        
        let { buildDotNetExtent } = await import('./extent');
        return buildDotNetExtent(this.layer.fullExtent);
    }
    async setFullExtent(value: any): Promise<void> {
        let { buildJsExtent } = await import('./extent');
        this.layer.fullExtent =  buildJsExtent(value);
    }
    async getPortalItem(): Promise<any> {
        if (!hasValue(this.layer.portalItem)) {
            return null;
        }
        
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.layer.portalItem);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.layer.portalItem = await  buildJsPortalItem(value, this.layerId, this.viewId);
    }
    async getSublayers(): Promise<any> {
        if (!hasValue(this.layer.sublayers)) {
            return null;
        }
        
        let { buildDotNetKMLSublayer } = await import('./kMLSublayer');
        return await Promise.all(this.layer.sublayers.map(async i => await buildDotNetKMLSublayer(i)));
    }
    
    async setSublayers(value: any): Promise<void> {
        let { buildJsKMLSublayer } = await import('./kMLSublayer');
        this.layer.sublayers = await Promise.all(value.map(async i => await buildJsKMLSublayer(i, this.layerId, this.viewId))) as any;
    }
    
    async getVisibilityTimeExtent(): Promise<any> {
        if (!hasValue(this.layer.visibilityTimeExtent)) {
            return null;
        }
        
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

export async function buildJsKMLLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsKMLLayer = new KMLLayer();
    if (hasValue(dotNetObject.fullExtent)) {
        let { buildJsExtent } = await import('./extent');
        jsKMLLayer.fullExtent = buildJsExtent(dotNetObject.fullExtent) as any;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsKMLLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.sublayers)) {
        let { buildJsKMLSublayer } = await import('./kMLSublayer');
        jsKMLLayer.sublayers = await Promise.all(dotNetObject.sublayers.map(async i => await buildJsKMLSublayer(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsKMLLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsKMLLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsKMLLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.effect)) {
        jsKMLLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsKMLLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsKMLLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsKMLLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsKMLLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsKMLLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.title)) {
        jsKMLLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.url)) {
        jsKMLLayer.url = dotNetObject.url;
    }
    let { default: KMLLayerWrapper } = await import('./kMLLayer');
    let kMLLayerWrapper = new KMLLayerWrapper(jsKMLLayer);
    kMLLayerWrapper.geoBlazorId = dotNetObject.id;
    kMLLayerWrapper.viewId = viewId;
    kMLLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(kMLLayerWrapper);
    jsObjectRefs[dotNetObject.id] = kMLLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsKMLLayer;
    
    let dnInstantiatedObject = await buildDotNetKMLLayer(jsKMLLayer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for KMLLayer', e);
    }
    
    return jsKMLLayer;
}

export async function buildDotNetKMLLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetKMLLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.fullExtent)) {
            let { buildDotNetExtent } = await import('./extent');
            dotNetKMLLayer.fullExtent = buildDotNetExtent(jsObject.fullExtent);
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetKMLLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.sublayers)) {
            let { buildDotNetKMLSublayer } = await import('./kMLSublayer');
            dotNetKMLLayer.sublayers = await Promise.all(jsObject.sublayers.map(async i => await buildDotNetKMLSublayer(i)));
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetKMLLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.id)) {
            dotNetKMLLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetKMLLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.effect)) {
            dotNetKMLLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetKMLLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetKMLLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetKMLLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetKMLLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetKMLLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetKMLLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.title)) {
            dotNetKMLLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetKMLLayer.type = jsObject.type;
        }
        if (hasValue(jsObject.url)) {
            dotNetKMLLayer.url = jsObject.url;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetKMLLayer.id = k;
                break;
            }
        }
    }

    return dotNetKMLLayer;
}

