// override generated code in this file
import AttachmentsPopupContentGenerated from './attachmentsPopupContent.gb';
import AttachmentsContent = __esri.AttachmentsContent;

export default class AttachmentsPopupContentWrapper extends AttachmentsPopupContentGenerated {

    constructor(component: AttachmentsContent) {
        super(component);
    }
    
}

export async function buildJsAttachmentsPopupContent(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsAttachmentsPopupContentGenerated } = await import('./attachmentsPopupContent.gb');
    return await buildJsAttachmentsPopupContentGenerated(dotNetObject, layerId, viewId);
}     

export async function buildDotNetAttachmentsPopupContent(jsObject: any): Promise<any> {
    let { buildDotNetAttachmentsPopupContentGenerated } = await import('./attachmentsPopupContent.gb');
    return await buildDotNetAttachmentsPopupContentGenerated(jsObject);
}
