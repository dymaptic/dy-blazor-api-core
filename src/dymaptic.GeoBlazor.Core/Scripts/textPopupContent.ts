// override generated code in this file
import TextContent = __esri.TextContent;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from "./arcGisJsInterop";

export function buildJsTextPopupContent(dotNetObject: any): any {
    let jsTextContent = new TextContent();

    if (hasValue(dotNetObject.text)) {
        jsTextContent.text = dotNetObject.text;
    }
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(textPopupContentWrapper);
    jsObjectRefs[dotNetObject.id] = jsObjectRef;
    arcGisObjectRefs[dotNetObject.id] = jsTextContent;

    let dnInstantiatedObject = buildDotNetTextPopupContent(jsTextContent);

    try {
        dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for TextPopupContent', e);
    }

    return jsTextContent;
}     

export function buildDotNetTextPopupContent(jsObject: any): any {
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

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetTextPopupContent.id = k;
                break;
            }
        }
    }

    return dotNetTextPopupContent;
}
