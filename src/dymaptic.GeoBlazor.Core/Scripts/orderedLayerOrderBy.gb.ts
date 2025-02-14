// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import OrderedLayerOrderBy = __esri.OrderedLayerOrderBy;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class OrderedLayerOrderByGenerated implements IPropertyWrapper {
    public component: OrderedLayerOrderBy;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: OrderedLayerOrderBy) {
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

export async function buildJsOrderedLayerOrderByGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsOrderedLayerOrderBy: any = {}

    if (hasValue(dotNetObject.field)) {
        jsOrderedLayerOrderBy.field = dotNetObject.field;
    }
    if (hasValue(dotNetObject.order)) {
        jsOrderedLayerOrderBy.order = dotNetObject.order;
    }
    if (hasValue(dotNetObject.valueExpression)) {
        jsOrderedLayerOrderBy.valueExpression = dotNetObject.valueExpression;
    }
    let { default: OrderedLayerOrderByWrapper } = await import('./orderedLayerOrderBy');
    let orderedLayerOrderByWrapper = new OrderedLayerOrderByWrapper(jsOrderedLayerOrderBy);
    orderedLayerOrderByWrapper.geoBlazorId = dotNetObject.id;
    orderedLayerOrderByWrapper.viewId = viewId;
    orderedLayerOrderByWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(orderedLayerOrderByWrapper);
    jsObjectRefs[dotNetObject.id] = orderedLayerOrderByWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsOrderedLayerOrderBy;
    
    let dnInstantiatedObject = await buildDotNetOrderedLayerOrderBy(jsOrderedLayerOrderBy);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for OrderedLayerOrderBy', e);
    }
    
    return jsOrderedLayerOrderBy;
}

export async function buildDotNetOrderedLayerOrderByGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetOrderedLayerOrderBy: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.field)) {
            dotNetOrderedLayerOrderBy.field = jsObject.field;
        }
        if (hasValue(jsObject.order)) {
            dotNetOrderedLayerOrderBy.order = jsObject.order;
        }
        if (hasValue(jsObject.valueExpression)) {
            dotNetOrderedLayerOrderBy.valueExpression = jsObject.valueExpression;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetOrderedLayerOrderBy.id = k;
                break;
            }
        }
    }

    return dotNetOrderedLayerOrderBy;
}

