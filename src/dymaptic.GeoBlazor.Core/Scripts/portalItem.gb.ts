// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import PortalItem from '@arcgis/core/portal/PortalItem';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class PortalItemGenerated implements IPropertyWrapper {
    public component: PortalItem;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: PortalItem) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async addRating(rating: any): Promise<any> {
        return await this.component.addRating(rating);
    }

    async addResource(resource: any,
        content: any,
        options: any): Promise<any> {
        return await this.component.addResource(resource,
            content,
            options);
    }

    async deleteRating(): Promise<any> {
        return await this.component.deleteRating();
    }

    async fetchData(responseType: any,
        options: any): Promise<any> {
        return await this.component.fetchData(responseType,
            options);
    }

    async fetchRating(options: any): Promise<any> {
        return await this.component.fetchRating(options);
    }

    async fetchRelatedItems(relationshipType: any,
        direction: any,
        options: any): Promise<any> {
        let result = await this.component.fetchRelatedItems(relationshipType,
            direction,
            options);
        let { buildDotNetPortalItem } = await import('./portalItem');
        return result.map(async i => await buildDotNetPortalItem(i));
    }

    async fetchResources(num: any,
        start: any,
        sortOrder: any,
        sortField: any,
        options: any): Promise<any> {
        return await this.component.fetchResources(num,
            start,
            sortOrder,
            sortField,
            options);
    }

    async getThumbnailUrl(width: any): Promise<any> {
        return this.component.getThumbnailUrl(width);
    }

    async reload(): Promise<any> {
        let result = await this.component.reload();
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(result);
    }

    async removeAllResources(options: any): Promise<any> {
        return await this.component.removeAllResources(options);
    }

    async removeResource(resource: any,
        options: any): Promise<any> {
        return await this.component.removeResource(resource,
            options);
    }

    async update(data: any): Promise<any> {
        let result = await this.component.update(data);
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(result);
    }

    async updateThumbnail(thumbnail: any,
        filename: any): Promise<any> {
        let result = await this.component.updateThumbnail(thumbnail,
            filename);
        let { buildDotNetPortalItem } = await import('./portalItem');
        return await buildDotNetPortalItem(result);
    }

    // region properties
    
    async getPortal(): Promise<any> {
        let { buildDotNetPortal } = await import('./portal');
        return await buildDotNetPortal(this.component.portal);
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

export async function buildJsPortalItemGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsPortalItem = new PortalItem();
    if (hasValue(dotNetObject.portal)) {
        let { buildJsPortal } = await import('./portal');
        jsPortalItem.portal = await buildJsPortal(dotNetObject.portal, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.access)) {
        jsPortalItem.access = dotNetObject.access;
    }
    if (hasValue(dotNetObject.accessInformation)) {
        jsPortalItem.accessInformation = dotNetObject.accessInformation;
    }
    if (hasValue(dotNetObject.apiKey)) {
        jsPortalItem.apiKey = dotNetObject.apiKey;
    }
    if (hasValue(dotNetObject.avgRating)) {
        jsPortalItem.avgRating = dotNetObject.avgRating;
    }
    if (hasValue(dotNetObject.categories)) {
        jsPortalItem.categories = dotNetObject.categories;
    }
    if (hasValue(dotNetObject.created)) {
        jsPortalItem.created = dotNetObject.created;
    }
    if (hasValue(dotNetObject.culture)) {
        jsPortalItem.culture = dotNetObject.culture;
    }
    if (hasValue(dotNetObject.description)) {
        jsPortalItem.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.extent)) {
        jsPortalItem.extent = dotNetObject.extent;
    }
    if (hasValue(dotNetObject.groupCategories)) {
        jsPortalItem.groupCategories = dotNetObject.groupCategories;
    }
    if (hasValue(dotNetObject.licenseInfo)) {
        jsPortalItem.licenseInfo = dotNetObject.licenseInfo;
    }
    if (hasValue(dotNetObject.modified)) {
        jsPortalItem.modified = dotNetObject.modified;
    }
    if (hasValue(dotNetObject.name)) {
        jsPortalItem.name = dotNetObject.name;
    }
    if (hasValue(dotNetObject.numComments)) {
        jsPortalItem.numComments = dotNetObject.numComments;
    }
    if (hasValue(dotNetObject.numRatings)) {
        jsPortalItem.numRatings = dotNetObject.numRatings;
    }
    if (hasValue(dotNetObject.numViews)) {
        jsPortalItem.numViews = dotNetObject.numViews;
    }
    if (hasValue(dotNetObject.owner)) {
        jsPortalItem.owner = dotNetObject.owner;
    }
    if (hasValue(dotNetObject.ownerFolder)) {
        jsPortalItem.ownerFolder = dotNetObject.ownerFolder;
    }
    if (hasValue(dotNetObject.portalItemId)) {
        jsPortalItem.id = dotNetObject.portalItemId;
    }
    if (hasValue(dotNetObject.screenshots)) {
        jsPortalItem.screenshots = dotNetObject.screenshots;
    }
    if (hasValue(dotNetObject.size)) {
        jsPortalItem.size = dotNetObject.size;
    }
    if (hasValue(dotNetObject.snippet)) {
        jsPortalItem.snippet = dotNetObject.snippet;
    }
    if (hasValue(dotNetObject.tags)) {
        jsPortalItem.tags = dotNetObject.tags;
    }
    if (hasValue(dotNetObject.title)) {
        jsPortalItem.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.typeKeywords)) {
        jsPortalItem.typeKeywords = dotNetObject.typeKeywords;
    }
    if (hasValue(dotNetObject.url)) {
        jsPortalItem.url = dotNetObject.url;
    }
    let { default: PortalItemWrapper } = await import('./portalItem');
    let portalItemWrapper = new PortalItemWrapper(jsPortalItem);
    portalItemWrapper.geoBlazorId = dotNetObject.id;
    portalItemWrapper.viewId = viewId;
    portalItemWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(portalItemWrapper);
    jsObjectRefs[dotNetObject.id] = portalItemWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsPortalItem;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for PortalItem', e);
    }
    
    return jsPortalItem;
}

