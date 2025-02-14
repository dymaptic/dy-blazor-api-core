// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import UniqueValueRendererLegendOptions = __esri.UniqueValueRendererLegendOptions;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class UniqueValueRendererLegendOptionsGenerated implements IPropertyWrapper {
    public component: UniqueValueRendererLegendOptions;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: UniqueValueRendererLegendOptions) {
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

export async function buildJsUniqueValueRendererLegendOptionsGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsUniqueValueRendererLegendOptions: any = {}

    if (hasValue(dotNetObject.title)) {
        jsUniqueValueRendererLegendOptions.title = dotNetObject.title;
    }
    let { default: UniqueValueRendererLegendOptionsWrapper } = await import('./uniqueValueRendererLegendOptions');
    let uniqueValueRendererLegendOptionsWrapper = new UniqueValueRendererLegendOptionsWrapper(jsUniqueValueRendererLegendOptions);
    uniqueValueRendererLegendOptionsWrapper.geoBlazorId = dotNetObject.id;
    uniqueValueRendererLegendOptionsWrapper.viewId = viewId;
    uniqueValueRendererLegendOptionsWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(uniqueValueRendererLegendOptionsWrapper);
    jsObjectRefs[dotNetObject.id] = uniqueValueRendererLegendOptionsWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsUniqueValueRendererLegendOptions;
    
    let dnInstantiatedObject = await buildDotNetUniqueValueRendererLegendOptions(jsUniqueValueRendererLegendOptions);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for UniqueValueRendererLegendOptions', e);
    }
    
    return jsUniqueValueRendererLegendOptions;
}

export async function buildDotNetUniqueValueRendererLegendOptionsGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetUniqueValueRendererLegendOptions: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.title)) {
            dotNetUniqueValueRendererLegendOptions.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetUniqueValueRendererLegendOptions.id = k;
                break;
            }
        }
    }

    return dotNetUniqueValueRendererLegendOptions;
}

