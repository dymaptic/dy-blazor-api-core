// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import PixelBlockStatistics = __esri.PixelBlockStatistics;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class PixelBlockStatisticsGenerated implements IPropertyWrapper {
    public component: PixelBlockStatistics;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: PixelBlockStatistics) {
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

export async function buildJsPixelBlockStatisticsGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsPixelBlockStatistics: any = {}

    if (hasValue(dotNetObject.maxValue)) {
        jsPixelBlockStatistics.maxValue = dotNetObject.maxValue;
    }
    if (hasValue(dotNetObject.minValue)) {
        jsPixelBlockStatistics.minValue = dotNetObject.minValue;
    }
    if (hasValue(dotNetObject.noDataValue)) {
        jsPixelBlockStatistics.noDataValue = dotNetObject.noDataValue;
    }
    let { default: PixelBlockStatisticsWrapper } = await import('./pixelBlockStatistics');
    let pixelBlockStatisticsWrapper = new PixelBlockStatisticsWrapper(jsPixelBlockStatistics);
    pixelBlockStatisticsWrapper.geoBlazorId = dotNetObject.id;
    pixelBlockStatisticsWrapper.viewId = viewId;
    pixelBlockStatisticsWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(pixelBlockStatisticsWrapper);
    jsObjectRefs[dotNetObject.id] = pixelBlockStatisticsWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsPixelBlockStatistics;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for PixelBlockStatistics', e);
    }
    
    return jsPixelBlockStatistics;
}

export async function buildDotNetPixelBlockStatisticsGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetPixelBlockStatistics: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.maxValue)) {
            dotNetPixelBlockStatistics.maxValue = jsObject.maxValue;
        }
        if (hasValue(jsObject.minValue)) {
            dotNetPixelBlockStatistics.minValue = jsObject.minValue;
        }
        if (hasValue(jsObject.noDataValue)) {
            dotNetPixelBlockStatistics.noDataValue = jsObject.noDataValue;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetPixelBlockStatistics.id = k;
                break;
            }
        }
    }

    return dotNetPixelBlockStatistics;
}

