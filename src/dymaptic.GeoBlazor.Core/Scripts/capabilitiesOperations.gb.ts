// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CapabilitiesOperations = __esri.CapabilitiesOperations;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CapabilitiesOperationsGenerated implements IPropertyWrapper {
    public component: CapabilitiesOperations;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: CapabilitiesOperations) {
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

export async function buildJsCapabilitiesOperationsGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCapabilitiesOperations: any = {}

    if (hasValue(dotNetObject.supportsAdd)) {
        jsCapabilitiesOperations.supportsAdd = dotNetObject.supportsAdd;
    }
    if (hasValue(dotNetObject.supportsCalculate)) {
        jsCapabilitiesOperations.supportsCalculate = dotNetObject.supportsCalculate;
    }
    if (hasValue(dotNetObject.supportsDelete)) {
        jsCapabilitiesOperations.supportsDelete = dotNetObject.supportsDelete;
    }
    if (hasValue(dotNetObject.supportsEditing)) {
        jsCapabilitiesOperations.supportsEditing = dotNetObject.supportsEditing;
    }
    if (hasValue(dotNetObject.supportsQuery)) {
        jsCapabilitiesOperations.supportsQuery = dotNetObject.supportsQuery;
    }
    if (hasValue(dotNetObject.supportsQueryAttachments)) {
        jsCapabilitiesOperations.supportsQueryAttachments = dotNetObject.supportsQueryAttachments;
    }
    if (hasValue(dotNetObject.supportsQueryTopFeatures)) {
        jsCapabilitiesOperations.supportsQueryTopFeatures = dotNetObject.supportsQueryTopFeatures;
    }
    if (hasValue(dotNetObject.supportsResizeAttachments)) {
        jsCapabilitiesOperations.supportsResizeAttachments = dotNetObject.supportsResizeAttachments;
    }
    if (hasValue(dotNetObject.supportsUpdate)) {
        jsCapabilitiesOperations.supportsUpdate = dotNetObject.supportsUpdate;
    }
    if (hasValue(dotNetObject.supportsValidateSql)) {
        jsCapabilitiesOperations.supportsValidateSql = dotNetObject.supportsValidateSql;
    }
    let { default: CapabilitiesOperationsWrapper } = await import('./capabilitiesOperations');
    let capabilitiesOperationsWrapper = new CapabilitiesOperationsWrapper(jsCapabilitiesOperations);
    capabilitiesOperationsWrapper.geoBlazorId = dotNetObject.id;
    capabilitiesOperationsWrapper.viewId = viewId;
    capabilitiesOperationsWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(capabilitiesOperationsWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = capabilitiesOperationsWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCapabilitiesOperations;
    
    return jsCapabilitiesOperations;
}

export async function buildDotNetCapabilitiesOperationsGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCapabilitiesOperations: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        dotNetCapabilitiesOperations.supportsAdd = jsObject.supportsAdd;
        dotNetCapabilitiesOperations.supportsCalculate = jsObject.supportsCalculate;
        dotNetCapabilitiesOperations.supportsDelete = jsObject.supportsDelete;
        dotNetCapabilitiesOperations.supportsEditing = jsObject.supportsEditing;
        dotNetCapabilitiesOperations.supportsQuery = jsObject.supportsQuery;
        dotNetCapabilitiesOperations.supportsQueryAttachments = jsObject.supportsQueryAttachments;
        dotNetCapabilitiesOperations.supportsQueryTopFeatures = jsObject.supportsQueryTopFeatures;
        dotNetCapabilitiesOperations.supportsResizeAttachments = jsObject.supportsResizeAttachments;
        dotNetCapabilitiesOperations.supportsUpdate = jsObject.supportsUpdate;
        dotNetCapabilitiesOperations.supportsValidateSql = jsObject.supportsValidateSql;

    return dotNetCapabilitiesOperations;
}

