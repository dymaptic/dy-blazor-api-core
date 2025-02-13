// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import LayerFloorInfo from '@arcgis/core/layers/support/LayerFloorInfo';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class LayerFloorInfoGenerated implements IPropertyWrapper {
    public component: LayerFloorInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: LayerFloorInfo) {
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

export async function buildJsLayerFloorInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsLayerFloorInfo = new LayerFloorInfo();

    if (hasValue(dotNetObject.floorField)) {
        jsLayerFloorInfo.floorField = dotNetObject.floorField;
    }
    let { default: LayerFloorInfoWrapper } = await import('./layerFloorInfo');
    let layerFloorInfoWrapper = new LayerFloorInfoWrapper(jsLayerFloorInfo);
    layerFloorInfoWrapper.geoBlazorId = dotNetObject.id;
    layerFloorInfoWrapper.viewId = viewId;
    layerFloorInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(layerFloorInfoWrapper);
    jsObjectRefs[dotNetObject.id] = layerFloorInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsLayerFloorInfo;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for LayerFloorInfo', e);
    }
    
    return jsLayerFloorInfo;
}

export async function buildDotNetLayerFloorInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetLayerFloorInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.floorField)) {
            dotNetLayerFloorInfo.floorField = jsObject.floorField;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetLayerFloorInfo.id = k;
                break;
            }
        }
    }

    return dotNetLayerFloorInfo;
}

