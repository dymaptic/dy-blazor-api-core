// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import Sublayer from '@arcgis/core/layers/support/Sublayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class SublayerGenerated implements IPropertyWrapper {
    public component: Sublayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: Sublayer) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async createFeatureLayer(): Promise<any> {
        let result = await this.component.createFeatureLayer();
        let { buildDotNetFeatureLayer } = await import('./featureLayer');
        return await buildDotNetFeatureLayer(result);
    }

    async createPopupTemplate(options: any): Promise<any> {
        let result = this.component.createPopupTemplate(options);
        let { buildDotNetPopupTemplate } = await import('./popupTemplate');
        return await buildDotNetPopupTemplate(result);
    }

    async createQuery(): Promise<any> {
        return this.component.createQuery();
    }

    async getFeatureType(feature: any): Promise<any> {
        let { buildJsGraphic } = await import('./graphic');
        let jsFeature = buildJsGraphic(feature, this.layerId, this.viewId) as any;
        return this.component.getFeatureType(jsFeature);
    }

    async getFieldDomain(fieldName: any,
        options: any): Promise<any> {
        return this.component.getFieldDomain(fieldName,
            options);
    }

    async queryAttachments(attachmentQuery: any,
        options: any): Promise<any> {
        return this.component.queryAttachments(attachmentQuery,
            options);
    }

    async queryFeatureCount(query: any,
        options: any): Promise<any> {
        return await this.component.queryFeatureCount(query,
            options);
    }

    async queryFeatures(query: any,
        options: any): Promise<any> {
        return await this.component.queryFeatures(query,
            options);
    }

    async queryObjectIds(query: any,
        options: any): Promise<any> {
        return await this.component.queryObjectIds(query,
            options);
    }

    async queryRelatedFeatures(relationshipQuery: any,
        options: any): Promise<any> {
        return await this.component.queryRelatedFeatures(relationshipQuery,
            options);
    }

    async queryRelatedFeaturesCount(relationshipQuery: any,
        options: any): Promise<any> {
        return await this.component.queryRelatedFeaturesCount(relationshipQuery,
            options);
    }

    // region properties
    
    async getFields(): Promise<any> {
        if (!hasValue(this.component.fields)) {
            return null;
        }
        
        let { buildDotNetField } = await import('./field');
        return await Promise.all(this.component.fields.map(async i => await buildDotNetField(i)));
    }
    
    async getFloorInfo(): Promise<any> {
        if (!hasValue(this.component.floorInfo)) {
            return null;
        }
        
        let { buildDotNetLayerFloorInfo } = await import('./layerFloorInfo');
        return await buildDotNetLayerFloorInfo(this.component.floorInfo);
    }
    async setFloorInfo(value: any): Promise<void> {
        let { buildJsLayerFloorInfo } = await import('./layerFloorInfo');
        this.component.floorInfo = await  buildJsLayerFloorInfo(value, this.layerId, this.viewId);
    }
    async getFullExtent(): Promise<any> {
        if (!hasValue(this.component.fullExtent)) {
            return null;
        }
        
        let { buildDotNetExtent } = await import('./extent');
        return buildDotNetExtent(this.component.fullExtent);
    }
    async getLabelingInfo(): Promise<any> {
        if (!hasValue(this.component.labelingInfo)) {
            return null;
        }
        
        let { buildDotNetLabel } = await import('./label');
        return await Promise.all(this.component.labelingInfo.map(async i => await buildDotNetLabel(i)));
    }
    
    async setLabelingInfo(value: any): Promise<void> {
        let { buildJsLabel } = await import('./label');
        this.component.labelingInfo = await Promise.all(value.map(async i => await buildJsLabel(i, this.layerId, this.viewId))) as any;
    }
    
    async getLayer(): Promise<any> {
        if (!hasValue(this.component.layer)) {
            return null;
        }
        
        let { buildDotNetLayer } = await import('./layer');
        return await buildDotNetLayer(this.component.layer);
    }
    async getPopupTemplate(): Promise<any> {
        if (!hasValue(this.component.popupTemplate)) {
            return null;
        }
        
        let { buildDotNetPopupTemplate } = await import('./popupTemplate');
        return await buildDotNetPopupTemplate(this.component.popupTemplate);
    }
    async setPopupTemplate(value: any): Promise<void> {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        this.component.popupTemplate = await  buildJsPopupTemplate(value, this.layerId, this.viewId);
    }
    async getRenderer(): Promise<any> {
        if (!hasValue(this.component.renderer)) {
            return null;
        }
        
        let { buildDotNetRenderer } = await import('./renderer');
        return await buildDotNetRenderer(this.component.renderer);
    }
    async setRenderer(value: any): Promise<void> {
        let { buildJsRenderer } = await import('./renderer');
        this.component.renderer = await  buildJsRenderer(value, this.layerId, this.viewId);
    }
    async getSpatialReference(): Promise<any> {
        if (!hasValue(this.component.spatialReference)) {
            return null;
        }
        
        let { buildDotNetSpatialReference } = await import('./spatialReference');
        return buildDotNetSpatialReference(this.component.spatialReference);
    }
    async getSublayers(): Promise<any> {
        if (!hasValue(this.component.sublayers)) {
            return null;
        }
        
        let { buildDotNetSublayer } = await import('./sublayer');
        return await Promise.all(this.component.sublayers.map(async i => await buildDotNetSublayer(i)));
    }
    
    async setSublayers(value: any): Promise<void> {
        let { buildJsSublayer } = await import('./sublayer');
        this.component.sublayers = await Promise.all(value.map(async i => await buildJsSublayer(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsSublayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsSublayer = new Sublayer();
    if (hasValue(dotNetObject.floorInfo)) {
        let { buildJsLayerFloorInfo } = await import('./layerFloorInfo');
        jsSublayer.floorInfo = await buildJsLayerFloorInfo(dotNetObject.floorInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.labelingInfo)) {
        let { buildJsLabel } = await import('./label');
        jsSublayer.labelingInfo = await Promise.all(dotNetObject.labelingInfo.map(async i => await buildJsLabel(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.popupTemplate)) {
        let { buildJsPopupTemplate } = await import('./popupTemplate');
        jsSublayer.popupTemplate = await buildJsPopupTemplate(dotNetObject.popupTemplate, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.renderer)) {
        let { buildJsRenderer } = await import('./renderer');
        jsSublayer.renderer = await buildJsRenderer(dotNetObject.renderer, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.definitionExpression)) {
        jsSublayer.definitionExpression = dotNetObject.definitionExpression;
    }
    if (hasValue(dotNetObject.labelsVisible)) {
        jsSublayer.labelsVisible = dotNetObject.labelsVisible;
    }
    if (hasValue(dotNetObject.legendEnabled)) {
        jsSublayer.legendEnabled = dotNetObject.legendEnabled;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsSublayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsSublayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsSublayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsSublayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.popupEnabled)) {
        jsSublayer.popupEnabled = dotNetObject.popupEnabled;
    }
    if (hasValue(dotNetObject.source)) {
        jsSublayer.source = dotNetObject.source;
    }
    if (hasValue(dotNetObject.sublayerId)) {
        jsSublayer.id = dotNetObject.sublayerId;
    }
    if (hasValue(dotNetObject.title)) {
        jsSublayer.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.url)) {
        jsSublayer.url = dotNetObject.url;
    }
    let { default: SublayerWrapper } = await import('./sublayer');
    let sublayerWrapper = new SublayerWrapper(jsSublayer);
    sublayerWrapper.geoBlazorId = dotNetObject.id;
    sublayerWrapper.viewId = viewId;
    sublayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(sublayerWrapper);
    jsObjectRefs[dotNetObject.id] = sublayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsSublayer;
    
    let { buildDotNetSublayer } = await import('./sublayer');
    let dnInstantiatedObject = await buildDotNetSublayer(jsSublayer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for Sublayer', e);
    }
    
    return jsSublayer;
}

export async function buildDotNetSublayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetSublayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.fields)) {
            let { buildDotNetField } = await import('./field');
            dotNetSublayer.fields = await Promise.all(jsObject.fields.map(async i => await buildDotNetField(i)));
        }
        if (hasValue(jsObject.floorInfo)) {
            let { buildDotNetLayerFloorInfo } = await import('./layerFloorInfo');
            dotNetSublayer.floorInfo = await buildDotNetLayerFloorInfo(jsObject.floorInfo);
        }
        if (hasValue(jsObject.fullExtent)) {
            let { buildDotNetExtent } = await import('./extent');
            dotNetSublayer.fullExtent = buildDotNetExtent(jsObject.fullExtent);
        }
        if (hasValue(jsObject.labelingInfo)) {
            let { buildDotNetLabel } = await import('./label');
            dotNetSublayer.labelingInfo = await Promise.all(jsObject.labelingInfo.map(async i => await buildDotNetLabel(i)));
        }
        if (hasValue(jsObject.popupTemplate)) {
            let { buildDotNetPopupTemplate } = await import('./popupTemplate');
            dotNetSublayer.popupTemplate = await buildDotNetPopupTemplate(jsObject.popupTemplate);
        }
        if (hasValue(jsObject.renderer)) {
            let { buildDotNetRenderer } = await import('./renderer');
            dotNetSublayer.renderer = await buildDotNetRenderer(jsObject.renderer);
        }
        if (hasValue(jsObject.spatialReference)) {
            let { buildDotNetSpatialReference } = await import('./spatialReference');
            dotNetSublayer.spatialReference = buildDotNetSpatialReference(jsObject.spatialReference);
        }
        if (hasValue(jsObject.capabilities)) {
            dotNetSublayer.capabilities = jsObject.capabilities;
        }
        if (hasValue(jsObject.definitionExpression)) {
            dotNetSublayer.definitionExpression = jsObject.definitionExpression;
        }
        if (hasValue(jsObject.fieldsIndex)) {
            dotNetSublayer.fieldsIndex = jsObject.fieldsIndex;
        }
        if (hasValue(jsObject.isTable)) {
            dotNetSublayer.isTable = jsObject.isTable;
        }
        if (hasValue(jsObject.labelsVisible)) {
            dotNetSublayer.labelsVisible = jsObject.labelsVisible;
        }
        if (hasValue(jsObject.legendEnabled)) {
            dotNetSublayer.legendEnabled = jsObject.legendEnabled;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetSublayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetSublayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetSublayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.objectIdField)) {
            dotNetSublayer.objectIdField = jsObject.objectIdField;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetSublayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.popupEnabled)) {
            dotNetSublayer.popupEnabled = jsObject.popupEnabled;
        }
        if (hasValue(jsObject.relationships)) {
            dotNetSublayer.relationships = jsObject.relationships;
        }
        if (hasValue(jsObject.source)) {
            dotNetSublayer.source = jsObject.source;
        }
        if (hasValue(jsObject.sourceJSON)) {
            dotNetSublayer.sourceJSON = jsObject.sourceJSON;
        }
        if (hasValue(jsObject.id)) {
            dotNetSublayer.sublayerId = jsObject.id;
        }
        if (hasValue(jsObject.title)) {
            dotNetSublayer.title = jsObject.title;
        }
        if (hasValue(jsObject.typeIdField)) {
            dotNetSublayer.typeIdField = jsObject.typeIdField;
        }
        if (hasValue(jsObject.types)) {
            dotNetSublayer.types = jsObject.types;
        }
        if (hasValue(jsObject.url)) {
            dotNetSublayer.url = jsObject.url;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetSublayer.id = k;
                break;
            }
        }
    }

    return dotNetSublayer;
}

