// override generated code in this file
import OpacityStopGenerated from './opacityStop.gb';
import OpacityStop from '@arcgis/core/renderers/visualVariables/support/OpacityStop';

export default class OpacityStopWrapper extends OpacityStopGenerated {

    constructor(component: OpacityStop) {
        super(component);
    }
    
}              
export async function buildJsOpacityStop(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsOpacityStopGenerated } = await import('./opacityStop.gb');
    return await buildJsOpacityStopGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetOpacityStop(jsObject: any): Promise<any> {
    let { buildDotNetOpacityStopGenerated } = await import('./opacityStop.gb');
    return await buildDotNetOpacityStopGenerated(jsObject);
}
