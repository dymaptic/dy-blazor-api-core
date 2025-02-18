// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ColorVariable from '@arcgis/core/renderers/visualVariables/ColorVariable';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ColorVariableGenerated implements IPropertyWrapper {
    public component: ColorVariable;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ColorVariable) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getLegendOptions(): Promise<any> {
        if (!hasValue(this.component.legendOptions)) {
            return null;
        }
        
        let { buildDotNetVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
        return await buildDotNetVisualVariableLegendOptions(this.component.legendOptions);
    }
    async setLegendOptions(value: any): Promise<void> {
        let { buildJsVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
        this.component.legendOptions = await  buildJsVisualVariableLegendOptions(value, this.layerId, this.viewId);
    }
    async getStops(): Promise<any> {
        if (!hasValue(this.component.stops)) {
            return null;
        }
        
        let { buildDotNetColorStop } = await import('./colorStop');
        return await Promise.all(this.component.stops.map(async i => await buildDotNetColorStop(i)));
    }
    
    async setStops(value: any): Promise<void> {
        let { buildJsColorStop } = await import('./colorStop');
        this.component.stops = await Promise.all(value.map(async i => await buildJsColorStop(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsColorVariableGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsColorVariable = new ColorVariable();
    if (hasValue(dotNetObject.legendOptions)) {
        let { buildJsVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
        jsColorVariable.legendOptions = await buildJsVisualVariableLegendOptions(dotNetObject.legendOptions, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.stops)) {
        let { buildJsColorStop } = await import('./colorStop');
        jsColorVariable.stops = await Promise.all(dotNetObject.stops.map(async i => await buildJsColorStop(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.field)) {
        jsColorVariable.field = dotNetObject.field;
    }
    if (hasValue(dotNetObject.normalizationField)) {
        jsColorVariable.normalizationField = dotNetObject.normalizationField;
    }
    if (hasValue(dotNetObject.valueExpression)) {
        jsColorVariable.valueExpression = dotNetObject.valueExpression;
    }
    if (hasValue(dotNetObject.valueExpressionTitle)) {
        jsColorVariable.valueExpressionTitle = dotNetObject.valueExpressionTitle;
    }
    let { default: ColorVariableWrapper } = await import('./colorVariable');
    let colorVariableWrapper = new ColorVariableWrapper(jsColorVariable);
    colorVariableWrapper.geoBlazorId = dotNetObject.id;
    colorVariableWrapper.viewId = viewId;
    colorVariableWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(colorVariableWrapper);
    jsObjectRefs[dotNetObject.id] = colorVariableWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsColorVariable;
    let { buildDotNetColorVariable } = await import('./colorVariable');
    let dnInstantiatedObject = await buildDotNetColorVariable(jsColorVariable);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ColorVariable', e);
    }
    
    return jsColorVariable;
}

export async function buildDotNetColorVariableGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetColorVariable: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.legendOptions)) {
            let { buildDotNetVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
            dotNetColorVariable.legendOptions = await buildDotNetVisualVariableLegendOptions(jsObject.legendOptions);
        }
        if (hasValue(jsObject.stops)) {
            let { buildDotNetColorStop } = await import('./colorStop');
            dotNetColorVariable.stops = await Promise.all(jsObject.stops.map(async i => await buildDotNetColorStop(i)));
        }
        dotNetColorVariable.type = jsObject.type;
        if (hasValue(jsObject.field)) {
            dotNetColorVariable.field = jsObject.field;
        }
        if (hasValue(jsObject.normalizationField)) {
            dotNetColorVariable.normalizationField = jsObject.normalizationField;
        }
        if (hasValue(jsObject.valueExpression)) {
            dotNetColorVariable.valueExpression = jsObject.valueExpression;
        }
        if (hasValue(jsObject.valueExpressionTitle)) {
            dotNetColorVariable.valueExpressionTitle = jsObject.valueExpressionTitle;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetColorVariable.id = k;
                break;
            }
        }
    }

    return dotNetColorVariable;
}

