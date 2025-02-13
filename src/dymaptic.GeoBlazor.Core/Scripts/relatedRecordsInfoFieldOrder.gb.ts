// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import RelatedRecordsInfoFieldOrder from '@arcgis/core/popup/support/RelatedRecordsInfoFieldOrder';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class RelatedRecordsInfoFieldOrderGenerated implements IPropertyWrapper {
    public component: RelatedRecordsInfoFieldOrder;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: RelatedRecordsInfoFieldOrder) {
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

export async function buildJsRelatedRecordsInfoFieldOrderGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsRelatedRecordsInfoFieldOrder = new RelatedRecordsInfoFieldOrder();

    if (hasValue(dotNetObject.field)) {
        jsRelatedRecordsInfoFieldOrder.field = dotNetObject.field;
    }
    if (hasValue(dotNetObject.order)) {
        jsRelatedRecordsInfoFieldOrder.order = dotNetObject.order;
    }
    let { default: RelatedRecordsInfoFieldOrderWrapper } = await import('./relatedRecordsInfoFieldOrder');
    let relatedRecordsInfoFieldOrderWrapper = new RelatedRecordsInfoFieldOrderWrapper(jsRelatedRecordsInfoFieldOrder);
    relatedRecordsInfoFieldOrderWrapper.geoBlazorId = dotNetObject.id;
    relatedRecordsInfoFieldOrderWrapper.viewId = viewId;
    relatedRecordsInfoFieldOrderWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(relatedRecordsInfoFieldOrderWrapper);
    jsObjectRefs[dotNetObject.id] = relatedRecordsInfoFieldOrderWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsRelatedRecordsInfoFieldOrder;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for RelatedRecordsInfoFieldOrder', e);
    }
    
    return jsRelatedRecordsInfoFieldOrder;
}

export async function buildDotNetRelatedRecordsInfoFieldOrderGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetRelatedRecordsInfoFieldOrder: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.field)) {
            dotNetRelatedRecordsInfoFieldOrder.field = jsObject.field;
        }
        if (hasValue(jsObject.order)) {
            dotNetRelatedRecordsInfoFieldOrder.order = jsObject.order;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetRelatedRecordsInfoFieldOrder.id = k;
                break;
            }
        }
    }

    return dotNetRelatedRecordsInfoFieldOrder;
}

