// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FeatureViewModel from '@arcgis/core/widgets/Feature/FeatureViewModel';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FeatureViewModelGenerated implements IPropertyWrapper {
    public component: FeatureViewModel;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FeatureViewModel) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async nextMedia(contentElementIndex: any): Promise<void> {
        this.component.nextMedia(contentElementIndex);
    }

    async previousMedia(contentElementIndex: any): Promise<void> {
        this.component.previousMedia(contentElementIndex);
    }

    async setActiveMedia(contentElementIndex: any,
        mediaInfoIndex: any): Promise<void> {
        this.component.setActiveMedia(contentElementIndex,
            mediaInfoIndex);
    }

    // region properties
    
    async getAbilities(): Promise<any> {
        if (!hasValue(this.component.abilities)) {
            return null;
        }
        
        let { buildDotNetAbilities } = await import('./abilities');
        return await buildDotNetAbilities(this.component.abilities, this.layerId, this.viewId);
    }
    async setAbilities(value: any): Promise<void> {
        let { buildJsAbilities } = await import('./abilities');
        this.component.abilities = await  buildJsAbilities(value, this.layerId, this.viewId);
    }
    async getContent(): Promise<any> {
        if (!hasValue(this.component.content)) {
            return null;
        }
        
        let { buildDotNetPopupContent } = await import('./popupContent');
        return this.component.content!.map(i => buildDotNetPopupContent(i));
    }
    
    async getFormattedAttributes(): Promise<any> {
        if (!hasValue(this.component.formattedAttributes)) {
            return null;
        }
        
        let { buildDotNetFeatureViewModelFormattedAttributes } = await import('./featureViewModelFormattedAttributes');
        return await buildDotNetFeatureViewModelFormattedAttributes(this.component.formattedAttributes, this.layerId, this.viewId);
    }
    async getGraphic(): Promise<any> {
        if (!hasValue(this.component.graphic)) {
            return null;
        }
        
        let { buildDotNetGraphic } = await import('./graphic');
        return buildDotNetGraphic(this.component.graphic, this.layerId, this.viewId);
    }
    async setGraphic(value: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        this.component.graphic =  buildJsGraphic(value);
    }
    async getLocation(): Promise<any> {
        if (!hasValue(this.component.location)) {
            return null;
        }
        
        let { buildDotNetPoint } = await import('./point');
        return buildDotNetPoint(this.component.location);
    }
    async setLocation(value: any): Promise<void> {
        let { buildJsPoint } = await import('./point');
        this.component.location =  buildJsPoint(value);
    }
    async getSpatialReference(): Promise<any> {
        if (!hasValue(this.component.spatialReference)) {
            return null;
        }
        
        let { buildDotNetSpatialReference } = await import('./spatialReference');
        return buildDotNetSpatialReference(this.component.spatialReference);
    }
    async setSpatialReference(value: any): Promise<void> {
        let { buildJsSpatialReference } = await import('./spatialReference');
        this.component.spatialReference =  buildJsSpatialReference(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsFeatureViewModelGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFeatureViewModel = new FeatureViewModel();
    if (hasValue(dotNetObject.abilities)) {
        let { buildJsAbilities } = await import('./abilities');
        jsFeatureViewModel.abilities = await buildJsAbilities(dotNetObject.abilities, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.graphic)) {
        let { buildJsGraphic } = await import('./graphic');
        jsFeatureViewModel.graphic = buildJsGraphic(dotNetObject.graphic) as any;
    }
    if (hasValue(dotNetObject.location)) {
        let { buildJsPoint } = await import('./point');
        jsFeatureViewModel.location = buildJsPoint(dotNetObject.location) as any;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        let { buildJsSpatialReference } = await import('./spatialReference');
        jsFeatureViewModel.spatialReference = buildJsSpatialReference(dotNetObject.spatialReference) as any;
    }

    if (hasValue(dotNetObject.defaultPopupTemplateEnabled)) {
        jsFeatureViewModel.defaultPopupTemplateEnabled = dotNetObject.defaultPopupTemplateEnabled;
    }
    if (hasValue(dotNetObject.map)) {
        jsFeatureViewModel.map = dotNetObject.map;
    }
    if (hasValue(dotNetObject.timeZone)) {
        jsFeatureViewModel.timeZone = dotNetObject.timeZone;
    }
    if (hasValue(dotNetObject.view)) {
        jsFeatureViewModel.view = dotNetObject.view;
    }
    let { default: FeatureViewModelWrapper } = await import('./featureViewModel');
    let featureViewModelWrapper = new FeatureViewModelWrapper(jsFeatureViewModel);
    featureViewModelWrapper.geoBlazorId = dotNetObject.id;
    featureViewModelWrapper.viewId = viewId;
    featureViewModelWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(featureViewModelWrapper);
    jsObjectRefs[dotNetObject.id] = featureViewModelWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsFeatureViewModel;
    let { buildDotNetFeatureViewModel } = await import('./featureViewModel');
    let dnInstantiatedObject = await buildDotNetFeatureViewModel(jsFeatureViewModel, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FeatureViewModel', e);
    }
    
    return jsFeatureViewModel;
}

export async function buildDotNetFeatureViewModelGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFeatureViewModel: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.abilities)) {
            let { buildDotNetAbilities } = await import('./abilities');
            dotNetFeatureViewModel.abilities = await buildDotNetAbilities(jsObject.abilities, layerId, viewId);
        }
        if (hasValue(jsObject.content)) {
            let { buildDotNetPopupContent } = await import('./popupContent');
            dotNetFeatureViewModel.content = jsObject.content.map(i => buildDotNetPopupContent(i));
        }
        if (hasValue(jsObject.formattedAttributes)) {
            let { buildDotNetFeatureViewModelFormattedAttributes } = await import('./featureViewModelFormattedAttributes');
            dotNetFeatureViewModel.formattedAttributes = await buildDotNetFeatureViewModelFormattedAttributes(jsObject.formattedAttributes, layerId, viewId);
        }
        if (hasValue(jsObject.graphic)) {
            let { buildDotNetGraphic } = await import('./graphic');
            dotNetFeatureViewModel.graphic = buildDotNetGraphic(jsObject.graphic, layerId, viewId);
        }
        if (hasValue(jsObject.location)) {
            let { buildDotNetPoint } = await import('./point');
            dotNetFeatureViewModel.location = buildDotNetPoint(jsObject.location);
        }
        if (hasValue(jsObject.spatialReference)) {
            let { buildDotNetSpatialReference } = await import('./spatialReference');
            dotNetFeatureViewModel.spatialReference = buildDotNetSpatialReference(jsObject.spatialReference);
        }
        if (hasValue(jsObject.defaultPopupTemplateEnabled)) {
            dotNetFeatureViewModel.defaultPopupTemplateEnabled = jsObject.defaultPopupTemplateEnabled;
        }
        if (hasValue(jsObject.lastEditInfo)) {
            dotNetFeatureViewModel.lastEditInfo = jsObject.lastEditInfo;
        }
        if (hasValue(jsObject.map)) {
            dotNetFeatureViewModel.map = jsObject.map;
        }
        if (hasValue(jsObject.state)) {
            dotNetFeatureViewModel.state = jsObject.state;
        }
        if (hasValue(jsObject.timeZone)) {
            dotNetFeatureViewModel.timeZone = jsObject.timeZone;
        }
        if (hasValue(jsObject.title)) {
            dotNetFeatureViewModel.title = jsObject.title;
        }
        if (hasValue(jsObject.view)) {
            dotNetFeatureViewModel.view = jsObject.view;
        }
        if (hasValue(jsObject.waitingForContent)) {
            dotNetFeatureViewModel.waitingForContent = jsObject.waitingForContent;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFeatureViewModel.id = k;
                break;
            }
        }
    }

    return dotNetFeatureViewModel;
}

