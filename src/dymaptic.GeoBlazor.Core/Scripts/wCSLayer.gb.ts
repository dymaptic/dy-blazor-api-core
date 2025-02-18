// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import WCSLayer from '@arcgis/core/layers/WCSLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class WCSLayerGenerated implements IPropertyWrapper {
    public layer: WCSLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: WCSLayer) {
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

    async createPopupTemplate(options: any): Promise<any> {
        let result = this.layer.createPopupTemplate(options);
        let { buildDotNetPopupTemplate } = await import('./popupTemplate');
        return await buildDotNetPopupTemplate(result);
    }

    async fetchAttributionData(): Promise<any> {
        return await this.layer.fetchAttributionData();
    }

    async fetchPixels(extent: any,
        width: any,
        height: any,
        options: any): Promise<any> {
        let { buildJsExtent } = await import('./extent');
        let jsExtent = buildJsExtent(extent) as any;
        let result = await this.layer.fetchPixels(jsExtent,
            width,
            height,
            options);
        let { buildDotNetPixelData } = await import('./pixelData');
        return await buildDotNetPixelData(result);
    }

    async identify(point: any,
        options: any): Promise<any> {
        let { buildJsPoint } = await import('./point');
        let jsPoint = buildJsPoint(point) as any;
        return await this.layer.identify(jsPoint,
            options);
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
    async getMultidimensionalDefinition(): Promise<any> {
        if (!hasValue(this.layer.multidimensionalDefinition)) {
            return null;
        }
        
        let { buildDotNetDimensionalDefinition } = await import('./dimensionalDefinition');
        return await Promise.all(this.layer.multidimensionalDefinition.map(async i => await buildDotNetDimensionalDefinition(i)));
    }
    
    async setMultidimensionalDefinition(value: any): Promise<void> {
        let { buildJsDimensionalDefinition } = await import('./dimensionalDefinition');
        this.layer.multidimensionalDefinition = await Promise.all(value.map(async i => await buildJsDimensionalDefinition(i, this.layerId, this.viewId))) as any;
    }
    
    async getMultidimensionalSubset(): Promise<any> {
        if (!hasValue(this.layer.multidimensionalSubset)) {
            return null;
        }
        
        let { buildDotNetMultidimensionalSubset } = await import('./multidimensionalSubset');
        return await buildDotNetMultidimensionalSubset(this.layer.multidimensionalSubset);
    }
    async setMultidimensionalSubset(value: any): Promise<void> {
        let { buildJsMultidimensionalSubset } = await import('./multidimensionalSubset');
        this.layer.multidimensionalSubset = await  buildJsMultidimensionalSubset(value, this.layerId, this.viewId);
    }
    async getPopupTemplate(): Promise<any> {
        if (!hasValue(this.layer.popupTemplate)) {
            return null;
        }
        
        let { buildDotNetPopupTemplate } = await import('./popupTemplate');
        return await buildDotNetPopupTemplate(this.layer.popupTemplate);
    }
    async setPopupTemplate(value: any): Promise<void> {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        this.layer.popupTemplate =  buildJsPopupTemplate(value, this.layerId, this.viewId);
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
    async getRasterFields(): Promise<any> {
        if (!hasValue(this.layer.rasterFields)) {
            return null;
        }
        
        let { buildDotNetField } = await import('./field');
        return this.layer.rasterFields!.map(i => buildDotNetField(i));
    }
    
    async setRasterFields(value: any): Promise<void> {
        let { buildJsField } = await import('./field');
        this.layer.rasterFields = value.map(i => buildJsField(i)) as any;
    }
    
    async getTimeExtent(): Promise<any> {
        if (!hasValue(this.layer.timeExtent)) {
            return null;
        }
        
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return buildDotNetTimeExtent(this.layer.timeExtent);
    }
    async setTimeExtent(value: any): Promise<void> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        this.layer.timeExtent = await  buildJsTimeExtent(value, this.layerId, this.viewId);
    }
    async getTimeInfo(): Promise<any> {
        if (!hasValue(this.layer.timeInfo)) {
            return null;
        }
        
        let { buildDotNetTimeInfo } = await import('./timeInfo');
        return await buildDotNetTimeInfo(this.layer.timeInfo);
    }
    async setTimeInfo(value: any): Promise<void> {
        let { buildJsTimeInfo } = await import('./timeInfo');
        this.layer.timeInfo = await  buildJsTimeInfo(value, this.layerId, this.viewId);
    }
    async getTimeOffset(): Promise<any> {
        if (!hasValue(this.layer.timeOffset)) {
            return null;
        }
        
        let { buildDotNetTimeInterval } = await import('./timeInterval');
        return await buildDotNetTimeInterval(this.layer.timeOffset);
    }
    async setTimeOffset(value: any): Promise<void> {
        let { buildJsTimeInterval } = await import('./timeInterval');
        this.layer.timeOffset = await  buildJsTimeInterval(value, this.layerId, this.viewId);
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

export async function buildJsWCSLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsWCSLayer = new WCSLayer();
    if (hasValue(dotNetObject.fullExtent)) {
        let { buildJsExtent } = await import('./extent');
        jsWCSLayer.fullExtent = buildJsExtent(dotNetObject.fullExtent) as any;
    }
    if (hasValue(dotNetObject.multidimensionalDefinition)) {
        let { buildJsDimensionalDefinition } = await import('./dimensionalDefinition');
        jsWCSLayer.multidimensionalDefinition = await Promise.all(dotNetObject.multidimensionalDefinition.map(async i => await buildJsDimensionalDefinition(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.multidimensionalSubset)) {
        let { buildJsMultidimensionalSubset } = await import('./multidimensionalSubset');
        jsWCSLayer.multidimensionalSubset = await buildJsMultidimensionalSubset(dotNetObject.multidimensionalSubset, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.popupTemplate)) {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        jsWCSLayer.popupTemplate = buildJsPopupTemplate(dotNetObject.popupTemplate, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsWCSLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.rasterFields)) {
        let { buildJsField } = await import('./field');
        jsWCSLayer.rasterFields = dotNetObject.rasterFields.map(i => buildJsField(i)) as any;
    }
    if (hasValue(dotNetObject.timeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsWCSLayer.timeExtent = await buildJsTimeExtent(dotNetObject.timeExtent, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeInfo)) {
        let { buildJsTimeInfo } = await import('./timeInfo');
        jsWCSLayer.timeInfo = await buildJsTimeInfo(dotNetObject.timeInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeOffset)) {
        let { buildJsTimeInterval } = await import('./timeInterval');
        jsWCSLayer.timeOffset = await buildJsTimeInterval(dotNetObject.timeOffset, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsWCSLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsWCSLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.bandIds)) {
        jsWCSLayer.bandIds = dotNetObject.bandIds;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsWCSLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.copyright)) {
        jsWCSLayer.copyright = dotNetObject.copyright;
    }
    if (hasValue(dotNetObject.coverageId)) {
        jsWCSLayer.coverageId = dotNetObject.coverageId;
    }
    if (hasValue(dotNetObject.coverageInfo)) {
        jsWCSLayer.coverageInfo = dotNetObject.coverageInfo;
    }
    if (hasValue(dotNetObject.customParameters)) {
        jsWCSLayer.customParameters = dotNetObject.customParameters;
    }
    if (hasValue(dotNetObject.effect)) {
        jsWCSLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.interpolation)) {
        jsWCSLayer.interpolation = dotNetObject.interpolation;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsWCSLayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsWCSLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsWCSLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsWCSLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsWCSLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsWCSLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.popupEnabled)) {
        jsWCSLayer.popupEnabled = dotNetObject.popupEnabled;
    }
    if (hasValue(dotNetObject.renderer)) {
        jsWCSLayer.renderer = dotNetObject.renderer;
    }
    if (hasValue(dotNetObject.title)) {
        jsWCSLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.url)) {
        jsWCSLayer.url = dotNetObject.url;
    }
    if (hasValue(dotNetObject.useViewTime)) {
        jsWCSLayer.useViewTime = dotNetObject.useViewTime;
    }
    if (hasValue(dotNetObject.version)) {
        jsWCSLayer.version = dotNetObject.version;
    }
    let { default: WCSLayerWrapper } = await import('./wCSLayer');
    let wCSLayerWrapper = new WCSLayerWrapper(jsWCSLayer);
    wCSLayerWrapper.geoBlazorId = dotNetObject.id;
    wCSLayerWrapper.viewId = viewId;
    wCSLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(wCSLayerWrapper);
    jsObjectRefs[dotNetObject.id] = wCSLayerWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsWCSLayer;
    let { buildDotNetWCSLayer } = await import('./wCSLayer');
    let dnInstantiatedObject = await buildDotNetWCSLayer(jsWCSLayer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for WCSLayer', e);
    }
    
    return jsWCSLayer;
}

export async function buildDotNetWCSLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetWCSLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.fullExtent)) {
            let { buildDotNetExtent } = await import('./extent');
            dotNetWCSLayer.fullExtent = buildDotNetExtent(jsObject.fullExtent);
        }
        if (hasValue(jsObject.multidimensionalDefinition)) {
            let { buildDotNetDimensionalDefinition } = await import('./dimensionalDefinition');
            dotNetWCSLayer.multidimensionalDefinition = await Promise.all(jsObject.multidimensionalDefinition.map(async i => await buildDotNetDimensionalDefinition(i)));
        }
        if (hasValue(jsObject.multidimensionalSubset)) {
            let { buildDotNetMultidimensionalSubset } = await import('./multidimensionalSubset');
            dotNetWCSLayer.multidimensionalSubset = await buildDotNetMultidimensionalSubset(jsObject.multidimensionalSubset);
        }
        if (hasValue(jsObject.popupTemplate)) {
            let { buildDotNetPopupTemplate } = await import('./popupTemplate');
            dotNetWCSLayer.popupTemplate = await buildDotNetPopupTemplate(jsObject.popupTemplate);
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetWCSLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.rasterFields)) {
            let { buildDotNetField } = await import('./field');
            dotNetWCSLayer.rasterFields = jsObject.rasterFields.map(i => buildDotNetField(i));
        }
        if (hasValue(jsObject.timeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetWCSLayer.timeExtent = buildDotNetTimeExtent(jsObject.timeExtent);
        }
        if (hasValue(jsObject.timeInfo)) {
            let { buildDotNetTimeInfo } = await import('./timeInfo');
            dotNetWCSLayer.timeInfo = await buildDotNetTimeInfo(jsObject.timeInfo);
        }
        if (hasValue(jsObject.timeOffset)) {
            let { buildDotNetTimeInterval } = await import('./timeInterval');
            dotNetWCSLayer.timeOffset = await buildDotNetTimeInterval(jsObject.timeOffset);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetWCSLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.id)) {
            dotNetWCSLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.bandIds)) {
            dotNetWCSLayer.bandIds = jsObject.bandIds;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetWCSLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.copyright)) {
            dotNetWCSLayer.copyright = jsObject.copyright;
        }
        if (hasValue(jsObject.coverageId)) {
            dotNetWCSLayer.coverageId = jsObject.coverageId;
        }
        if (hasValue(jsObject.coverageInfo)) {
            dotNetWCSLayer.coverageInfo = jsObject.coverageInfo;
        }
        if (hasValue(jsObject.customParameters)) {
            dotNetWCSLayer.customParameters = jsObject.customParameters;
        }
        if (hasValue(jsObject.effect)) {
            dotNetWCSLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.interpolation)) {
            dotNetWCSLayer.interpolation = jsObject.interpolation;
        }
        if (hasValue(jsObject.legendEnabled)) {
            dotNetWCSLayer.legendEnabled = jsObject.legendEnabled;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetWCSLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetWCSLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetWCSLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetWCSLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetWCSLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetWCSLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.popupEnabled)) {
            dotNetWCSLayer.popupEnabled = jsObject.popupEnabled;
        }
        if (hasValue(jsObject.rasterInfo)) {
            dotNetWCSLayer.rasterInfo = jsObject.rasterInfo;
        }
        if (hasValue(jsObject.renderer)) {
            dotNetWCSLayer.renderer = jsObject.renderer;
        }
        if (hasValue(jsObject.serviceRasterInfo)) {
            dotNetWCSLayer.serviceRasterInfo = jsObject.serviceRasterInfo;
        }
        if (hasValue(jsObject.title)) {
            dotNetWCSLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetWCSLayer.type = jsObject.type;
        }
        if (hasValue(jsObject.url)) {
            dotNetWCSLayer.url = jsObject.url;
        }
        if (hasValue(jsObject.useViewTime)) {
            dotNetWCSLayer.useViewTime = jsObject.useViewTime;
        }
        if (hasValue(jsObject.version)) {
            dotNetWCSLayer.version = jsObject.version;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetWCSLayer.id = k;
                break;
            }
        }
    }

    return dotNetWCSLayer;
}

