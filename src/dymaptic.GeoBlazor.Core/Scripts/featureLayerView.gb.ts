// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FeatureLayerView from '@arcgis/core/views/layers/FeatureLayerView';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FeatureLayerViewGenerated implements IPropertyWrapper {
    public component: FeatureLayerView;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FeatureLayerView) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async queryAggregates(query: any,
        options: any): Promise<any> {
        return await this.component.queryAggregates(query,
            options);
    }

    // region properties
    
    async getFeatureEffect(): Promise<any> {
        let { buildDotNetFeatureEffect } = await import('./featureEffect');
        return await buildDotNetFeatureEffect(this.component.featureEffect, this.layerId, this.viewId);
    }
    async getFilter(): Promise<any> {
        let { buildDotNetFeatureFilter } = await import('./featureFilter');
        return await buildDotNetFeatureFilter(this.component.filter, this.layerId, this.viewId);
    }
    async getHighlightOptions(): Promise<any> {
        let { buildDotNetHighlightOptions } = await import('./highlightOptions');
        return await buildDotNetHighlightOptions(this.component.highlightOptions);
    }
    async setHighlightOptions(value: any): Promise<void> {
        let { buildJsHighlightOptions } = await import('./highlightOptions');
        this.component.highlightOptions = await  buildJsHighlightOptions(value, this.layerId, this.viewId);
    }
    async getLayer(): Promise<any> {
        let { buildDotNetFeatureLayer } = await import('./featureLayer');
        return buildDotNetFeatureLayer(this.component.layer);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsFeatureLayerViewGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFeatureLayerView = new FeatureLayerView();
    if (hasValue(dotNetObject.featureEffect)) {
        let { buildJsFeatureEffect } = await import('./jsBuilder');
        jsFeatureLayerView.featureEffect = await buildJsFeatureEffect(dotNetObject.featureEffect) as any;
    }
    if (hasValue(dotNetObject.filter)) {
        let { buildJsFeatureFilter } = await import('./jsBuilder');
        jsFeatureLayerView.filter = buildJsFeatureFilter(dotNetObject.filter) as any;
    }
    if (hasValue(dotNetObject.highlightOptions)) {
        let { buildJsHighlightOptions } = await import('./highlightOptions');
        jsFeatureLayerView.highlightOptions = await buildJsHighlightOptions(dotNetObject.highlightOptions, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.maximumNumberOfFeatures)) {
        jsFeatureLayerView.maximumNumberOfFeatures = dotNetObject.maximumNumberOfFeatures;
    }
    if (hasValue(dotNetObject.maximumNumberOfFeaturesExceeded)) {
        jsFeatureLayerView.maximumNumberOfFeaturesExceeded = dotNetObject.maximumNumberOfFeaturesExceeded;
    }
    let { default: FeatureLayerViewWrapper } = await import('./featureLayerView');
    let featureLayerViewWrapper = new FeatureLayerViewWrapper(jsFeatureLayerView);
    featureLayerViewWrapper.geoBlazorId = dotNetObject.id;
    featureLayerViewWrapper.viewId = viewId;
    featureLayerViewWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(featureLayerViewWrapper);
    jsObjectRefs[dotNetObject.id] = featureLayerViewWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsFeatureLayerView;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FeatureLayerView', e);
    }
    
    return jsFeatureLayerView;
}

export async function buildDotNetFeatureLayerViewGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFeatureLayerView: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.featureEffect)) {
            let { buildDotNetFeatureEffect } = await import('./featureEffect');
            dotNetFeatureLayerView.featureEffect = await buildDotNetFeatureEffect(jsObject.featureEffect, layerId, viewId);
        }
        if (hasValue(jsObject.filter)) {
            let { buildDotNetFeatureFilter } = await import('./featureFilter');
            dotNetFeatureLayerView.filter = await buildDotNetFeatureFilter(jsObject.filter, layerId, viewId);
        }
        if (hasValue(jsObject.highlightOptions)) {
            let { buildDotNetHighlightOptions } = await import('./highlightOptions');
            dotNetFeatureLayerView.highlightOptions = await buildDotNetHighlightOptions(jsObject.highlightOptions);
        }
        if (hasValue(jsObject.layer)) {
            let { buildDotNetFeatureLayer } = await import('./dotNetBuilder');
            dotNetFeatureLayerView.layer = buildDotNetFeatureLayer(jsObject.layer);
        }
        if (hasValue(jsObject.availableFields)) {
            dotNetFeatureLayerView.availableFields = jsObject.availableFields;
        }
        if (hasValue(jsObject.dataUpdating)) {
            dotNetFeatureLayerView.dataUpdating = jsObject.dataUpdating;
        }
        if (hasValue(jsObject.hasAllFeatures)) {
            dotNetFeatureLayerView.hasAllFeatures = jsObject.hasAllFeatures;
        }
        if (hasValue(jsObject.hasAllFeaturesInView)) {
            dotNetFeatureLayerView.hasAllFeaturesInView = jsObject.hasAllFeaturesInView;
        }
        if (hasValue(jsObject.hasFullGeometries)) {
            dotNetFeatureLayerView.hasFullGeometries = jsObject.hasFullGeometries;
        }
        if (hasValue(jsObject.maximumNumberOfFeatures)) {
            dotNetFeatureLayerView.maximumNumberOfFeatures = jsObject.maximumNumberOfFeatures;
        }
        if (hasValue(jsObject.maximumNumberOfFeaturesExceeded)) {
            dotNetFeatureLayerView.maximumNumberOfFeaturesExceeded = jsObject.maximumNumberOfFeaturesExceeded;
        }
        if (hasValue(jsObject.spatialReferenceSupported)) {
            dotNetFeatureLayerView.spatialReferenceSupported = jsObject.spatialReferenceSupported;
        }
        if (hasValue(jsObject.suspended)) {
            dotNetFeatureLayerView.suspended = jsObject.suspended;
        }
        if (hasValue(jsObject.updating)) {
            dotNetFeatureLayerView.updating = jsObject.updating;
        }
        if (hasValue(jsObject.view)) {
            dotNetFeatureLayerView.view = jsObject.view;
        }
        if (hasValue(jsObject.visibleAtCurrentScale)) {
            dotNetFeatureLayerView.visibleAtCurrentScale = jsObject.visibleAtCurrentScale;
        }
        if (hasValue(jsObject.visibleAtCurrentTimeExtent)) {
            dotNetFeatureLayerView.visibleAtCurrentTimeExtent = jsObject.visibleAtCurrentTimeExtent;
        }

    return dotNetFeatureLayerView;
}

