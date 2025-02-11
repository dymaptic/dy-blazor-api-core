// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import LineSymbolMarker from '@arcgis/core/symbols/LineSymbolMarker';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class LineSymbolMarkerGenerated implements IPropertyWrapper {
    public component: LineSymbolMarker;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: LineSymbolMarker) {
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

export async function buildJsLineSymbolMarkerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsLineSymbolMarker = new LineSymbolMarker();

    if (hasValue(dotNetObject.color)) {
        jsLineSymbolMarker.color = dotNetObject.color;
    }
    if (hasValue(dotNetObject.placement)) {
        jsLineSymbolMarker.placement = dotNetObject.placement;
    }
    if (hasValue(dotNetObject.style)) {
        jsLineSymbolMarker.style = dotNetObject.style;
    }
    let { default: LineSymbolMarkerWrapper } = await import('./lineSymbolMarker');
    let lineSymbolMarkerWrapper = new LineSymbolMarkerWrapper(jsLineSymbolMarker);
    lineSymbolMarkerWrapper.geoBlazorId = dotNetObject.id;
    lineSymbolMarkerWrapper.viewId = viewId;
    lineSymbolMarkerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(lineSymbolMarkerWrapper);
    jsObjectRefs[dotNetObject.id] = lineSymbolMarkerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsLineSymbolMarker;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for LineSymbolMarker', e);
    }
    
    return jsLineSymbolMarker;
}

export async function buildDotNetLineSymbolMarkerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetLineSymbolMarker: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.color)) {
            dotNetLineSymbolMarker.color = jsObject.color;
        }
        if (hasValue(jsObject.placement)) {
            dotNetLineSymbolMarker.placement = jsObject.placement;
        }
        if (hasValue(jsObject.style)) {
            dotNetLineSymbolMarker.style = jsObject.style;
        }
        if (hasValue(jsObject.type)) {
            dotNetLineSymbolMarker.type = jsObject.type;
        }

    return dotNetLineSymbolMarker;
}

