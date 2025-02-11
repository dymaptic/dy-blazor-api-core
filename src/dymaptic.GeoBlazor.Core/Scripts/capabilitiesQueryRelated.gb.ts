// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CapabilitiesQueryRelated = __esri.CapabilitiesQueryRelated;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CapabilitiesQueryRelatedGenerated implements IPropertyWrapper {
    public component: CapabilitiesQueryRelated;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: CapabilitiesQueryRelated) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsCapabilitiesQueryRelatedGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCapabilitiesQueryRelated: any = {}

    if (hasValue(dotNetObject.supportsCacheHint)) {
        jsCapabilitiesQueryRelated.supportsCacheHint = dotNetObject.supportsCacheHint;
    }
    if (hasValue(dotNetObject.supportsCount)) {
        jsCapabilitiesQueryRelated.supportsCount = dotNetObject.supportsCount;
    }
    if (hasValue(dotNetObject.supportsOrderBy)) {
        jsCapabilitiesQueryRelated.supportsOrderBy = dotNetObject.supportsOrderBy;
    }
    if (hasValue(dotNetObject.supportsPagination)) {
        jsCapabilitiesQueryRelated.supportsPagination = dotNetObject.supportsPagination;
    }
    let { default: CapabilitiesQueryRelatedWrapper } = await import('./capabilitiesQueryRelated');
    let capabilitiesQueryRelatedWrapper = new CapabilitiesQueryRelatedWrapper(jsCapabilitiesQueryRelated);
    capabilitiesQueryRelatedWrapper.geoBlazorId = dotNetObject.id;
    capabilitiesQueryRelatedWrapper.viewId = viewId;
    capabilitiesQueryRelatedWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(capabilitiesQueryRelatedWrapper);
    jsObjectRefs[dotNetObject.id] = capabilitiesQueryRelatedWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCapabilitiesQueryRelated;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for CapabilitiesQueryRelated', e);
    }
    
    return jsCapabilitiesQueryRelated;
}

export async function buildDotNetCapabilitiesQueryRelatedGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCapabilitiesQueryRelated: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.supportsCacheHint)) {
            dotNetCapabilitiesQueryRelated.supportsCacheHint = jsObject.supportsCacheHint;
        }
        if (hasValue(jsObject.supportsCount)) {
            dotNetCapabilitiesQueryRelated.supportsCount = jsObject.supportsCount;
        }
        if (hasValue(jsObject.supportsOrderBy)) {
            dotNetCapabilitiesQueryRelated.supportsOrderBy = jsObject.supportsOrderBy;
        }
        if (hasValue(jsObject.supportsPagination)) {
            dotNetCapabilitiesQueryRelated.supportsPagination = jsObject.supportsPagination;
        }

    return dotNetCapabilitiesQueryRelated;
}

