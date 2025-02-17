// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FeatureLayer from '@arcgis/core/layers/FeatureLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FeatureLayerGenerated implements IPropertyWrapper {
    public layer: FeatureLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: FeatureLayer) {
        this.layer = layer;
    }
    
    // region methods
   
    unwrap() {
        return this.layer;
    }
    
    async load(options: AbortSignal): Promise<void> {
        await this.layer.load(options);
    }

    async addAttachment(feature: any,
        attachment: any): Promise<any> {
        let { buildJsGraphic } = await import('./graphic');
        let jsFeature = await buildJsGraphic(feature, this.layerId, this.viewId) as any;
        return await this.layer.addAttachment(jsFeature,
            attachment);
    }

    async applyEdits(edits: any,
        options: any): Promise<any> {
        return await this.layer.applyEdits(edits,
            options);
    }

    async createLayerView(view: any,
        options: any): Promise<any> {
        let result = await this.layer.createLayerView(view,
            options);
        let { buildDotNetLayerView } = await import('./layerView');
        return await buildDotNetLayerView(result);
    }

    async deleteAttachments(feature: any,
        attachmentIds: any): Promise<any> {
        let { buildJsGraphic } = await import('./graphic');
        let jsFeature = await buildJsGraphic(feature, this.layerId, this.viewId) as any;
        return await this.layer.deleteAttachments(jsFeature,
            attachmentIds);
    }

    async fetchAttributionData(): Promise<any> {
        return await this.layer.fetchAttributionData();
    }

    async queryAttachments(attachmentQuery: any,
        options: any): Promise<any> {
        return await this.layer.queryAttachments(attachmentQuery,
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

    async updateAttachment(feature: any,
        attachmentId: any,
        attachment: any): Promise<any> {
        let { buildJsGraphic } = await import('./graphic');
        let jsFeature = await buildJsGraphic(feature, this.layerId, this.viewId) as any;
        return await this.layer.updateAttachment(jsFeature,
            attachmentId,
            attachment);
    }

    // region properties
    
    async getEffectiveCapabilities(): Promise<any> {
        if (!hasValue(this.layer.effectiveCapabilities)) {
            return null;
        }
        
        let { buildDotNetCapabilities } = await import('./capabilities');
        return await buildDotNetCapabilities(this.layer.effectiveCapabilities);
    }
    async getElevationInfo(): Promise<any> {
        if (!hasValue(this.layer.elevationInfo)) {
            return null;
        }
        
        let { buildDotNetFeatureLayerBaseElevationInfo } = await import('./featureLayerBaseElevationInfo');
        return await buildDotNetFeatureLayerBaseElevationInfo(this.layer.elevationInfo);
    }
    async setElevationInfo(value: any): Promise<void> {
        let { buildJsFeatureLayerBaseElevationInfo } = await import('./featureLayerBaseElevationInfo');
        this.layer.elevationInfo = await  buildJsFeatureLayerBaseElevationInfo(value, this.layerId, this.viewId);
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
        this.layer.featureEffect = await  buildJsFeatureEffect(value, this.layerId, this.viewId);
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
    
    async getFloorInfo(): Promise<any> {
        if (!hasValue(this.layer.floorInfo)) {
            return null;
        }
        
        let { buildDotNetLayerFloorInfo } = await import('./layerFloorInfo');
        return await buildDotNetLayerFloorInfo(this.layer.floorInfo);
    }
    async setFloorInfo(value: any): Promise<void> {
        let { buildJsLayerFloorInfo } = await import('./layerFloorInfo');
        this.layer.floorInfo = await  buildJsLayerFloorInfo(value, this.layerId, this.viewId);
    }
    async getFormTemplate(): Promise<any> {
        if (!hasValue(this.layer.formTemplate)) {
            return null;
        }
        
        let { buildDotNetFormTemplate } = await import('./formTemplate');
        return await buildDotNetFormTemplate(this.layer.formTemplate);
    }
    async setFormTemplate(value: any): Promise<void> {
        let { buildJsFormTemplate } = await import('./formTemplate');
        this.layer.formTemplate = await  buildJsFormTemplate(value, this.layerId, this.viewId);
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
    async getSource(): Promise<any> {
        if (!hasValue(this.layer.source)) {
            return null;
        }
        
        let { buildDotNetGraphic } = await import('./graphic');
        return await Promise.all(this.layer.source.map(async i => await buildDotNetGraphic(i, this.layerId, this.viewId)));
    }
    
    async setSource(value: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        this.layer.source = value.map(i => buildJsGraphic(i, this.layerId, this.viewId)) as any;
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
    async getTemplates(): Promise<any> {
        if (!hasValue(this.layer.templates)) {
            return null;
        }
        
        let { buildDotNetFeatureTemplate } = await import('./featureTemplate');
        return await Promise.all(this.layer.templates.map(async i => await buildDotNetFeatureTemplate(i)));
    }
    
    async setTemplates(value: any): Promise<void> {
        let { buildJsFeatureTemplate } = await import('./featureTemplate');
        this.layer.templates = await Promise.all(value.map(async i => await buildJsFeatureTemplate(i, this.layerId, this.viewId))) as any;
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

export async function buildJsFeatureLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFeatureLayer = new FeatureLayer();
    if (hasValue(dotNetObject.elevationInfo)) {
        let { buildJsFeatureLayerBaseElevationInfo } = await import('./featureLayerBaseElevationInfo');
        jsFeatureLayer.elevationInfo = await buildJsFeatureLayerBaseElevationInfo(dotNetObject.elevationInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.featureEffect)) {
        let { buildJsFeatureEffect } = await import('./jsBuilder');
        jsFeatureLayer.featureEffect = buildJsFeatureEffect(dotNetObject.featureEffect) as any;
    }
    if (hasValue(dotNetObject.fields)) {
        let { buildJsField } = await import('./field');
        jsFeatureLayer.fields = await Promise.all(dotNetObject.fields.map(async i => await buildJsField(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.floorInfo)) {
        let { buildJsLayerFloorInfo } = await import('./layerFloorInfo');
        jsFeatureLayer.floorInfo = await buildJsLayerFloorInfo(dotNetObject.floorInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.formTemplate)) {
        let { buildJsFormTemplate } = await import('./jsBuilder');
        jsFeatureLayer.formTemplate = await buildJsFormTemplate(dotNetObject.formTemplate) as any;
    }
    if (hasValue(dotNetObject.fullExtent)) {
        let { buildJsExtent } = await import('./extent');
        jsFeatureLayer.fullExtent = buildJsExtent(dotNetObject.fullExtent) as any;
    }
    if (hasValue(dotNetObject.labelingInfo)) {
        let { buildJsLabel } = await import('./label');
        jsFeatureLayer.labelingInfo = await Promise.all(dotNetObject.labelingInfo.map(async i => await buildJsLabel(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.orderBy)) {
        let { buildJsOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
        jsFeatureLayer.orderBy = await Promise.all(dotNetObject.orderBy.map(async i => await buildJsOrderedLayerOrderBy(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.popupTemplate)) {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        jsFeatureLayer.popupTemplate = await buildJsPopupTemplate(dotNetObject.popupTemplate, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsFeatureLayer.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.renderer)) {
        let { buildJsRenderer } = await import('./renderer');
        jsFeatureLayer.renderer = await buildJsRenderer(dotNetObject.renderer, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.source)) {
        let { buildJsGraphic } = await import('./graphic');
        jsFeatureLayer.source = dotNetObject.source.map(i => buildJsGraphic(i, layerId, viewId)) as any;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        let { buildJsSpatialReference } = await import('./spatialReference');
        jsFeatureLayer.spatialReference = buildJsSpatialReference(dotNetObject.spatialReference) as any;
    }
    if (hasValue(dotNetObject.templates)) {
        let { buildJsFeatureTemplate } = await import('./featureTemplate');
        jsFeatureLayer.templates = await Promise.all(dotNetObject.templates.map(async i => await buildJsFeatureTemplate(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.timeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsFeatureLayer.timeExtent = await buildJsTimeExtent(dotNetObject.timeExtent, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeInfo)) {
        let { buildJsTimeInfo } = await import('./timeInfo');
        jsFeatureLayer.timeInfo = await buildJsTimeInfo(dotNetObject.timeInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.timeOffset)) {
        let { buildJsTimeInterval } = await import('./timeInterval');
        jsFeatureLayer.timeOffset = await buildJsTimeInterval(dotNetObject.timeOffset, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsFeatureLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.apiKey)) {
        jsFeatureLayer.apiKey = dotNetObject.apiKey;
    }
    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsFeatureLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsFeatureLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.charts)) {
        jsFeatureLayer.charts = dotNetObject.charts;
    }
    if (hasValue(dotNetObject.copyright)) {
        jsFeatureLayer.copyright = dotNetObject.copyright;
    }
    if (hasValue(dotNetObject.customParameters)) {
        jsFeatureLayer.customParameters = dotNetObject.customParameters;
    }
    if (hasValue(dotNetObject.dateFieldsTimeZone)) {
        jsFeatureLayer.dateFieldsTimeZone = dotNetObject.dateFieldsTimeZone;
    }
    if (hasValue(dotNetObject.definitionExpression)) {
        jsFeatureLayer.definitionExpression = dotNetObject.definitionExpression;
    }
    if (hasValue(dotNetObject.displayField)) {
        jsFeatureLayer.displayField = dotNetObject.displayField;
    }
    if (hasValue(dotNetObject.dynamicDataSource)) {
        jsFeatureLayer.dynamicDataSource = dotNetObject.dynamicDataSource;
    }
    if (hasValue(dotNetObject.editingEnabled)) {
        jsFeatureLayer.editingEnabled = dotNetObject.editingEnabled;
    }
    if (hasValue(dotNetObject.effect)) {
        jsFeatureLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.featureReduction)) {
        jsFeatureLayer.featureReduction = dotNetObject.featureReduction;
    }
    if (hasValue(dotNetObject.gdbVersion)) {
        jsFeatureLayer.gdbVersion = dotNetObject.gdbVersion;
    }
    if (hasValue(dotNetObject.hasM)) {
        jsFeatureLayer.hasM = dotNetObject.hasM;
    }
    if (hasValue(dotNetObject.hasZ)) {
        jsFeatureLayer.hasZ = dotNetObject.hasZ;
    }
    if (hasValue(dotNetObject.historicMoment)) {
        jsFeatureLayer.historicMoment = dotNetObject.historicMoment;
    }
    if (hasValue(dotNetObject.labelsVisible)) {
        jsFeatureLayer.labelsVisible = dotNetObject.labelsVisible;
    }
    if (hasValue(dotNetObject.layerIndex)) {
        jsFeatureLayer.layerId = dotNetObject.layerIndex;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsFeatureLayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsFeatureLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsFeatureLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsFeatureLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.objectIdField)) {
        jsFeatureLayer.objectIdField = dotNetObject.objectIdField;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsFeatureLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.outFields)) {
        jsFeatureLayer.outFields = dotNetObject.outFields;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsFeatureLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.popupEnabled)) {
        jsFeatureLayer.popupEnabled = dotNetObject.popupEnabled;
    }
    if (hasValue(dotNetObject.refreshInterval)) {
        jsFeatureLayer.refreshInterval = dotNetObject.refreshInterval;
    }
    if (hasValue(dotNetObject.returnM)) {
        jsFeatureLayer.returnM = dotNetObject.returnM;
    }
    if (hasValue(dotNetObject.returnZ)) {
        jsFeatureLayer.returnZ = dotNetObject.returnZ;
    }
    if (hasValue(dotNetObject.screenSizePerspectiveEnabled)) {
        jsFeatureLayer.screenSizePerspectiveEnabled = dotNetObject.screenSizePerspectiveEnabled;
    }
    if (hasValue(dotNetObject.sourceJSON)) {
        jsFeatureLayer.sourceJSON = dotNetObject.sourceJSON;
    }
    if (hasValue(dotNetObject.title)) {
        jsFeatureLayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.typeIdField)) {
        jsFeatureLayer.typeIdField = dotNetObject.typeIdField;
    }
    if (hasValue(dotNetObject.types)) {
        jsFeatureLayer.types = dotNetObject.types;
    }
    if (hasValue(dotNetObject.url)) {
        jsFeatureLayer.url = dotNetObject.url;
    }
    if (hasValue(dotNetObject.useViewTime)) {
        jsFeatureLayer.useViewTime = dotNetObject.useViewTime;
    }
    jsFeatureLayer.on('edits', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsEdits', evt);
    });
    
    jsFeatureLayer.on('refresh', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsRefresh', evt);
    });
    
    let { default: FeatureLayerWrapper } = await import('./featureLayer');
    let featureLayerWrapper = new FeatureLayerWrapper(jsFeatureLayer);
    featureLayerWrapper.geoBlazorId = dotNetObject.id;
    featureLayerWrapper.viewId = viewId;
    featureLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(featureLayerWrapper);
    jsObjectRefs[dotNetObject.id] = featureLayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsFeatureLayer;
    
    let { buildDotNetFeatureLayer } = await import('./featureLayer');
    let dnInstantiatedObject = await buildDotNetFeatureLayer(jsFeatureLayer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FeatureLayer', e);
    }
    
    return jsFeatureLayer;
}

export async function buildDotNetFeatureLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFeatureLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.effectiveCapabilities)) {
            let { buildDotNetCapabilities } = await import('./capabilities');
            dotNetFeatureLayer.effectiveCapabilities = await buildDotNetCapabilities(jsObject.effectiveCapabilities);
        }
        if (hasValue(jsObject.elevationInfo)) {
            let { buildDotNetFeatureLayerBaseElevationInfo } = await import('./featureLayerBaseElevationInfo');
            dotNetFeatureLayer.elevationInfo = await buildDotNetFeatureLayerBaseElevationInfo(jsObject.elevationInfo);
        }
        if (hasValue(jsObject.featureEffect)) {
            let { buildDotNetFeatureEffect } = await import('./featureEffect');
            dotNetFeatureLayer.featureEffect = await buildDotNetFeatureEffect(jsObject.featureEffect);
        }
        if (hasValue(jsObject.fields)) {
            let { buildDotNetField } = await import('./field');
            dotNetFeatureLayer.fields = await Promise.all(jsObject.fields.map(async i => await buildDotNetField(i)));
        }
        if (hasValue(jsObject.floorInfo)) {
            let { buildDotNetLayerFloorInfo } = await import('./layerFloorInfo');
            dotNetFeatureLayer.floorInfo = await buildDotNetLayerFloorInfo(jsObject.floorInfo);
        }
        if (hasValue(jsObject.formTemplate)) {
            let { buildDotNetFormTemplate } = await import('./formTemplate');
            dotNetFeatureLayer.formTemplate = await buildDotNetFormTemplate(jsObject.formTemplate);
        }
        if (hasValue(jsObject.fullExtent)) {
            let { buildDotNetExtent } = await import('./extent');
            dotNetFeatureLayer.fullExtent = buildDotNetExtent(jsObject.fullExtent);
        }
        if (hasValue(jsObject.labelingInfo)) {
            let { buildDotNetLabel } = await import('./label');
            dotNetFeatureLayer.labelingInfo = await Promise.all(jsObject.labelingInfo.map(async i => await buildDotNetLabel(i)));
        }
        if (hasValue(jsObject.orderBy)) {
            let { buildDotNetOrderedLayerOrderBy } = await import('./orderedLayerOrderBy');
            dotNetFeatureLayer.orderBy = await Promise.all(jsObject.orderBy.map(async i => await buildDotNetOrderedLayerOrderBy(i)));
        }
        if (hasValue(jsObject.popupTemplate)) {
            let { buildDotNetPopupTemplate } = await import('./popupTemplate');
            dotNetFeatureLayer.popupTemplate = await buildDotNetPopupTemplate(jsObject.popupTemplate);
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetFeatureLayer.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.renderer)) {
            let { buildDotNetRenderer } = await import('./renderer');
            dotNetFeatureLayer.renderer = await buildDotNetRenderer(jsObject.renderer);
        }
        if (hasValue(jsObject.spatialReference)) {
            let { buildDotNetSpatialReference } = await import('./spatialReference');
            dotNetFeatureLayer.spatialReference = buildDotNetSpatialReference(jsObject.spatialReference);
        }
        if (hasValue(jsObject.templates)) {
            let { buildDotNetFeatureTemplate } = await import('./featureTemplate');
            dotNetFeatureLayer.templates = await Promise.all(jsObject.templates.map(async i => await buildDotNetFeatureTemplate(i)));
        }
        if (hasValue(jsObject.timeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetFeatureLayer.timeExtent = buildDotNetTimeExtent(jsObject.timeExtent);
        }
        if (hasValue(jsObject.timeInfo)) {
            let { buildDotNetTimeInfo } = await import('./timeInfo');
            dotNetFeatureLayer.timeInfo = await buildDotNetTimeInfo(jsObject.timeInfo);
        }
        if (hasValue(jsObject.timeOffset)) {
            let { buildDotNetTimeInterval } = await import('./timeInterval');
            dotNetFeatureLayer.timeOffset = await buildDotNetTimeInterval(jsObject.timeOffset);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetFeatureLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.apiKey)) {
            dotNetFeatureLayer.apiKey = jsObject.apiKey;
        }
        if (hasValue(jsObject.id)) {
            dotNetFeatureLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetFeatureLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.capabilities)) {
            dotNetFeatureLayer.capabilities = jsObject.capabilities;
        }
        if (hasValue(jsObject.charts)) {
            dotNetFeatureLayer.charts = jsObject.charts;
        }
        if (hasValue(jsObject.copyright)) {
            dotNetFeatureLayer.copyright = jsObject.copyright;
        }
        if (hasValue(jsObject.customParameters)) {
            dotNetFeatureLayer.customParameters = jsObject.customParameters;
        }
        if (hasValue(jsObject.dateFieldsTimeZone)) {
            dotNetFeatureLayer.dateFieldsTimeZone = jsObject.dateFieldsTimeZone;
        }
        if (hasValue(jsObject.datesInUnknownTimezone)) {
            dotNetFeatureLayer.datesInUnknownTimezone = jsObject.datesInUnknownTimezone;
        }
        if (hasValue(jsObject.definitionExpression)) {
            dotNetFeatureLayer.definitionExpression = jsObject.definitionExpression;
        }
        if (hasValue(jsObject.displayField)) {
            dotNetFeatureLayer.displayField = jsObject.displayField;
        }
        if (hasValue(jsObject.dynamicDataSource)) {
            dotNetFeatureLayer.dynamicDataSource = jsObject.dynamicDataSource;
        }
        if (hasValue(jsObject.editFieldsInfo)) {
            dotNetFeatureLayer.editFieldsInfo = jsObject.editFieldsInfo;
        }
        if (hasValue(jsObject.editingEnabled)) {
            dotNetFeatureLayer.editingEnabled = jsObject.editingEnabled;
        }
        if (hasValue(jsObject.editingInfo)) {
            dotNetFeatureLayer.editingInfo = jsObject.editingInfo;
        }
        if (hasValue(jsObject.effect)) {
            dotNetFeatureLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.effectiveEditingEnabled)) {
            dotNetFeatureLayer.effectiveEditingEnabled = jsObject.effectiveEditingEnabled;
        }
        if (hasValue(jsObject.featureReduction)) {
            dotNetFeatureLayer.featureReduction = jsObject.featureReduction;
        }
        if (hasValue(jsObject.fieldsIndex)) {
            dotNetFeatureLayer.fieldsIndex = jsObject.fieldsIndex;
        }
        if (hasValue(jsObject.gdbVersion)) {
            dotNetFeatureLayer.gdbVersion = jsObject.gdbVersion;
        }
        if (hasValue(jsObject.geometryFieldsInfo)) {
            dotNetFeatureLayer.geometryFieldsInfo = jsObject.geometryFieldsInfo;
        }
        if (hasValue(jsObject.geometryType)) {
            dotNetFeatureLayer.geometryType = jsObject.geometryType;
        }
        if (hasValue(jsObject.hasM)) {
            dotNetFeatureLayer.hasM = jsObject.hasM;
        }
        if (hasValue(jsObject.hasZ)) {
            dotNetFeatureLayer.hasZ = jsObject.hasZ;
        }
        if (hasValue(jsObject.historicMoment)) {
            dotNetFeatureLayer.historicMoment = jsObject.historicMoment;
        }
        if (hasValue(jsObject.isTable)) {
            dotNetFeatureLayer.isTable = jsObject.isTable;
        }
        if (hasValue(jsObject.labelsVisible)) {
            dotNetFeatureLayer.labelsVisible = jsObject.labelsVisible;
        }
        if (hasValue(jsObject.layerId)) {
            dotNetFeatureLayer.layerIndex = jsObject.layerId;
        }
        if (hasValue(jsObject.legendEnabled)) {
            dotNetFeatureLayer.legendEnabled = jsObject.legendEnabled;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetFeatureLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetFeatureLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetFeatureLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetFeatureLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.objectIdField)) {
            dotNetFeatureLayer.objectIdField = jsObject.objectIdField;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetFeatureLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.outFields)) {
            dotNetFeatureLayer.outFields = jsObject.outFields;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetFeatureLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.popupEnabled)) {
            dotNetFeatureLayer.popupEnabled = jsObject.popupEnabled;
        }
        if (hasValue(jsObject.preferredTimeZone)) {
            dotNetFeatureLayer.preferredTimeZone = jsObject.preferredTimeZone;
        }
        if (hasValue(jsObject.publishingInfo)) {
            dotNetFeatureLayer.publishingInfo = jsObject.publishingInfo;
        }
        if (hasValue(jsObject.refreshInterval)) {
            dotNetFeatureLayer.refreshInterval = jsObject.refreshInterval;
        }
        if (hasValue(jsObject.relationships)) {
            dotNetFeatureLayer.relationships = jsObject.relationships;
        }
        if (hasValue(jsObject.returnM)) {
            dotNetFeatureLayer.returnM = jsObject.returnM;
        }
        if (hasValue(jsObject.returnZ)) {
            dotNetFeatureLayer.returnZ = jsObject.returnZ;
        }
        if (hasValue(jsObject.screenSizePerspectiveEnabled)) {
            dotNetFeatureLayer.screenSizePerspectiveEnabled = jsObject.screenSizePerspectiveEnabled;
        }
        if (hasValue(jsObject.serviceDefinitionExpression)) {
            dotNetFeatureLayer.serviceDefinitionExpression = jsObject.serviceDefinitionExpression;
        }
        if (hasValue(jsObject.serviceItemId)) {
            dotNetFeatureLayer.serviceItemId = jsObject.serviceItemId;
        }
        if (hasValue(jsObject.sourceJSON)) {
            dotNetFeatureLayer.sourceJSON = jsObject.sourceJSON;
        }
        if (hasValue(jsObject.subtypeField)) {
            dotNetFeatureLayer.subtypeField = jsObject.subtypeField;
        }
        if (hasValue(jsObject.subtypes)) {
            dotNetFeatureLayer.subtypes = jsObject.subtypes;
        }
        if (hasValue(jsObject.title)) {
            dotNetFeatureLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetFeatureLayer.type = jsObject.type;
        }
        if (hasValue(jsObject.typeIdField)) {
            dotNetFeatureLayer.typeIdField = jsObject.typeIdField;
        }
        if (hasValue(jsObject.types)) {
            dotNetFeatureLayer.types = jsObject.types;
        }
        if (hasValue(jsObject.url)) {
            dotNetFeatureLayer.url = jsObject.url;
        }
        if (hasValue(jsObject.useViewTime)) {
            dotNetFeatureLayer.useViewTime = jsObject.useViewTime;
        }
        if (hasValue(jsObject.version)) {
            dotNetFeatureLayer.version = jsObject.version;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFeatureLayer.id = k;
                break;
            }
        }
    }

    return dotNetFeatureLayer;
}

