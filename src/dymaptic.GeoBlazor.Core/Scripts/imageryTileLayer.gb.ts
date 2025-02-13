// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ImageryTileLayer from '@arcgis/core/layers/ImageryTileLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ImageryTileLayerGenerated implements IPropertyWrapper {
    public layer: ImageryTileLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: ImageryTileLayer) {
        this.layer = layer;
    }
    
    // region methods
   
    unwrap() {
        return this.layer;
    }
    
    async load(options: AbortSignal): Promise<void> {
        await this.layer.load(options);
    }

    async computeStatisticsHistograms(parameters: any,
        requestOptions: any): Promise<any> {
        return await this.layer.computeStatisticsHistograms(parameters,
            requestOptions);
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
        let result = await this.layer.fetchPixels(extent,
            width,
            height,
            options);
        let { buildDotNetPixelData } = await import('./pixelData');
        return await buildDotNetPixelData(result);
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

    async identify(point: any,
        options: any): Promise<any> {
        return await this.layer.identify(point,
            options);
    }

    async save(options: any): Promise<any> {
        let result = await this.layer.save(options);
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(result);
    }

    async saveAs(portalItem: any,
        options: any): Promise<any> {
        let { buildJsPortalItem } = await import('./portalItem');
        let jsPortalItem = await buildJsPortalItem(portalItem, this.layerId, this.viewId) as any;
        let result = await this.layer.saveAs(jsPortalItem,
            options);
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(result);
    }

    // region properties
    
    async getMultidimensionalDefinition(): Promise<any> {
        let { buildDotNetDimensionalDefinition } = await import('./dimensionalDefinition');
        return this.layer.multidimensionalDefinition.map(async i => await buildDotNetDimensionalDefinition(i));
    }
    
    async setMultidimensionalDefinition(value: any): Promise<void> {
        let { buildJsDimensionalDefinition } = await import('./dimensionalDefinition');
        this.layer.multidimensionalDefinition = value.map(i => buildJsDimensionalDefinition(i));
    }
    
    async getMultidimensionalSubset(): Promise<any> {
        let { buildDotNetMultidimensionalSubset } = await import('./multidimensionalSubset');
        return await buildDotNetMultidimensionalSubset(this.layer.multidimensionalSubset);
    }
    async setMultidimensionalSubset(value: any): Promise<void> {
        let { buildJsMultidimensionalSubset } = await import('./multidimensionalSubset');
        this.layer.multidimensionalSubset =  buildJsMultidimensionalSubset(value);
    }
    async getPopupTemplate(): Promise<any> {
        let { buildDotNetPopupTemplate } = await import('./popupTemplate');
        return await buildDotNetPopupTemplate(this.layer.popupTemplate);
    }
    async setPopupTemplate(value: any): Promise<void> {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        this.layer.popupTemplate =  buildJsPopupTemplate(value, this.layerId, this.viewId);
    }
    async getPortalItem(): Promise<any> {
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.layer.portalItem);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.layer.portalItem = await  buildJsPortalItem(value, this.layerId, this.viewId);
    }
    async getRasterFields(): Promise<any> {
        let { buildDotNetField } = await import('./field');
        return this.layer.rasterFields.map(async i => await buildDotNetField(i));
    }
    
    async getRasterFunction(): Promise<any> {
        let { buildDotNetRasterFunction } = await import('./rasterFunction');
        return await buildDotNetRasterFunction(this.layer.rasterFunction);
    }
    async setRasterFunction(value: any): Promise<void> {
        let { buildJsRasterFunction } = await import('./rasterFunction');
        this.layer.rasterFunction = await  buildJsRasterFunction(value, this.layerId, this.viewId);
    }
    async getTileInfo(): Promise<any> {
        let { buildDotNetTileInfo } = await import('./tileInfo');
        return await buildDotNetTileInfo(this.layer.tileInfo);
    }
    async setTileInfo(value: any): Promise<void> {
        let { buildJsTileInfo } = await import('./tileInfo');
        this.layer.tileInfo = await  buildJsTileInfo(value, this.layerId, this.viewId);
    }
    async getTimeExtent(): Promise<any> {
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return buildDotNetTimeExtent(this.layer.timeExtent);
    }
    async setTimeExtent(value: any): Promise<void> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        this.layer.timeExtent = await  buildJsTimeExtent(value, this.layerId, this.viewId);
    }
    async getTimeInfo(): Promise<any> {
        let { buildDotNetTimeInfo } = await import('./timeInfo');
        return await buildDotNetTimeInfo(this.layer.timeInfo);
    }
    async setTimeInfo(value: any): Promise<void> {
        let { buildJsTimeInfo } = await import('./timeInfo');
        this.layer.timeInfo = await  buildJsTimeInfo(value, this.layerId, this.viewId);
    }
    async getTimeOffset(): Promise<any> {
        let { buildDotNetTimeInterval } = await import('./timeInterval');
        return await buildDotNetTimeInterval(this.layer.timeOffset);
    }
    async setTimeOffset(value: any): Promise<void> {
        let { buildJsTimeInterval } = await import('./timeInterval');
        this.layer.timeOffset = await  buildJsTimeInterval(value, this.layerId, this.viewId);
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

export async function buildJsImageryTileLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsImageryTileLayer = new ImageryTileLayer();
    if (hasValue(dotNetObject.multidimensionalDefinition)) {
        let { buildJsDimensionalDefinition } = await import('./jsBuilder');
        jsImageryTileLayer.multidimensionalDefinition = dotNetObject.multidimensionalDefinition.map(i => buildJsDimensionalDefinition(i)) as any;
    }
    if (hasValue(dotNetObject.multidimensionalSubset)) {
        let { buildJsMultidimensionalSubset } = await import('./jsBuilder');
        jsImageryTileLayer.multidimensionalSubset = buildJsMultidimensionalSubset(dotNetObject.multidimensionalSubset) as any;
    }
    if (hasValue(dotNetObject.popupTemplate)) {
        let { buildJsPopupTemplate } = await import('./jsBuilder');
        jsImageryTileLayer.popupTemplate = await buildJsPopupTemplate(dotNetObject.popupTemplate, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsImageryTileLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.rasterFunction)) {
        let { buildJsRasterFunction } = await import('./rasterFunction');
        jsImageryTileLayer.rasterFunction = await buildJsRasterFunction(dotNetObject.rasterFunction, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.tileInfo)) {
        let { buildJsTileInfo } = await import('./tileInfo');
        jsImageryTileLayer.tileInfo = await buildJsTileInfo(dotNetObject.tileInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsImageryTileLayer.timeExtent = await buildJsTimeExtent(dotNetObject.timeExtent, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeInfo)) {
        let { buildJsTimeInfo } = await import('./timeInfo');
        jsImageryTileLayer.timeInfo = await buildJsTimeInfo(dotNetObject.timeInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeOffset)) {
        let { buildJsTimeInterval } = await import('./timeInterval');
        jsImageryTileLayer.timeOffset = await buildJsTimeInterval(dotNetObject.timeOffset, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsImageryTileLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsImageryTileLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.bandIds)) {
        jsImageryTileLayer.bandIds = dotNetObject.bandIds;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsImageryTileLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.copyright)) {
        jsImageryTileLayer.copyright = dotNetObject.copyright;
    }
    if (hasValue(dotNetObject.customParameters)) {
        jsImageryTileLayer.customParameters = dotNetObject.customParameters;
    }
    if (hasValue(dotNetObject.effect)) {
        jsImageryTileLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.fullExtent)) {
        jsImageryTileLayer.fullExtent = dotNetObject.fullExtent;
    }
    if (hasValue(dotNetObject.interpolation)) {
        jsImageryTileLayer.interpolation = dotNetObject.interpolation;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsImageryTileLayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsImageryTileLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsImageryTileLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsImageryTileLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsImageryTileLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsImageryTileLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.popupEnabled)) {
        jsImageryTileLayer.popupEnabled = dotNetObject.popupEnabled;
    }
    if (hasValue(dotNetObject.renderer)) {
        jsImageryTileLayer.renderer = dotNetObject.renderer;
    }
    if (hasValue(dotNetObject.source)) {
        jsImageryTileLayer.source = dotNetObject.source;
    }
    if (hasValue(dotNetObject.title)) {
        jsImageryTileLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.url)) {
        jsImageryTileLayer.url = dotNetObject.url;
    }
    if (hasValue(dotNetObject.useViewTime)) {
        jsImageryTileLayer.useViewTime = dotNetObject.useViewTime;
    }
    let { default: ImageryTileLayerWrapper } = await import('./imageryTileLayer');
    let imageryTileLayerWrapper = new ImageryTileLayerWrapper(jsImageryTileLayer);
    imageryTileLayerWrapper.geoBlazorId = dotNetObject.id;
    imageryTileLayerWrapper.viewId = viewId;
    imageryTileLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(imageryTileLayerWrapper);
    jsObjectRefs[dotNetObject.id] = imageryTileLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsImageryTileLayer;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ImageryTileLayer', e);
    }
    
    return jsImageryTileLayer;
}

