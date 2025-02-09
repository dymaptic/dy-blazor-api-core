// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import UniqueValueClass from '@arcgis/core/renderers/support/UniqueValueClass';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class UniqueValueClassGenerated implements IPropertyWrapper {
    public component: UniqueValueClass;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: UniqueValueClass) {
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
    
    async getSymbol(): Promise<any> {
        let { buildDotNetSymbol } = await import('./symbol');
        return buildDotNetSymbol(this.component.symbol);
    }
    async setSymbol(value: any): Promise<void> {
        let { buildJsSymbol } = await import('./symbol');
        this.component.symbol =  buildJsSymbol(value);
    }
    async getValues(): Promise<any> {
        let { buildDotNetUniqueValue } = await import('./uniqueValue');
        return this.component.values.map(async i => await buildDotNetUniqueValue(i));
    }
    
    async setValues(value: any): Promise<void> {
        let { buildJsUniqueValue } = await import('./uniqueValue');
        this.component.values = value.map(async i => await buildJsUniqueValue(i, this.layerId, this.viewId));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsUniqueValueClassGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsUniqueValueClass = new UniqueValueClass();
    if (hasValue(dotNetObject.symbol)) {
        let { buildJsSymbol } = await import('./jsBuilder');
        jsUniqueValueClass.symbol = buildJsSymbol(dotNetObject.symbol) as any;
    }
    if (hasValue(dotNetObject.values)) {
        let { buildJsUniqueValue } = await import('./uniqueValue');
        jsUniqueValueClass.values = dotNetObject.values.map(async i => await buildJsUniqueValue(i, layerId, viewId)) as any;
    }

    if (hasValue(dotNetObject.label)) {
        jsUniqueValueClass.label = dotNetObject.label;
    }
    let { default: UniqueValueClassWrapper } = await import('./uniqueValueClass');
    let uniqueValueClassWrapper = new UniqueValueClassWrapper(jsUniqueValueClass);
    uniqueValueClassWrapper.geoBlazorId = dotNetObject.id;
    uniqueValueClassWrapper.viewId = viewId;
    uniqueValueClassWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(uniqueValueClassWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = uniqueValueClassWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsUniqueValueClass;
    
    return jsUniqueValueClass;
}

export async function buildDotNetUniqueValueClassGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetUniqueValueClass: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.symbol)) {
            let { buildDotNetSymbol } = await import('./dotNetBuilder');
            dotNetUniqueValueClass.symbol = buildDotNetSymbol(jsObject.symbol);
        }
        if (hasValue(jsObject.values)) {
            let { buildDotNetUniqueValue } = await import('./uniqueValue');
            dotNetUniqueValueClass.values = jsObject.values.map(async i => await buildDotNetUniqueValue(i));
        }
        dotNetUniqueValueClass.label = jsObject.label;

    return dotNetUniqueValueClass;
}

