// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import SizeVariable from '@arcgis/core/renderers/visualVariables/SizeVariable';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class SizeVariableGenerated implements IPropertyWrapper {
    public component: SizeVariable;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: SizeVariable) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async flipSizes(): Promise<void> {
        this.component.flipSizes();
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
        
        let { buildDotNetSizeStop } = await import('./sizeStop');
        return await Promise.all(this.component.stops.map(async i => await buildDotNetSizeStop(i)));
    }
    
    async setStops(value: any): Promise<void> {
        let { buildJsSizeStop } = await import('./sizeStop');
        this.component.stops = await Promise.all(value.map(async i => await buildJsSizeStop(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsSizeVariableGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsSizeVariable = new SizeVariable();
    if (hasValue(dotNetObject.legendOptions)) {
        let { buildJsVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
        jsSizeVariable.legendOptions = await buildJsVisualVariableLegendOptions(dotNetObject.legendOptions, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.stops)) {
        let { buildJsSizeStop } = await import('./sizeStop');
        jsSizeVariable.stops = await Promise.all(dotNetObject.stops.map(async i => await buildJsSizeStop(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.axis)) {
        jsSizeVariable.axis = dotNetObject.axis;
    }
    if (hasValue(dotNetObject.field)) {
        jsSizeVariable.field = dotNetObject.field;
    }
    if (hasValue(dotNetObject.maxDataValue)) {
        jsSizeVariable.maxDataValue = dotNetObject.maxDataValue;
    }
    if (hasValue(dotNetObject.maxSize)) {
        jsSizeVariable.maxSize = dotNetObject.maxSize;
    }
    if (hasValue(dotNetObject.minDataValue)) {
        jsSizeVariable.minDataValue = dotNetObject.minDataValue;
    }
    if (hasValue(dotNetObject.minSize)) {
        jsSizeVariable.minSize = dotNetObject.minSize;
    }
    if (hasValue(dotNetObject.normalizationField)) {
        jsSizeVariable.normalizationField = dotNetObject.normalizationField;
    }
    if (hasValue(dotNetObject.target)) {
        jsSizeVariable.target = dotNetObject.target;
    }
    if (hasValue(dotNetObject.useSymbolValue)) {
        jsSizeVariable.useSymbolValue = dotNetObject.useSymbolValue;
    }
    if (hasValue(dotNetObject.valueExpression)) {
        jsSizeVariable.valueExpression = dotNetObject.valueExpression;
    }
    if (hasValue(dotNetObject.valueExpressionTitle)) {
        jsSizeVariable.valueExpressionTitle = dotNetObject.valueExpressionTitle;
    }
    if (hasValue(dotNetObject.valueRepresentation)) {
        jsSizeVariable.valueRepresentation = dotNetObject.valueRepresentation;
    }
    if (hasValue(dotNetObject.valueUnit)) {
        jsSizeVariable.valueUnit = dotNetObject.valueUnit;
    }
    let { default: SizeVariableWrapper } = await import('./sizeVariable');
    let sizeVariableWrapper = new SizeVariableWrapper(jsSizeVariable);
    sizeVariableWrapper.geoBlazorId = dotNetObject.id;
    sizeVariableWrapper.viewId = viewId;
    sizeVariableWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(sizeVariableWrapper);
    jsObjectRefs[dotNetObject.id] = sizeVariableWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsSizeVariable;
    
    let dnInstantiatedObject = await buildDotNetSizeVariable(jsSizeVariable);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for SizeVariable', e);
    }
    
    return jsSizeVariable;
}

export async function buildDotNetSizeVariableGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetSizeVariable: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.legendOptions)) {
            let { buildDotNetVisualVariableLegendOptions } = await import('./visualVariableLegendOptions');
            dotNetSizeVariable.legendOptions = await buildDotNetVisualVariableLegendOptions(jsObject.legendOptions);
        }
        if (hasValue(jsObject.stops)) {
            let { buildDotNetSizeStop } = await import('./sizeStop');
            dotNetSizeVariable.stops = await Promise.all(jsObject.stops.map(async i => await buildDotNetSizeStop(i)));
        }
        if (hasValue(jsObject.axis)) {
            dotNetSizeVariable.axis = jsObject.axis;
        }
        if (hasValue(jsObject.field)) {
            dotNetSizeVariable.field = jsObject.field;
        }
        if (hasValue(jsObject.maxDataValue)) {
            dotNetSizeVariable.maxDataValue = jsObject.maxDataValue;
        }
        if (hasValue(jsObject.maxSize)) {
            dotNetSizeVariable.maxSize = jsObject.maxSize;
        }
        if (hasValue(jsObject.minDataValue)) {
            dotNetSizeVariable.minDataValue = jsObject.minDataValue;
        }
        if (hasValue(jsObject.minSize)) {
            dotNetSizeVariable.minSize = jsObject.minSize;
        }
        if (hasValue(jsObject.normalizationField)) {
            dotNetSizeVariable.normalizationField = jsObject.normalizationField;
        }
        if (hasValue(jsObject.target)) {
            dotNetSizeVariable.target = jsObject.target;
        }
        if (hasValue(jsObject.type)) {
            dotNetSizeVariable.type = jsObject.type;
        }
        if (hasValue(jsObject.useSymbolValue)) {
            dotNetSizeVariable.useSymbolValue = jsObject.useSymbolValue;
        }
        if (hasValue(jsObject.valueExpression)) {
            dotNetSizeVariable.valueExpression = jsObject.valueExpression;
        }
        if (hasValue(jsObject.valueExpressionTitle)) {
            dotNetSizeVariable.valueExpressionTitle = jsObject.valueExpressionTitle;
        }
        if (hasValue(jsObject.valueRepresentation)) {
            dotNetSizeVariable.valueRepresentation = jsObject.valueRepresentation;
        }
        if (hasValue(jsObject.valueUnit)) {
            dotNetSizeVariable.valueUnit = jsObject.valueUnit;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetSizeVariable.id = k;
                break;
            }
        }
    }

    return dotNetSizeVariable;
}

