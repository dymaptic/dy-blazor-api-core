// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FeaturesViewModel from '@arcgis/core/widgets/Features/FeaturesViewModel';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FeaturesViewModelGenerated implements IPropertyWrapper {
    public component: FeaturesViewModel;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FeaturesViewModel) {
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
        return this.component.features!.map(i => buildDotNetGraphic(i));
    }
    
    async setFeatures(value: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        this.component.features = value.map(i => buildJsGraphic(i)) as any;
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
        return buildDotNetGraphic(this.component.selectedClusterBoundaryFeature, this.layerId, this.viewId);
    }
    async getSelectedFeature(): Promise<any> {
        if (!hasValue(this.component.selectedFeature)) {
            return null;
        }
        
        let { buildDotNetGraphic } = await import('./graphic');
        return buildDotNetGraphic(this.component.selectedFeature, this.layerId, this.viewId);
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

export async function buildJsFeaturesViewModelGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFeaturesViewModel = new FeaturesViewModel();
    if (hasValue(dotNetObject.features)) {
        let { buildJsGraphic } = await import('./graphic');
        jsFeaturesViewModel.features = dotNetObject.features.map(i => buildJsGraphic(i)) as any;
    }
    if (hasValue(dotNetObject.featureViewModelAbilities)) {
        let { buildJsAbilities } = await import('./abilities');
        jsFeaturesViewModel.featureViewModelAbilities = await buildJsAbilities(dotNetObject.featureViewModelAbilities, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.location)) {
        let { buildJsPoint } = await import('./point');
        jsFeaturesViewModel.location = buildJsPoint(dotNetObject.location) as any;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        let { buildJsSpatialReference } = await import('./spatialReference');
        jsFeaturesViewModel.spatialReference = buildJsSpatialReference(dotNetObject.spatialReference) as any;
    }

    if (hasValue(dotNetObject.actions)) {
        jsFeaturesViewModel.actions = dotNetObject.actions;
    }
    if (hasValue(dotNetObject.autoCloseEnabled)) {
        jsFeaturesViewModel.autoCloseEnabled = dotNetObject.autoCloseEnabled;
    }
    if (hasValue(dotNetObject.browseClusterEnabled)) {
        jsFeaturesViewModel.browseClusterEnabled = dotNetObject.browseClusterEnabled;
    }
    if (hasValue(dotNetObject.content)) {
        jsFeaturesViewModel.content = dotNetObject.content;
    }
    if (hasValue(dotNetObject.defaultPopupTemplateEnabled)) {
        jsFeaturesViewModel.defaultPopupTemplateEnabled = dotNetObject.defaultPopupTemplateEnabled;
    }
    if (hasValue(dotNetObject.featuresPerPage)) {
        jsFeaturesViewModel.featuresPerPage = dotNetObject.featuresPerPage;
    }
    if (hasValue(dotNetObject.goToOverride)) {
        jsFeaturesViewModel.goToOverride = dotNetObject.goToOverride;
    }
    if (hasValue(dotNetObject.highlightEnabled)) {
        jsFeaturesViewModel.highlightEnabled = dotNetObject.highlightEnabled;
    }
    if (hasValue(dotNetObject.includeDefaultActions)) {
        jsFeaturesViewModel.includeDefaultActions = dotNetObject.includeDefaultActions;
    }
    if (hasValue(dotNetObject.map)) {
        jsFeaturesViewModel.map = dotNetObject.map;
    }
    if (hasValue(dotNetObject.promises)) {
        jsFeaturesViewModel.promises = dotNetObject.promises;
    }
    if (hasValue(dotNetObject.selectedFeatureIndex)) {
        jsFeaturesViewModel.selectedFeatureIndex = dotNetObject.selectedFeatureIndex;
    }
    if (hasValue(dotNetObject.timeZone)) {
        jsFeaturesViewModel.timeZone = dotNetObject.timeZone;
    }
    if (hasValue(dotNetObject.title)) {
        jsFeaturesViewModel.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.view)) {
        jsFeaturesViewModel.view = dotNetObject.view;
    }
    jsFeaturesViewModel.on('trigger-action', async (evt: any) => {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsTriggerAction', evt);
    });
    
    let { default: FeaturesViewModelWrapper } = await import('./featuresViewModel');
    let featuresViewModelWrapper = new FeaturesViewModelWrapper(jsFeaturesViewModel);
    featuresViewModelWrapper.geoBlazorId = dotNetObject.id;
    featuresViewModelWrapper.viewId = viewId;
    featuresViewModelWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(featuresViewModelWrapper);
    jsObjectRefs[dotNetObject.id] = featuresViewModelWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsFeaturesViewModel;
    let { buildDotNetFeaturesViewModel } = await import('./featuresViewModel');
    let dnInstantiatedObject = await buildDotNetFeaturesViewModel(jsFeaturesViewModel, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FeaturesViewModel', e);
    }
    
    return jsFeaturesViewModel;
}

export async function buildDotNetFeaturesViewModelGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFeaturesViewModel: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.features)) {
            let { buildDotNetGraphic } = await import('./graphic');
            dotNetFeaturesViewModel.features = jsObject.features.map(i => buildDotNetGraphic(i, layerId, viewId));
        }
        if (hasValue(jsObject.featureViewModelAbilities)) {
            let { buildDotNetAbilities } = await import('./abilities');
            dotNetFeaturesViewModel.featureViewModelAbilities = await buildDotNetAbilities(jsObject.featureViewModelAbilities, layerId, viewId);
        }
        if (hasValue(jsObject.featureViewModels)) {
            let { buildDotNetFeatureViewModel } = await import('./featureViewModel');
            dotNetFeaturesViewModel.featureViewModels = await Promise.all(jsObject.featureViewModels.map(async i => await buildDotNetFeatureViewModel(i, layerId, viewId)));
        }
        if (hasValue(jsObject.location)) {
            let { buildDotNetPoint } = await import('./point');
            dotNetFeaturesViewModel.location = buildDotNetPoint(jsObject.location);
        }
        if (hasValue(jsObject.selectedClusterBoundaryFeature)) {
            let { buildDotNetGraphic } = await import('./graphic');
            dotNetFeaturesViewModel.selectedClusterBoundaryFeature = buildDotNetGraphic(jsObject.selectedClusterBoundaryFeature, layerId, viewId);
        }
        if (hasValue(jsObject.selectedFeature)) {
            let { buildDotNetGraphic } = await import('./graphic');
            dotNetFeaturesViewModel.selectedFeature = buildDotNetGraphic(jsObject.selectedFeature, layerId, viewId);
        }
        if (hasValue(jsObject.spatialReference)) {
            let { buildDotNetSpatialReference } = await import('./spatialReference');
            dotNetFeaturesViewModel.spatialReference = buildDotNetSpatialReference(jsObject.spatialReference);
        }
        if (hasValue(jsObject.actions)) {
            dotNetFeaturesViewModel.actions = jsObject.actions;
        }
        if (hasValue(jsObject.active)) {
            dotNetFeaturesViewModel.active = jsObject.active;
        }
        if (hasValue(jsObject.allActions)) {
            dotNetFeaturesViewModel.allActions = jsObject.allActions;
        }
        if (hasValue(jsObject.autoCloseEnabled)) {
            dotNetFeaturesViewModel.autoCloseEnabled = jsObject.autoCloseEnabled;
        }
        if (hasValue(jsObject.browseClusterEnabled)) {
            dotNetFeaturesViewModel.browseClusterEnabled = jsObject.browseClusterEnabled;
        }
        if (hasValue(jsObject.content)) {
            dotNetFeaturesViewModel.content = jsObject.content;
        }
        if (hasValue(jsObject.defaultActions)) {
            dotNetFeaturesViewModel.defaultActions = jsObject.defaultActions;
        }
        if (hasValue(jsObject.defaultPopupTemplateEnabled)) {
            dotNetFeaturesViewModel.defaultPopupTemplateEnabled = jsObject.defaultPopupTemplateEnabled;
        }
        if (hasValue(jsObject.featureCount)) {
            dotNetFeaturesViewModel.featureCount = jsObject.featureCount;
        }
        if (hasValue(jsObject.featuresPerPage)) {
            dotNetFeaturesViewModel.featuresPerPage = jsObject.featuresPerPage;
        }
        if (hasValue(jsObject.goToOverride)) {
            dotNetFeaturesViewModel.goToOverride = jsObject.goToOverride;
        }
        if (hasValue(jsObject.highlightEnabled)) {
            dotNetFeaturesViewModel.highlightEnabled = jsObject.highlightEnabled;
        }
        if (hasValue(jsObject.includeDefaultActions)) {
            dotNetFeaturesViewModel.includeDefaultActions = jsObject.includeDefaultActions;
        }
        if (hasValue(jsObject.map)) {
            dotNetFeaturesViewModel.map = jsObject.map;
        }
        if (hasValue(jsObject.pendingPromisesCount)) {
            dotNetFeaturesViewModel.pendingPromisesCount = jsObject.pendingPromisesCount;
        }
        if (hasValue(jsObject.promiseCount)) {
            dotNetFeaturesViewModel.promiseCount = jsObject.promiseCount;
        }
        if (hasValue(jsObject.promises)) {
            dotNetFeaturesViewModel.promises = jsObject.promises;
        }
        if (hasValue(jsObject.selectedFeatureIndex)) {
            dotNetFeaturesViewModel.selectedFeatureIndex = jsObject.selectedFeatureIndex;
        }
        if (hasValue(jsObject.state)) {
            dotNetFeaturesViewModel.state = jsObject.state;
        }
        if (hasValue(jsObject.timeZone)) {
            dotNetFeaturesViewModel.timeZone = jsObject.timeZone;
        }
        if (hasValue(jsObject.title)) {
            dotNetFeaturesViewModel.title = jsObject.title;
        }
        if (hasValue(jsObject.view)) {
            dotNetFeaturesViewModel.view = jsObject.view;
        }
        if (hasValue(jsObject.waitingForResult)) {
            dotNetFeaturesViewModel.waitingForResult = jsObject.waitingForResult;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFeaturesViewModel.id = k;
                break;
            }
        }
    }

    return dotNetFeaturesViewModel;
}