export async function buildDotNetImageryTileLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetImageryTileLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.multidimensionalDefinition)) {
            let { buildDotNetDimensionalDefinition } = await import('./dimensionalDefinition');
            dotNetImageryTileLayer.multidimensionalDefinition = jsObject.multidimensionalDefinition.map(async i => await buildDotNetDimensionalDefinition(i));
        }
        if (hasValue(jsObject.multidimensionalSubset)) {
            let { buildDotNetMultidimensionalSubset } = await import('./multidimensionalSubset');
            dotNetImageryTileLayer.multidimensionalSubset = await buildDotNetMultidimensionalSubset(jsObject.multidimensionalSubset);
        }
        if (hasValue(jsObject.popupTemplate)) {
            let { buildDotNetPopupTemplate } = await import('./popupTemplate');
            dotNetImageryTileLayer.popupTemplate = await buildDotNetPopupTemplate(jsObject.popupTemplate);
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetImageryTileLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.rasterFields)) {
            let { buildDotNetField } = await import('./field');
            dotNetImageryTileLayer.rasterFields = jsObject.rasterFields.map(async i => await buildDotNetField(i));
        }
        if (hasValue(jsObject.rasterFunction)) {
            let { buildDotNetRasterFunction } = await import('./rasterFunction');
            dotNetImageryTileLayer.rasterFunction = await buildDotNetRasterFunction(jsObject.rasterFunction);
        }
        if (hasValue(jsObject.tileInfo)) {
            let { buildDotNetTileInfo } = await import('./tileInfo');
            dotNetImageryTileLayer.tileInfo = await buildDotNetTileInfo(jsObject.tileInfo);
        }
        if (hasValue(jsObject.timeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetImageryTileLayer.timeExtent = buildDotNetTimeExtent(jsObject.timeExtent);
        }
        if (hasValue(jsObject.timeInfo)) {
            let { buildDotNetTimeInfo } = await import('./timeInfo');
            dotNetImageryTileLayer.timeInfo = await buildDotNetTimeInfo(jsObject.timeInfo);
        }
        if (hasValue(jsObject.timeOffset)) {
            let { buildDotNetTimeInterval } = await import('./timeInterval');
            dotNetImageryTileLayer.timeOffset = await buildDotNetTimeInterval(jsObject.timeOffset);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetImageryTileLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.id)) {
            dotNetImageryTileLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.bandIds)) {
            dotNetImageryTileLayer.bandIds = jsObject.bandIds;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetImageryTileLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.copyright)) {
            dotNetImageryTileLayer.copyright = jsObject.copyright;
        }
        if (hasValue(jsObject.customParameters)) {
            dotNetImageryTileLayer.customParameters = jsObject.customParameters;
        }
        if (hasValue(jsObject.effect)) {
            dotNetImageryTileLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.fullExtent)) {
            dotNetImageryTileLayer.fullExtent = jsObject.fullExtent;
        }
        if (hasValue(jsObject.interpolation)) {
            dotNetImageryTileLayer.interpolation = jsObject.interpolation;
        }
        if (hasValue(jsObject.legendEnabled)) {
            dotNetImageryTileLayer.legendEnabled = jsObject.legendEnabled;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetImageryTileLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetImageryTileLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetImageryTileLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetImageryTileLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetImageryTileLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetImageryTileLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.popupEnabled)) {
            dotNetImageryTileLayer.popupEnabled = jsObject.popupEnabled;
        }
        if (hasValue(jsObject.rasterInfo)) {
            dotNetImageryTileLayer.rasterInfo = jsObject.rasterInfo;
        }
        if (hasValue(jsObject.renderer)) {
            dotNetImageryTileLayer.renderer = jsObject.renderer;
        }
        if (hasValue(jsObject.serviceRasterInfo)) {
            dotNetImageryTileLayer.serviceRasterInfo = jsObject.serviceRasterInfo;
        }
        if (hasValue(jsObject.source)) {
            dotNetImageryTileLayer.source = jsObject.source;
        }
        if (hasValue(jsObject.sourceJSON)) {
            dotNetImageryTileLayer.sourceJSON = jsObject.sourceJSON;
        }
        if (hasValue(jsObject.title)) {
            dotNetImageryTileLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetImageryTileLayer.type = jsObject.type;
        }
        if (hasValue(jsObject.url)) {
            dotNetImageryTileLayer.url = jsObject.url;
        }
        if (hasValue(jsObject.useViewTime)) {
            dotNetImageryTileLayer.useViewTime = jsObject.useViewTime;
        }
        if (hasValue(jsObject.version)) {
            dotNetImageryTileLayer.version = jsObject.version;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetImageryTileLayer.id = k;
                break;
            }
        }
    }

    return dotNetImageryTileLayer;
}

