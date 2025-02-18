// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FeatureEffect from '@arcgis/core/layers/support/FeatureEffect';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FeatureEffectGenerated implements IPropertyWrapper {
    public component: FeatureEffect;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FeatureEffect) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getFilter(): Promise<any> {
        if (!hasValue(this.component.filter)) {
            return null;
        }
        
        let { buildDotNetFeatureFilter } = await import('./featureFilter');
        return await buildDotNetFeatureFilter(this.component.filter);
    }
    async setFilter(value: any): Promise<void> {
        let { buildJsFeatureFilter } = await import('./featureFilter');
        this.component.filter =  buildJsFeatureFilter(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsFeatureEffectGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFeatureEffect = new FeatureEffect();
    if (hasValue(dotNetObject.filter)) {
        let { buildJsFeatureFilter } = await import('./jsBuilder');
        jsFeatureEffect.filter = buildJsFeatureFilter(dotNetObject.filter) as any;
    }

    if (hasValue(dotNetObject.excludedEffect)) {
        jsFeatureEffect.excludedEffect = dotNetObject.excludedEffect;
    }
    if (hasValue(dotNetObject.excludedLabelsVisible)) {
        jsFeatureEffect.excludedLabelsVisible = dotNetObject.excludedLabelsVisible;
    }
    if (hasValue(dotNetObject.includedEffect)) {
        jsFeatureEffect.includedEffect = dotNetObject.includedEffect;
    }
    let { default: FeatureEffectWrapper } = await import('./featureEffect');
    let featureEffectWrapper = new FeatureEffectWrapper(jsFeatureEffect);
    featureEffectWrapper.geoBlazorId = dotNetObject.id;
    featureEffectWrapper.viewId = viewId;
    featureEffectWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(featureEffectWrapper);
    jsObjectRefs[dotNetObject.id] = featureEffectWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsFeatureEffect;
    let { buildDotNetFeatureEffect } = await import('./featureEffect');
    let dnInstantiatedObject = await buildDotNetFeatureEffect(jsFeatureEffect);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FeatureEffect', e);
    }
    
    return jsFeatureEffect;
}

export async function buildDotNetFeatureEffectGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFeatureEffect: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.filter)) {
            let { buildDotNetFeatureFilter } = await import('./featureFilter');
            dotNetFeatureEffect.filter = await buildDotNetFeatureFilter(jsObject.filter);
        }
        if (hasValue(jsObject.excludedEffect)) {
            dotNetFeatureEffect.excludedEffect = jsObject.excludedEffect;
        }
        if (hasValue(jsObject.excludedLabelsVisible)) {
            dotNetFeatureEffect.excludedLabelsVisible = jsObject.excludedLabelsVisible;
        }
        if (hasValue(jsObject.includedEffect)) {
            dotNetFeatureEffect.includedEffect = jsObject.includedEffect;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFeatureEffect.id = k;
                break;
            }
        }
    }

    return dotNetFeatureEffect;
}

