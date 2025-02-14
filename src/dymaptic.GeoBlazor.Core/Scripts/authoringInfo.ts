// override generated code in this file
import AuthoringInfoGenerated from './authoringInfo.gb';
import AuthoringInfo from '@arcgis/core/renderers/support/AuthoringInfo';
import {hasValue} from "./arcGisJsInterop";

export default class AuthoringInfoWrapper extends AuthoringInfoGenerated {

    constructor(component: AuthoringInfo) {
        super(component);
    }

    async setColorRamp(value: any): Promise<void> {
        let { buildJsColorRamp } = await import('./colorRamp');
        this.component.colorRamp =  await buildJsColorRamp(value, this.layerId, this.viewId);
    }
    
}              
export async function buildJsAuthoringInfo(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsAuthoringInfoGenerated } = await import('./authoringInfo.gb');
    return await buildJsAuthoringInfoGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetAuthoringInfo(jsObject: any): Promise<any> {
    let { buildDotNetAuthoringInfoGenerated } = await import('./authoringInfo.gb');
    let dnAuthoringInfo = await buildDotNetAuthoringInfoGenerated(jsObject);
    if (hasValue(jsObject.colorRamp)) {
        dnAuthoringInfo.colorRamp = {
            type: jsObject.colorRamp.type
        };
    }
    
    return dnAuthoringInfo;
}
