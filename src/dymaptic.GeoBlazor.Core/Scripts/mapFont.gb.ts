// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import Font from '@arcgis/core/symbols/Font';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class MapFontGenerated implements IPropertyWrapper {
    public component: Font;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: Font) {
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

export async function buildJsMapFontGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFont = new Font();

    if (hasValue(dotNetObject.decoration)) {
        jsFont.decoration = dotNetObject.decoration;
    }
    if (hasValue(dotNetObject.family)) {
        jsFont.family = dotNetObject.family;
    }
    if (hasValue(dotNetObject.size)) {
        jsFont.size = dotNetObject.size;
    }
    if (hasValue(dotNetObject.style)) {
        jsFont.style = dotNetObject.style;
    }
    if (hasValue(dotNetObject.weight)) {
        jsFont.weight = dotNetObject.weight;
    }
    let { default: MapFontWrapper } = await import('./mapFont');
    let mapFontWrapper = new MapFontWrapper(jsFont);
    mapFontWrapper.geoBlazorId = dotNetObject.id;
    mapFontWrapper.viewId = viewId;
    mapFontWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(mapFontWrapper);
    jsObjectRefs[dotNetObject.id] = mapFontWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsFont;
    
    let { buildDotNetMapFont } = await import('./mapFont');
    let dnInstantiatedObject = await buildDotNetMapFont(jsFont);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for MapFont', e);
    }
    
    return jsFont;
}

export async function buildDotNetMapFontGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetMapFont: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.decoration)) {
            dotNetMapFont.decoration = jsObject.decoration;
        }
        if (hasValue(jsObject.family)) {
            dotNetMapFont.family = jsObject.family;
        }
        if (hasValue(jsObject.size)) {
            dotNetMapFont.size = jsObject.size;
        }
        if (hasValue(jsObject.style)) {
            dotNetMapFont.style = jsObject.style;
        }
        if (hasValue(jsObject.weight)) {
            dotNetMapFont.weight = jsObject.weight;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetMapFont.id = k;
                break;
            }
        }
    }

    return dotNetMapFont;
}

