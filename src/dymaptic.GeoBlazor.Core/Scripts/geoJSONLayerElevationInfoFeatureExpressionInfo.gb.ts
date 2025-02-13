// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GeoJSONLayerElevationInfoFeatureExpressionInfo = __esri.GeoJSONLayerElevationInfoFeatureExpressionInfo;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GeoJSONLayerElevationInfoFeatureExpressionInfoGenerated implements IPropertyWrapper {
    public component: GeoJSONLayerElevationInfoFeatureExpressionInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: GeoJSONLayerElevationInfoFeatureExpressionInfo) {
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

export async function buildJsGeoJSONLayerElevationInfoFeatureExpressionInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGeoJSONLayerElevationInfoFeatureExpressionInfo: any = {}

    if (hasValue(dotNetObject.expression)) {
        jsGeoJSONLayerElevationInfoFeatureExpressionInfo.expression = dotNetObject.expression;
    }
    if (hasValue(dotNetObject.title)) {
        jsGeoJSONLayerElevationInfoFeatureExpressionInfo.title = dotNetObject.title;
    }
    let { default: GeoJSONLayerElevationInfoFeatureExpressionInfoWrapper } = await import('./geoJSONLayerElevationInfoFeatureExpressionInfo');
    let geoJSONLayerElevationInfoFeatureExpressionInfoWrapper = new GeoJSONLayerElevationInfoFeatureExpressionInfoWrapper(jsGeoJSONLayerElevationInfoFeatureExpressionInfo);
    geoJSONLayerElevationInfoFeatureExpressionInfoWrapper.geoBlazorId = dotNetObject.id;
    geoJSONLayerElevationInfoFeatureExpressionInfoWrapper.viewId = viewId;
    geoJSONLayerElevationInfoFeatureExpressionInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(geoJSONLayerElevationInfoFeatureExpressionInfoWrapper);
    jsObjectRefs[dotNetObject.id] = geoJSONLayerElevationInfoFeatureExpressionInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsGeoJSONLayerElevationInfoFeatureExpressionInfo;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for GeoJSONLayerElevationInfoFeatureExpressionInfo', e);
    }
    
    return jsGeoJSONLayerElevationInfoFeatureExpressionInfo;
}

export async function buildDotNetGeoJSONLayerElevationInfoFeatureExpressionInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGeoJSONLayerElevationInfoFeatureExpressionInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.expression)) {
            dotNetGeoJSONLayerElevationInfoFeatureExpressionInfo.expression = jsObject.expression;
        }
        if (hasValue(jsObject.title)) {
            dotNetGeoJSONLayerElevationInfoFeatureExpressionInfo.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetGeoJSONLayerElevationInfoFeatureExpressionInfo.id = k;
                break;
            }
        }
    }

    return dotNetGeoJSONLayerElevationInfoFeatureExpressionInfo;
}

