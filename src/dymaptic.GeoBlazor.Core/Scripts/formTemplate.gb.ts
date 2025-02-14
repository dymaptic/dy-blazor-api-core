// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FormTemplate from '@arcgis/core/form/FormTemplate';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FormTemplateGenerated implements IPropertyWrapper {
    public component: FormTemplate;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FormTemplate) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getElements(): Promise<any> {
        if (!hasValue(this.component.elements)) {
            return null;
        }
        
        let { buildDotNetFormElement } = await import('./formElement');
        return await Promise.all(this.component.elements.map(async i => await buildDotNetFormElement(i)));
    }
    
    async setElements(value: any): Promise<void> {
        let { buildJsFormElement } = await import('./formElement');
        this.component.elements = await Promise.all(value.map(async i => await buildJsFormElement(i, this.layerId, this.viewId))) as any;
    }
    
    async getExpressionInfos(): Promise<any> {
        if (!hasValue(this.component.expressionInfos)) {
            return null;
        }
        
        let { buildDotNetExpressionInfo } = await import('./expressionInfo');
        return await Promise.all(this.component.expressionInfos.map(async i => await buildDotNetExpressionInfo(i)));
    }
    
    async setExpressionInfos(value: any): Promise<void> {
        let { buildJsExpressionInfo } = await import('./expressionInfo');
        this.component.expressionInfos = await Promise.all(value.map(async i => await buildJsExpressionInfo(i))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsFormTemplateGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFormTemplate = new FormTemplate();
    if (hasValue(dotNetObject.elements)) {
        let { buildJsFormElement } = await import('./formElement');
        jsFormTemplate.elements = await Promise.all(dotNetObject.elements.map(async i => await buildJsFormElement(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.expressionInfos)) {
        let { buildJsExpressionInfo } = await import('./jsBuilder');
        jsFormTemplate.expressionInfos = await Promise.all(dotNetObject.expressionInfos.map(async i => await buildJsExpressionInfo(i))) as any;
    }

    if (hasValue(dotNetObject.description)) {
        jsFormTemplate.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.preserveFieldValuesWhenHidden)) {
        jsFormTemplate.preserveFieldValuesWhenHidden = dotNetObject.preserveFieldValuesWhenHidden;
    }
    if (hasValue(dotNetObject.title)) {
        jsFormTemplate.title = dotNetObject.title;
    }
    let { default: FormTemplateWrapper } = await import('./formTemplate');
    let formTemplateWrapper = new FormTemplateWrapper(jsFormTemplate);
    formTemplateWrapper.geoBlazorId = dotNetObject.id;
    formTemplateWrapper.viewId = viewId;
    formTemplateWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(formTemplateWrapper);
    jsObjectRefs[dotNetObject.id] = formTemplateWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsFormTemplate;
    
    let dnInstantiatedObject = await buildDotNetFormTemplate(jsFormTemplate);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FormTemplate', e);
    }
    
    return jsFormTemplate;
}

export async function buildDotNetFormTemplateGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFormTemplate: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.elements)) {
            let { buildDotNetFormElement } = await import('./formElement');
            dotNetFormTemplate.elements = await Promise.all(jsObject.elements.map(async i => await buildDotNetFormElement(i)));
        }
        if (hasValue(jsObject.expressionInfos)) {
            let { buildDotNetExpressionInfo } = await import('./expressionInfo');
            dotNetFormTemplate.expressionInfos = await Promise.all(jsObject.expressionInfos.map(async i => await buildDotNetExpressionInfo(i)));
        }
        if (hasValue(jsObject.description)) {
            dotNetFormTemplate.description = jsObject.description;
        }
        if (hasValue(jsObject.preserveFieldValuesWhenHidden)) {
            dotNetFormTemplate.preserveFieldValuesWhenHidden = jsObject.preserveFieldValuesWhenHidden;
        }
        if (hasValue(jsObject.title)) {
            dotNetFormTemplate.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFormTemplate.id = k;
                break;
            }
        }
    }

    return dotNetFormTemplate;
}

