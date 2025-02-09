import BingMapsLayerGenerated from './bingMapsLayer.gb';
import BingMapsLayer from "@arcgis/core/layers/BingMapsLayer";
import BaseTileLayerWrapper from "./baseTileLayer";
import {buildJsEffect} from "./jsBuilder";
import {buildDotNetEffect, buildDotNetTileInfo} from "./dotNetBuilder";

export default class BingMapsLayerWrapper extends BingMapsLayerGenerated {
    
    constructor(layer: BingMapsLayer) {
        super(layer);
    }
    
    getBingLogo() {
        return this.layer.bingLogo;
    }
    
    getCopyright() {
        return this.layer.copyright;
    }
    
    hasAttributionData() {
        return this.layer.hasAttributionData;
    }
    
    getTileInfo() {
        return buildDotNetTileInfo(this.layer.tileInfo);
    }
}
export async function buildJsBingMapsLayer(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsBingMapsLayerGenerated } = await import('./bingMapsLayer.gb');
    return await buildJsBingMapsLayerGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetBingMapsLayer(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildDotNetBingMapsLayerGenerated } = await import('./bingMapsLayer.gb');
    return await buildDotNetBingMapsLayerGenerated(jsObject, layerId, viewId);
}
