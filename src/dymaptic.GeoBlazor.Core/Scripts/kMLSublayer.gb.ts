// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import KMLSublayer from '@arcgis/core/layers/support/KMLSublayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class KMLSublayerGenerated implements IPropertyWrapper {
    public component: KMLSublayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: KMLSublayer) {
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
        
        let { buildDotNetKMLLayer } = await import('./kMLLayer');
        return await buildDotNetKMLLayer(this.component.layer);
    }
    async setLayer(value: any): Promise<void> {
        let { buildJsKMLLayer } = await import('./kMLLayer');
        this.component.layer = await  buildJsKMLLayer(value, this.layerId, this.viewId);
    }
    async getSublayers(): Promise<any> {
        if (!hasValue(this.component.sublayers)) {
            return null;
        }
        
        let { buildDotNetKMLSublayer } = await import('./kMLSublayer');
        return await Promise.all(this.component.sublayers.map(async i => await buildDotNetKMLSublayer(i)));
    }
    
    async setSublayers(value: any): Promise<void> {
        let { buildJsKMLSublayer } = await import('./kMLSublayer');
        this.component.sublayers = await Promise.all(value.map(async i => await buildJsKMLSublayer(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsKMLSublayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsKMLSublayer = new KMLSublayer();

    if (hasValue(dotNetObject.description)) {
        jsKMLSublayer.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.kMLSublayerId)) {
        jsKMLSublayer.id = dotNetObject.kMLSublayerId;
    }
    if (hasValue(dotNetObject.networkLink)) {
        jsKMLSublayer.networkLink = dotNetObject.networkLink;
    }
    if (hasValue(dotNetObject.title)) {
        jsKMLSublayer.title = dotNetObject.title;
    }
    let { default: KMLSublayerWrapper } = await import('./kMLSublayer');
    let kMLSublayerWrapper = new KMLSublayerWrapper(jsKMLSublayer);
    kMLSublayerWrapper.geoBlazorId = dotNetObject.id;
    kMLSublayerWrapper.viewId = viewId;
    kMLSublayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(kMLSublayerWrapper);
    jsObjectRefs[dotNetObject.id] = kMLSublayerWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsKMLSublayer;
    
    let { buildDotNetKMLSublayer } = await import('./kMLSublayer');
    let dnInstantiatedObject = await buildDotNetKMLSublayer(jsKMLSublayer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for KMLSublayer', e);
    }
    
    return jsKMLSublayer;
}

export async function buildDotNetKMLSublayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetKMLSublayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.description)) {
            dotNetKMLSublayer.description = jsObject.description;
        }
        if (hasValue(jsObject.id)) {
            dotNetKMLSublayer.kMLSublayerId = jsObject.id;
        }
        if (hasValue(jsObject.networkLink)) {
            dotNetKMLSublayer.networkLink = jsObject.networkLink;
        }
        if (hasValue(jsObject.sourceJSON)) {
            dotNetKMLSublayer.sourceJSON = jsObject.sourceJSON;
        }
        if (hasValue(jsObject.title)) {
            dotNetKMLSublayer.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetKMLSublayer.id = k;
                break;
            }
        }
    }

    return dotNetKMLSublayer;
}

