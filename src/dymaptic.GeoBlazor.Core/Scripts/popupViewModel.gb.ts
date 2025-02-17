// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import PopupViewModel from '@arcgis/core/widgets/Popup/PopupViewModel';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class PopupViewModelGenerated implements IPropertyWrapper {
    public component: PopupViewModel;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: PopupViewModel) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async clear(): Promise<void> {
        this.component.clear();
    }

    async fetchFeatures(screenPoint: any,
        options: any): Promise<any> {
        let { buildJsFeaturesViewModelFetchFeaturesScreenPoint } = await import('./featuresViewModelFetchFeaturesScreenPoint');
        let jsScreenPoint = await buildJsFeaturesViewModelFetchFeaturesScreenPoint(screenPoint, this.layerId, this.viewId) as any;
        return await this.component.fetchFeatures(jsScreenPoint,
            options);
    }

    async next(): Promise<any> {
        let result = this.component.next();
        let { buildDotNetFeaturesViewModel } = await import('./featuresViewModel');
        return await buildDotNetFeaturesViewModel(result, this.layerId, this.viewId);
    }

    async open(options: any): Promise<void> {
        this.component.open(options);
    }

    async previous(): Promise<any> {
        let result = this.component.previous();
        let { buildDotNetFeaturesViewModel } = await import('./featuresViewModel');
        return await buildDotNetFeaturesViewModel(result, this.layerId, this.viewId);
    }

    async triggerAction(actionIndex: any): Promise<void> {
        this.component.triggerAction(actionIndex);
    }

    // region properties
    
    async getFeatures(): Promise<any> {
        if (!hasValue(this.component.features)) {
            return null;
        }
        
        let { buildDotNetGraphic } = await import('./graphic');
        return await Promise.all(this.component.features.map(async i => await buildDotNetGraphic(i)));
    }
    
    async setFeatures(value: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        this.component.features = await Promise.all(value.map(async i => await buildJsGraphic(i, this.layerId, this.viewId))) as any;
    }
    
    async getFeatureViewModelAbilities(): Promise<any> {
        if (!hasValue(this.component.featureViewModelAbilities)) {
            return null;
        }
        
        let { buildDotNetAbilities } = await import('./abilities');
        return await buildDotNetAbilities(this.component.featureViewModelAbilities, this.layerId, this.viewId);
    }
    async setFeatureViewModelAbilities(value: any): Promise<void> {
        let { buildJsAbilities } = await import('./abilities');
        this.component.featureViewModelAbilities = await  buildJsAbilities(value, this.layerId, this.viewId);
    }
    async getFeatureViewModels(): Promise<any> {
        if (!hasValue(this.component.featureViewModels)) {
            return null;
        }
        
        let { buildDotNetFeatureViewModel } = await import('./featureViewModel');
        return await Promise.all(this.component.featureViewModels.map(async i => await buildDotNetFeatureViewModel(i)));
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
    async getSelectedClusterBoundaryFeature(): Promise<any> {
        if (!hasValue(this.component.selectedClusterBoundaryFeature)) {
            return null;
        }
        
        let { buildDotNetGraphic } = await import('./graphic');
        return await buildDotNetGraphic(this.component.selectedClusterBoundaryFeature, this.layerId, this.viewId);
    }
    async getSelectedFeature(): Promise<any> {
        if (!hasValue(this.component.selectedFeature)) {
            return null;
        }
        
        let { buildDotNetGraphic } = await import('./graphic');
        return await buildDotNetGraphic(this.component.selectedFeature, this.layerId, this.viewId);
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
        this.component.spatialReference = await  buildJsSpatialReference(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsPopupViewModelGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsPopupViewModel = new PopupViewModel();
    if (hasValue(dotNetObject.features)) {
        let { buildJsGraphic } = await import('./graphic');
        jsPopupViewModel.features = dotNetObject.features.map(i => buildJsGraphic(i, layerId, viewId)) as any;
    }
    if (hasValue(dotNetObject.featureViewModelAbilities)) {
        let { buildJsAbilities } = await import('./abilities');
        jsPopupViewModel.featureViewModelAbilities = await buildJsAbilities(dotNetObject.featureViewModelAbilities, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.location)) {
        let { buildJsPoint } = await import('./point');
        jsPopupViewModel.location = buildJsPoint(dotNetObject.location) as any;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        let { buildJsSpatialReference } = await import('./spatialReference');
        jsPopupViewModel.spatialReference = await buildJsSpatialReference(dotNetObject.spatialReference) as any;
    }

    if (hasValue(dotNetObject.actions)) {
        jsPopupViewModel.actions = dotNetObject.actions;
    }
    if (hasValue(dotNetObject.autoCloseEnabled)) {
        jsPopupViewModel.autoCloseEnabled = dotNetObject.autoCloseEnabled;
    }
    if (hasValue(dotNetObject.browseClusterEnabled)) {
        jsPopupViewModel.browseClusterEnabled = dotNetObject.browseClusterEnabled;
    }
    if (hasValue(dotNetObject.content)) {
        jsPopupViewModel.content = dotNetObject.content;
    }
    if (hasValue(dotNetObject.defaultPopupTemplateEnabled)) {
        jsPopupViewModel.defaultPopupTemplateEnabled = dotNetObject.defaultPopupTemplateEnabled;
    }
    if (hasValue(dotNetObject.featuresPerPage)) {
        jsPopupViewModel.featuresPerPage = dotNetObject.featuresPerPage;
    }
    if (hasValue(dotNetObject.goToOverride)) {
        jsPopupViewModel.goToOverride = dotNetObject.goToOverride;
    }
    if (hasValue(dotNetObject.highlightEnabled)) {
        jsPopupViewModel.highlightEnabled = dotNetObject.highlightEnabled;
    }
    if (hasValue(dotNetObject.includeDefaultActions)) {
        jsPopupViewModel.includeDefaultActions = dotNetObject.includeDefaultActions;
    }
    if (hasValue(dotNetObject.map)) {
        jsPopupViewModel.map = dotNetObject.map;
    }
    if (hasValue(dotNetObject.promises)) {
        jsPopupViewModel.promises = dotNetObject.promises;
    }
    if (hasValue(dotNetObject.selectedFeatureIndex)) {
        jsPopupViewModel.selectedFeatureIndex = dotNetObject.selectedFeatureIndex;
    }
    if (hasValue(dotNetObject.timeZone)) {
        jsPopupViewModel.timeZone = dotNetObject.timeZone;
    }
    if (hasValue(dotNetObject.title)) {
        jsPopupViewModel.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.view)) {
        jsPopupViewModel.view = dotNetObject.view;
    }
    jsPopupViewModel.on('trigger-action', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsTriggerAction', evt);
    });
    
    let { default: PopupViewModelWrapper } = await import('./popupViewModel');
    let popupViewModelWrapper = new PopupViewModelWrapper(jsPopupViewModel);
    popupViewModelWrapper.geoBlazorId = dotNetObject.id;
    popupViewModelWrapper.viewId = viewId;
    popupViewModelWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(popupViewModelWrapper);
    jsObjectRefs[dotNetObject.id] = popupViewModelWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsPopupViewModel;
    
    let { buildDotNetPopupViewModel } = await import('./popupViewModel');
    let dnInstantiatedObject = await buildDotNetPopupViewModel(jsPopupViewModel, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for PopupViewModel', e);
    }
    
    return jsPopupViewModel;
}

export async function buildDotNetPopupViewModelGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetPopupViewModel: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.features)) {
            let { buildDotNetGraphic } = await import('./graphic');
            dotNetPopupViewModel.features = await Promise.all(jsObject.features.map(async i => await buildDotNetGraphic(i, layerId, viewId)));
        }
        if (hasValue(jsObject.featureViewModelAbilities)) {
            let { buildDotNetAbilities } = await import('./abilities');
            dotNetPopupViewModel.featureViewModelAbilities = await buildDotNetAbilities(jsObject.featureViewModelAbilities, layerId, viewId);
        }
        if (hasValue(jsObject.featureViewModels)) {
            let { buildDotNetFeatureViewModel } = await import('./featureViewModel');
            dotNetPopupViewModel.featureViewModels = await Promise.all(jsObject.featureViewModels.map(async i => await buildDotNetFeatureViewModel(i, layerId, viewId)));
        }
        if (hasValue(jsObject.location)) {
            let { buildDotNetPoint } = await import('./point');
            dotNetPopupViewModel.location = buildDotNetPoint(jsObject.location);
        }
        if (hasValue(jsObject.selectedClusterBoundaryFeature)) {
            let { buildDotNetGraphic } = await import('./graphic');
            dotNetPopupViewModel.selectedClusterBoundaryFeature = await buildDotNetGraphic(jsObject.selectedClusterBoundaryFeature, layerId, viewId);
        }
        if (hasValue(jsObject.selectedFeature)) {
            let { buildDotNetGraphic } = await import('./graphic');
            dotNetPopupViewModel.selectedFeature = await buildDotNetGraphic(jsObject.selectedFeature, layerId, viewId);
        }
        if (hasValue(jsObject.spatialReference)) {
            let { buildDotNetSpatialReference } = await import('./spatialReference');
            dotNetPopupViewModel.spatialReference = buildDotNetSpatialReference(jsObject.spatialReference);
        }
        if (hasValue(jsObject.actions)) {
            dotNetPopupViewModel.actions = jsObject.actions;
        }
        if (hasValue(jsObject.active)) {
            dotNetPopupViewModel.active = jsObject.active;
        }
        if (hasValue(jsObject.allActions)) {
            dotNetPopupViewModel.allActions = jsObject.allActions;
        }
        if (hasValue(jsObject.autoCloseEnabled)) {
            dotNetPopupViewModel.autoCloseEnabled = jsObject.autoCloseEnabled;
        }
        if (hasValue(jsObject.browseClusterEnabled)) {
            dotNetPopupViewModel.browseClusterEnabled = jsObject.browseClusterEnabled;
        }
        if (hasValue(jsObject.content)) {
            dotNetPopupViewModel.content = jsObject.content;
        }
        if (hasValue(jsObject.defaultActions)) {
            dotNetPopupViewModel.defaultActions = jsObject.defaultActions;
        }
        if (hasValue(jsObject.defaultPopupTemplateEnabled)) {
            dotNetPopupViewModel.defaultPopupTemplateEnabled = jsObject.defaultPopupTemplateEnabled;
        }
        if (hasValue(jsObject.featureCount)) {
            dotNetPopupViewModel.featureCount = jsObject.featureCount;
        }
        if (hasValue(jsObject.featuresPerPage)) {
            dotNetPopupViewModel.featuresPerPage = jsObject.featuresPerPage;
        }
        if (hasValue(jsObject.goToOverride)) {
            dotNetPopupViewModel.goToOverride = jsObject.goToOverride;
        }
        if (hasValue(jsObject.highlightEnabled)) {
            dotNetPopupViewModel.highlightEnabled = jsObject.highlightEnabled;
        }
        if (hasValue(jsObject.includeDefaultActions)) {
            dotNetPopupViewModel.includeDefaultActions = jsObject.includeDefaultActions;
        }
        if (hasValue(jsObject.map)) {
            dotNetPopupViewModel.map = jsObject.map;
        }
        if (hasValue(jsObject.pendingPromisesCount)) {
            dotNetPopupViewModel.pendingPromisesCount = jsObject.pendingPromisesCount;
        }
        if (hasValue(jsObject.promiseCount)) {
            dotNetPopupViewModel.promiseCount = jsObject.promiseCount;
        }
        if (hasValue(jsObject.promises)) {
            dotNetPopupViewModel.promises = jsObject.promises;
        }
        if (hasValue(jsObject.selectedFeatureIndex)) {
            dotNetPopupViewModel.selectedFeatureIndex = jsObject.selectedFeatureIndex;
        }
        if (hasValue(jsObject.state)) {
            dotNetPopupViewModel.state = jsObject.state;
        }
        if (hasValue(jsObject.timeZone)) {
            dotNetPopupViewModel.timeZone = jsObject.timeZone;
        }
        if (hasValue(jsObject.title)) {
            dotNetPopupViewModel.title = jsObject.title;
        }
        if (hasValue(jsObject.view)) {
            dotNetPopupViewModel.view = jsObject.view;
        }
        if (hasValue(jsObject.waitingForResult)) {
            dotNetPopupViewModel.waitingForResult = jsObject.waitingForResult;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetPopupViewModel.id = k;
                break;
            }
        }
    }

    return dotNetPopupViewModel;
}

