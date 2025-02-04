// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FeatureFilter from '@arcgis/core/layers/support/FeatureFilter';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FeatureFilterGenerated implements IPropertyWrapper {
    public component: FeatureFilter;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FeatureFilter) {
        this.component = component;
        // set all properties from component
        for (let prop in component) {
            if (component.hasOwnProperty(prop)) {
                this[prop] = component[prop];
            }
        }
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async createQuery(): Promise<any> {
        return this.component.createQuery();
    }

    // region properties
    
    async getTimeExtent(layerId: string | null, viewId: string | null): Promise<any> {
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return await buildDotNetTimeExtent(this.component.timeExtent, layerId, viewId);
    }
    async setTimeExtent(value: any, layerId: string | null, viewId: string | null): Promise<void> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        this.component.timeExtent = await buildJsTimeExtent(value, layerId, viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsFeatureFilterGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { default: FeatureFilter } = await import('@arcgis/core/layers/support/FeatureFilter');
    let jsFeatureFilter = new FeatureFilter();
    if (hasValue(dotNetObject.timeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsFeatureFilter.timeExtent = await buildJsTimeExtent(dotNetObject.timeExtent, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.distance)) {
        jsFeatureFilter.distance = dotNetObject.distance;
    }
    if (hasValue(dotNetObject.geometry)) {
        jsFeatureFilter.geometry = dotNetObject.geometry;
    }
    if (hasValue(dotNetObject.objectIds)) {
        jsFeatureFilter.objectIds = dotNetObject.objectIds;
    }
    if (hasValue(dotNetObject.spatialRelationship)) {
        jsFeatureFilter.spatialRelationship = dotNetObject.spatialRelationship;
    }
    if (hasValue(dotNetObject.units)) {
        jsFeatureFilter.units = dotNetObject.units;
    }
    if (hasValue(dotNetObject.where)) {
        jsFeatureFilter.where = dotNetObject.where;
    }
    let { default: FeatureFilterWrapper } = await import('./featureFilter');
    let featureFilterWrapper = new FeatureFilterWrapper(jsFeatureFilter);
    featureFilterWrapper.geoBlazorId = dotNetObject.id;
    featureFilterWrapper.viewId = viewId;
    featureFilterWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(featureFilterWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = featureFilterWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsFeatureFilter;
    
    return jsFeatureFilter;
}

export async function buildDotNetFeatureFilterGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFeatureFilter: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.timeExtent)) {
            let { buildDotNetTimeExtent } = await import('./dotNetBuilder');
            dotNetFeatureFilter.timeExtent = await buildDotNetTimeExtent(jsObject.timeExtent, layerId, viewId);
        }
        dotNetFeatureFilter.distance = jsObject.distance;
        dotNetFeatureFilter.geometry = jsObject.geometry;
        dotNetFeatureFilter.objectIds = jsObject.objectIds;
        dotNetFeatureFilter.spatialRelationship = jsObject.spatialRelationship;
        dotNetFeatureFilter.units = jsObject.units;
        dotNetFeatureFilter.where = jsObject.where;
    return dotNetFeatureFilter;
}

