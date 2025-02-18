// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import SceneLayerElevationInfo = __esri.SceneLayerElevationInfo;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class SceneLayerElevationInfoGenerated implements IPropertyWrapper {
    public component: SceneLayerElevationInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: SceneLayerElevationInfo) {
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

export async function buildJsSceneLayerElevationInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsSceneLayerElevationInfo: any = {}

    if (hasValue(dotNetObject.mode)) {
        jsSceneLayerElevationInfo.mode = dotNetObject.mode;
    }
    if (hasValue(dotNetObject.offset)) {
        jsSceneLayerElevationInfo.offset = dotNetObject.offset;
    }
    if (hasValue(dotNetObject.unit)) {
        jsSceneLayerElevationInfo.unit = dotNetObject.unit;
    }
    let { default: SceneLayerElevationInfoWrapper } = await import('./sceneLayerElevationInfo');
    let sceneLayerElevationInfoWrapper = new SceneLayerElevationInfoWrapper(jsSceneLayerElevationInfo);
    sceneLayerElevationInfoWrapper.geoBlazorId = dotNetObject.id;
    sceneLayerElevationInfoWrapper.viewId = viewId;
    sceneLayerElevationInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(sceneLayerElevationInfoWrapper);
    jsObjectRefs[dotNetObject.id] = sceneLayerElevationInfoWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsSceneLayerElevationInfo;
    let { buildDotNetSceneLayerElevationInfo } = await import('./sceneLayerElevationInfo');
    let dnInstantiatedObject = await buildDotNetSceneLayerElevationInfo(jsSceneLayerElevationInfo, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for SceneLayerElevationInfo', e);
    }
    
    return jsSceneLayerElevationInfo;
}

export async function buildDotNetSceneLayerElevationInfoGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetSceneLayerElevationInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.mode)) {
            dotNetSceneLayerElevationInfo.mode = jsObject.mode;
        }
        if (hasValue(jsObject.offset)) {
            dotNetSceneLayerElevationInfo.offset = jsObject.offset;
        }
        if (hasValue(jsObject.unit)) {
            dotNetSceneLayerElevationInfo.unit = jsObject.unit;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetSceneLayerElevationInfo.id = k;
                break;
            }
        }
    }

    return dotNetSceneLayerElevationInfo;
}

