// override generated code in this file
import ImageMediaInfoValueGenerated from './imageMediaInfoValue.gb';
import ImageMediaInfoValue from '@arcgis/core/popup/content/support/ImageMediaInfoValue';

export default class ImageMediaInfoValueWrapper extends ImageMediaInfoValueGenerated {

    constructor(component: ImageMediaInfoValue) {
        super(component);
    }
    
}              
export async function buildJsImageMediaInfoValue(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsImageMediaInfoValueGenerated } = await import('./imageMediaInfoValue.gb');
    return await buildJsImageMediaInfoValueGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetImageMediaInfoValue(jsObject: any): Promise<any> {
    let { buildDotNetImageMediaInfoValueGenerated } = await import('./imageMediaInfoValue.gb');
    return await buildDotNetImageMediaInfoValueGenerated(jsObject);
}
