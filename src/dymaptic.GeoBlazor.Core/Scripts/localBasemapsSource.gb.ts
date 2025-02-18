// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import LocalBasemapsSource from '@arcgis/core/widgets/BasemapGallery/support/LocalBasemapsSource';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class LocalBasemapsSourceGenerated implements IPropertyWrapper {
    public component: LocalBasemapsSource;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: LocalBasemapsSource) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getBasemaps(): Promise<any> {
        if (!hasValue(this.component.basemaps)) {
            return null;
        }
        
        let { buildDotNetBasemap } = await import('./basemap');
        return await Promise.all(this.component.basemaps.map(async i => await buildDotNetBasemap(i)));
    }
    
    async setBasemaps(value: any): Promise<void> {
        let { buildJsBasemap } = await import('./basemap');
        this.component.basemaps = await Promise.all(value.map(async i => await buildJsBasemap(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsLocalBasemapsSourceGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsLocalBasemapsSource = new LocalBasemapsSource();
    if (hasValue(dotNetObject.basemaps)) {
        let { buildJsBasemap } = await import('./basemap');
        jsLocalBasemapsSource.basemaps = await Promise.all(dotNetObject.basemaps.map(async i => await buildJsBasemap(i, layerId, viewId))) as any;
    }

    let { default: LocalBasemapsSourceWrapper } = await import('./localBasemapsSource');
    let localBasemapsSourceWrapper = new LocalBasemapsSourceWrapper(jsLocalBasemapsSource);
    localBasemapsSourceWrapper.geoBlazorId = dotNetObject.id;
    localBasemapsSourceWrapper.viewId = viewId;
    localBasemapsSourceWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(localBasemapsSourceWrapper);
    jsObjectRefs[dotNetObject.id] = localBasemapsSourceWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsLocalBasemapsSource;
    let { buildDotNetLocalBasemapsSource } = await import('./localBasemapsSource');
    let dnInstantiatedObject = await buildDotNetLocalBasemapsSource(jsLocalBasemapsSource, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for LocalBasemapsSource', e);
    }
    
    return jsLocalBasemapsSource;
}

export async function buildDotNetLocalBasemapsSourceGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetLocalBasemapsSource: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.basemaps)) {
            let { buildDotNetBasemap } = await import('./basemap');
            dotNetLocalBasemapsSource.basemaps = await Promise.all(jsObject.basemaps.map(async i => await buildDotNetBasemap(i)));
        }
        if (hasValue(jsObject.state)) {
            dotNetLocalBasemapsSource.state = jsObject.state;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetLocalBasemapsSource.id = k;
                break;
            }
        }
    }

    return dotNetLocalBasemapsSource;
}

