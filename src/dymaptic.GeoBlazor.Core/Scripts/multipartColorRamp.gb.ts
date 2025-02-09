// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import MultipartColorRamp from '@arcgis/core/rest/support/MultipartColorRamp';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class MultipartColorRampGenerated implements IPropertyWrapper {
    public component: MultipartColorRamp;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: MultipartColorRamp) {
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
    
    async getColorRamps(): Promise<any> {
        let { buildDotNetAlgorithmicColorRamp } = await import('./algorithmicColorRamp');
        return this.component.colorRamps.map(async i => await buildDotNetAlgorithmicColorRamp(i));
    }
    
    async setColorRamps(value: any): Promise<void> {
        let { buildJsAlgorithmicColorRamp } = await import('./algorithmicColorRamp');
        this.component.colorRamps = value.map(i => buildJsAlgorithmicColorRamp(i));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsMultipartColorRampGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsMultipartColorRamp = new MultipartColorRamp();
    if (hasValue(dotNetObject.colorRamps)) {
        let { buildJsAlgorithmicColorRamp } = await import('./jsBuilder');
        jsMultipartColorRamp.colorRamps = dotNetObject.colorRamps.map(i => buildJsAlgorithmicColorRamp(i)) as any;
    }

    let { default: MultipartColorRampWrapper } = await import('./multipartColorRamp');
    let multipartColorRampWrapper = new MultipartColorRampWrapper(jsMultipartColorRamp);
    multipartColorRampWrapper.geoBlazorId = dotNetObject.id;
    multipartColorRampWrapper.viewId = viewId;
    multipartColorRampWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(multipartColorRampWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = multipartColorRampWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsMultipartColorRamp;
    
    return jsMultipartColorRamp;
}

export async function buildDotNetMultipartColorRampGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetMultipartColorRamp: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.colorRamps)) {
            let { buildDotNetAlgorithmicColorRamp } = await import('./algorithmicColorRamp');
            dotNetMultipartColorRamp.colorRamps = jsObject.colorRamps.map(async i => await buildDotNetAlgorithmicColorRamp(i));
        }
        dotNetMultipartColorRamp.type = jsObject.type;

    return dotNetMultipartColorRamp;
}

