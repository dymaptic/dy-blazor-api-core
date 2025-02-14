// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GraphicsLayerElevationInfoFeatureExpressionInfo = __esri.GraphicsLayerElevationInfoFeatureExpressionInfo;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GraphicsLayerElevationInfoFeatureExpressionInfoGenerated implements IPropertyWrapper {
    public component: GraphicsLayerElevationInfoFeatureExpressionInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: GraphicsLayerElevationInfoFeatureExpressionInfo) {
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

export async function buildJsGraphicsLayerElevationInfoFeatureExpressionInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGraphicsLayerElevationInfoFeatureExpressionInfo: any = {}

    if (hasValue(dotNetObject.expression)) {
        jsGraphicsLayerElevationInfoFeatureExpressionInfo.expression = dotNetObject.expression;
    }
    if (hasValue(dotNetObject.title)) {
        jsGraphicsLayerElevationInfoFeatureExpressionInfo.title = dotNetObject.title;
    }
    let { default: GraphicsLayerElevationInfoFeatureExpressionInfoWrapper } = await import('./graphicsLayerElevationInfoFeatureExpressionInfo');
    let graphicsLayerElevationInfoFeatureExpressionInfoWrapper = new GraphicsLayerElevationInfoFeatureExpressionInfoWrapper(jsGraphicsLayerElevationInfoFeatureExpressionInfo);
    graphicsLayerElevationInfoFeatureExpressionInfoWrapper.geoBlazorId = dotNetObject.id;
    graphicsLayerElevationInfoFeatureExpressionInfoWrapper.viewId = viewId;
    graphicsLayerElevationInfoFeatureExpressionInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(graphicsLayerElevationInfoFeatureExpressionInfoWrapper);
    jsObjectRefs[dotNetObject.id] = graphicsLayerElevationInfoFeatureExpressionInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsGraphicsLayerElevationInfoFeatureExpressionInfo;
    
    let dnInstantiatedObject = await buildDotNetGraphicsLayerElevationInfoFeatureExpressionInfo(jsGraphicsLayerElevationInfoFeatureExpressionInfo);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for GraphicsLayerElevationInfoFeatureExpressionInfo', e);
    }
    
    return jsGraphicsLayerElevationInfoFeatureExpressionInfo;
}

export async function buildDotNetGraphicsLayerElevationInfoFeatureExpressionInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGraphicsLayerElevationInfoFeatureExpressionInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.expression)) {
            dotNetGraphicsLayerElevationInfoFeatureExpressionInfo.expression = jsObject.expression;
        }
        if (hasValue(jsObject.title)) {
            dotNetGraphicsLayerElevationInfoFeatureExpressionInfo.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetGraphicsLayerElevationInfoFeatureExpressionInfo.id = k;
                break;
            }
        }
    }

    return dotNetGraphicsLayerElevationInfoFeatureExpressionInfo;
}

