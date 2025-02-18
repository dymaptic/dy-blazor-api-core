// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FieldElement from '@arcgis/core/form/elements/FieldElement';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FieldElementGenerated implements IPropertyWrapper {
    public component: FieldElement;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FieldElement) {
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

export async function buildJsFieldElementGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFieldElement = new FieldElement();

    if (hasValue(dotNetObject.description)) {
        jsFieldElement.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.domain)) {
        jsFieldElement.domain = dotNetObject.domain;
    }
    if (hasValue(dotNetObject.editableExpression)) {
        jsFieldElement.editableExpression = dotNetObject.editableExpression;
    }
    if (hasValue(dotNetObject.fieldName)) {
        jsFieldElement.fieldName = dotNetObject.fieldName;
    }
    if (hasValue(dotNetObject.hint)) {
        jsFieldElement.hint = dotNetObject.hint;
    }
    if (hasValue(dotNetObject.input)) {
        jsFieldElement.input = dotNetObject.input;
    }
    if (hasValue(dotNetObject.label)) {
        jsFieldElement.label = dotNetObject.label;
    }
    if (hasValue(dotNetObject.requiredExpression)) {
        jsFieldElement.requiredExpression = dotNetObject.requiredExpression;
    }
    if (hasValue(dotNetObject.valueExpression)) {
        jsFieldElement.valueExpression = dotNetObject.valueExpression;
    }
    if (hasValue(dotNetObject.visibilityExpression)) {
        jsFieldElement.visibilityExpression = dotNetObject.visibilityExpression;
    }
    let { default: FieldElementWrapper } = await import('./fieldElement');
    let fieldElementWrapper = new FieldElementWrapper(jsFieldElement);
    fieldElementWrapper.geoBlazorId = dotNetObject.id;
    fieldElementWrapper.viewId = viewId;
    fieldElementWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(fieldElementWrapper);
    jsObjectRefs[dotNetObject.id] = fieldElementWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsFieldElement;
    let { buildDotNetFieldElement } = await import('./fieldElement');
    let dnInstantiatedObject = await buildDotNetFieldElement(jsFieldElement);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FieldElement', e);
    }
    
    return jsFieldElement;
}

export async function buildDotNetFieldElementGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFieldElement: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.description)) {
            dotNetFieldElement.description = jsObject.description;
        }
        if (hasValue(jsObject.domain)) {
            dotNetFieldElement.domain = jsObject.domain;
        }
        if (hasValue(jsObject.editableExpression)) {
            dotNetFieldElement.editableExpression = jsObject.editableExpression;
        }
        if (hasValue(jsObject.fieldName)) {
            dotNetFieldElement.fieldName = jsObject.fieldName;
        }
        if (hasValue(jsObject.hint)) {
            dotNetFieldElement.hint = jsObject.hint;
        }
        if (hasValue(jsObject.input)) {
            dotNetFieldElement.input = jsObject.input;
        }
        if (hasValue(jsObject.label)) {
            dotNetFieldElement.label = jsObject.label;
        }
        if (hasValue(jsObject.requiredExpression)) {
            dotNetFieldElement.requiredExpression = jsObject.requiredExpression;
        }
        if (hasValue(jsObject.type)) {
            dotNetFieldElement.type = jsObject.type;
        }
        if (hasValue(jsObject.valueExpression)) {
            dotNetFieldElement.valueExpression = jsObject.valueExpression;
        }
        if (hasValue(jsObject.visibilityExpression)) {
            dotNetFieldElement.visibilityExpression = jsObject.visibilityExpression;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFieldElement.id = k;
                break;
            }
        }
    }

    return dotNetFieldElement;
}

