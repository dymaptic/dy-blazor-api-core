// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import UniqueValueGroup from '@arcgis/core/renderers/support/UniqueValueGroup';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class UniqueValueGroupGenerated implements IPropertyWrapper {
    public component: UniqueValueGroup;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: UniqueValueGroup) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getClasses(): Promise<any> {
        let { buildDotNetUniqueValueClass } = await import('./uniqueValueClass');
        return this.component.classes.map(async i => await buildDotNetUniqueValueClass(i));
    }
    
    async setClasses(value: any): Promise<void> {
        let { buildJsUniqueValueClass } = await import('./uniqueValueClass');
        this.component.classes = value.map(async i => await buildJsUniqueValueClass(i, this.layerId, this.viewId));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsUniqueValueGroupGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsUniqueValueGroup = new UniqueValueGroup();
    if (hasValue(dotNetObject.classes)) {
        let { buildJsUniqueValueClass } = await import('./uniqueValueClass');
        jsUniqueValueGroup.classes = dotNetObject.classes.map(async i => await buildJsUniqueValueClass(i, layerId, viewId)) as any;
    }

    if (hasValue(dotNetObject.heading)) {
        jsUniqueValueGroup.heading = dotNetObject.heading;
    }
    let { default: UniqueValueGroupWrapper } = await import('./uniqueValueGroup');
    let uniqueValueGroupWrapper = new UniqueValueGroupWrapper(jsUniqueValueGroup);
    uniqueValueGroupWrapper.geoBlazorId = dotNetObject.id;
    uniqueValueGroupWrapper.viewId = viewId;
    uniqueValueGroupWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(uniqueValueGroupWrapper);
    jsObjectRefs[dotNetObject.id] = uniqueValueGroupWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsUniqueValueGroup;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for UniqueValueGroup', e);
    }
    
    return jsUniqueValueGroup;
}

export async function buildDotNetUniqueValueGroupGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetUniqueValueGroup: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.classes)) {
            let { buildDotNetUniqueValueClass } = await import('./uniqueValueClass');
            dotNetUniqueValueGroup.classes = jsObject.classes.map(async i => await buildDotNetUniqueValueClass(i));
        }
        if (hasValue(jsObject.heading)) {
            dotNetUniqueValueGroup.heading = jsObject.heading;
        }

    return dotNetUniqueValueGroup;
}

