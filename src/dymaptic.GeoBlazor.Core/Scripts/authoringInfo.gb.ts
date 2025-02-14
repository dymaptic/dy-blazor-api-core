// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import AuthoringInfo from '@arcgis/core/renderers/support/AuthoringInfo';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class AuthoringInfoGenerated implements IPropertyWrapper {
    public component: AuthoringInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: AuthoringInfo) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getColorRamp(): Promise<any> {
        if (!hasValue(this.component.colorRamp)) {
            return null;
        }
        
        let { buildDotNetColorRamp } = await import('./colorRamp');
        return await buildDotNetColorRamp(this.component.colorRamp);
    }
    async getField1(): Promise<any> {
        if (!hasValue(this.component.field1)) {
            return null;
        }
        
        let { buildDotNetAuthoringInfoField } = await import('./authoringInfoField');
        return await buildDotNetAuthoringInfoField(this.component.field1);
    }
    async setField1(value: any): Promise<void> {
        let { buildJsAuthoringInfoField } = await import('./authoringInfoField');
        this.component.field1 = await  buildJsAuthoringInfoField(value, this.layerId, this.viewId);
    }
    async getField2(): Promise<any> {
        if (!hasValue(this.component.field2)) {
            return null;
        }
        
        let { buildDotNetAuthoringInfoField } = await import('./authoringInfoField');
        return await buildDotNetAuthoringInfoField(this.component.field2);
    }
    async setField2(value: any): Promise<void> {
        let { buildJsAuthoringInfoField } = await import('./authoringInfoField');
        this.component.field2 = await  buildJsAuthoringInfoField(value, this.layerId, this.viewId);
    }
    async getStatistics(): Promise<any> {
        if (!hasValue(this.component.statistics)) {
            return null;
        }
        
        let { buildDotNetAuthoringInfoStatistics } = await import('./authoringInfoStatistics');
        return await buildDotNetAuthoringInfoStatistics(this.component.statistics);
    }
    async setStatistics(value: any): Promise<void> {
        let { buildJsAuthoringInfoStatistics } = await import('./authoringInfoStatistics');
        this.component.statistics = await  buildJsAuthoringInfoStatistics(value, this.layerId, this.viewId);
    }
    async getVisualVariables(): Promise<any> {
        if (!hasValue(this.component.visualVariables)) {
            return null;
        }
        
        let { buildDotNetAuthoringInfoVisualVariable } = await import('./authoringInfoVisualVariable');
        return await Promise.all(this.component.visualVariables.map(async i => await buildDotNetAuthoringInfoVisualVariable(i)));
    }
    
    async setVisualVariables(value: any): Promise<void> {
        let { buildJsAuthoringInfoVisualVariable } = await import('./authoringInfoVisualVariable');
        this.component.visualVariables = await Promise.all(value.map(async i => await buildJsAuthoringInfoVisualVariable(i, this.layerId, this.viewId)));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsAuthoringInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsAuthoringInfo = new AuthoringInfo();
    if (hasValue(dotNetObject.colorRamp)) {
        let { buildJsColorRamp } = await import('./jsBuilder');
        jsAuthoringInfo.colorRamp = buildJsColorRamp(dotNetObject.colorRamp) as any;
    }
    if (hasValue(dotNetObject.field1)) {
        let { buildJsAuthoringInfoField } = await import('./authoringInfoField');
        jsAuthoringInfo.field1 = await buildJsAuthoringInfoField(dotNetObject.field1, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.field2)) {
        let { buildJsAuthoringInfoField } = await import('./authoringInfoField');
        jsAuthoringInfo.field2 = await buildJsAuthoringInfoField(dotNetObject.field2, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.statistics)) {
        let { buildJsAuthoringInfoStatistics } = await import('./authoringInfoStatistics');
        jsAuthoringInfo.statistics = await buildJsAuthoringInfoStatistics(dotNetObject.statistics, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.visualVariables)) {
        let { buildJsAuthoringInfoVisualVariable } = await import('./authoringInfoVisualVariable');
        jsAuthoringInfo.visualVariables = await Promise.all(dotNetObject.visualVariables.map(async i => await buildJsAuthoringInfoVisualVariable(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.classificationMethod)) {
        jsAuthoringInfo.classificationMethod = dotNetObject.classificationMethod;
    }
    if (hasValue(dotNetObject.fadeRatio)) {
        jsAuthoringInfo.fadeRatio = dotNetObject.fadeRatio;
    }
    if (hasValue(dotNetObject.fields)) {
        jsAuthoringInfo.fields = dotNetObject.fields;
    }
    if (hasValue(dotNetObject.flowTheme)) {
        jsAuthoringInfo.flowTheme = dotNetObject.flowTheme;
    }
    if (hasValue(dotNetObject.focus)) {
        jsAuthoringInfo.focus = dotNetObject.focus;
    }
    if (hasValue(dotNetObject.isAutoGenerated)) {
        jsAuthoringInfo.isAutoGenerated = dotNetObject.isAutoGenerated;
    }
    if (hasValue(dotNetObject.lengthUnit)) {
        jsAuthoringInfo.lengthUnit = dotNetObject.lengthUnit;
    }
    if (hasValue(dotNetObject.maxSliderValue)) {
        jsAuthoringInfo.maxSliderValue = dotNetObject.maxSliderValue;
    }
    if (hasValue(dotNetObject.minSliderValue)) {
        jsAuthoringInfo.minSliderValue = dotNetObject.minSliderValue;
    }
    if (hasValue(dotNetObject.numClasses)) {
        jsAuthoringInfo.numClasses = dotNetObject.numClasses;
    }
    if (hasValue(dotNetObject.standardDeviationInterval)) {
        jsAuthoringInfo.standardDeviationInterval = dotNetObject.standardDeviationInterval;
    }
    if (hasValue(dotNetObject.univariateSymbolStyle)) {
        jsAuthoringInfo.univariateSymbolStyle = dotNetObject.univariateSymbolStyle;
    }
    if (hasValue(dotNetObject.univariateTheme)) {
        jsAuthoringInfo.univariateTheme = dotNetObject.univariateTheme;
    }
    let { default: AuthoringInfoWrapper } = await import('./authoringInfo');
    let authoringInfoWrapper = new AuthoringInfoWrapper(jsAuthoringInfo);
    authoringInfoWrapper.geoBlazorId = dotNetObject.id;
    authoringInfoWrapper.viewId = viewId;
    authoringInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(authoringInfoWrapper);
    jsObjectRefs[dotNetObject.id] = authoringInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsAuthoringInfo;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for AuthoringInfo', e);
    }
    
    return jsAuthoringInfo;
}

export async function buildDotNetAuthoringInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetAuthoringInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.colorRamp)) {
            let { buildDotNetColorRamp } = await import('./colorRamp');
            dotNetAuthoringInfo.colorRamp = await buildDotNetColorRamp(jsObject.colorRamp);
        }
        if (hasValue(jsObject.field1)) {
            let { buildDotNetAuthoringInfoField } = await import('./authoringInfoField');
            dotNetAuthoringInfo.field1 = await buildDotNetAuthoringInfoField(jsObject.field1);
        }
        if (hasValue(jsObject.field2)) {
            let { buildDotNetAuthoringInfoField } = await import('./authoringInfoField');
            dotNetAuthoringInfo.field2 = await buildDotNetAuthoringInfoField(jsObject.field2);
        }
        if (hasValue(jsObject.statistics)) {
            let { buildDotNetAuthoringInfoStatistics } = await import('./authoringInfoStatistics');
            dotNetAuthoringInfo.statistics = await buildDotNetAuthoringInfoStatistics(jsObject.statistics);
        }
        if (hasValue(jsObject.visualVariables)) {
            let { buildDotNetAuthoringInfoVisualVariable } = await import('./authoringInfoVisualVariable');
            dotNetAuthoringInfo.visualVariables = await Promise.all(jsObject.visualVariables.map(async i => await buildDotNetAuthoringInfoVisualVariable(i)));
        }
        if (hasValue(jsObject.classificationMethod)) {
            dotNetAuthoringInfo.classificationMethod = jsObject.classificationMethod;
        }
        if (hasValue(jsObject.fadeRatio)) {
            dotNetAuthoringInfo.fadeRatio = jsObject.fadeRatio;
        }
        if (hasValue(jsObject.fields)) {
            dotNetAuthoringInfo.fields = jsObject.fields;
        }
        if (hasValue(jsObject.flowTheme)) {
            dotNetAuthoringInfo.flowTheme = jsObject.flowTheme;
        }
        if (hasValue(jsObject.focus)) {
            dotNetAuthoringInfo.focus = jsObject.focus;
        }
        if (hasValue(jsObject.isAutoGenerated)) {
            dotNetAuthoringInfo.isAutoGenerated = jsObject.isAutoGenerated;
        }
        if (hasValue(jsObject.lengthUnit)) {
            dotNetAuthoringInfo.lengthUnit = jsObject.lengthUnit;
        }
        if (hasValue(jsObject.maxSliderValue)) {
            dotNetAuthoringInfo.maxSliderValue = jsObject.maxSliderValue;
        }
        if (hasValue(jsObject.minSliderValue)) {
            dotNetAuthoringInfo.minSliderValue = jsObject.minSliderValue;
        }
        if (hasValue(jsObject.numClasses)) {
            dotNetAuthoringInfo.numClasses = jsObject.numClasses;
        }
        if (hasValue(jsObject.standardDeviationInterval)) {
            dotNetAuthoringInfo.standardDeviationInterval = jsObject.standardDeviationInterval;
        }
        if (hasValue(jsObject.type)) {
            dotNetAuthoringInfo.type = jsObject.type;
        }
        if (hasValue(jsObject.univariateSymbolStyle)) {
            dotNetAuthoringInfo.univariateSymbolStyle = jsObject.univariateSymbolStyle;
        }
        if (hasValue(jsObject.univariateTheme)) {
            dotNetAuthoringInfo.univariateTheme = jsObject.univariateTheme;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetAuthoringInfo.id = k;
                break;
            }
        }
    }

    return dotNetAuthoringInfo;
}

