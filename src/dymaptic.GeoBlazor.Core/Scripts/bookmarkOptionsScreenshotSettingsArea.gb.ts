// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import BookmarkOptionsScreenshotSettingsArea = __esri.BookmarkOptionsScreenshotSettingsArea;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class BookmarkOptionsScreenshotSettingsAreaGenerated implements IPropertyWrapper {
    public component: BookmarkOptionsScreenshotSettingsArea;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: BookmarkOptionsScreenshotSettingsArea) {
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

export async function buildJsBookmarkOptionsScreenshotSettingsAreaGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsBookmarkOptionsScreenshotSettingsArea: any = {}

    if (hasValue(dotNetObject.height)) {
        jsBookmarkOptionsScreenshotSettingsArea.height = dotNetObject.height;
    }
    if (hasValue(dotNetObject.width)) {
        jsBookmarkOptionsScreenshotSettingsArea.width = dotNetObject.width;
    }
    if (hasValue(dotNetObject.x)) {
        jsBookmarkOptionsScreenshotSettingsArea.x = dotNetObject.x;
    }
    if (hasValue(dotNetObject.y)) {
        jsBookmarkOptionsScreenshotSettingsArea.y = dotNetObject.y;
    }
    let { default: BookmarkOptionsScreenshotSettingsAreaWrapper } = await import('./bookmarkOptionsScreenshotSettingsArea');
    let bookmarkOptionsScreenshotSettingsAreaWrapper = new BookmarkOptionsScreenshotSettingsAreaWrapper(jsBookmarkOptionsScreenshotSettingsArea);
    bookmarkOptionsScreenshotSettingsAreaWrapper.geoBlazorId = dotNetObject.id;
    bookmarkOptionsScreenshotSettingsAreaWrapper.viewId = viewId;
    bookmarkOptionsScreenshotSettingsAreaWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(bookmarkOptionsScreenshotSettingsAreaWrapper);
    jsObjectRefs[dotNetObject.id] = bookmarkOptionsScreenshotSettingsAreaWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsBookmarkOptionsScreenshotSettingsArea;
    
    let { buildDotNetBookmarkOptionsScreenshotSettingsArea } = await import('./bookmarkOptionsScreenshotSettingsArea');
    let dnInstantiatedObject = await buildDotNetBookmarkOptionsScreenshotSettingsArea(jsBookmarkOptionsScreenshotSettingsArea, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for BookmarkOptionsScreenshotSettingsArea', e);
    }
    
    return jsBookmarkOptionsScreenshotSettingsArea;
}

export async function buildDotNetBookmarkOptionsScreenshotSettingsAreaGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetBookmarkOptionsScreenshotSettingsArea: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.height)) {
            dotNetBookmarkOptionsScreenshotSettingsArea.height = jsObject.height;
        }
        if (hasValue(jsObject.width)) {
            dotNetBookmarkOptionsScreenshotSettingsArea.width = jsObject.width;
        }
        if (hasValue(jsObject.x)) {
            dotNetBookmarkOptionsScreenshotSettingsArea.x = jsObject.x;
        }
        if (hasValue(jsObject.y)) {
            dotNetBookmarkOptionsScreenshotSettingsArea.y = jsObject.y;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetBookmarkOptionsScreenshotSettingsArea.id = k;
                break;
            }
        }
    }

    return dotNetBookmarkOptionsScreenshotSettingsArea;
}

