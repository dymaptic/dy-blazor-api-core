// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import LayerView from '@arcgis/core/views/layers/LayerView';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class LayerViewGenerated implements IPropertyWrapper {
    public component: LayerView;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: LayerView) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getLayer(): Promise<any> {
        if (!hasValue(this.component.layer)) {
            return null;
        }
        
        let { buildDotNetLayer } = await import('./layer');
        return await buildDotNetLayer(this.component.layer);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsLayerViewGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsLayerView = new LayerView();

    let { default: LayerViewWrapper } = await import('./layerView');
    let layerViewWrapper = new LayerViewWrapper(jsLayerView);
    layerViewWrapper.geoBlazorId = dotNetObject.id;
    layerViewWrapper.viewId = viewId;
    layerViewWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(layerViewWrapper);
    jsObjectRefs[dotNetObject.id] = layerViewWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsLayerView;
    
    let dnInstantiatedObject = await buildDotNetLayerView(jsLayerView);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for LayerView', e);
    }
    
    return jsLayerView;
}

export async function buildDotNetLayerViewGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetLayerView: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.layer)) {
            let { buildDotNetLayer } = await import('./layer');
            dotNetLayerView.layer = await buildDotNetLayer(jsObject.layer);
        }
        if (hasValue(jsObject.spatialReferenceSupported)) {
            dotNetLayerView.spatialReferenceSupported = jsObject.spatialReferenceSupported;
        }
        if (hasValue(jsObject.suspended)) {
            dotNetLayerView.suspended = jsObject.suspended;
        }
        if (hasValue(jsObject.updating)) {
            dotNetLayerView.updating = jsObject.updating;
        }
        if (hasValue(jsObject.view)) {
            dotNetLayerView.view = jsObject.view;
        }
        if (hasValue(jsObject.visibleAtCurrentScale)) {
            dotNetLayerView.visibleAtCurrentScale = jsObject.visibleAtCurrentScale;
        }
        if (hasValue(jsObject.visibleAtCurrentTimeExtent)) {
            dotNetLayerView.visibleAtCurrentTimeExtent = jsObject.visibleAtCurrentTimeExtent;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetLayerView.id = k;
                break;
            }
        }
    }

    return dotNetLayerView;
}

