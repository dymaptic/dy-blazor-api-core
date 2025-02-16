// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import WebMap from '@arcgis/core/WebMap';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class WebMapGenerated implements IPropertyWrapper {
    public component: WebMap;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: WebMap) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async load(): Promise<any> {
        return await this.component.load();
    }

    async loadAll(): Promise<any> {
        let result = await this.component.loadAll();
        let { buildDotNetWebMap } = await import('./webMap');
        return await buildDotNetWebMap(result, this.layerId, this.viewId);
    }

    async save(options: any): Promise<any> {
        let result = await this.component.save(options);
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(result);
    }

    async saveAs(portalItem: any,
        options: any): Promise<any> {
        let { buildJsPortalItem } = await import('./portalItem');
        let jsPortalItem = await buildJsPortalItem(portalItem, this.layerId, this.viewId) as any;
        let result = await this.component.saveAs(jsPortalItem,
            options);
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(result);
    }

    async updateFrom(view: any,
        options: any): Promise<any> {
        return await this.component.updateFrom(view,
            options);
    }

    // region properties
    
    async getPortalItem(): Promise<any> {
        if (!hasValue(this.component.portalItem)) {
            return null;
        }
        
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(this.component.portalItem);
    }
    async setPortalItem(value: any): Promise<void> {
        let { buildJsPortalItem } = await import('./portalItem');
        this.component.portalItem = await  buildJsPortalItem(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsWebMapGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsWebMap = new WebMap();
    if (hasValue(dotNetObject.portalItem)) {
        let { buildJsPortalItem } = await import('./portalItem');
        jsWebMap.portalItem = await buildJsPortalItem(dotNetObject.portalItem, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.applicationProperties)) {
        jsWebMap.applicationProperties = dotNetObject.applicationProperties;
    }
    if (hasValue(dotNetObject.authoringApp)) {
        jsWebMap.authoringApp = dotNetObject.authoringApp;
    }
    if (hasValue(dotNetObject.authoringAppVersion)) {
        jsWebMap.authoringAppVersion = dotNetObject.authoringAppVersion;
    }
    if (hasValue(dotNetObject.bookmarks)) {
        jsWebMap.bookmarks = dotNetObject.bookmarks;
    }
    if (hasValue(dotNetObject.floorInfo)) {
        jsWebMap.floorInfo = dotNetObject.floorInfo;
    }
    if (hasValue(dotNetObject.geotriggersInfo)) {
        jsWebMap.geotriggersInfo = dotNetObject.geotriggersInfo;
    }
    if (hasValue(dotNetObject.initialViewProperties)) {
        jsWebMap.initialViewProperties = dotNetObject.initialViewProperties;
    }
    if (hasValue(dotNetObject.presentation)) {
        jsWebMap.presentation = dotNetObject.presentation;
    }
    if (hasValue(dotNetObject.thumbnailUrl)) {
        jsWebMap.thumbnailUrl = dotNetObject.thumbnailUrl;
    }
    if (hasValue(dotNetObject.utilityNetworks)) {
        jsWebMap.utilityNetworks = dotNetObject.utilityNetworks;
    }
    if (hasValue(dotNetObject.widgets)) {
        jsWebMap.widgets = dotNetObject.widgets;
    }
    let { default: WebMapWrapper } = await import('./webMap');
    let webMapWrapper = new WebMapWrapper(jsWebMap);
    webMapWrapper.geoBlazorId = dotNetObject.id;
    webMapWrapper.viewId = viewId;
    webMapWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(webMapWrapper);
    jsObjectRefs[dotNetObject.id] = webMapWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsWebMap;
    
    let { buildDotNetWebMap } = await import('./webMap');
    let dnInstantiatedObject = await buildDotNetWebMap(jsWebMap, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for WebMap', e);
    }
    
    return jsWebMap;
}

export async function buildDotNetWebMapGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetWebMap: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.portalItem)) {
            let { buildDotNetPortalItem } = await import('./portalItem');
            dotNetWebMap.portalItem = await buildDotNetPortalItem(jsObject.portalItem);
        }
        if (hasValue(jsObject.applicationProperties)) {
            dotNetWebMap.applicationProperties = jsObject.applicationProperties;
        }
        if (hasValue(jsObject.authoringApp)) {
            dotNetWebMap.authoringApp = jsObject.authoringApp;
        }
        if (hasValue(jsObject.authoringAppVersion)) {
            dotNetWebMap.authoringAppVersion = jsObject.authoringAppVersion;
        }
        if (hasValue(jsObject.bookmarks)) {
            dotNetWebMap.bookmarks = jsObject.bookmarks;
        }
        if (hasValue(jsObject.floorInfo)) {
            dotNetWebMap.floorInfo = jsObject.floorInfo;
        }
        if (hasValue(jsObject.geotriggersInfo)) {
            dotNetWebMap.geotriggersInfo = jsObject.geotriggersInfo;
        }
        if (hasValue(jsObject.initialViewProperties)) {
            dotNetWebMap.initialViewProperties = jsObject.initialViewProperties;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetWebMap.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.loadError)) {
            dotNetWebMap.loadError = jsObject.loadError;
        }
        if (hasValue(jsObject.loadStatus)) {
            dotNetWebMap.loadStatus = jsObject.loadStatus;
        }
        if (hasValue(jsObject.presentation)) {
            dotNetWebMap.presentation = jsObject.presentation;
        }
        if (hasValue(jsObject.sourceVersion)) {
            dotNetWebMap.sourceVersion = jsObject.sourceVersion;
        }
        if (hasValue(jsObject.thumbnailUrl)) {
            dotNetWebMap.thumbnailUrl = jsObject.thumbnailUrl;
        }
        if (hasValue(jsObject.utilityNetworks)) {
            dotNetWebMap.utilityNetworks = jsObject.utilityNetworks;
        }
        if (hasValue(jsObject.widgets)) {
            dotNetWebMap.widgets = jsObject.widgets;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetWebMap.id = k;
                break;
            }
        }
    }

    return dotNetWebMap;
}

