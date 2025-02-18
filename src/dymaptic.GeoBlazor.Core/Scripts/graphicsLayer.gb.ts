// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import GraphicsLayer from '@arcgis/core/layers/GraphicsLayer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class GraphicsLayerGenerated implements IPropertyWrapper {
    public layer: GraphicsLayer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(layer: GraphicsLayer) {
        this.layer = layer;
    }
    
    // region methods
   
    unwrap() {
        return this.layer;
    }
    
    async load(options: AbortSignal): Promise<void> {
        await this.layer.load(options);
    }

    async add(graphic: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        let jsGraphic = await buildJsGraphic(graphic, this.layerId, this.viewId) as any;
        this.layer.add(jsGraphic);
    }

    async addMany(graphics: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        let jsGraphics = await buildJsGraphic(graphics, this.layerId, this.viewId) as any;
        this.layer.addMany(jsGraphics);
    }

    async createLayerView(view: any,
        options: any): Promise<any> {
        let result = await this.layer.createLayerView(view,
            options);
        let { buildDotNetLayerView } = await import('./layerView');
        return await buildDotNetLayerView(result);
    }

    async fetchAttributionData(): Promise<any> {
        return await this.layer.fetchAttributionData();
    }

    async remove(graphic: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        let jsGraphic = await buildJsGraphic(graphic, this.layerId, this.viewId) as any;
        this.layer.remove(jsGraphic);
    }

    async removeAll(): Promise<void> {
        this.layer.removeAll();
    }

    async removeMany(graphics: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        let jsGraphics = await buildJsGraphic(graphics, this.layerId, this.viewId) as any;
        this.layer.removeMany(jsGraphics);
    }

    // region properties
    
    async getElevationInfo(): Promise<any> {
        if (!hasValue(this.layer.elevationInfo)) {
            return null;
        }
        
        let { buildDotNetGraphicsLayerElevationInfo } = await import('./graphicsLayerElevationInfo');
        return await buildDotNetGraphicsLayerElevationInfo(this.layer.elevationInfo);
    }
    async setElevationInfo(value: any): Promise<void> {
        let { buildJsGraphicsLayerElevationInfo } = await import('./graphicsLayerElevationInfo');
        this.layer.elevationInfo = await  buildJsGraphicsLayerElevationInfo(value, this.layerId, this.viewId);
    }
    async getFullExtent(): Promise<any> {
        if (!hasValue(this.layer.fullExtent)) {
            return null;
        }
        
        let { buildDotNetExtent } = await import('./extent');
        return buildDotNetExtent(this.layer.fullExtent);
    }
    async setFullExtent(value: any): Promise<void> {
        let { buildJsExtent } = await import('./extent');
        this.layer.fullExtent =  buildJsExtent(value);
    }
    async getGraphics(): Promise<any> {
        if (!hasValue(this.layer.graphics)) {
            return null;
        }
        
        let { buildDotNetGraphic } = await import('./graphic');
        return this.layer.graphics!.map(i => buildDotNetGraphic(i));
    }
    
    async setGraphics(value: any): Promise<void> {
        let { buildJsGraphic } = await import('./graphic');
        this.layer.graphics = value.map(i => buildJsGraphic(i, this.layerId, this.viewId)) as any;
    }
    
    async getVisibilityTimeExtent(): Promise<any> {
        if (!hasValue(this.layer.visibilityTimeExtent)) {
            return null;
        }
        
        let { buildDotNetTimeExtent } = await import('./timeExtent');
        return buildDotNetTimeExtent(this.layer.visibilityTimeExtent);
    }
    async setVisibilityTimeExtent(value: any): Promise<void> {
        let { buildJsTimeExtent } = await import('./timeExtent');
        this.layer.visibilityTimeExtent = await  buildJsTimeExtent(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.layer[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.layer[prop] = value;
    }
}

export async function buildJsGraphicsLayerGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsGraphicsLayer = new GraphicsLayer();
    if (hasValue(dotNetObject.elevationInfo)) {
        let { buildJsGraphicsLayerElevationInfo } = await import('./graphicsLayerElevationInfo');
        jsGraphicsLayer.elevationInfo = await buildJsGraphicsLayerElevationInfo(dotNetObject.elevationInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.fullExtent)) {
        let { buildJsExtent } = await import('./extent');
        jsGraphicsLayer.fullExtent = buildJsExtent(dotNetObject.fullExtent) as any;
    }
    if (hasValue(dotNetObject.graphics)) {
        let { buildJsGraphic } = await import('./graphic');
        jsGraphicsLayer.graphics = await Promise.all(dotNetObject.graphics.map(async i => await buildJsGraphic(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.visibilityTimeExtent)) {
        let { buildJsTimeExtent } = await import('./timeExtent');
        jsGraphicsLayer.visibilityTimeExtent = await buildJsTimeExtent(dotNetObject.visibilityTimeExtent, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.arcGISLayerId)) {
        jsGraphicsLayer.id = dotNetObject.arcGISLayerId;
    }
    if (hasValue(dotNetObject.blendMode)) {
        jsGraphicsLayer.blendMode = dotNetObject.blendMode;
    }
    if (hasValue(dotNetObject.effect)) {
        jsGraphicsLayer.effect = dotNetObject.effect;
    }
    if (hasValue(dotNetObject.listMode)) {
        jsGraphicsLayer.listMode = dotNetObject.listMode;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsGraphicsLayer.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsGraphicsLayer.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.opacity)) {
        jsGraphicsLayer.opacity = dotNetObject.opacity;
    }
    if (hasValue(dotNetObject.persistenceEnabled)) {
        jsGraphicsLayer.persistenceEnabled = dotNetObject.persistenceEnabled;
    }
    if (hasValue(dotNetObject.screenSizePerspectiveEnabled)) {
        jsGraphicsLayer.screenSizePerspectiveEnabled = dotNetObject.screenSizePerspectiveEnabled;
    }
    if (hasValue(dotNetObject.title)) {
        jsGraphicsLayer.title = dotNetObject.title;
    }
    let { default: GraphicsLayerWrapper } = await import('./graphicsLayer');
    let graphicsLayerWrapper = new GraphicsLayerWrapper(jsGraphicsLayer);
    graphicsLayerWrapper.geoBlazorId = dotNetObject.id;
    graphicsLayerWrapper.viewId = viewId;
    graphicsLayerWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(graphicsLayerWrapper);
    jsObjectRefs[dotNetObject.id] = graphicsLayerWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsGraphicsLayer;
    let { buildDotNetGraphicsLayer } = await import('./graphicsLayer');
    let dnInstantiatedObject = await buildDotNetGraphicsLayer(jsGraphicsLayer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for GraphicsLayer', e);
    }
    
    return jsGraphicsLayer;
}

export async function buildDotNetGraphicsLayerGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetGraphicsLayer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.elevationInfo)) {
            let { buildDotNetGraphicsLayerElevationInfo } = await import('./graphicsLayerElevationInfo');
            dotNetGraphicsLayer.elevationInfo = await buildDotNetGraphicsLayerElevationInfo(jsObject.elevationInfo);
        }
        if (hasValue(jsObject.fullExtent)) {
            let { buildDotNetExtent } = await import('./extent');
            dotNetGraphicsLayer.fullExtent = buildDotNetExtent(jsObject.fullExtent);
        }
        if (hasValue(jsObject.visibilityTimeExtent)) {
            let { buildDotNetTimeExtent } = await import('./timeExtent');
            dotNetGraphicsLayer.visibilityTimeExtent = buildDotNetTimeExtent(jsObject.visibilityTimeExtent);
        }
        if (hasValue(jsObject.id)) {
            dotNetGraphicsLayer.arcGISLayerId = jsObject.id;
        }
        if (hasValue(jsObject.blendMode)) {
            dotNetGraphicsLayer.blendMode = jsObject.blendMode;
        }
        if (hasValue(jsObject.effect)) {
            dotNetGraphicsLayer.effect = jsObject.effect;
        }
        if (hasValue(jsObject.listMode)) {
            dotNetGraphicsLayer.listMode = jsObject.listMode;
        }
        if (hasValue(jsObject.loaded)) {
            dotNetGraphicsLayer.loaded = jsObject.loaded;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetGraphicsLayer.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetGraphicsLayer.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.opacity)) {
            dotNetGraphicsLayer.opacity = jsObject.opacity;
        }
        if (hasValue(jsObject.persistenceEnabled)) {
            dotNetGraphicsLayer.persistenceEnabled = jsObject.persistenceEnabled;
        }
        if (hasValue(jsObject.screenSizePerspectiveEnabled)) {
            dotNetGraphicsLayer.screenSizePerspectiveEnabled = jsObject.screenSizePerspectiveEnabled;
        }
        if (hasValue(jsObject.title)) {
            dotNetGraphicsLayer.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetGraphicsLayer.type = jsObject.type;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetGraphicsLayer.id = k;
                break;
            }
        }
    }

    return dotNetGraphicsLayer;
}

