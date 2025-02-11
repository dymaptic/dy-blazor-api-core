// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import PortalFolder from '@arcgis/core/portal/PortalFolder';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class PortalFolderGenerated implements IPropertyWrapper {
    public component: PortalFolder;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: PortalFolder) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getPortal(): Promise<any> {
        let { buildDotNetPortal } = await import('./portal');
        return await buildDotNetPortal(this.component.portal, this.layerId, this.viewId);
    }
    async setPortal(value: any): Promise<void> {
        let { buildJsPortal } = await import('./portal');
        this.component.portal = await  buildJsPortal(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsPortalFolderGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsPortalFolder = new PortalFolder();

    if (hasValue(dotNetObject.created)) {
        jsPortalFolder.created = dotNetObject.created;
    }
    if (hasValue(dotNetObject.portalFolderId)) {
        jsPortalFolder.id = dotNetObject.portalFolderId;
    }
    if (hasValue(dotNetObject.title)) {
        jsPortalFolder.title = dotNetObject.title;
    }
    let { default: PortalFolderWrapper } = await import('./portalFolder');
    let portalFolderWrapper = new PortalFolderWrapper(jsPortalFolder);
    portalFolderWrapper.geoBlazorId = dotNetObject.id;
    portalFolderWrapper.viewId = viewId;
    portalFolderWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(portalFolderWrapper);
    jsObjectRefs[dotNetObject.id] = portalFolderWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsPortalFolder;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for PortalFolder', e);
    }
    
    return jsPortalFolder;
}

export async function buildDotNetPortalFolderGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetPortalFolder: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.created)) {
            dotNetPortalFolder.created = jsObject.created;
        }
        if (hasValue(jsObject.id)) {
            dotNetPortalFolder.portalFolderId = jsObject.id;
        }
        if (hasValue(jsObject.title)) {
            dotNetPortalFolder.title = jsObject.title;
        }
        if (hasValue(jsObject.url)) {
            dotNetPortalFolder.url = jsObject.url;
        }

    return dotNetPortalFolder;
}

