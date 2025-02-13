// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import Portal from '@arcgis/core/portal/Portal';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class PortalGenerated implements IPropertyWrapper {
    public component: Portal;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: Portal) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async createElevationLayers(): Promise<any> {
        let result = await this.component.createElevationLayers();
        let { buildDotNetElevationLayer } = await import('./elevationLayer');
        return result.map(async i => await buildDotNetElevationLayer(i));
    }

    async fetchBasemaps(basemapGalleryGroupQuery: any,
        options: any): Promise<any> {
        let result = await this.component.fetchBasemaps(basemapGalleryGroupQuery,
            options);
        let { buildDotNetBasemap } = await import('./basemap');
        return result.map(async i => await buildDotNetBasemap(i));
    }

    async fetchCategorySchema(options: any): Promise<any> {
        return await this.component.fetchCategorySchema(options);
    }

    async fetchFeaturedGroups(options: any): Promise<any> {
        return await this.component.fetchFeaturedGroups(options);
    }

    async fetchRegions(options: any): Promise<any> {
        return await this.component.fetchRegions(options);
    }

    async fetchSettings(options: any): Promise<any> {
        return await this.component.fetchSettings(options);
    }

    async queryGroups(queryParams: any,
        options: any): Promise<any> {
        return await this.component.queryGroups(queryParams,
            options);
    }

    async queryItems(queryParams: any,
        options: any): Promise<any> {
        return await this.component.queryItems(queryParams,
            options);
    }

    async queryUsers(queryParams: any,
        options: any): Promise<any> {
        return await this.component.queryUsers(queryParams,
            options);
    }

    // region properties
    
    async getDefaultBasemap(): Promise<any> {
        let { buildDotNetBasemap } = await import('./basemap');
        return await buildDotNetBasemap(this.component.defaultBasemap);
    }
    async setDefaultBasemap(value: any): Promise<void> {
        let { buildJsBasemap } = await import('./basemap');
        this.component.defaultBasemap = await  buildJsBasemap(value, this.layerId, this.viewId);
    }
    async getDefaultDevBasemap(): Promise<any> {
        let { buildDotNetBasemap } = await import('./basemap');
        return await buildDotNetBasemap(this.component.defaultDevBasemap);
    }
    async setDefaultDevBasemap(value: any): Promise<void> {
        let { buildJsBasemap } = await import('./basemap');
        this.component.defaultDevBasemap = await  buildJsBasemap(value, this.layerId, this.viewId);
    }
    async getDefaultVectorBasemap(): Promise<any> {
        let { buildDotNetBasemap } = await import('./basemap');
        return await buildDotNetBasemap(this.component.defaultVectorBasemap);
    }
    async setDefaultVectorBasemap(value: any): Promise<void> {
        let { buildJsBasemap } = await import('./basemap');
        this.component.defaultVectorBasemap = await  buildJsBasemap(value, this.layerId, this.viewId);
    }
    async getFeaturedGroups(): Promise<any> {
        let { buildDotNetPortalFeaturedGroups } = await import('./portalFeaturedGroups');
        return this.component.featuredGroups.map(async i => await buildDotNetPortalFeaturedGroups(i));
    }
    
    async setFeaturedGroups(value: any): Promise<void> {
        let { buildJsPortalFeaturedGroups } = await import('./portalFeaturedGroups');
        this.component.featuredGroups = value.map(async i => await buildJsPortalFeaturedGroups(i, this.layerId, this.viewId));
    }
    
    async getUser(): Promise<any> {
        let { buildDotNetPortalUser } = await import('./portalUser');
        return await buildDotNetPortalUser(this.component.user);
    }
    async setUser(value: any): Promise<void> {
        let { buildJsPortalUser } = await import('./portalUser');
        this.component.user = await  buildJsPortalUser(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsPortalGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsPortal = new Portal();
    if (hasValue(dotNetObject.featuredGroups)) {
        let { buildJsPortalFeaturedGroups } = await import('./portalFeaturedGroups');
        jsPortal.featuredGroups = await Promise.all(dotNetObject.featuredGroups.map(async i => await buildJsPortalFeaturedGroups(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.access)) {
        jsPortal.access = dotNetObject.access;
    }
    if (hasValue(dotNetObject.allSSL)) {
        jsPortal.allSSL = dotNetObject.allSSL;
    }
    if (hasValue(dotNetObject.authMode)) {
        jsPortal.authMode = dotNetObject.authMode;
    }
    if (hasValue(dotNetObject.authorizedCrossOriginDomains)) {
        jsPortal.authorizedCrossOriginDomains = dotNetObject.authorizedCrossOriginDomains;
    }
    if (hasValue(dotNetObject.basemapGalleryGroupQuery)) {
        jsPortal.basemapGalleryGroupQuery = dotNetObject.basemapGalleryGroupQuery;
    }
    if (hasValue(dotNetObject.basemapGalleryGroupQuery3D)) {
        jsPortal.basemapGalleryGroupQuery3D = dotNetObject.basemapGalleryGroupQuery3D;
    }
    if (hasValue(dotNetObject.bingKey)) {
        jsPortal.bingKey = dotNetObject.bingKey;
    }
    if (hasValue(dotNetObject.canListApps)) {
        jsPortal.canListApps = dotNetObject.canListApps;
    }
    if (hasValue(dotNetObject.canListData)) {
        jsPortal.canListData = dotNetObject.canListData;
    }
    if (hasValue(dotNetObject.canListPreProvisionedItems)) {
        jsPortal.canListPreProvisionedItems = dotNetObject.canListPreProvisionedItems;
    }
    if (hasValue(dotNetObject.canProvisionDirectPurchase)) {
        jsPortal.canProvisionDirectPurchase = dotNetObject.canProvisionDirectPurchase;
    }
    if (hasValue(dotNetObject.canSearchPublic)) {
        jsPortal.canSearchPublic = dotNetObject.canSearchPublic;
    }
    if (hasValue(dotNetObject.canShareBingPublic)) {
        jsPortal.canShareBingPublic = dotNetObject.canShareBingPublic;
    }
    if (hasValue(dotNetObject.canSharePublic)) {
        jsPortal.canSharePublic = dotNetObject.canSharePublic;
    }
    if (hasValue(dotNetObject.canSignInArcGIS)) {
        jsPortal.canSignInArcGIS = dotNetObject.canSignInArcGIS;
    }
    if (hasValue(dotNetObject.canSignInIDP)) {
        jsPortal.canSignInIDP = dotNetObject.canSignInIDP;
    }
    if (hasValue(dotNetObject.colorSetsGroupQuery)) {
        jsPortal.colorSetsGroupQuery = dotNetObject.colorSetsGroupQuery;
    }
    if (hasValue(dotNetObject.commentsEnabled)) {
        jsPortal.commentsEnabled = dotNetObject.commentsEnabled;
    }
    if (hasValue(dotNetObject.created)) {
        jsPortal.created = dotNetObject.created;
    }
    if (hasValue(dotNetObject.culture)) {
        jsPortal.culture = dotNetObject.culture;
    }
    if (hasValue(dotNetObject.customBaseUrl)) {
        jsPortal.customBaseUrl = dotNetObject.customBaseUrl;
    }
    if (hasValue(dotNetObject.defaultExtent)) {
        jsPortal.defaultExtent = dotNetObject.defaultExtent;
    }
    if (hasValue(dotNetObject.description)) {
        jsPortal.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.devBasemapGalleryGroupQuery)) {
        jsPortal.devBasemapGalleryGroupQuery = dotNetObject.devBasemapGalleryGroupQuery;
    }
    if (hasValue(dotNetObject.eueiEnabled)) {
        jsPortal.eueiEnabled = dotNetObject.eueiEnabled;
    }
    if (hasValue(dotNetObject.featuredItemsGroupQuery)) {
        jsPortal.featuredItemsGroupQuery = dotNetObject.featuredItemsGroupQuery;
    }
    if (hasValue(dotNetObject.galleryTemplatesGroupQuery)) {
        jsPortal.galleryTemplatesGroupQuery = dotNetObject.galleryTemplatesGroupQuery;
    }
    if (hasValue(dotNetObject.hasCategorySchema)) {
        jsPortal.hasCategorySchema = dotNetObject.hasCategorySchema;
    }
    if (hasValue(dotNetObject.helperServices)) {
        jsPortal.helperServices = dotNetObject.helperServices;
    }
    if (hasValue(dotNetObject.homePageFeaturedContent)) {
        jsPortal.homePageFeaturedContent = dotNetObject.homePageFeaturedContent;
    }
    if (hasValue(dotNetObject.homePageFeaturedContentCount)) {
        jsPortal.homePageFeaturedContentCount = dotNetObject.homePageFeaturedContentCount;
    }
    if (hasValue(dotNetObject.httpPort)) {
        jsPortal.httpPort = dotNetObject.httpPort;
    }
    if (hasValue(dotNetObject.httpsPort)) {
        jsPortal.httpsPort = dotNetObject.httpsPort;
    }
    if (hasValue(dotNetObject.ipCntryCode)) {
        jsPortal.ipCntryCode = dotNetObject.ipCntryCode;
    }
    if (hasValue(dotNetObject.isPortal)) {
        jsPortal.isPortal = dotNetObject.isPortal;
    }
    if (hasValue(dotNetObject.isReadOnly)) {
        jsPortal.isReadOnly = dotNetObject.isReadOnly;
    }
    if (hasValue(dotNetObject.layerTemplatesGroupQuery)) {
        jsPortal.layerTemplatesGroupQuery = dotNetObject.layerTemplatesGroupQuery;
    }
    if (hasValue(dotNetObject.maxTokenExpirationMinutes)) {
        jsPortal.maxTokenExpirationMinutes = dotNetObject.maxTokenExpirationMinutes;
    }
    if (hasValue(dotNetObject.modified)) {
        jsPortal.modified = dotNetObject.modified;
    }
    if (hasValue(dotNetObject.name)) {
        jsPortal.name = dotNetObject.name;
    }
    if (hasValue(dotNetObject.portalHostname)) {
        jsPortal.portalHostname = dotNetObject.portalHostname;
    }
    if (hasValue(dotNetObject.portalId)) {
        jsPortal.id = dotNetObject.portalId;
    }
    if (hasValue(dotNetObject.portalMode)) {
        jsPortal.portalMode = dotNetObject.portalMode;
    }
    if (hasValue(dotNetObject.portalProperties)) {
        jsPortal.portalProperties = dotNetObject.portalProperties;
    }
    if (hasValue(dotNetObject.recycleBinEnabled)) {
        jsPortal.recycleBinEnabled = dotNetObject.recycleBinEnabled;
    }
    if (hasValue(dotNetObject.region)) {
        jsPortal.region = dotNetObject.region;
    }
    if (hasValue(dotNetObject.rotatorPanels)) {
        jsPortal.rotatorPanels = dotNetObject.rotatorPanels;
    }
    if (hasValue(dotNetObject.showHomePageDescription)) {
        jsPortal.showHomePageDescription = dotNetObject.showHomePageDescription;
    }
    if (hasValue(dotNetObject.supportsHostedServices)) {
        jsPortal.supportsHostedServices = dotNetObject.supportsHostedServices;
    }
    if (hasValue(dotNetObject.symbolSetsGroupQuery)) {
        jsPortal.symbolSetsGroupQuery = dotNetObject.symbolSetsGroupQuery;
    }
    if (hasValue(dotNetObject.templatesGroupQuery)) {
        jsPortal.templatesGroupQuery = dotNetObject.templatesGroupQuery;
    }
    if (hasValue(dotNetObject.units)) {
        jsPortal.units = dotNetObject.units;
    }
    if (hasValue(dotNetObject.url)) {
        jsPortal.url = dotNetObject.url;
    }
    if (hasValue(dotNetObject.urlKey)) {
        jsPortal.urlKey = dotNetObject.urlKey;
    }
    if (hasValue(dotNetObject.use3dBasemaps)) {
        jsPortal.use3dBasemaps = dotNetObject.use3dBasemaps;
    }
    if (hasValue(dotNetObject.useStandardizedQuery)) {
        jsPortal.useStandardizedQuery = dotNetObject.useStandardizedQuery;
    }
    if (hasValue(dotNetObject.useVectorBasemaps)) {
        jsPortal.useVectorBasemaps = dotNetObject.useVectorBasemaps;
    }
    if (hasValue(dotNetObject.vectorBasemapGalleryGroupQuery)) {
        jsPortal.vectorBasemapGalleryGroupQuery = dotNetObject.vectorBasemapGalleryGroupQuery;
    }
    let { default: PortalWrapper } = await import('./portal');
    let portalWrapper = new PortalWrapper(jsPortal);
    portalWrapper.geoBlazorId = dotNetObject.id;
    portalWrapper.viewId = viewId;
    portalWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(portalWrapper);
    jsObjectRefs[dotNetObject.id] = portalWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsPortal;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for Portal', e);
    }
    
    return jsPortal;
}

export async function buildDotNetPortalGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetPortal: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.featuredGroups)) {
            let { buildDotNetPortalFeaturedGroups } = await import('./portalFeaturedGroups');
            dotNetPortal.featuredGroups = await Promise.all(jsObject.featuredGroups.map(async i => await buildDotNetPortalFeaturedGroups(i)));
        }
        if (hasValue(jsObject.access)) {
            dotNetPortal.access = jsObject.access;
        }
        if (hasValue(jsObject.allSSL)) {
            dotNetPortal.allSSL = jsObject.allSSL;
        }
        if (hasValue(jsObject.authMode)) {
            dotNetPortal.authMode = jsObject.authMode;
        }
        if (hasValue(jsObject.authorizedCrossOriginDomains)) {
            dotNetPortal.authorizedCrossOriginDomains = jsObject.authorizedCrossOriginDomains;
        }
        if (hasValue(jsObject.basemapGalleryGroupQuery)) {
            dotNetPortal.basemapGalleryGroupQuery = jsObject.basemapGalleryGroupQuery;
        }
        if (hasValue(jsObject.basemapGalleryGroupQuery3D)) {
            dotNetPortal.basemapGalleryGroupQuery3D = jsObject.basemapGalleryGroupQuery3D;
        }
        if (hasValue(jsObject.bingKey)) {
            dotNetPortal.bingKey = jsObject.bingKey;
        }
        if (hasValue(jsObject.canListApps)) {
            dotNetPortal.canListApps = jsObject.canListApps;
        }
        if (hasValue(jsObject.canListData)) {
            dotNetPortal.canListData = jsObject.canListData;
        }
        if (hasValue(jsObject.canListPreProvisionedItems)) {
            dotNetPortal.canListPreProvisionedItems = jsObject.canListPreProvisionedItems;
        }
        if (hasValue(jsObject.canProvisionDirectPurchase)) {
            dotNetPortal.canProvisionDirectPurchase = jsObject.canProvisionDirectPurchase;
        }
        if (hasValue(jsObject.canSearchPublic)) {
            dotNetPortal.canSearchPublic = jsObject.canSearchPublic;
        }
        if (hasValue(jsObject.canShareBingPublic)) {
            dotNetPortal.canShareBingPublic = jsObject.canShareBingPublic;
        }
        if (hasValue(jsObject.canSharePublic)) {
            dotNetPortal.canSharePublic = jsObject.canSharePublic;
        }
        if (hasValue(jsObject.canSignInArcGIS)) {
            dotNetPortal.canSignInArcGIS = jsObject.canSignInArcGIS;
        }
        if (hasValue(jsObject.canSignInIDP)) {
            dotNetPortal.canSignInIDP = jsObject.canSignInIDP;
        }
        if (hasValue(jsObject.colorSetsGroupQuery)) {
            dotNetPortal.colorSetsGroupQuery = jsObject.colorSetsGroupQuery;
        }
        if (hasValue(jsObject.commentsEnabled)) {
            dotNetPortal.commentsEnabled = jsObject.commentsEnabled;
        }
        if (hasValue(jsObject.created)) {
            dotNetPortal.created = jsObject.created;
        }
        if (hasValue(jsObject.culture)) {
            dotNetPortal.culture = jsObject.culture;
        }
        if (hasValue(jsObject.customBaseUrl)) {
            dotNetPortal.customBaseUrl = jsObject.customBaseUrl;
        }
        if (hasValue(jsObject.defaultExtent)) {
            dotNetPortal.defaultExtent = jsObject.defaultExtent;
        }
        if (hasValue(jsObject.description)) {
            dotNetPortal.description = jsObject.description;
        }
        if (hasValue(jsObject.devBasemapGalleryGroupQuery)) {
            dotNetPortal.devBasemapGalleryGroupQuery = jsObject.devBasemapGalleryGroupQuery;
        }
        if (hasValue(jsObject.eueiEnabled)) {
            dotNetPortal.eueiEnabled = jsObject.eueiEnabled;
        }
        if (hasValue(jsObject.featuredItemsGroupQuery)) {
            dotNetPortal.featuredItemsGroupQuery = jsObject.featuredItemsGroupQuery;
        }
        if (hasValue(jsObject.galleryTemplatesGroupQuery)) {
            dotNetPortal.galleryTemplatesGroupQuery = jsObject.galleryTemplatesGroupQuery;
        }
        if (hasValue(jsObject.hasCategorySchema)) {
            dotNetPortal.hasCategorySchema = jsObject.hasCategorySchema;
        }
        if (hasValue(jsObject.helperServices)) {
            dotNetPortal.helperServices = jsObject.helperServices;
        }
        if (hasValue(jsObject.homePageFeaturedContent)) {
            dotNetPortal.homePageFeaturedContent = jsObject.homePageFeaturedContent;
        }
        if (hasValue(jsObject.homePageFeaturedContentCount)) {
            dotNetPortal.homePageFeaturedContentCount = jsObject.homePageFeaturedContentCount;
        }
        if (hasValue(jsObject.httpPort)) {
            dotNetPortal.httpPort = jsObject.httpPort;
        }
        if (hasValue(jsObject.httpsPort)) {
            dotNetPortal.httpsPort = jsObject.httpsPort;
        }
        if (hasValue(jsObject.ipCntryCode)) {
            dotNetPortal.ipCntryCode = jsObject.ipCntryCode;
        }
        if (hasValue(jsObject.isOrganization)) {
            dotNetPortal.isOrganization = jsObject.isOrganization;
        }
        if (hasValue(jsObject.isPortal)) {
            dotNetPortal.isPortal = jsObject.isPortal;
        }
        if (hasValue(jsObject.isReadOnly)) {
            dotNetPortal.isReadOnly = jsObject.isReadOnly;
        }
        if (hasValue(jsObject.layerTemplatesGroupQuery)) {
            dotNetPortal.layerTemplatesGroupQuery = jsObject.layerTemplatesGroupQuery;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetPortal.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxTokenExpirationMinutes)) {
            dotNetPortal.maxTokenExpirationMinutes = jsObject.maxTokenExpirationMinutes;
        }
        if (hasValue(jsObject.modified)) {
            dotNetPortal.modified = jsObject.modified;
        }
        if (hasValue(jsObject.name)) {
            dotNetPortal.name = jsObject.name;
        }
        if (hasValue(jsObject.portalHostname)) {
            dotNetPortal.portalHostname = jsObject.portalHostname;
        }
        if (hasValue(jsObject.id)) {
            dotNetPortal.portalId = jsObject.id;
        }
        if (hasValue(jsObject.portalMode)) {
            dotNetPortal.portalMode = jsObject.portalMode;
        }
        if (hasValue(jsObject.portalProperties)) {
            dotNetPortal.portalProperties = jsObject.portalProperties;
        }
        if (hasValue(jsObject.recycleBinEnabled)) {
            dotNetPortal.recycleBinEnabled = jsObject.recycleBinEnabled;
        }
        if (hasValue(jsObject.region)) {
            dotNetPortal.region = jsObject.region;
        }
        if (hasValue(jsObject.restUrl)) {
            dotNetPortal.restUrl = jsObject.restUrl;
        }
        if (hasValue(jsObject.rotatorPanels)) {
            dotNetPortal.rotatorPanels = jsObject.rotatorPanels;
        }
        if (hasValue(jsObject.showHomePageDescription)) {
            dotNetPortal.showHomePageDescription = jsObject.showHomePageDescription;
        }
        if (hasValue(jsObject.sourceJSON)) {
            dotNetPortal.sourceJSON = jsObject.sourceJSON;
        }
        if (hasValue(jsObject.supportsHostedServices)) {
            dotNetPortal.supportsHostedServices = jsObject.supportsHostedServices;
        }
        if (hasValue(jsObject.symbolSetsGroupQuery)) {
            dotNetPortal.symbolSetsGroupQuery = jsObject.symbolSetsGroupQuery;
        }
        if (hasValue(jsObject.templatesGroupQuery)) {
            dotNetPortal.templatesGroupQuery = jsObject.templatesGroupQuery;
        }
        if (hasValue(jsObject.thumbnailUrl)) {
            dotNetPortal.thumbnailUrl = jsObject.thumbnailUrl;
        }
        if (hasValue(jsObject.units)) {
            dotNetPortal.units = jsObject.units;
        }
        if (hasValue(jsObject.url)) {
            dotNetPortal.url = jsObject.url;
        }
        if (hasValue(jsObject.urlKey)) {
            dotNetPortal.urlKey = jsObject.urlKey;
        }
        if (hasValue(jsObject.use3dBasemaps)) {
            dotNetPortal.use3dBasemaps = jsObject.use3dBasemaps;
        }
        if (hasValue(jsObject.useStandardizedQuery)) {
            dotNetPortal.useStandardizedQuery = jsObject.useStandardizedQuery;
        }
        if (hasValue(jsObject.useVectorBasemaps)) {
            dotNetPortal.useVectorBasemaps = jsObject.useVectorBasemaps;
        }
        if (hasValue(jsObject.vectorBasemapGalleryGroupQuery)) {
            dotNetPortal.vectorBasemapGalleryGroupQuery = jsObject.vectorBasemapGalleryGroupQuery;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetPortal.id = k;
                break;
            }
        }
    }

    return dotNetPortal;
}

