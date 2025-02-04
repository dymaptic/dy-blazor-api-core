// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import TimeExtent from '@arcgis/core/TimeExtent';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class TimeExtentGenerated implements IPropertyWrapper {
    public component: TimeExtent;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: TimeExtent) {
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
    
    async intersection(timeExtent: any): Promise<any> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        let jsTimeExtent = await buildJsTimeExtent(timeExtent, layerId, viewId) as any;
        let result = this.component.intersection(jsTimeExtent);
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return buildDotNetTimeExtent(result);
    }

    async union(timeExtent: any): Promise<any> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        let jsTimeExtent = await buildJsTimeExtent(timeExtent, layerId, viewId) as any;
        let result = this.component.union(jsTimeExtent);
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return buildDotNetTimeExtent(result);
    }

    // region properties
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsTimeExtentGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { default: TimeExtent } = await import('@arcgis/core/TimeExtent');
    let jsTimeExtent = new TimeExtent();
    if (hasValue(dotNetObject.end)) {
        jsTimeExtent.end = dotNetObject.end;
    }
    if (hasValue(dotNetObject.start)) {
        jsTimeExtent.start = dotNetObject.start;
    }
    let { default: TimeExtentWrapper } = await import('./timeExtent');
    let timeExtentWrapper = new TimeExtentWrapper(jsTimeExtent);
    timeExtentWrapper.geoBlazorId = dotNetObject.id;
    timeExtentWrapper.viewId = viewId;
    timeExtentWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(timeExtentWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = timeExtentWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsTimeExtent;
    
    return jsTimeExtent;
}

export async function buildDotNetTimeExtentGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetTimeExtent: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        dotNetTimeExtent.end = jsObject.end;
        dotNetTimeExtent.start = jsObject.start;
    return dotNetTimeExtent;
}

