// override generated code in this file
import FormTemplateGenerated from './formTemplate.gb';
import FormTemplate from '@arcgis/core/form/FormTemplate';

export default class FormTemplateWrapper extends FormTemplateGenerated {

    constructor(component: FormTemplate) {
        super(component);
    }
    
}              
export async function buildJsFormTemplate(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsFormTemplateGenerated } = await import('./formTemplate.gb');
    return await buildJsFormTemplateGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetFormTemplate(jsObject: any): Promise<any> {
    let { buildDotNetFormTemplateGenerated } = await import('./formTemplate.gb');
    return await buildDotNetFormTemplateGenerated(jsObject);
}
