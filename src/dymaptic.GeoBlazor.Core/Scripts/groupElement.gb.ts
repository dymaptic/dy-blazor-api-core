// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GroupElement from '@arcgis/core/form/elements/GroupElement';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GroupElementGenerated implements IPropertyWrapper {
    public component: GroupElement;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: GroupElement) {
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
        this.component.elements = await Promise.all(value.map(async i => await buildJsFormElement(i, this.layerId, this.viewId)));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsGroupElementGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGroupElement = new GroupElement();
    if (hasValue(dotNetObject.elements)) {
        let { buildJsFormElement } = await import('./formElement');
        jsGroupElement.elements = await Promise.all(dotNetObject.elements.map(async i => await buildJsFormElement(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.description)) {
        jsGroupElement.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.initialState)) {
        jsGroupElement.initialState = dotNetObject.initialState;
    }
    if (hasValue(dotNetObject.label)) {
        jsGroupElement.label = dotNetObject.label;
    }
    if (hasValue(dotNetObject.visibilityExpression)) {
        jsGroupElement.visibilityExpression = dotNetObject.visibilityExpression;
    }
    let { default: GroupElementWrapper } = await import('./groupElement');
    let groupElementWrapper = new GroupElementWrapper(jsGroupElement);
    groupElementWrapper.geoBlazorId = dotNetObject.id;
    groupElementWrapper.viewId = viewId;
    groupElementWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(groupElementWrapper);
    jsObjectRefs[dotNetObject.id] = groupElementWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsGroupElement;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for GroupElement', e);
    }
    
    return jsGroupElement;
}

export async function buildDotNetGroupElementGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGroupElement: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.elements)) {
            let { buildDotNetFormElement } = await import('./formElement');
            dotNetGroupElement.elements = await Promise.all(jsObject.elements.map(async i => await buildDotNetFormElement(i)));
        }
        if (hasValue(jsObject.description)) {
            dotNetGroupElement.description = jsObject.description;
        }
        if (hasValue(jsObject.initialState)) {
            dotNetGroupElement.initialState = jsObject.initialState;
        }
        if (hasValue(jsObject.label)) {
            dotNetGroupElement.label = jsObject.label;
        }
        if (hasValue(jsObject.type)) {
            dotNetGroupElement.type = jsObject.type;
        }
        if (hasValue(jsObject.visibilityExpression)) {
            dotNetGroupElement.visibilityExpression = jsObject.visibilityExpression;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetGroupElement.id = k;
                break;
            }
        }
    }

    return dotNetGroupElement;
}

