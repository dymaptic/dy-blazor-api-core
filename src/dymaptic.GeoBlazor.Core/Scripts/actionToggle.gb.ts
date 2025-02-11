// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ActionToggle from '@arcgis/core/support/actions/ActionToggle';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ActionToggleGenerated implements IPropertyWrapper {
    public component: ActionToggle;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ActionToggle) {
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

export async function buildJsActionToggleGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsActionToggle = new ActionToggle();

    if (hasValue(dotNetObject.actionId)) {
        jsActionToggle.id = dotNetObject.actionId;
    }
    if (hasValue(dotNetObject.active)) {
        jsActionToggle.active = dotNetObject.active;
    }
    if (hasValue(dotNetObject.className)) {
        jsActionToggle.className = dotNetObject.className;
    }
    if (hasValue(dotNetObject.disabled)) {
        jsActionToggle.disabled = dotNetObject.disabled;
    }
    if (hasValue(dotNetObject.icon)) {
        jsActionToggle.icon = dotNetObject.icon;
    }
    if (hasValue(dotNetObject.title)) {
        jsActionToggle.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.value)) {
        jsActionToggle.value = dotNetObject.value;
    }
    let { default: ActionToggleWrapper } = await import('./actionToggle');
    let actionToggleWrapper = new ActionToggleWrapper(jsActionToggle);
    actionToggleWrapper.geoBlazorId = dotNetObject.id;
    actionToggleWrapper.viewId = viewId;
    actionToggleWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(actionToggleWrapper);
    jsObjectRefs[dotNetObject.id] = actionToggleWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsActionToggle;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ActionToggle', e);
    }
    
    return jsActionToggle;
}

export async function buildDotNetActionToggleGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetActionToggle: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.id)) {
            dotNetActionToggle.actionId = jsObject.id;
        }
        if (hasValue(jsObject.active)) {
            dotNetActionToggle.active = jsObject.active;
        }
        if (hasValue(jsObject.className)) {
            dotNetActionToggle.className = jsObject.className;
        }
        if (hasValue(jsObject.disabled)) {
            dotNetActionToggle.disabled = jsObject.disabled;
        }
        if (hasValue(jsObject.icon)) {
            dotNetActionToggle.icon = jsObject.icon;
        }
        if (hasValue(jsObject.title)) {
            dotNetActionToggle.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetActionToggle.type = jsObject.type;
        }
        if (hasValue(jsObject.value)) {
            dotNetActionToggle.value = jsObject.value;
        }

    return dotNetActionToggle;
}

