// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import SliderVisibleElements = __esri.SliderVisibleElements;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class SliderVisibleElementsGenerated implements IPropertyWrapper {
    public component: SliderVisibleElements;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: SliderVisibleElements) {
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

export async function buildJsSliderVisibleElementsGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsSliderVisibleElements: any = {}

    if (hasValue(dotNetObject.labels)) {
        jsSliderVisibleElements.labels = dotNetObject.labels;
    }
    if (hasValue(dotNetObject.rangeLabels)) {
        jsSliderVisibleElements.rangeLabels = dotNetObject.rangeLabels;
    }
    let { default: SliderVisibleElementsWrapper } = await import('./sliderVisibleElements');
    let sliderVisibleElementsWrapper = new SliderVisibleElementsWrapper(jsSliderVisibleElements);
    sliderVisibleElementsWrapper.geoBlazorId = dotNetObject.id;
    sliderVisibleElementsWrapper.viewId = viewId;
    sliderVisibleElementsWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(sliderVisibleElementsWrapper);
    jsObjectRefs[dotNetObject.id] = sliderVisibleElementsWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsSliderVisibleElements;
    let { buildDotNetSliderVisibleElements } = await import('./sliderVisibleElements');
    let dnInstantiatedObject = await buildDotNetSliderVisibleElements(jsSliderVisibleElements, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for SliderVisibleElements', e);
    }
    
    return jsSliderVisibleElements;
}

export async function buildDotNetSliderVisibleElementsGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetSliderVisibleElements: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.labels)) {
            dotNetSliderVisibleElements.labels = jsObject.labels;
        }
        if (hasValue(jsObject.rangeLabels)) {
            dotNetSliderVisibleElements.rangeLabels = jsObject.rangeLabels;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetSliderVisibleElements.id = k;
                break;
            }
        }
    }

    return dotNetSliderVisibleElements;
}