export async function buildDotNetPortalItemGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetPortalItem: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.portal)) {
            let { buildDotNetPortal } = await import('./portal');
            dotNetPortalItem.portal = await buildDotNetPortal(jsObject.portal);
        }
        if (hasValue(jsObject.access)) {
            dotNetPortalItem.access = jsObject.access;
        }
        if (hasValue(jsObject.accessInformation)) {
            dotNetPortalItem.accessInformation = jsObject.accessInformation;
        }
        if (hasValue(jsObject.apiKey)) {
            dotNetPortalItem.apiKey = jsObject.apiKey;
        }
        if (hasValue(jsObject.applicationProxies)) {
            dotNetPortalItem.applicationProxies = jsObject.applicationProxies;
        }
        if (hasValue(jsObject.avgRating)) {
            dotNetPortalItem.avgRating = jsObject.avgRating;
        }
        if (hasValue(jsObject.categories)) {
            dotNetPortalItem.categories = jsObject.categories;
        }
        if (hasValue(jsObject.created)) {
            dotNetPortalItem.created = jsObject.created;
        }
        if (hasValue(jsObject.culture)) {
            dotNetPortalItem.culture = jsObject.culture;
        }
        if (hasValue(jsObject.description)) {
            dotNetPortalItem.description = jsObject.description;
        }
        if (hasValue(jsObject.extent)) {
            dotNetPortalItem.extent = jsObject.extent;
        }
        if (hasValue(jsObject.groupCategories)) {
            dotNetPortalItem.groupCategories = jsObject.groupCategories;
        }
        if (hasValue(jsObject.isLayer)) {
            dotNetPortalItem.isLayer = jsObject.isLayer;
        }
        if (hasValue(jsObject.isOrgItem)) {
            dotNetPortalItem.isOrgItem = jsObject.isOrgItem;
        }
        if (hasValue(jsObject.itemControl)) {
            dotNetPortalItem.itemControl = jsObject.itemControl;
        }
        if (hasValue(jsObject.itemPageUrl)) {
            dotNetPortalItem.itemPageUrl = jsObject.itemPageUrl;
        }
        if (hasValue(jsObject.itemUrl)) {
            dotNetPortalItem.itemUrl = jsObject.itemUrl;
        }
        if (hasValue(jsObject.licenseInfo)) {
            dotNetPortalItem.licenseInfo = jsObject.licenseInfo;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetPortalItem.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.modified)) {
            dotNetPortalItem.modified = jsObject.modified;
        }
        if (hasValue(jsObject.name)) {
            dotNetPortalItem.name = jsObject.name;
        }
        if (hasValue(jsObject.numComments)) {
            dotNetPortalItem.numComments = jsObject.numComments;
        }
        if (hasValue(jsObject.numRatings)) {
            dotNetPortalItem.numRatings = jsObject.numRatings;
        }
        if (hasValue(jsObject.numViews)) {
            dotNetPortalItem.numViews = jsObject.numViews;
        }
        if (hasValue(jsObject.owner)) {
            dotNetPortalItem.owner = jsObject.owner;
        }
        if (hasValue(jsObject.ownerFolder)) {
            dotNetPortalItem.ownerFolder = jsObject.ownerFolder;
        }
        if (hasValue(jsObject.id)) {
            dotNetPortalItem.portalItemId = jsObject.id;
        }
        if (hasValue(jsObject.screenshots)) {
            dotNetPortalItem.screenshots = jsObject.screenshots;
        }
        if (hasValue(jsObject.size)) {
            dotNetPortalItem.size = jsObject.size;
        }
        if (hasValue(jsObject.snippet)) {
            dotNetPortalItem.snippet = jsObject.snippet;
        }
        if (hasValue(jsObject.sourceJSON)) {
            dotNetPortalItem.sourceJSON = jsObject.sourceJSON;
        }
        if (hasValue(jsObject.tags)) {
            dotNetPortalItem.tags = jsObject.tags;
        }
        if (hasValue(jsObject.thumbnailUrl)) {
            dotNetPortalItem.thumbnailUrl = jsObject.thumbnailUrl;
        }
        if (hasValue(jsObject.title)) {
            dotNetPortalItem.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetPortalItem.type = jsObject.type;
        }
        if (hasValue(jsObject.typeKeywords)) {
            dotNetPortalItem.typeKeywords = jsObject.typeKeywords;
        }
        if (hasValue(jsObject.url)) {
            dotNetPortalItem.url = jsObject.url;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetPortalItem.id = k;
                break;
            }
        }
    }

    return dotNetPortalItem;
}

