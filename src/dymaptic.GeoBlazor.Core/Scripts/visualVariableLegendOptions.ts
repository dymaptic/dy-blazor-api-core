// override generated code in this file
import VisualVariableLegendOptionsGenerated from './visualVariableLegendOptions.gb';
import VisualVariableLegendOptions = __esri.VisualVariableLegendOptions;

export default class VisualVariableLegendOptionsWrapper extends VisualVariableLegendOptionsGenerated {

    constructor(component: VisualVariableLegendOptions) {
        super(component);
    }
    
}              
export async function buildJsVisualVariableLegendOptions(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsVisualVariableLegendOptionsGenerated } = await import('./visualVariableLegendOptions.gb');
    return await buildJsVisualVariableLegendOptionsGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetVisualVariableLegendOptions(jsObject: any): Promise<any> {
    let { buildDotNetVisualVariableLegendOptionsGenerated } = await import('./visualVariableLegendOptions.gb');
    return await buildDotNetVisualVariableLegendOptionsGenerated(jsObject);
}
