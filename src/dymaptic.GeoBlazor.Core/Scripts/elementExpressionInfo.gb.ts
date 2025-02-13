// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ElementExpressionInfo from '@arcgis/core/popup/ElementExpressionInfo';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ElementExpressionInfoGenerated implements IPropertyWrapper {
    public component: ElementExpressionInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ElementExpressionInfo) {
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

export async function buildJsElementExpressionInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsElementExpressionInfo = new ElementExpressionInfo();

    if (hasValue(dotNetObject.expression)) {
        jsElementExpressionInfo.expression = dotNetObject.expression;
    }
    if (hasValue(dotNetObject.returnType)) {
        jsElementExpressionInfo.returnType = dotNetObject.returnType;
    }
    if (hasValue(dotNetObject.title)) {
        jsElementExpressionInfo.title = dotNetObject.title;
    }
    let { default: ElementExpressionInfoWrapper } = await import('./elementExpressionInfo');
    let elementExpressionInfoWrapper = new ElementExpressionInfoWrapper(jsElementExpressionInfo);
    elementExpressionInfoWrapper.geoBlazorId = dotNetObject.id;
    elementExpressionInfoWrapper.viewId = viewId;
    elementExpressionInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(elementExpressionInfoWrapper);
    jsObjectRefs[dotNetObject.id] = elementExpressionInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsElementExpressionInfo;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ElementExpressionInfo', e);
    }
    
    return jsElementExpressionInfo;
}

export async function buildDotNetElementExpressionInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetElementExpressionInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.expression)) {
            dotNetElementExpressionInfo.expression = jsObject.expression;
        }
        if (hasValue(jsObject.returnType)) {
            dotNetElementExpressionInfo.returnType = jsObject.returnType;
        }
        if (hasValue(jsObject.title)) {
            dotNetElementExpressionInfo.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetElementExpressionInfo.id = k;
                break;
            }
        }
    }

    return dotNetElementExpressionInfo;
}

