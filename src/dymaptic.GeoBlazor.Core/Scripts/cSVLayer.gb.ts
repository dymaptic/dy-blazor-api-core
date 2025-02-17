// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CSVLayer from '@arcgis/core/layers/CSVLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CSVLayerGenerated implements IPropertyWrapper {
    public layer: CSVLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: CSVLayer) {
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

    async createQuery(): Promise<any> {
        return this.layer.createQuery();
    }

    async fetchAttributionData(): Promise<any> {
        return await this.layer.fetchAttributionData();
    }

    async getField(fieldName: any): Promise<any> {
        let result = this.layer.getField(fieldName);
        let { buildDotNetField } = await import('./field');
        return await buildDotNetField(result);
    }

    async getFieldDomain(fieldName: any,
        options: any): Promise<any> {
        return this.layer.getFieldDomain(fieldName,
            options);
    }

    async queryExtent(query: any,
        options: any): Promise<any> {
        return await this.layer.queryExtent(query,
            options);
    }

    async queryFeatureCount(query: any,
        options: any): Promise<any> {
        return await this.layer.queryFeatureCount(query,
            options);
    }

    async queryFeatures(query: any,
        options: any): Promise<any> {
        return await this.layer.queryFeatures(query,
            options);
    }

    async queryObjectIds(query: any,
        options: any): Promise<any> {
        return await this.layer.queryObjectIds(query,
            options);
    }

    async refresh(): Promise<void> {
        this.layer.refresh();
    }

    // region properties
    
    async getElevationInfo(): Promise<any> {
        if (!hasValue(this.layer.elevationInfo)) {
            return null;
        }
        
        let { buildDotNetCSVLayerElevationInfo } = await import('./cSVLayerElevationInfo');
        return await buildDotNetCSVLayerElevationInfo(this.layer.elevationInfo);
    }
    async setElevationInfo(value: any): Promise<void> {
        let { buildJsCSVLayerElevationInfo } = await import('./cSVLayerElevationInfo');
        this.layer.elevationInfo = await  buildJsCSVLayerElevationInfo(value, this.layerId, this.viewId);
    }
    async getFeatureEffect(): Promise<any> {
        if (!hasValue(this.layer.featureEffect)) {
            return null;
        }
        
        let { buildDotNetFeatureEffect } = await import('./featureEffect');
        return await buildDotNetFeatureEffect(this.layer.featureEffect);
    }
    async setFeatureEffect(value: any): Promise<void> {
        let { buildJsFeatureEffect } = await import('./featureEffect');
        this.layer.featureEffect = await  buildJsFeatureEffect(value);
    }
    async getFields(): Promise<any> {
        if (!hasValue(this.layer.fields)) {
            return null;
        }
        
        let { buildDotNetField } = await import('./field');
        return await Promise.all(this.layer.fields.map(async i => await buildDotNetField(i)));
    }
    
    async setFields(value: any): Promise<void> {
        let { buildJsField } = await import('./field');
        this.layer.fields = await Promise.all(value.map(async i => await buildJsField(i, this.layerId, this.viewId))) as any;
    }
    
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
    async getLabelingInfo(): Promise<any> {
        if (!hasValue(this.layer.labelingInfo)) {
            return null;
        }
        
        let { buildDotNetLabel } = await import('./label');
        return await Promise.all(this.layer.labelingInfo.map(async i => await buildDotNetLabel(i)));
    }
    
    async setLabelingInfo(value: any): Promise<void> {
        let { buildJsLabel } = await import('./label');
        this.layer.labelingInfo = await Promise.all(value.map(async i => await buildJsLabel(i, this.layerId, this.viewId))) as any;
    }
    
    async getOrderBy(): Promise<any> {
        if (!hasValue(this.layer.orderBy)) {
            return null;
        }
        
        let { buildDotNetOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
        return await Promise.all(this.layer.orderBy.map(async i => await buildDotNetOrderedLayerOrderBy(i)));
    }
    
    async setOrderBy(value: any): Promise<void> {
        let { buildJsOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
        this.layer.orderBy = await Promise.all(value.map(async i => await buildJsOrderedLayerOrderBy(i, this.layerId, this.viewId))) as any;
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
        this.layer.popupTemplate = await  buildJsPopupTemplate(value, this.layerId, this.viewId);
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
    async getRenderer(): Promise<any> {
        if (!hasValue(this.layer.renderer)) {
            return null;
        }
        
        let { buildDotNetRenderer } = await import('./renderer');
        return await buildDotNetRenderer(this.layer.renderer);
    }
    async setRenderer(value: any): Promise<void> {
        let { buildJsRenderer } = await import('./renderer');
        this.layer.renderer = await  buildJsRenderer(value, this.layerId, this.viewId);
    }
    async getSpatialReference(): Promise<any> {
        if (!hasValue(this.layer.spatialReference)) {
            return null;
        }
        
        let { buildDotNetSpatialReference } = await import('./spatialReference');
        return buildDotNetSpatialReference(this.layer.spatialReference);
    }
    async setSpatialReference(value: any): Promise<void> {
        let { buildJsSpatialReference } = await import('./spatialReference');
        this.layer.spatialReference = await  buildJsSpatialReference(value);
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

export async function buildJsCSVLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCSVLayer = new CSVLayer();
    if (hasValue(dotNetObject.elevationInfo)) {
        let { buildJsCSVLayerElevationInfo } = await import('./cSVLayerElevationInfo');
        jsCSVLayer.elevationInfo = await buildJsCSVLayerElevationInfo(dotNetObject.elevationInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.featureEffect)) {
        let { buildJsFeatureEffect } = await import('./jsBuilder');
        jsCSVLayer.featureEffect = await buildJsFeatureEffect(dotNetObject.featureEffect) as any;
    }
    if (hasValue(dotNetObject.fields)) {
        let { buildJsField } = await import('./field');
        jsCSVLayer.fields = await Promise.all(dotNetObject.fields.map(async i => await buildJsField(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.fullExtent)) {
        let { buildJsExtent } = await import('./extent');
        jsCSVLayer.fullExtent = buildJsExtent(dotNetObject.fullExtent) as any;
    }
    if (hasValue(dotNetObject.labelingInfo)) {
        let { buildJsLabel } = await import('./label');
        jsCSVLayer.labelingInfo = await Promise.all(dotNetObject.labelingInfo.map(async i => await buildJsLabel(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.orderBy)) {
        let { buildJsOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
        jsCSVLayer.orderBy = await Promise.all(dotNetObject.orderBy.map(async i => await buildJsOrderedLayerOrderBy(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.popupTemplate)) {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        jsCSVLayer.popupTemplate = await buildJsPopupTemplate(dotNetObject.popupTemplate, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsCSVLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.renderer)) {
        let { buildJsRenderer } = await import('./renderer');
        jsCSVLayer.renderer = await buildJsRenderer(dotNetObject.renderer, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        let { buildJsSpatialReference } = await import('./spatialReference');
        jsCSVLayer.spatialReference = await buildJsSpatialReference(dotNetObject.spatialReference) as any;
    }
    if (hasValue(dotNetObject.timeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsCSVLayer.timeExtent = await buildJsTimeExtent(dotNetObject.timeExtent, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeInfo)) {
        let { buildJsTimeInfo } = await import('./timeInfo');
        jsCSVLayer.timeInfo = await buildJsTimeInfo(dotNetObject.timeInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeOffset)) {
        let { buildJsTimeInterval } = await import('./timeInterval');
        jsCSVLayer.timeOffset = await buildJsTimeInterval(dotNetObject.timeOffset, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsCSVLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsCSVLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsCSVLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.copyright)) {
        jsCSVLayer.copyright = dotNetObject.copyright;
    }
    if (hasValue(dotNetObject.customParameters)) {
        jsCSVLayer.customParameters = dotNetObject.customParameters;
    }
    if (hasValue(dotNetObject.definitionExpression)) {
        jsCSVLayer.definitionExpression = dotNetObject.definitionExpression;
    }
    if (hasValue(dotNetObject.delimiter)) {
        jsCSVLayer.delimiter = dotNetObject.delimiter;
    }
    if (hasValue(dotNetObject.displayField)) {
        jsCSVLayer.displayField = dotNetObject.displayField;
    }
    if (hasValue(dotNetObject.effect)) {
        jsCSVLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.featureReduction)) {
        jsCSVLayer.featureReduction = dotNetObject.featureReduction;
    }
    if (hasValue(dotNetObject.geometryType)) {
        jsCSVLayer.geometryType = dotNetObject.geometryType;
    }
    if (hasValue(dotNetObject.labelsVisible)) {
        jsCSVLayer.labelsVisible = dotNetObject.labelsVisible;
    }
    if (hasValue(dotNetObject.latitudeField)) {
        jsCSVLayer.latitudeField = dotNetObject.latitudeField;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsCSVLayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsCSVLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.longitudeField)) {
        jsCSVLayer.longitudeField = dotNetObject.longitudeField;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsCSVLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsCSVLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.objectIdField)) {
        jsCSVLayer.objectIdField = dotNetObject.objectIdField;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsCSVLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.outFields)) {
        jsCSVLayer.outFields = dotNetObject.outFields;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsCSVLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.popupEnabled)) {
        jsCSVLayer.popupEnabled = dotNetObject.popupEnabled;
    }
    if (hasValue(dotNetObject.refreshInterval)) {
        jsCSVLayer.refreshInterval = dotNetObject.refreshInterval;
    }
    if (hasValue(dotNetObject.screenSizePerspectiveEnabled)) {
        jsCSVLayer.screenSizePerspectiveEnabled = dotNetObject.screenSizePerspectiveEnabled;
    }
    if (hasValue(dotNetObject.title)) {
        jsCSVLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.url)) {
        jsCSVLayer.url = dotNetObject.url;
    }
    if (hasValue(dotNetObject.useViewTime)) {
        jsCSVLayer.useViewTime = dotNetObject.useViewTime;
    }
    jsCSVLayer.on('refresh', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsRefresh', evt);
    });
    
    let { default: CSVLayerWrapper } = await import('./cSVLayer');
    let cSVLayerWrapper = new CSVLayerWrapper(jsCSVLayer);
    cSVLayerWrapper.geoBlazorId = dotNetObject.id;
    cSVLayerWrapper.viewId = viewId;
    cSVLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(cSVLayerWrapper);
    jsObjectRefs[dotNetObject.id] = cSVLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCSVLayer;
    
    let { buildDotNetCSVLayer } = await import('./cSVLayer');
    let dnInstantiatedObject = await buildDotNetCSVLayer(jsCSVLayer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for CSVLayer', e);
    }
    
    return jsCSVLayer;
}

export async function buildDotNetCSVLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCSVLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.elevationInfo)) {
            let { buildDotNetCSVLayerElevationInfo } = await import('./cSVLayerElevationInfo');
            dotNetCSVLayer.elevationInfo = await buildDotNetCSVLayerElevationInfo(jsObject.elevationInfo);
        }
        if (hasValue(jsObject.featureEffect)) {
            let { buildDotNetFeatureEffect } = await import('./featureEffect');
            dotNetCSVLayer.featureEffect = await buildDotNetFeatureEffect(jsObject.featureEffect);
        }
        if (hasValue(jsObject.fields)) {
            let { buildDotNetField } = await import('./field');
            dotNetCSVLayer.fields = await Promise.all(jsObject.fields.map(async i => await buildDotNetField(i)));
        }
        if (hasValue(jsObject.fullExtent)) {
            let { buildDotNetExtent } = await import('./extent');
            dotNetCSVLayer.fullExtent = buildDotNetExtent(jsObject.fullExtent);
        }
        if (hasValue(jsObject.labelingInfo)) {
            let { buildDotNetLabel } = await import('./label');
            dotNetCSVLayer.labelingInfo = await Promise.all(jsObject.labelingInfo.map(async i => await buildDotNetLabel(i)));
        }
        if (hasValue(jsObject.orderBy)) {
            let { buildDotNetOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
            dotNetCSVLayer.orderBy = await Promise.all(jsObject.orderBy.map(async i => await buildDotNetOrderedLayerOrderBy(i)));
        }
        if (hasValue(jsObject.popupTemplate)) {
            let { buildDotNetPopupTemplate } = await import('./popupTemplate');
            dotNetCSVLayer.popupTemplate = await buildDotNetPopupTemplate(jsObject.popupTemplate);
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetCSVLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.renderer)) {
            let { buildDotNetRenderer } = await import('./renderer');
            dotNetCSVLayer.renderer = await buildDotNetRenderer(jsObject.renderer);
        }
        if (hasValue(jsObject.spatialReference)) {
            let { buildDotNetSpatialReference } = await import('./spatialReference');
            dotNetCSVLayer.spatialReference = buildDotNetSpatialReference(jsObject.spatialReference);
        }
        if (hasValue(jsObject.timeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetCSVLayer.timeExtent = buildDotNetTimeExtent(jsObject.timeExtent);
        }
        if (hasValue(jsObject.timeInfo)) {
            let { buildDotNetTimeInfo } = await import('./timeInfo');
            dotNetCSVLayer.timeInfo = await buildDotNetTimeInfo(jsObject.timeInfo);
        }
        if (hasValue(jsObject.timeOffset)) {
            let { buildDotNetTimeInterval } = await import('./timeInterval');
            dotNetCSVLayer.timeOffset = await buildDotNetTimeInterval(jsObject.timeOffset);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetCSVLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.id)) {
            dotNetCSVLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetCSVLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.capabilities)) {
            dotNetCSVLayer.capabilities = jsObject.capabilities;
        }
        if (hasValue(jsObject.copyright)) {
            dotNetCSVLayer.copyright = jsObject.copyright;
        }
        if (hasValue(jsObject.customParameters)) {
            dotNetCSVLayer.customParameters = jsObject.customParameters;
        }
        if (hasValue(jsObject.dateFieldsTimeZone)) {
            dotNetCSVLayer.dateFieldsTimeZone = jsObject.dateFieldsTimeZone;
        }
        if (hasValue(jsObject.definitionExpression)) {
            dotNetCSVLayer.definitionExpression = jsObject.definitionExpression;
        }
        if (hasValue(jsObject.delimiter)) {
            dotNetCSVLayer.delimiter = jsObject.delimiter;
        }
        if (hasValue(jsObject.displayField)) {
            dotNetCSVLayer.displayField = jsObject.displayField;
        }
        if (hasValue(jsObject.effect)) {
            dotNetCSVLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.featureReduction)) {
            dotNetCSVLayer.featureReduction = jsObject.featureReduction;
        }
        if (hasValue(jsObject.fieldsIndex)) {
            dotNetCSVLayer.fieldsIndex = jsObject.fieldsIndex;
        }
        if (hasValue(jsObject.geometryType)) {
            dotNetCSVLayer.geometryType = jsObject.geometryType;
        }
        if (hasValue(jsObject.isTable)) {
            dotNetCSVLayer.isTable = jsObject.isTable;
        }
        if (hasValue(jsObject.labelsVisible)) {
            dotNetCSVLayer.labelsVisible = jsObject.labelsVisible;
        }
        if (hasValue(jsObject.latitudeField)) {
            dotNetCSVLayer.latitudeField = jsObject.latitudeField;
        }
        if (hasValue(jsObject.legendEnabled)) {
            dotNetCSVLayer.legendEnabled = jsObject.legendEnabled;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetCSVLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetCSVLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.longitudeField)) {
            dotNetCSVLayer.longitudeField = jsObject.longitudeField;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetCSVLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetCSVLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.objectIdField)) {
            dotNetCSVLayer.objectIdField = jsObject.objectIdField;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetCSVLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.outFields)) {
            dotNetCSVLayer.outFields = jsObject.outFields;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetCSVLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.popupEnabled)) {
            dotNetCSVLayer.popupEnabled = jsObject.popupEnabled;
        }
        if (hasValue(jsObject.refreshInterval)) {
            dotNetCSVLayer.refreshInterval = jsObject.refreshInterval;
        }
        if (hasValue(jsObject.screenSizePerspectiveEnabled)) {
            dotNetCSVLayer.screenSizePerspectiveEnabled = jsObject.screenSizePerspectiveEnabled;
        }
        if (hasValue(jsObject.title)) {
            dotNetCSVLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetCSVLayer.type = jsObject.type;
        }
        if (hasValue(jsObject.url)) {
            dotNetCSVLayer.url = jsObject.url;
        }
        if (hasValue(jsObject.useViewTime)) {
            dotNetCSVLayer.useViewTime = jsObject.useViewTime;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetCSVLayer.id = k;
                break;
            }
        }
    }

    return dotNetCSVLayer;
}

