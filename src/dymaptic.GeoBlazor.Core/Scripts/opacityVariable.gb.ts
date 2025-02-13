// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import OpacityVariable from '@arcgis/core/renderers/visualVariables/OpacityVariable';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class OpacityVariableGenerated implements IPropertyWrapper {
    public component: OpacityVariable;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: OpacityVariable) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getLegendOptions(): Promise<any> {
        let { buildDotNetVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
        return await buildDotNetVisualVariableLegendOptions(this.component.legendOptions);
    }
    async setLegendOptions(value: any): Promise<void> {
        let { buildJsVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
        this.component.legendOptions = await  buildJsVisualVariableLegendOptions(value, this.layerId, this.viewId);
    }
    async getStops(): Promise<any> {
        let { buildDotNetOpacityStop } = await import('./opacityStop');
        return this.component.stops.map(async i => await buildDotNetOpacityStop(i));
    }
    
    async setStops(value: any): Promise<void> {
        let { buildJsOpacityStop } = await import('./opacityStop');
        this.component.stops = value.map(async i => await buildJsOpacityStop(i, this.layerId, this.viewId));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsOpacityVariableGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsOpacityVariable = new OpacityVariable();
    if (hasValue(dotNetObject.legendOptions)) {
        let { buildJsVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
        jsOpacityVariable.legendOptions = await buildJsVisualVariableLegendOptions(dotNetObject.legendOptions, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.stops)) {
        let { buildJsOpacityStop } = await import('./opacityStop');
        jsOpacityVariable.stops = await Promise.all(dotNetObject.stops.map(async i => await buildJsOpacityStop(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.field)) {
        jsOpacityVariable.field = dotNetObject.field;
    }
    if (hasValue(dotNetObject.normalizationField)) {
        jsOpacityVariable.normalizationField = dotNetObject.normalizationField;
    }
    if (hasValue(dotNetObject.valueExpression)) {
        jsOpacityVariable.valueExpression = dotNetObject.valueExpression;
    }
    if (hasValue(dotNetObject.valueExpressionTitle)) {
        jsOpacityVariable.valueExpressionTitle = dotNetObject.valueExpressionTitle;
    }
    let { default: OpacityVariableWrapper } = await import('./opacityVariable');
    let opacityVariableWrapper = new OpacityVariableWrapper(jsOpacityVariable);
    opacityVariableWrapper.geoBlazorId = dotNetObject.id;
    opacityVariableWrapper.viewId = viewId;
    opacityVariableWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(opacityVariableWrapper);
    jsObjectRefs[dotNetObject.id] = opacityVariableWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsOpacityVariable;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for OpacityVariable', e);
    }
    
    return jsOpacityVariable;
}

export async function buildDotNetOpacityVariableGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetOpacityVariable: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.legendOptions)) {
            let { buildDotNetVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
            dotNetOpacityVariable.legendOptions = await buildDotNetVisualVariableLegendOptions(jsObject.legendOptions);
        }
        if (hasValue(jsObject.stops)) {
            let { buildDotNetOpacityStop } = await import('./opacityStop');
            dotNetOpacityVariable.stops = await Promise.all(jsObject.stops.map(async i => await buildDotNetOpacityStop(i)));
        }
        dotNetOpacityVariable.type = jsObject.type;
        if (hasValue(jsObject.field)) {
            dotNetOpacityVariable.field = jsObject.field;
        }
        if (hasValue(jsObject.normalizationField)) {
            dotNetOpacityVariable.normalizationField = jsObject.normalizationField;
        }
        if (hasValue(jsObject.valueExpression)) {
            dotNetOpacityVariable.valueExpression = jsObject.valueExpression;
        }
        if (hasValue(jsObject.valueExpressionTitle)) {
            dotNetOpacityVariable.valueExpressionTitle = jsObject.valueExpressionTitle;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetOpacityVariable.id = k;
                break;
            }
        }
    }

    return dotNetOpacityVariable;
}

