// override generated code in this file
import LineSymbolMarkerGenerated from './lineSymbolMarker.gb';
import LineSymbolMarker from '@arcgis/core/symbols/LineSymbolMarker';

export default class LineSymbolMarkerWrapper extends LineSymbolMarkerGenerated {

    constructor(component: LineSymbolMarker) {
        super(component);
    }
    
}              
export async function buildJsLineSymbolMarker(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsLineSymbolMarkerGenerated } = await import('./lineSymbolMarker.gb');
    return await buildJsLineSymbolMarkerGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetLineSymbolMarker(jsObject: any): Promise<any> {
    let { buildDotNetLineSymbolMarkerGenerated } = await import('./lineSymbolMarker.gb');
    return await buildDotNetLineSymbolMarkerGenerated(jsObject);
}
