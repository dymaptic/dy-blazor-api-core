// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import BookmarksVisibleElements = __esri.BookmarksVisibleElements;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class BookmarksVisibleElementsGenerated implements IPropertyWrapper {
    public component: BookmarksVisibleElements;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: BookmarksVisibleElements) {
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

export async function buildJsBookmarksVisibleElementsGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsBookmarksVisibleElements: any = {}

    if (hasValue(dotNetObject.addBookmark)) {
        jsBookmarksVisibleElements.addBookmark = dotNetObject.addBookmark;
    }
    if (hasValue(dotNetObject.addBookmarkButton)) {
        jsBookmarksVisibleElements.addBookmarkButton = dotNetObject.addBookmarkButton;
    }
    if (hasValue(dotNetObject.closeButton)) {
        jsBookmarksVisibleElements.closeButton = dotNetObject.closeButton;
    }
    if (hasValue(dotNetObject.collapseButton)) {
        jsBookmarksVisibleElements.collapseButton = dotNetObject.collapseButton;
    }
    if (hasValue(dotNetObject.editBookmarkButton)) {
        jsBookmarksVisibleElements.editBookmarkButton = dotNetObject.editBookmarkButton;
    }
    if (hasValue(dotNetObject.filter)) {
        jsBookmarksVisibleElements.filter = dotNetObject.filter;
    }
    if (hasValue(dotNetObject.flow)) {
        jsBookmarksVisibleElements.flow = dotNetObject.flow;
    }
    if (hasValue(dotNetObject.heading)) {
        jsBookmarksVisibleElements.heading = dotNetObject.heading;
    }
    if (hasValue(dotNetObject.thumbnail)) {
        jsBookmarksVisibleElements.thumbnail = dotNetObject.thumbnail;
    }
    if (hasValue(dotNetObject.time)) {
        jsBookmarksVisibleElements.time = dotNetObject.time;
    }
    let { default: BookmarksVisibleElementsWrapper } = await import('./bookmarksVisibleElements');
    let bookmarksVisibleElementsWrapper = new BookmarksVisibleElementsWrapper(jsBookmarksVisibleElements);
    bookmarksVisibleElementsWrapper.geoBlazorId = dotNetObject.id;
    bookmarksVisibleElementsWrapper.viewId = viewId;
    bookmarksVisibleElementsWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(bookmarksVisibleElementsWrapper);
    jsObjectRefs[dotNetObject.id] = bookmarksVisibleElementsWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsBookmarksVisibleElements;
    
    let { buildDotNetBookmarksVisibleElements } = await import('./bookmarksVisibleElements');
    let dnInstantiatedObject = await buildDotNetBookmarksVisibleElements(jsBookmarksVisibleElements, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for BookmarksVisibleElements', e);
    }
    
    return jsBookmarksVisibleElements;
}

export async function buildDotNetBookmarksVisibleElementsGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetBookmarksVisibleElements: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.addBookmark)) {
            dotNetBookmarksVisibleElements.addBookmark = jsObject.addBookmark;
        }
        if (hasValue(jsObject.addBookmarkButton)) {
            dotNetBookmarksVisibleElements.addBookmarkButton = jsObject.addBookmarkButton;
        }
        if (hasValue(jsObject.closeButton)) {
            dotNetBookmarksVisibleElements.closeButton = jsObject.closeButton;
        }
        if (hasValue(jsObject.collapseButton)) {
            dotNetBookmarksVisibleElements.collapseButton = jsObject.collapseButton;
        }
        if (hasValue(jsObject.editBookmarkButton)) {
            dotNetBookmarksVisibleElements.editBookmarkButton = jsObject.editBookmarkButton;
        }
        if (hasValue(jsObject.filter)) {
            dotNetBookmarksVisibleElements.filter = jsObject.filter;
        }
        if (hasValue(jsObject.flow)) {
            dotNetBookmarksVisibleElements.flow = jsObject.flow;
        }
        if (hasValue(jsObject.heading)) {
            dotNetBookmarksVisibleElements.heading = jsObject.heading;
        }
        if (hasValue(jsObject.thumbnail)) {
            dotNetBookmarksVisibleElements.thumbnail = jsObject.thumbnail;
        }
        if (hasValue(jsObject.time)) {
            dotNetBookmarksVisibleElements.time = jsObject.time;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetBookmarksVisibleElements.id = k;
                break;
            }
        }
    }

    return dotNetBookmarksVisibleElements;
}

