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
    jsObjectRefs[dotNetObject.id] = capabilitiesOperationsWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCapabilitiesOperations;
    
    let dnInstantiatedObject = await buildDotNetCapabilitiesOperations(jsCapabilitiesOperations);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for CapabilitiesOperations', e);
    }
    
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
        if (hasValue(jsObject.supportsAdd)) {
            dotNetCapabilitiesOperations.supportsAdd = jsObject.supportsAdd;
        }
        if (hasValue(jsObject.supportsCalculate)) {
            dotNetCapabilitiesOperations.supportsCalculate = jsObject.supportsCalculate;
        }
        if (hasValue(jsObject.supportsDelete)) {
            dotNetCapabilitiesOperations.supportsDelete = jsObject.supportsDelete;
        }
        if (hasValue(jsObject.supportsEditing)) {
            dotNetCapabilitiesOperations.supportsEditing = jsObject.supportsEditing;
        }
        if (hasValue(jsObject.supportsQuery)) {
            dotNetCapabilitiesOperations.supportsQuery = jsObject.supportsQuery;
        }
        if (hasValue(jsObject.supportsQueryAttachments)) {
            dotNetCapabilitiesOperations.supportsQueryAttachments = jsObject.supportsQueryAttachments;
        }
        if (hasValue(jsObject.supportsQueryTopFeatures)) {
            dotNetCapabilitiesOperations.supportsQueryTopFeatures = jsObject.supportsQueryTopFeatures;
        }
        if (hasValue(jsObject.supportsResizeAttachments)) {
            dotNetCapabilitiesOperations.supportsResizeAttachments = jsObject.supportsResizeAttachments;
        }
        if (hasValue(jsObject.supportsUpdate)) {
            dotNetCapabilitiesOperations.supportsUpdate = jsObject.supportsUpdate;
        }
        if (hasValue(jsObject.supportsValidateSql)) {
            dotNetCapabilitiesOperations.supportsValidateSql = jsObject.supportsValidateSql;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetCapabilitiesOperations.id = k;
                break;
            }
        }
    }

    return dotNetCapabilitiesOperations;
}

