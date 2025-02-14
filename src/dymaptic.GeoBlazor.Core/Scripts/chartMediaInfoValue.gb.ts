// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ChartMediaInfoValue from '@arcgis/core/popup/content/support/ChartMediaInfoValue';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ChartMediaInfoValueGenerated implements IPropertyWrapper {
    public component: ChartMediaInfoValue;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ChartMediaInfoValue) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getColors(): Promise<any> {
        if (!hasValue(this.component.colors)) {
            return null;
        }
        
        let { buildDotNetMapColor } = await import('./mapColor');
        return this.component.colors!.map(i => buildDotNetMapColor(i));
    }
    
    async setColors(value: any): Promise<void> {
        let { buildJsMapColor } = await import('./mapColor');
        this.component.colors = value.map(i => buildJsMapColor(i)) as any;
    }
    
    async getSeries(): Promise<any> {
        if (!hasValue(this.component.series)) {
            return null;
        }
        
        let { buildDotNetChartMediaInfoValueSeries } = await import('./chartMediaInfoValueSeries');
        return await Promise.all(this.component.series.map(async i => await buildDotNetChartMediaInfoValueSeries(i)));
    }
    
    async setSeries(value: any): Promise<void> {
        let { buildJsChartMediaInfoValueSeries } = await import('./chartMediaInfoValueSeries');
        this.component.series = await Promise.all(value.map(async i => await buildJsChartMediaInfoValueSeries(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsChartMediaInfoValueGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsChartMediaInfoValue = new ChartMediaInfoValue();
    if (hasValue(dotNetObject.colors)) {
        let { buildJsMapColor } = await import('./mapColor');
        jsChartMediaInfoValue.colors = dotNetObject.colors.map(i => buildJsMapColor(i)) as any;
    }
    if (hasValue(dotNetObject.series)) {
        let { buildJsChartMediaInfoValueSeries } = await import('./chartMediaInfoValueSeries');
        jsChartMediaInfoValue.series = await Promise.all(dotNetObject.series.map(async i => await buildJsChartMediaInfoValueSeries(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.fields)) {
        jsChartMediaInfoValue.fields = dotNetObject.fields;
    }
    if (hasValue(dotNetObject.normalizeField)) {
        jsChartMediaInfoValue.normalizeField = dotNetObject.normalizeField;
    }
    if (hasValue(dotNetObject.tooltipField)) {
        jsChartMediaInfoValue.tooltipField = dotNetObject.tooltipField;
    }
    let { default: ChartMediaInfoValueWrapper } = await import('./chartMediaInfoValue');
    let chartMediaInfoValueWrapper = new ChartMediaInfoValueWrapper(jsChartMediaInfoValue);
    chartMediaInfoValueWrapper.geoBlazorId = dotNetObject.id;
    chartMediaInfoValueWrapper.viewId = viewId;
    chartMediaInfoValueWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(chartMediaInfoValueWrapper);
    jsObjectRefs[dotNetObject.id] = chartMediaInfoValueWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsChartMediaInfoValue;
    
    let dnInstantiatedObject = await buildDotNetChartMediaInfoValue(jsChartMediaInfoValue);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ChartMediaInfoValue', e);
    }
    
    return jsChartMediaInfoValue;
}

export async function buildDotNetChartMediaInfoValueGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetChartMediaInfoValue: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.colors)) {
            let { buildDotNetMapColor } = await import('./mapColor');
            dotNetChartMediaInfoValue.colors = jsObject.colors.map(i => buildDotNetMapColor(i));
        }
        if (hasValue(jsObject.series)) {
            let { buildDotNetChartMediaInfoValueSeries } = await import('./chartMediaInfoValueSeries');
            dotNetChartMediaInfoValue.series = await Promise.all(jsObject.series.map(async i => await buildDotNetChartMediaInfoValueSeries(i)));
        }
        if (hasValue(jsObject.fields)) {
            dotNetChartMediaInfoValue.fields = jsObject.fields;
        }
        if (hasValue(jsObject.normalizeField)) {
            dotNetChartMediaInfoValue.normalizeField = jsObject.normalizeField;
        }
        if (hasValue(jsObject.tooltipField)) {
            dotNetChartMediaInfoValue.tooltipField = jsObject.tooltipField;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetChartMediaInfoValue.id = k;
                break;
            }
        }
    }

    return dotNetChartMediaInfoValue;
}

