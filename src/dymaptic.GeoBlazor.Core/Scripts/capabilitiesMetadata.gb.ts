// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CapabilitiesMetadata = __esri.CapabilitiesMetadata;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CapabilitiesMetadataGenerated implements IPropertyWrapper {
    public component: CapabilitiesMetadata;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: CapabilitiesMetadata) {
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

export async function buildJsCapabilitiesMetadataGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCapabilitiesMetadata: any = {}

    if (hasValue(dotNetObject.supportsAdvancedFieldProperties)) {
        jsCapabilitiesMetadata.supportsAdvancedFieldProperties = dotNetObject.supportsAdvancedFieldProperties;
    }
    let { default: CapabilitiesMetadataWrapper } = await import('./capabilitiesMetadata');
    let capabilitiesMetadataWrapper = new CapabilitiesMetadataWrapper(jsCapabilitiesMetadata);
    capabilitiesMetadataWrapper.geoBlazorId = dotNetObject.id;
    capabilitiesMetadataWrapper.viewId = viewId;
    capabilitiesMetadataWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(capabilitiesMetadataWrapper);
    jsObjectRefs[dotNetObject.id] = capabilitiesMetadataWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCapabilitiesMetadata;
    
    let { buildDotNetCapabilitiesMetadata } = await import('./capabilitiesMetadata');
    let dnInstantiatedObject = await buildDotNetCapabilitiesMetadata(jsCapabilitiesMetadata);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for CapabilitiesMetadata', e);
    }
    
    return jsCapabilitiesMetadata;
}

export async function buildDotNetCapabilitiesMetadataGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCapabilitiesMetadata: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.supportsAdvancedFieldProperties)) {
            dotNetCapabilitiesMetadata.supportsAdvancedFieldProperties = jsObject.supportsAdvancedFieldProperties;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetCapabilitiesMetadata.id = k;
                break;
            }
        }
    }

    return dotNetCapabilitiesMetadata;
}

