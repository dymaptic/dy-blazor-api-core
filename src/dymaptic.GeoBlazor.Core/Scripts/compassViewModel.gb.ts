// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CompassViewModel from '@arcgis/core/widgets/Compass/CompassViewModel';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CompassViewModelGenerated implements IPropertyWrapper {
    public component: CompassViewModel;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: CompassViewModel) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async reset(): Promise<void> {
        this.component.reset();
    }

    // region properties
    
    async getOrientation(): Promise<any> {
        if (!hasValue(this.component.orientation)) {
            return null;
        }
        
        let { buildDotNetOrientation } = await import('./orientation');
        return await buildDotNetOrientation(this.component.orientation, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsCompassViewModelGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCompassViewModel = new CompassViewModel();

    if (hasValue(dotNetObject.goToOverride)) {
        jsCompassViewModel.goToOverride = dotNetObject.goToOverride;
    }
    if (hasValue(dotNetObject.view)) {
        jsCompassViewModel.view = dotNetObject.view;
    }
    let { default: CompassViewModelWrapper } = await import('./compassViewModel');
    let compassViewModelWrapper = new CompassViewModelWrapper(jsCompassViewModel);
    compassViewModelWrapper.geoBlazorId = dotNetObject.id;
    compassViewModelWrapper.viewId = viewId;
    compassViewModelWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(compassViewModelWrapper);
    jsObjectRefs[dotNetObject.id] = compassViewModelWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCompassViewModel;
    
    let { buildDotNetCompassViewModel } = await import('./compassViewModel');
    let dnInstantiatedObject = await buildDotNetCompassViewModel(jsCompassViewModel, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for CompassViewModel', e);
    }
    
    return jsCompassViewModel;
}

export async function buildDotNetCompassViewModelGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCompassViewModel: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.orientation)) {
            let { buildDotNetOrientation } = await import('./orientation');
            dotNetCompassViewModel.orientation = await buildDotNetOrientation(jsObject.orientation, layerId, viewId);
        }
        if (hasValue(jsObject.goToOverride)) {
            dotNetCompassViewModel.goToOverride = jsObject.goToOverride;
        }
        if (hasValue(jsObject.state)) {
            dotNetCompassViewModel.state = jsObject.state;
        }
        if (hasValue(jsObject.view)) {
            dotNetCompassViewModel.view = jsObject.view;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetCompassViewModel.id = k;
                break;
            }
        }
    }

    return dotNetCompassViewModel;
}

