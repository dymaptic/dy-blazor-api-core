// override generated code in this file
import LineSymbolMarker from '@arcgis/core/symbols/LineSymbolMarker';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from "./arcGisJsInterop";
import {buildDotNetMapColor, buildJsMapColor } from './mapColor';

export function buildJsLineSymbolMarker(dotNetObject: any): any {
    let jsLineSymbolMarker = new LineSymbolMarker();
    if (hasValue(dotNetObject.color)) {
        jsLineSymbolMarker.color = buildJsMapColor(dotNetObject.color) as any;
    }

    if (hasValue(dotNetObject.placement)) {
        jsLineSymbolMarker.placement = dotNetObject.placement;
    }
    if (hasValue(dotNetObject.style)) {
        jsLineSymbolMarker.style = dotNetObject.style;
    }

    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(lineSymbolMarkerWrapper);
    jsObjectRefs[dotNetObject.id] = jsObjectRef;
    arcGisObjectRefs[dotNetObject.id] = jsLineSymbolMarker;

    let dnInstantiatedObject = buildDotNetLineSymbolMarker(jsLineSymbolMarker);

    try {
        dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for LineSymbolMarker', e);
    }

    return jsLineSymbolMarker;
}
export function buildDotNetLineSymbolMarker(jsObject: any): any {
    if (!hasValue(jsObject)) {
        return null;
    }

    let dotNetLineSymbolMarker: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
    if (hasValue(jsObject.color)) {
        dotNetLineSymbolMarker.color = buildDotNetMapColor(jsObject.color);
    }
    if (hasValue(jsObject.placement)) {
        dotNetLineSymbolMarker.placement = jsObject.placement;
    }
    if (hasValue(jsObject.style)) {
        dotNetLineSymbolMarker.style = jsObject.style;
    }
    if (hasValue(jsObject.type)) {
        dotNetLineSymbolMarker.type = jsObject.type;
    }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetLineSymbolMarker.id = k;
                break;
            }
        }
    }

    return dotNetLineSymbolMarker;
}
