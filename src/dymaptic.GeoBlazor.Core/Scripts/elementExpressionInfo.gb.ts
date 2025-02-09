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
        // set all properties from component
        for (let prop in component) {
            if (component.hasOwnProperty(prop)) {
                this[prop] = component[prop];
            }
        }
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
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = elementExpressionInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsElementExpressionInfo;
    
    return jsElementExpressionInfo;
}

export function buildDotNetElementExpressionInfoGenerated(jsObject: any): any {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetElementExpressionInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        dotNetElementExpressionInfo.expression = jsObject.expression;
        dotNetElementExpressionInfo.returnType = jsObject.returnType;
        dotNetElementExpressionInfo.title = jsObject.title;

    return dotNetElementExpressionInfo;
}

