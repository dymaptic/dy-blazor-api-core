// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GeoJSONLayerElevationInfo = __esri.GeoJSONLayerElevationInfo;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GeoJSONLayerElevationInfoGenerated implements IPropertyWrapper {
    public component: GeoJSONLayerElevationInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: GeoJSONLayerElevationInfo) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getFeatureExpressionInfo(): Promise<any> {
        if (!hasValue(this.component.featureExpressionInfo)) {
            return null;
        }
        
        let { buildDotNetGeoJSONLayerElevationInfoFeatureExpressionInfo } = await import('./geoJSONLayerElevationInfoFeatureExpressionInfo');
        return await buildDotNetGeoJSONLayerElevationInfoFeatureExpressionInfo(this.component.featureExpressionInfo);
    }
    async setFeatureExpressionInfo(value: any): Promise<void> {
        let { buildJsGeoJSONLayerElevationInfoFeatureExpressionInfo } = await import('./geoJSONLayerElevationInfoFeatureExpressionInfo');
        this.component.featureExpressionInfo = await  buildJsGeoJSONLayerElevationInfoFeatureExpressionInfo(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsGeoJSONLayerElevationInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGeoJSONLayerElevationInfo: any = {}
    if (hasValue(dotNetObject.featureExpressionInfo)) {
        let { buildJsGeoJSONLayerElevationInfoFeatureExpressionInfo } = await import('./geoJSONLayerElevationInfoFeatureExpressionInfo');
        jsGeoJSONLayerElevationInfo.featureExpressionInfo = await buildJsGeoJSONLayerElevationInfoFeatureExpressionInfo(dotNetObject.featureExpressionInfo, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.mode)) {
        jsGeoJSONLayerElevationInfo.mode = dotNetObject.mode;
    }
    if (hasValue(dotNetObject.offset)) {
        jsGeoJSONLayerElevationInfo.offset = dotNetObject.offset;
    }
    if (hasValue(dotNetObject.unit)) {
        jsGeoJSONLayerElevationInfo.unit = dotNetObject.unit;
    }
    let { default: GeoJSONLayerElevationInfoWrapper } = await import('./geoJSONLayerElevationInfo');
    let geoJSONLayerElevationInfoWrapper = new GeoJSONLayerElevationInfoWrapper(jsGeoJSONLayerElevationInfo);
    geoJSONLayerElevationInfoWrapper.geoBlazorId = dotNetObject.id;
    geoJSONLayerElevationInfoWrapper.viewId = viewId;
    geoJSONLayerElevationInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(geoJSONLayerElevationInfoWrapper);
    jsObjectRefs[dotNetObject.id] = geoJSONLayerElevationInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsGeoJSONLayerElevationInfo;
    
    let { buildDotNetGeoJSONLayerElevationInfo } = await import('./geoJSONLayerElevationInfo');
    let dnInstantiatedObject = await buildDotNetGeoJSONLayerElevationInfo(jsGeoJSONLayerElevationInfo);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for GeoJSONLayerElevationInfo', e);
    }
    
    return jsGeoJSONLayerElevationInfo;
}

export async function buildDotNetGeoJSONLayerElevationInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGeoJSONLayerElevationInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.featureExpressionInfo)) {
            let { buildDotNetGeoJSONLayerElevationInfoFeatureExpressionInfo } = await import('./geoJSONLayerElevationInfoFeatureExpressionInfo');
            dotNetGeoJSONLayerElevationInfo.featureExpressionInfo = await buildDotNetGeoJSONLayerElevationInfoFeatureExpressionInfo(jsObject.featureExpressionInfo);
        }
        if (hasValue(jsObject.mode)) {
            dotNetGeoJSONLayerElevationInfo.mode = jsObject.mode;
        }
        if (hasValue(jsObject.offset)) {
            dotNetGeoJSONLayerElevationInfo.offset = jsObject.offset;
        }
        if (hasValue(jsObject.unit)) {
            dotNetGeoJSONLayerElevationInfo.unit = jsObject.unit;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetGeoJSONLayerElevationInfo.id = k;
                break;
            }
        }
    }

    return dotNetGeoJSONLayerElevationInfo;
}

