// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FieldInfoFormat from '@arcgis/core/popup/support/FieldInfoFormat';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FieldInfoFormatGenerated implements IPropertyWrapper {
    public component: FieldInfoFormat;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FieldInfoFormat) {
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

export async function buildJsFieldInfoFormatGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFieldInfoFormat = new FieldInfoFormat();

    if (hasValue(dotNetObject.dateFormat)) {
        jsFieldInfoFormat.dateFormat = dotNetObject.dateFormat;
    }
    if (hasValue(dotNetObject.digitSeparator)) {
        jsFieldInfoFormat.digitSeparator = dotNetObject.digitSeparator;
    }
    if (hasValue(dotNetObject.places)) {
        jsFieldInfoFormat.places = dotNetObject.places;
    }
    let { default: FieldInfoFormatWrapper } = await import('./fieldInfoFormat');
    let fieldInfoFormatWrapper = new FieldInfoFormatWrapper(jsFieldInfoFormat);
    fieldInfoFormatWrapper.geoBlazorId = dotNetObject.id;
    fieldInfoFormatWrapper.viewId = viewId;
    fieldInfoFormatWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(fieldInfoFormatWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = fieldInfoFormatWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsFieldInfoFormat;
    
    return jsFieldInfoFormat;
}

export function buildDotNetFieldInfoFormatGenerated(jsObject: any): any {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFieldInfoFormat: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        dotNetFieldInfoFormat.dateFormat = jsObject.dateFormat;
        dotNetFieldInfoFormat.digitSeparator = jsObject.digitSeparator;
        dotNetFieldInfoFormat.places = jsObject.places;

    return dotNetFieldInfoFormat;
}

