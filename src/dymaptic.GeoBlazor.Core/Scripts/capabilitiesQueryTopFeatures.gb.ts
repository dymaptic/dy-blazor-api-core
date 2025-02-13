// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CapabilitiesQueryTopFeatures = __esri.CapabilitiesQueryTopFeatures;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CapabilitiesQueryTopFeaturesGenerated implements IPropertyWrapper {
    public component: CapabilitiesQueryTopFeatures;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: CapabilitiesQueryTopFeatures) {
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

export async function buildJsCapabilitiesQueryTopFeaturesGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCapabilitiesQueryTopFeatures: any = {}

    if (hasValue(dotNetObject.supportsCacheHint)) {
        jsCapabilitiesQueryTopFeatures.supportsCacheHint = dotNetObject.supportsCacheHint;
    }
    let { default: CapabilitiesQueryTopFeaturesWrapper } = await import('./capabilitiesQueryTopFeatures');
    let capabilitiesQueryTopFeaturesWrapper = new CapabilitiesQueryTopFeaturesWrapper(jsCapabilitiesQueryTopFeatures);
    capabilitiesQueryTopFeaturesWrapper.geoBlazorId = dotNetObject.id;
    capabilitiesQueryTopFeaturesWrapper.viewId = viewId;
    capabilitiesQueryTopFeaturesWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(capabilitiesQueryTopFeaturesWrapper);
    jsObjectRefs[dotNetObject.id] = capabilitiesQueryTopFeaturesWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCapabilitiesQueryTopFeatures;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for CapabilitiesQueryTopFeatures', e);
    }
    
    return jsCapabilitiesQueryTopFeatures;
}

export async function buildDotNetCapabilitiesQueryTopFeaturesGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCapabilitiesQueryTopFeatures: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.supportsCacheHint)) {
            dotNetCapabilitiesQueryTopFeatures.supportsCacheHint = jsObject.supportsCacheHint;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetCapabilitiesQueryTopFeatures.id = k;
                break;
            }
        }
    }

    return dotNetCapabilitiesQueryTopFeatures;
}

