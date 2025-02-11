// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import RasterFunction from '@arcgis/core/layers/support/RasterFunction';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class RasterFunctionGenerated implements IPropertyWrapper {
    public component: RasterFunction;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: RasterFunction) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsRasterFunctionGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsRasterFunction = new RasterFunction();

    if (hasValue(dotNetObject.functionArguments)) {
        jsRasterFunction.functionArguments = dotNetObject.functionArguments;
    }
    if (hasValue(dotNetObject.functionName)) {
        jsRasterFunction.functionName = dotNetObject.functionName;
    }
    if (hasValue(dotNetObject.outputPixelType)) {
        jsRasterFunction.outputPixelType = dotNetObject.outputPixelType;
    }
    if (hasValue(dotNetObject.rasterFunctionDefinition)) {
        jsRasterFunction.rasterFunctionDefinition = dotNetObject.rasterFunctionDefinition;
    }
    if (hasValue(dotNetObject.variableName)) {
        jsRasterFunction.variableName = dotNetObject.variableName;
    }
    let { default: RasterFunctionWrapper } = await import('./rasterFunction');
    let rasterFunctionWrapper = new RasterFunctionWrapper(jsRasterFunction);
    rasterFunctionWrapper.geoBlazorId = dotNetObject.id;
    rasterFunctionWrapper.viewId = viewId;
    rasterFunctionWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(rasterFunctionWrapper);
    jsObjectRefs[dotNetObject.id] = rasterFunctionWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsRasterFunction;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for RasterFunction', e);
    }
    
    return jsRasterFunction;
}

export async function buildDotNetRasterFunctionGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetRasterFunction: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.functionArguments)) {
            dotNetRasterFunction.functionArguments = jsObject.functionArguments;
        }
        if (hasValue(jsObject.functionName)) {
            dotNetRasterFunction.functionName = jsObject.functionName;
        }
        if (hasValue(jsObject.outputPixelType)) {
            dotNetRasterFunction.outputPixelType = jsObject.outputPixelType;
        }
        if (hasValue(jsObject.rasterFunctionDefinition)) {
            dotNetRasterFunction.rasterFunctionDefinition = jsObject.rasterFunctionDefinition;
        }
        if (hasValue(jsObject.variableName)) {
            dotNetRasterFunction.variableName = jsObject.variableName;
        }

    return dotNetRasterFunction;
}

