// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import Field from '@arcgis/core/layers/support/Field';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FieldGenerated implements IPropertyWrapper {
    public component: Field;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: Field) {
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

export async function buildJsFieldGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsField = new Field();

    if (hasValue(dotNetObject.alias)) {
        jsField.alias = dotNetObject.alias;
    }
    if (hasValue(dotNetObject.defaultValue)) {
        jsField.defaultValue = dotNetObject.defaultValue;
    }
    if (hasValue(dotNetObject.description)) {
        jsField.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.domain)) {
        jsField.domain = dotNetObject.domain;
    }
    if (hasValue(dotNetObject.editable)) {
        jsField.editable = dotNetObject.editable;
    }
    if (hasValue(dotNetObject.length)) {
        jsField.length = dotNetObject.length;
    }
    if (hasValue(dotNetObject.name)) {
        jsField.name = dotNetObject.name;
    }
    if (hasValue(dotNetObject.nullable)) {
        jsField.nullable = dotNetObject.nullable;
    }
    if (hasValue(dotNetObject.type)) {
        jsField.type = dotNetObject.type;
    }
    if (hasValue(dotNetObject.valueType)) {
        jsField.valueType = dotNetObject.valueType;
    }
    let { default: FieldWrapper } = await import('./field');
    let fieldWrapper = new FieldWrapper(jsField);
    fieldWrapper.geoBlazorId = dotNetObject.id;
    fieldWrapper.viewId = viewId;
    fieldWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(fieldWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = fieldWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsField;
    
    return jsField;
}

export async function buildDotNetFieldGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetField: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        dotNetField.alias = jsObject.alias;
        dotNetField.defaultValue = jsObject.defaultValue;
        dotNetField.description = jsObject.description;
        dotNetField.domain = jsObject.domain;
        dotNetField.editable = jsObject.editable;
        dotNetField.length = jsObject.length;
        dotNetField.name = jsObject.name;
        dotNetField.nullable = jsObject.nullable;
        dotNetField.type = jsObject.type;
        dotNetField.valueType = jsObject.valueType;

    return dotNetField;
}

