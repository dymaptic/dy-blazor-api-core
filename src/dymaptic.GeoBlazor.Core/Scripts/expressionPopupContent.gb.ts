// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ExpressionContent = __esri.ExpressionContent;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ExpressionPopupContentGenerated implements IPropertyWrapper {
    public component: ExpressionContent;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ExpressionContent) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getExpressionInfo(): Promise<any> {
        if (!hasValue(this.component.expressionInfo)) {
            return null;
        }
        
        let { buildDotNetElementExpressionInfo } = await import('./elementExpressionInfo');
        return await buildDotNetElementExpressionInfo(this.component.expressionInfo);
    }
    async setExpressionInfo(value: any): Promise<void> {
        let { buildJsElementExpressionInfo } = await import('./elementExpressionInfo');
        this.component.expressionInfo =  buildJsElementExpressionInfo(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsExpressionPopupContentGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsExpressionContent = new ExpressionContent();
    if (hasValue(dotNetObject.expressionInfo)) {
        let { buildJsElementExpressionInfo } = await import('./jsBuilder');
        jsExpressionContent.expressionInfo = buildJsElementExpressionInfo(dotNetObject.expressionInfo) as any;
    }

    let { default: ExpressionPopupContentWrapper } = await import('./expressionPopupContent');
    let expressionPopupContentWrapper = new ExpressionPopupContentWrapper(jsExpressionContent);
    expressionPopupContentWrapper.geoBlazorId = dotNetObject.id;
    expressionPopupContentWrapper.viewId = viewId;
    expressionPopupContentWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(expressionPopupContentWrapper);
    jsObjectRefs[dotNetObject.id] = expressionPopupContentWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsExpressionContent;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ExpressionPopupContent', e);
    }
    
    return jsExpressionContent;
}

export async function buildDotNetExpressionPopupContentGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetExpressionPopupContent: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.expressionInfo)) {
            let { buildDotNetElementExpressionInfo } = await import('./elementExpressionInfo');
            dotNetExpressionPopupContent.expressionInfo = await buildDotNetElementExpressionInfo(jsObject.expressionInfo);
        }
        if (hasValue(jsObject.type)) {
            dotNetExpressionPopupContent.type = jsObject.type;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetExpressionPopupContent.id = k;
                break;
            }
        }
    }

    return dotNetExpressionPopupContent;
}

