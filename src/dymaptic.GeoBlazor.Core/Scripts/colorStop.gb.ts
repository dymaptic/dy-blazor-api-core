// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ColorStop from '@arcgis/core/renderers/visualVariables/support/ColorStop';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ColorStopGenerated implements IPropertyWrapper {
    public component: ColorStop;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ColorStop) {
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

export async function buildJsColorStopGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsColorStop = new ColorStop();

    if (hasValue(dotNetObject.color)) {
        jsColorStop.color = dotNetObject.color;
    }
    if (hasValue(dotNetObject.label)) {
        jsColorStop.label = dotNetObject.label;
    }
    if (hasValue(dotNetObject.value)) {
        jsColorStop.value = dotNetObject.value;
    }
    let { default: ColorStopWrapper } = await import('./colorStop');
    let colorStopWrapper = new ColorStopWrapper(jsColorStop);
    colorStopWrapper.geoBlazorId = dotNetObject.id;
    colorStopWrapper.viewId = viewId;
    colorStopWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(colorStopWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = colorStopWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsColorStop;
    
    return jsColorStop;
}

export async function buildDotNetColorStopGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetColorStop: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        dotNetColorStop.color = jsObject.color;
        dotNetColorStop.label = jsObject.label;
        dotNetColorStop.value = jsObject.value;

    return dotNetColorStop;
}

