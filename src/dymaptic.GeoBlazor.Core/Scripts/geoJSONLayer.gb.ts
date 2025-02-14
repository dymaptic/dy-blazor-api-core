// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GeoJSONLayer from '@arcgis/core/layers/GeoJSONLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GeoJSONLayerGenerated implements IPropertyWrapper {
    public layer: GeoJSONLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: GeoJSONLayer) {
        this.layer = layer;
    }
    
    // region methods
   
    unwrap() {
        return this.layer;
    }
    
    async load(options: AbortSignal): Promise<void> {
        await this.layer.load(options);
    }

    async applyEdits(edits: any): Promise<any> {
        return await this.layer.applyEdits(edits);
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
        let { buildDotNetGeoJSONLayerElevationInfo } = await import('./geoJSONLayerElevationInfo');
        return await buildDotNetGeoJSONLayerElevationInfo(this.layer.elevationInfo);
    }
    async setElevationInfo(value: any): Promise<void> {
        let { buildJsGeoJSONLayerElevationInfo } = await import('./geoJSONLayerElevationInfo');
        this.layer.elevationInfo = await  buildJsGeoJSONLayerElevationInfo(value, this.layerId, this.viewId);
    }
    async getFeatureEffect(): Promise<any> {
        let { buildDotNetFeatureEffect } = await import('./featureEffect');
        return await buildDotNetFeatureEffect(this.layer.featureEffect);
    }
    async setFeatureEffect(value: any): Promise<void> {
        let { buildJsFeatureEffect } = await import('./featureEffect');
        this.layer.featureEffect = await  buildJsFeatureEffect(value);
    }
    async getFields(): Promise<any> {
        let { buildDotNetField } = await import('./field');
        return await Promise.all(this.layer.fields.map(async i => await buildDotNetField(i)));
    }
    
    async setFields(value: any): Promise<void> {
        let { buildJsField } = await import('./field');
        this.layer.fields = value.map(i => buildJsField(i));
    }
    
    async getLabelingInfo(): Promise<any> {
        let { buildDotNetLabel } = await import('./label');
        return await Promise.all(this.layer.labelingInfo.map(async i => await buildDotNetLabel(i)));
    }
    
    async setLabelingInfo(value: any): Promise<void> {
        let { buildJsLabel } = await import('./label');
        this.layer.labelingInfo = value.map(async i => await buildJsLabel(i, this.layerId, this.viewId));
    }
    
    async getOrderBy(): Promise<any> {
        let { buildDotNetOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
        return await Promise.all(this.layer.orderBy.map(async i => await buildDotNetOrderedLayerOrderBy(i)));
    }
    
    async setOrderBy(value: any): Promise<void> {
        let { buildJsOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
        this.layer.orderBy = value.map(async i => await buildJsOrderedLayerOrderBy(i, this.layerId, this.viewId));
    }
    
    async getPopupTemplate(): Promise<any> {
        let { buildDotNetPopupTemplate } = await import('./popupTemplate');
        return await buildDotNetPopupTemplate(this.layer.popupTemplate);
    }
    async setPopupTemplate(value: any): Promise<void> {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        this.layer.popupTemplate = await  buildJsPopupTemplate(value, this.layerId, this.viewId);
    }
    async getPortalItem(): Promise<any> {
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.layer.portalItem);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.layer.portalItem = await  buildJsPortalItem(value, this.layerId, this.viewId);
    }
    async getRenderer(): Promise<any> {
        let { buildDotNetRenderer } = await import('./renderer');
        return await buildDotNetRenderer(this.layer.renderer);
    }
    async setRenderer(value: any): Promise<void> {
        let { buildJsRenderer } = await import('./renderer');
        this.layer.renderer =  buildJsRenderer(value);
    }
    async getTemplates(): Promise<any> {
        let { buildDotNetFeatureTemplate } = await import('./featureTemplate');
        return await Promise.all(this.layer.templates.map(async i => await buildDotNetFeatureTemplate(i)));
    }
    
    async setTemplates(value: any): Promise<void> {
        let { buildJsFeatureTemplate } = await import('./featureTemplate');
        this.layer.templates = value.map(async i => await buildJsFeatureTemplate(i, this.layerId, this.viewId));
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

export async function buildJsGeoJSONLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGeoJSONLayer = new GeoJSONLayer();
    if (hasValue(dotNetObject.elevationInfo)) {
        let { buildJsGeoJSONLayerElevationInfo } = await import('./geoJSONLayerElevationInfo');
        jsGeoJSONLayer.elevationInfo = await buildJsGeoJSONLayerElevationInfo(dotNetObject.elevationInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.featureEffect)) {
        let { buildJsFeatureEffect } = await import('./jsBuilder');
        jsGeoJSONLayer.featureEffect = await buildJsFeatureEffect(dotNetObject.featureEffect) as any;
    }
    if (hasValue(dotNetObject.fields)) {
        let { buildJsField } = await import('./jsBuilder');
        jsGeoJSONLayer.fields = await Promise.all(dotNetObject.fields.map(async i => await buildJsField(i))) as any;
    }
    if (hasValue(dotNetObject.labelingInfo)) {
        let { buildJsLabel } = await import('./label');
        jsGeoJSONLayer.labelingInfo = await Promise.all(dotNetObject.labelingInfo.map(async i => await buildJsLabel(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.orderBy)) {
        let { buildJsOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
        jsGeoJSONLayer.orderBy = await Promise.all(dotNetObject.orderBy.map(async i => await buildJsOrderedLayerOrderBy(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.popupTemplate)) {
        let { buildJsPopupTemplate } = await import('./jsBuilder');
        jsGeoJSONLayer.popupTemplate = await buildJsPopupTemplate(dotNetObject.popupTemplate, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsGeoJSONLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.renderer)) {
        let { buildJsRenderer } = await import('./jsBuilder');
        jsGeoJSONLayer.renderer = buildJsRenderer(dotNetObject.renderer) as any;
    }
    if (hasValue(dotNetObject.templates)) {
        let { buildJsFeatureTemplate } = await import('./featureTemplate');
        jsGeoJSONLayer.templates = await Promise.all(dotNetObject.templates.map(async i => await buildJsFeatureTemplate(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.timeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsGeoJSONLayer.timeExtent = await buildJsTimeExtent(dotNetObject.timeExtent, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeInfo)) {
        let { buildJsTimeInfo } = await import('./timeInfo');
        jsGeoJSONLayer.timeInfo = await buildJsTimeInfo(dotNetObject.timeInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeOffset)) {
        let { buildJsTimeInterval } = await import('./timeInterval');
        jsGeoJSONLayer.timeOffset = await buildJsTimeInterval(dotNetObject.timeOffset, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsGeoJSONLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsGeoJSONLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsGeoJSONLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.copyright)) {
        jsGeoJSONLayer.copyright = dotNetObject.copyright;
    }
    if (hasValue(dotNetObject.customParameters)) {
        jsGeoJSONLayer.customParameters = dotNetObject.customParameters;
    }
    if (hasValue(dotNetObject.definitionExpression)) {
        jsGeoJSONLayer.definitionExpression = dotNetObject.definitionExpression;
    }
    if (hasValue(dotNetObject.displayField)) {
        jsGeoJSONLayer.displayField = dotNetObject.displayField;
    }
    if (hasValue(dotNetObject.editingEnabled)) {
        jsGeoJSONLayer.editingEnabled = dotNetObject.editingEnabled;
    }
    if (hasValue(dotNetObject.effect)) {
        jsGeoJSONLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.featureReduction)) {
        jsGeoJSONLayer.featureReduction = dotNetObject.featureReduction;
    }
    if (hasValue(dotNetObject.fullExtent)) {
        jsGeoJSONLayer.fullExtent = dotNetObject.fullExtent;
    }
    if (hasValue(dotNetObject.geometryType)) {
        jsGeoJSONLayer.geometryType = dotNetObject.geometryType;
    }
    if (hasValue(dotNetObject.labelsVisible)) {
        jsGeoJSONLayer.labelsVisible = dotNetObject.labelsVisible;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsGeoJSONLayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsGeoJSONLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsGeoJSONLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsGeoJSONLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.objectIdField)) {
        jsGeoJSONLayer.objectIdField = dotNetObject.objectIdField;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsGeoJSONLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.outFields)) {
        jsGeoJSONLayer.outFields = dotNetObject.outFields;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsGeoJSONLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.popupEnabled)) {
        jsGeoJSONLayer.popupEnabled = dotNetObject.popupEnabled;
    }
    if (hasValue(dotNetObject.refreshInterval)) {
        jsGeoJSONLayer.refreshInterval = dotNetObject.refreshInterval;
    }
    if (hasValue(dotNetObject.screenSizePerspectiveEnabled)) {
        jsGeoJSONLayer.screenSizePerspectiveEnabled = dotNetObject.screenSizePerspectiveEnabled;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        jsGeoJSONLayer.spatialReference = dotNetObject.spatialReference;
    }
    if (hasValue(dotNetObject.title)) {
        jsGeoJSONLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.url)) {
        jsGeoJSONLayer.url = dotNetObject.url;
    }
    if (hasValue(dotNetObject.useViewTime)) {
        jsGeoJSONLayer.useViewTime = dotNetObject.useViewTime;
    }
    jsGeoJSONLayer.on('edits', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsEdits', evt);
    });
    
    jsGeoJSONLayer.on('refresh', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsRefresh', evt);
    });
    
    let { default: GeoJSONLayerWrapper } = await import('./geoJSONLayer');
    let geoJSONLayerWrapper = new GeoJSONLayerWrapper(jsGeoJSONLayer);
    geoJSONLayerWrapper.geoBlazorId = dotNetObject.id;
    geoJSONLayerWrapper.viewId = viewId;
    geoJSONLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(geoJSONLayerWrapper);
    jsObjectRefs[dotNetObject.id] = geoJSONLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsGeoJSONLayer;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for GeoJSONLayer', e);
    }
    
    return jsGeoJSONLayer;
}

export async function buildDotNetGeoJSONLayerGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGeoJSONLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.elevationInfo)) {
            let { buildDotNetGeoJSONLayerElevationInfo } = await import('./geoJSONLayerElevationInfo');
            dotNetGeoJSONLayer.elevationInfo = await buildDotNetGeoJSONLayerElevationInfo(jsObject.elevationInfo);
        }
        if (hasValue(jsObject.featureEffect)) {
            let { buildDotNetFeatureEffect } = await import('./featureEffect');
            dotNetGeoJSONLayer.featureEffect = await buildDotNetFeatureEffect(jsObject.featureEffect);
        }
        if (hasValue(jsObject.fields)) {
            let { buildDotNetField } = await import('./field');
            dotNetGeoJSONLayer.fields = await Promise.all(jsObject.fields.map(async i => await buildDotNetField(i)));
        }
        if (hasValue(jsObject.labelingInfo)) {
            let { buildDotNetLabel } = await import('./label');
            dotNetGeoJSONLayer.labelingInfo = await Promise.all(jsObject.labelingInfo.map(async i => await buildDotNetLabel(i)));
        }
        if (hasValue(jsObject.orderBy)) {
            let { buildDotNetOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
            dotNetGeoJSONLayer.orderBy = await Promise.all(jsObject.orderBy.map(async i => await buildDotNetOrderedLayerOrderBy(i)));
        }
        if (hasValue(jsObject.popupTemplate)) {
            let { buildDotNetPopupTemplate } = await import('./popupTemplate');
            dotNetGeoJSONLayer.popupTemplate = await buildDotNetPopupTemplate(jsObject.popupTemplate);
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetGeoJSONLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.renderer)) {
            let { buildDotNetRenderer } = await import('./renderer');
            dotNetGeoJSONLayer.renderer = await buildDotNetRenderer(jsObject.renderer);
        }
        if (hasValue(jsObject.templates)) {
            let { buildDotNetFeatureTemplate } = await import('./featureTemplate');
            dotNetGeoJSONLayer.templates = await Promise.all(jsObject.templates.map(async i => await buildDotNetFeatureTemplate(i, layerId, viewId)));
        }
        if (hasValue(jsObject.timeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetGeoJSONLayer.timeExtent = buildDotNetTimeExtent(jsObject.timeExtent);
        }
        if (hasValue(jsObject.timeInfo)) {
            let { buildDotNetTimeInfo } = await import('./timeInfo');
            dotNetGeoJSONLayer.timeInfo = await buildDotNetTimeInfo(jsObject.timeInfo);
        }
        if (hasValue(jsObject.timeOffset)) {
            let { buildDotNetTimeInterval } = await import('./timeInterval');
            dotNetGeoJSONLayer.timeOffset = await buildDotNetTimeInterval(jsObject.timeOffset);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetGeoJSONLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.id)) {
            dotNetGeoJSONLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetGeoJSONLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.capabilities)) {
            dotNetGeoJSONLayer.capabilities = jsObject.capabilities;
        }
        if (hasValue(jsObject.copyright)) {
            dotNetGeoJSONLayer.copyright = jsObject.copyright;
        }
        if (hasValue(jsObject.customParameters)) {
            dotNetGeoJSONLayer.customParameters = jsObject.customParameters;
        }
        if (hasValue(jsObject.dateFieldsTimeZone)) {
            dotNetGeoJSONLayer.dateFieldsTimeZone = jsObject.dateFieldsTimeZone;
        }
        if (hasValue(jsObject.definitionExpression)) {
            dotNetGeoJSONLayer.definitionExpression = jsObject.definitionExpression;
        }
        if (hasValue(jsObject.displayField)) {
            dotNetGeoJSONLayer.displayField = jsObject.displayField;
        }
        if (hasValue(jsObject.editingEnabled)) {
            dotNetGeoJSONLayer.editingEnabled = jsObject.editingEnabled;
        }
        if (hasValue(jsObject.effect)) {
            dotNetGeoJSONLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.featureReduction)) {
            dotNetGeoJSONLayer.featureReduction = jsObject.featureReduction;
        }
        if (hasValue(jsObject.fieldsIndex)) {
            dotNetGeoJSONLayer.fieldsIndex = jsObject.fieldsIndex;
        }
        if (hasValue(jsObject.fullExtent)) {
            dotNetGeoJSONLayer.fullExtent = jsObject.fullExtent;
        }
        if (hasValue(jsObject.geometryType)) {
            dotNetGeoJSONLayer.geometryType = jsObject.geometryType;
        }
        if (hasValue(jsObject.hasZ)) {
            dotNetGeoJSONLayer.hasZ = jsObject.hasZ;
        }
        if (hasValue(jsObject.isTable)) {
            dotNetGeoJSONLayer.isTable = jsObject.isTable;
        }
        if (hasValue(jsObject.labelsVisible)) {
            dotNetGeoJSONLayer.labelsVisible = jsObject.labelsVisible;
        }
        if (hasValue(jsObject.legendEnabled)) {
            dotNetGeoJSONLayer.legendEnabled = jsObject.legendEnabled;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetGeoJSONLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetGeoJSONLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetGeoJSONLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetGeoJSONLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.objectIdField)) {
            dotNetGeoJSONLayer.objectIdField = jsObject.objectIdField;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetGeoJSONLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.outFields)) {
            dotNetGeoJSONLayer.outFields = jsObject.outFields;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetGeoJSONLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.popupEnabled)) {
            dotNetGeoJSONLayer.popupEnabled = jsObject.popupEnabled;
        }
        if (hasValue(jsObject.refreshInterval)) {
            dotNetGeoJSONLayer.refreshInterval = jsObject.refreshInterval;
        }
        if (hasValue(jsObject.screenSizePerspectiveEnabled)) {
            dotNetGeoJSONLayer.screenSizePerspectiveEnabled = jsObject.screenSizePerspectiveEnabled;
        }
        if (hasValue(jsObject.spatialReference)) {
            dotNetGeoJSONLayer.spatialReference = jsObject.spatialReference;
        }
        if (hasValue(jsObject.title)) {
            dotNetGeoJSONLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetGeoJSONLayer.type = jsObject.type;
        }
        if (hasValue(jsObject.url)) {
            dotNetGeoJSONLayer.url = jsObject.url;
        }
        if (hasValue(jsObject.useViewTime)) {
            dotNetGeoJSONLayer.useViewTime = jsObject.useViewTime;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetGeoJSONLayer.id = k;
                break;
            }
        }
    }

    return dotNetGeoJSONLayer;
}

