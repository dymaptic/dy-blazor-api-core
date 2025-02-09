// override generated code in this file
import LineChartMediaInfoGenerated from './lineChartMediaInfo.gb';
import LineChartMediaInfo from '@arcgis/core/popup/content/LineChartMediaInfo';

export default class LineChartMediaInfoWrapper extends LineChartMediaInfoGenerated {

    constructor(component: LineChartMediaInfo) {
        super(component);
    }
    
}

export async function buildJsLineChartMediaInfo(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsLineChartMediaInfoGenerated } = await import('./lineChartMediaInfo.gb');
    return await buildJsLineChartMediaInfoGenerated(dotNetObject, layerId, viewId);
}     

export async function buildDotNetLineChartMediaInfo(jsObject: any): Promise<any> {
    let { buildDotNetLineChartMediaInfoGenerated } = await import('./lineChartMediaInfo.gb');
    return await buildDotNetLineChartMediaInfoGenerated(jsObject);
}
