// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import TextContent = __esri.TextContent;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class TextPopupContentGenerated implements IPropertyWrapper {
    public component: TextContent;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: TextContent) {
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

export async function buildJsTextPopupContentGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsTextContent = new TextContent();

    if (hasValue(dotNetObject.text)) {
        jsTextContent.text = dotNetObject.text;
    }
    let { default: TextPopupContentWrapper } = await import('./textPopupContent');
    let textPopupContentWrapper = new TextPopupContentWrapper(jsTextContent);
    textPopupContentWrapper.geoBlazorId = dotNetObject.id;
    textPopupContentWrapper.viewId = viewId;
    textPopupContentWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(textPopupContentWrapper);
    jsObjectRefs[dotNetObject.id] = textPopupContentWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsTextContent;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for TextPopupContent', e);
    }
    
    return jsTextContent;
}

export async function buildDotNetTextPopupContentGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetTextPopupContent: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.text)) {
            dotNetTextPopupContent.text = jsObject.text;
        }
        if (hasValue(jsObject.type)) {
            dotNetTextPopupContent.type = jsObject.type;
        }

    return dotNetTextPopupContent;
}

