// override generated code in this file
import FeatureLayerBaseElevationInfoGenerated from './featureLayerBaseElevationInfo.gb';
import FeatureLayerBaseElevationInfo = __esri.FeatureLayerBaseElevationInfo;

export default class FeatureLayerBaseElevationInfoWrapper extends FeatureLayerBaseElevationInfoGenerated {

    constructor(component: FeatureLayerBaseElevationInfo) {
        super(component);
    }
    
}              
export async function buildJsFeatureLayerBaseElevationInfo(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsFeatureLayerBaseElevationInfoGenerated } = await import('./featureLayerBaseElevationInfo.gb');
    return await buildJsFeatureLayerBaseElevationInfoGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetFeatureLayerBaseElevationInfo(jsObject: any): Promise<any> {
    let { buildDotNetFeatureLayerBaseElevationInfoGenerated } = await import('./featureLayerBaseElevationInfo.gb');
    return await buildDotNetFeatureLayerBaseElevationInfoGenerated(jsObject);
}
