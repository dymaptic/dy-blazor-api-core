// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import AlgorithmicColorRamp from '@arcgis/core/rest/support/AlgorithmicColorRamp';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class AlgorithmicColorRampGenerated implements IPropertyWrapper {
    public component: AlgorithmicColorRamp;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: AlgorithmicColorRamp) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getFromColor(): Promise<any> {
        let { buildDotNetMapColor } = await import('./mapColor');
        return buildDotNetMapColor(this.component.fromColor);
    }
    async setFromColor(value: any): Promise<void> {
        let { buildJsMapColor } = await import('./mapColor');
        this.component.fromColor =  buildJsMapColor(value);
    }
    async getToColor(): Promise<any> {
        let { buildDotNetMapColor } = await import('./mapColor');
        return buildDotNetMapColor(this.component.toColor);
    }
    async setToColor(value: any): Promise<void> {
        let { buildJsMapColor } = await import('./mapColor');
        this.component.toColor =  buildJsMapColor(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsAlgorithmicColorRampGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsAlgorithmicColorRamp = new AlgorithmicColorRamp();
    if (hasValue(dotNetObject.fromColor)) {
        let { buildJsMapColor } = await import('./mapColor');
        jsAlgorithmicColorRamp.fromColor = buildJsMapColor(dotNetObject.fromColor) as any;
    }
    if (hasValue(dotNetObject.toColor)) {
        let { buildJsMapColor } = await import('./mapColor');
        jsAlgorithmicColorRamp.toColor = buildJsMapColor(dotNetObject.toColor) as any;
    }

    if (hasValue(dotNetObject.algorithm)) {
        jsAlgorithmicColorRamp.algorithm = dotNetObject.algorithm;
    }
    let { default: AlgorithmicColorRampWrapper } = await import('./algorithmicColorRamp');
    let algorithmicColorRampWrapper = new AlgorithmicColorRampWrapper(jsAlgorithmicColorRamp);
    algorithmicColorRampWrapper.geoBlazorId = dotNetObject.id;
    algorithmicColorRampWrapper.viewId = viewId;
    algorithmicColorRampWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(algorithmicColorRampWrapper);
    jsObjectRefs[dotNetObject.id] = algorithmicColorRampWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsAlgorithmicColorRamp;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for AlgorithmicColorRamp', e);
    }
    
    return jsAlgorithmicColorRamp;
}

export async function buildDotNetAlgorithmicColorRampGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetAlgorithmicColorRamp: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.fromColor)) {
            let { buildDotNetMapColor } = await import('./mapColor');
            dotNetAlgorithmicColorRamp.fromColor = buildDotNetMapColor(jsObject.fromColor);
        }
        if (hasValue(jsObject.toColor)) {
            let { buildDotNetMapColor } = await import('./mapColor');
            dotNetAlgorithmicColorRamp.toColor = buildDotNetMapColor(jsObject.toColor);
        }
        if (hasValue(jsObject.algorithm)) {
            dotNetAlgorithmicColorRamp.algorithm = jsObject.algorithm;
        }
        if (hasValue(jsObject.type)) {
            dotNetAlgorithmicColorRamp.type = jsObject.type;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetAlgorithmicColorRamp.id = k;
                break;
            }
        }
    }

    return dotNetAlgorithmicColorRamp;
}

