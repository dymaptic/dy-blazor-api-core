// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ArcGISImageServiceCapabilitiesMensuration = __esri.ArcGISImageServiceCapabilitiesMensuration;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ArcGISImageServiceCapabilitiesMensurationGenerated implements IPropertyWrapper {
    public component: ArcGISImageServiceCapabilitiesMensuration;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ArcGISImageServiceCapabilitiesMensuration) {
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

export async function buildJsArcGISImageServiceCapabilitiesMensurationGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsArcGISImageServiceCapabilitiesMensuration: any = {}

    if (hasValue(dotNetObject.supports3D)) {
        jsArcGISImageServiceCapabilitiesMensuration.supports3D = dotNetObject.supports3D;
    }
    if (hasValue(dotNetObject.supportsAreaAndPerimeter)) {
        jsArcGISImageServiceCapabilitiesMensuration.supportsAreaAndPerimeter = dotNetObject.supportsAreaAndPerimeter;
    }
    if (hasValue(dotNetObject.supportsDistanceAndAngle)) {
        jsArcGISImageServiceCapabilitiesMensuration.supportsDistanceAndAngle = dotNetObject.supportsDistanceAndAngle;
    }
    if (hasValue(dotNetObject.supportsHeightFromBaseAndTop)) {
        jsArcGISImageServiceCapabilitiesMensuration.supportsHeightFromBaseAndTop = dotNetObject.supportsHeightFromBaseAndTop;
    }
    if (hasValue(dotNetObject.supportsHeightFromBaseAndTopShadow)) {
        jsArcGISImageServiceCapabilitiesMensuration.supportsHeightFromBaseAndTopShadow = dotNetObject.supportsHeightFromBaseAndTopShadow;
    }
    if (hasValue(dotNetObject.supportsHeightFromTopAndTopShadow)) {
        jsArcGISImageServiceCapabilitiesMensuration.supportsHeightFromTopAndTopShadow = dotNetObject.supportsHeightFromTopAndTopShadow;
    }
    if (hasValue(dotNetObject.supportsPointOrCentroid)) {
        jsArcGISImageServiceCapabilitiesMensuration.supportsPointOrCentroid = dotNetObject.supportsPointOrCentroid;
    }
    let { default: ArcGISImageServiceCapabilitiesMensurationWrapper } = await import('./arcGISImageServiceCapabilitiesMensuration');
    let arcGISImageServiceCapabilitiesMensurationWrapper = new ArcGISImageServiceCapabilitiesMensurationWrapper(jsArcGISImageServiceCapabilitiesMensuration);
    arcGISImageServiceCapabilitiesMensurationWrapper.geoBlazorId = dotNetObject.id;
    arcGISImageServiceCapabilitiesMensurationWrapper.viewId = viewId;
    arcGISImageServiceCapabilitiesMensurationWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(arcGISImageServiceCapabilitiesMensurationWrapper);
    jsObjectRefs[dotNetObject.id] = arcGISImageServiceCapabilitiesMensurationWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsArcGISImageServiceCapabilitiesMensuration;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ArcGISImageServiceCapabilitiesMensuration', e);
    }
    
    return jsArcGISImageServiceCapabilitiesMensuration;
}

export async function buildDotNetArcGISImageServiceCapabilitiesMensurationGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetArcGISImageServiceCapabilitiesMensuration: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.supports3D)) {
            dotNetArcGISImageServiceCapabilitiesMensuration.supports3D = jsObject.supports3D;
        }
        if (hasValue(jsObject.supportsAreaAndPerimeter)) {
            dotNetArcGISImageServiceCapabilitiesMensuration.supportsAreaAndPerimeter = jsObject.supportsAreaAndPerimeter;
        }
        if (hasValue(jsObject.supportsDistanceAndAngle)) {
            dotNetArcGISImageServiceCapabilitiesMensuration.supportsDistanceAndAngle = jsObject.supportsDistanceAndAngle;
        }
        if (hasValue(jsObject.supportsHeightFromBaseAndTop)) {
            dotNetArcGISImageServiceCapabilitiesMensuration.supportsHeightFromBaseAndTop = jsObject.supportsHeightFromBaseAndTop;
        }
        if (hasValue(jsObject.supportsHeightFromBaseAndTopShadow)) {
            dotNetArcGISImageServiceCapabilitiesMensuration.supportsHeightFromBaseAndTopShadow = jsObject.supportsHeightFromBaseAndTopShadow;
        }
        if (hasValue(jsObject.supportsHeightFromTopAndTopShadow)) {
            dotNetArcGISImageServiceCapabilitiesMensuration.supportsHeightFromTopAndTopShadow = jsObject.supportsHeightFromTopAndTopShadow;
        }
        if (hasValue(jsObject.supportsPointOrCentroid)) {
            dotNetArcGISImageServiceCapabilitiesMensuration.supportsPointOrCentroid = jsObject.supportsPointOrCentroid;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetArcGISImageServiceCapabilitiesMensuration.id = k;
                break;
            }
        }
    }

    return dotNetArcGISImageServiceCapabilitiesMensuration;
}

