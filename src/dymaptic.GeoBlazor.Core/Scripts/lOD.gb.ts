// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import LOD from '@arcgis/core/layers/support/LOD';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class LODGenerated implements IPropertyWrapper {
    public component: LOD;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: LOD) {
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

export async function buildJsLODGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsLOD = new LOD();

    if (hasValue(dotNetObject.level)) {
        jsLOD.level = dotNetObject.level;
    }
    if (hasValue(dotNetObject.levelValue)) {
        jsLOD.levelValue = dotNetObject.levelValue;
    }
    if (hasValue(dotNetObject.resolution)) {
        jsLOD.resolution = dotNetObject.resolution;
    }
    if (hasValue(dotNetObject.scale)) {
        jsLOD.scale = dotNetObject.scale;
    }
    let { default: LODWrapper } = await import('./lOD');
    let lODWrapper = new LODWrapper(jsLOD);
    lODWrapper.geoBlazorId = dotNetObject.id;
    lODWrapper.viewId = viewId;
    lODWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(lODWrapper);
    jsObjectRefs[dotNetObject.id] = lODWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsLOD;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for LOD', e);
    }
    
    return jsLOD;
}

export async function buildDotNetLODGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetLOD: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.level)) {
            dotNetLOD.level = jsObject.level;
        }
        if (hasValue(jsObject.levelValue)) {
            dotNetLOD.levelValue = jsObject.levelValue;
        }
        if (hasValue(jsObject.resolution)) {
            dotNetLOD.resolution = jsObject.resolution;
        }
        if (hasValue(jsObject.scale)) {
            dotNetLOD.scale = jsObject.scale;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetLOD.id = k;
                break;
            }
        }
    }

    return dotNetLOD;
}

