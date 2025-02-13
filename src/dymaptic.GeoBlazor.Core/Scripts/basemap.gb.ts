// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import Basemap from '@arcgis/core/Basemap';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class BasemapGenerated implements IPropertyWrapper {
    public component: Basemap;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: Basemap) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async loadAll(): Promise<any> {
        let result = await this.component.loadAll();
        let { buildDotNetBasemap } = await import('./basemap');
        return await buildDotNetBasemap(result);
    }

    // region properties
    
    async getBaseLayers(): Promise<any> {
        let { buildDotNetLayer } = await import('./layer');
        return this.component.baseLayers.map(async i => await buildDotNetLayer(i));
    }
    
    async setBaseLayers(value: any): Promise<void> {
        let { buildJsLayer } = await import('./layer');
        this.component.baseLayers = value.map(async i => await buildJsLayer(i, this.layerId, this.viewId));
    }
    
    async getPortalItem(): Promise<any> {
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.component.portalItem);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.component.portalItem = await  buildJsPortalItem(value, this.layerId, this.viewId);
    }
    async getReferenceLayers(): Promise<any> {
        let { buildDotNetLayer } = await import('./layer');
        return this.component.referenceLayers.map(async i => await buildDotNetLayer(i));
    }
    
    async setReferenceLayers(value: any): Promise<void> {
        let { buildJsLayer } = await import('./layer');
        this.component.referenceLayers = value.map(async i => await buildJsLayer(i, this.layerId, this.viewId));
    }
    
    async getStyle(): Promise<any> {
        let { buildDotNetBasemapStyle } = await import('./basemapStyle');
        return await buildDotNetBasemapStyle(this.component.style);
    }
    async setStyle(value: any): Promise<void> {
        let { buildJsBasemapStyle } = await import('./basemapStyle');
        this.component.style = await  buildJsBasemapStyle(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsBasemapGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsBasemap = new Basemap();
    if (hasValue(dotNetObject.baseLayers)) {
        let { buildJsLayer } = await import('./layer');
        jsBasemap.baseLayers = await Promise.all(dotNetObject.baseLayers.map(async i => await buildJsLayer(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsBasemap.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.referenceLayers)) {
        let { buildJsLayer } = await import('./layer');
        jsBasemap.referenceLayers = await Promise.all(dotNetObject.referenceLayers.map(async i => await buildJsLayer(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.style)) {
        let { buildJsBasemapStyle } = await import('./basemapStyle');
        jsBasemap.style = await buildJsBasemapStyle(dotNetObject.style, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.basemapId)) {
        jsBasemap.id = dotNetObject.basemapId;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        jsBasemap.spatialReference = dotNetObject.spatialReference;
    }
    if (hasValue(dotNetObject.thumbnailUrl)) {
        jsBasemap.thumbnailUrl = dotNetObject.thumbnailUrl;
    }
    if (hasValue(dotNetObject.title)) {
        jsBasemap.title = dotNetObject.title;
    }
    let { default: BasemapWrapper } = await import('./basemap');
    let basemapWrapper = new BasemapWrapper(jsBasemap);
    basemapWrapper.geoBlazorId = dotNetObject.id;
    basemapWrapper.viewId = viewId;
    basemapWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(basemapWrapper);
    jsObjectRefs[dotNetObject.id] = basemapWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsBasemap;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for Basemap', e);
    }
    
    return jsBasemap;
}

export async function buildDotNetBasemapGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetBasemap: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.baseLayers)) {
            let { buildDotNetLayer } = await import('./layer');
            dotNetBasemap.baseLayers = await Promise.all(jsObject.baseLayers.map(async i => await buildDotNetLayer(i)));
        }
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetBasemap.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.referenceLayers)) {
            let { buildDotNetLayer } = await import('./layer');
            dotNetBasemap.referenceLayers = await Promise.all(jsObject.referenceLayers.map(async i => await buildDotNetLayer(i)));
        }
        if (hasValue(jsObject.style)) {
            let { buildDotNetBasemapStyle } = await import('./basemapStyle');
            dotNetBasemap.style = await buildDotNetBasemapStyle(jsObject.style);
        }
        if (hasValue(jsObject.id)) {
            dotNetBasemap.basemapId = jsObject.id;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetBasemap.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.spatialReference)) {
            dotNetBasemap.spatialReference = jsObject.spatialReference;
        }
        if (hasValue(jsObject.thumbnailUrl)) {
            dotNetBasemap.thumbnailUrl = jsObject.thumbnailUrl;
        }
        if (hasValue(jsObject.title)) {
            dotNetBasemap.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetBasemap.id = k;
                break;
            }
        }
    }

    return dotNetBasemap;
}

