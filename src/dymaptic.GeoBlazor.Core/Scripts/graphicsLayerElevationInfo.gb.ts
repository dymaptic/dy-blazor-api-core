// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GraphicsLayerElevationInfo = __esri.GraphicsLayerElevationInfo;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GraphicsLayerElevationInfoGenerated implements IPropertyWrapper {
    public component: GraphicsLayerElevationInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: GraphicsLayerElevationInfo) {
        this.component = component;
        // set all properties from component
        for (let prop in component) {
            if (component.hasOwnProperty(prop)) {
                this[prop] = component[prop];
            }
        }
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getFeatureExpressionInfo(): Promise<any> {
        let { buildDotNetGraphicsLayerElevationInfoFeatureExpressionInfo } = await import('./graphicsLayerElevationInfoFeatureExpressionInfo');
        return await buildDotNetGraphicsLayerElevationInfoFeatureExpressionInfo(this.component.featureExpressionInfo);
    }
    async setFeatureExpressionInfo(value: any): Promise<void> {
        let { buildJsGraphicsLayerElevationInfoFeatureExpressionInfo } = await import('./graphicsLayerElevationInfoFeatureExpressionInfo');
        this.component.featureExpressionInfo = await  buildJsGraphicsLayerElevationInfoFeatureExpressionInfo(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsGraphicsLayerElevationInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGraphicsLayerElevationInfo: any = {}
    if (hasValue(dotNetObject.featureExpressionInfo)) {
        let { buildJsGraphicsLayerElevationInfoFeatureExpressionInfo } = await import('./graphicsLayerElevationInfoFeatureExpressionInfo');
        jsGraphicsLayerElevationInfo.featureExpressionInfo = await buildJsGraphicsLayerElevationInfoFeatureExpressionInfo(dotNetObject.featureExpressionInfo, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.mode)) {
        jsGraphicsLayerElevationInfo.mode = dotNetObject.mode;
    }
    if (hasValue(dotNetObject.offset)) {
        jsGraphicsLayerElevationInfo.offset = dotNetObject.offset;
    }
    if (hasValue(dotNetObject.unit)) {
        jsGraphicsLayerElevationInfo.unit = dotNetObject.unit;
    }
    let { default: GraphicsLayerElevationInfoWrapper } = await import('./graphicsLayerElevationInfo');
    let graphicsLayerElevationInfoWrapper = new GraphicsLayerElevationInfoWrapper(jsGraphicsLayerElevationInfo);
    graphicsLayerElevationInfoWrapper.geoBlazorId = dotNetObject.id;
    graphicsLayerElevationInfoWrapper.viewId = viewId;
    graphicsLayerElevationInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(graphicsLayerElevationInfoWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = graphicsLayerElevationInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsGraphicsLayerElevationInfo;
    
    return jsGraphicsLayerElevationInfo;
}

export async function buildDotNetGraphicsLayerElevationInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGraphicsLayerElevationInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.featureExpressionInfo)) {
            let { buildDotNetGraphicsLayerElevationInfoFeatureExpressionInfo } = await import('./graphicsLayerElevationInfoFeatureExpressionInfo');
            dotNetGraphicsLayerElevationInfo.featureExpressionInfo = await buildDotNetGraphicsLayerElevationInfoFeatureExpressionInfo(jsObject.featureExpressionInfo);
        }
        dotNetGraphicsLayerElevationInfo.mode = jsObject.mode;
        dotNetGraphicsLayerElevationInfo.offset = jsObject.offset;
        dotNetGraphicsLayerElevationInfo.unit = jsObject.unit;

    return dotNetGraphicsLayerElevationInfo;
}

