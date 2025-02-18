// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import BookmarksCapabilities = __esri.BookmarksCapabilities;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class BookmarksCapabilitiesGenerated implements IPropertyWrapper {
    public component: BookmarksCapabilities;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: BookmarksCapabilities) {
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

export async function buildJsBookmarksCapabilitiesGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsBookmarksCapabilities: any = {}

    if (hasValue(dotNetObject.time)) {
        jsBookmarksCapabilities.time = dotNetObject.time;
    }
    let { default: BookmarksCapabilitiesWrapper } = await import('./bookmarksCapabilities');
    let bookmarksCapabilitiesWrapper = new BookmarksCapabilitiesWrapper(jsBookmarksCapabilities);
    bookmarksCapabilitiesWrapper.geoBlazorId = dotNetObject.id;
    bookmarksCapabilitiesWrapper.viewId = viewId;
    bookmarksCapabilitiesWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(bookmarksCapabilitiesWrapper);
    jsObjectRefs[dotNetObject.id] = bookmarksCapabilitiesWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsBookmarksCapabilities;
    let { buildDotNetBookmarksCapabilities } = await import('./bookmarksCapabilities');
    let dnInstantiatedObject = await buildDotNetBookmarksCapabilities(jsBookmarksCapabilities, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for BookmarksCapabilities', e);
    }
    
    return jsBookmarksCapabilities;
}

export async function buildDotNetBookmarksCapabilitiesGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetBookmarksCapabilities: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.time)) {
            dotNetBookmarksCapabilities.time = jsObject.time;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetBookmarksCapabilities.id = k;
                break;
            }
        }
    }

    return dotNetBookmarksCapabilities;
}

