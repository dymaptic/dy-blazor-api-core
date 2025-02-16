// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import TimeInterval from '@arcgis/core/TimeInterval';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class TimeIntervalGenerated implements IPropertyWrapper {
    public component: TimeInterval;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: TimeInterval) {
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

export async function buildJsTimeIntervalGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsTimeInterval = new TimeInterval();

    if (hasValue(dotNetObject.unit)) {
        jsTimeInterval.unit = dotNetObject.unit;
    }
    if (hasValue(dotNetObject.value)) {
        jsTimeInterval.value = dotNetObject.value;
    }
    let { default: TimeIntervalWrapper } = await import('./timeInterval');
    let timeIntervalWrapper = new TimeIntervalWrapper(jsTimeInterval);
    timeIntervalWrapper.geoBlazorId = dotNetObject.id;
    timeIntervalWrapper.viewId = viewId;
    timeIntervalWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(timeIntervalWrapper);
    jsObjectRefs[dotNetObject.id] = timeIntervalWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsTimeInterval;
    
    let { buildDotNetTimeInterval } = await import('./timeInterval');
    let dnInstantiatedObject = await buildDotNetTimeInterval(jsTimeInterval);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for TimeInterval', e);
    }
    
    return jsTimeInterval;
}

export async function buildDotNetTimeIntervalGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetTimeInterval: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.unit)) {
            dotNetTimeInterval.unit = jsObject.unit;
        }
        if (hasValue(jsObject.value)) {
            dotNetTimeInterval.value = jsObject.value;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetTimeInterval.id = k;
                break;
            }
        }
    }

    return dotNetTimeInterval;
}

