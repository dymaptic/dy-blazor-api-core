// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FeatureViewModelFormattedAttributes = __esri.FeatureViewModelFormattedAttributes;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FeatureViewModelFormattedAttributesGenerated implements IPropertyWrapper {
    public component: FeatureViewModelFormattedAttributes;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FeatureViewModelFormattedAttributes) {
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

export async function buildJsFeatureViewModelFormattedAttributesGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFeatureViewModelFormattedAttributes: any = {}

    if (hasValue(dotNetObject.content)) {
        jsFeatureViewModelFormattedAttributes.content = dotNetObject.content;
    }
    if (hasValue(dotNetObject.global)) {
        jsFeatureViewModelFormattedAttributes.global = dotNetObject.global;
    }
    let { default: FeatureViewModelFormattedAttributesWrapper } = await import('./featureViewModelFormattedAttributes');
    let featureViewModelFormattedAttributesWrapper = new FeatureViewModelFormattedAttributesWrapper(jsFeatureViewModelFormattedAttributes);
    featureViewModelFormattedAttributesWrapper.geoBlazorId = dotNetObject.id;
    featureViewModelFormattedAttributesWrapper.viewId = viewId;
    featureViewModelFormattedAttributesWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(featureViewModelFormattedAttributesWrapper);
    jsObjectRefs[dotNetObject.id] = featureViewModelFormattedAttributesWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsFeatureViewModelFormattedAttributes;
    let { buildDotNetFeatureViewModelFormattedAttributes } = await import('./featureViewModelFormattedAttributes');
    let dnInstantiatedObject = await buildDotNetFeatureViewModelFormattedAttributes(jsFeatureViewModelFormattedAttributes, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FeatureViewModelFormattedAttributes', e);
    }
    
    return jsFeatureViewModelFormattedAttributes;
}

export async function buildDotNetFeatureViewModelFormattedAttributesGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFeatureViewModelFormattedAttributes: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.content)) {
            dotNetFeatureViewModelFormattedAttributes.content = jsObject.content;
        }
        if (hasValue(jsObject.global)) {
            dotNetFeatureViewModelFormattedAttributes.global = jsObject.global;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFeatureViewModelFormattedAttributes.id = k;
                break;
            }
        }
    }

    return dotNetFeatureViewModelFormattedAttributes;
}

