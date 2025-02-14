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
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async intersection(timeExtent: any): Promise<any> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        let jsTimeExtent = await buildJsTimeExtent(timeExtent, this.layerId, this.viewId) as any;
        let result = this.component.intersection(jsTimeExtent);
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return buildDotNetTimeExtent(result);
    }

    async union(timeExtent: any): Promise<any> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        let jsTimeExtent = await buildJsTimeExtent(timeExtent, this.layerId, this.viewId) as any;
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
    jsObjectRefs[dotNetObject.id] = timeExtentWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsTimeExtent;
    
    let dnInstantiatedObject = buildDotNetTimeExtent(jsTimeExtent);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for TimeExtent', e);
    }
    
    return jsTimeExtent;
}

