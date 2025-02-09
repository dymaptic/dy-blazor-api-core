// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CapabilitiesData = __esri.CapabilitiesData;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CapabilitiesDataGenerated implements IPropertyWrapper {
    public component: CapabilitiesData;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: CapabilitiesData) {
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
    
    // region properties
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsCapabilitiesDataGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCapabilitiesData: any = {}

    if (hasValue(dotNetObject.isVersioned)) {
        jsCapabilitiesData.isVersioned = dotNetObject.isVersioned;
    }
    if (hasValue(dotNetObject.supportsAttachment)) {
        jsCapabilitiesData.supportsAttachment = dotNetObject.supportsAttachment;
    }
    if (hasValue(dotNetObject.supportsM)) {
        jsCapabilitiesData.supportsM = dotNetObject.supportsM;
    }
    if (hasValue(dotNetObject.supportsZ)) {
        jsCapabilitiesData.supportsZ = dotNetObject.supportsZ;
    }
    let { default: CapabilitiesDataWrapper } = await import('./capabilitiesData');
    let capabilitiesDataWrapper = new CapabilitiesDataWrapper(jsCapabilitiesData);
    capabilitiesDataWrapper.geoBlazorId = dotNetObject.id;
    capabilitiesDataWrapper.viewId = viewId;
    capabilitiesDataWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(capabilitiesDataWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = capabilitiesDataWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCapabilitiesData;
    
    return jsCapabilitiesData;
}

export async function buildDotNetCapabilitiesDataGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCapabilitiesData: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        dotNetCapabilitiesData.isVersioned = jsObject.isVersioned;
        dotNetCapabilitiesData.supportsAttachment = jsObject.supportsAttachment;
        dotNetCapabilitiesData.supportsM = jsObject.supportsM;
        dotNetCapabilitiesData.supportsZ = jsObject.supportsZ;

    return dotNetCapabilitiesData;
}

