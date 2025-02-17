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
        if (!hasValue(this.component.featureEffect)) {
            return null;
        }
        
        let { buildDotNetFeatureEffect } = await import('./featureEffect');
        return await buildDotNetFeatureEffect(this.component.featureEffect);
    }
    async getFilter(): Promise<any> {
        if (!hasValue(this.component.filter)) {
            return null;
        }
        
        let { buildDotNetFeatureFilter } = await import('./featureFilter');
        return await buildDotNetFeatureFilter(this.component.filter);
    }
    async getHighlightOptions(): Promise<any> {
        if (!hasValue(this.component.highlightOptions)) {
            return null;
        }
        
        let { buildDotNetHighlightOptions } = await import('./highlightOptions');
        return await buildDotNetHighlightOptions(this.component.highlightOptions);
    }
    async setHighlightOptions(value: any): Promise<void> {
        let { buildJsHighlightOptions } = await import('./highlightOptions');
        this.component.highlightOptions = await  buildJsHighlightOptions(value, this.layerId, this.viewId);
    }
    async getLayer(): Promise<any> {
        if (!hasValue(this.component.layer)) {
            return null;
        }
        
        let { buildDotNetFeatureLayer } = await import('./featureLayer');
        return await buildDotNetFeatureLayer(this.component.layer, this.layerId, this.viewId);
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
        jsFeatureLayerView.featureEffect = await buildJsFeatureEffect(dotNetObject.featureEffect, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.filter)) {
        let { buildJsFeatureFilter } = await import('./jsBuilder');
        jsFeatureLayerView.filter = await buildJsFeatureFilter(dotNetObject.filter, layerId, viewId) as any;
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
    
    let { buildDotNetFeatureLayerView } = await import('./featureLayerView');
    let dnInstantiatedObject = await buildDotNetFeatureLayerView(jsFeatureLayerView);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
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
            dotNetFeatureLayerView.featureEffect = await buildDotNetFeatureEffect(jsObject.featureEffect);
        }
        if (hasValue(jsObject.filter)) {
            let { buildDotNetFeatureFilter } = await import('./featureFilter');
            dotNetFeatureLayerView.filter = await buildDotNetFeatureFilter(jsObject.filter);
        }
        if (hasValue(jsObject.highlightOptions)) {
            let { buildDotNetHighlightOptions } = await import('./highlightOptions');
            dotNetFeatureLayerView.highlightOptions = await buildDotNetHighlightOptions(jsObject.highlightOptions);
        }
        if (hasValue(jsObject.layer)) {
            let { buildDotNetFeatureLayer } = await import('./featureLayer');
            dotNetFeatureLayerView.layer = await buildDotNetFeatureLayer(jsObject.layer, layerId, viewId);
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

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFeatureLayerView.id = k;
                break;
            }
        }
    }

    return dotNetFeatureLayerView;
}

