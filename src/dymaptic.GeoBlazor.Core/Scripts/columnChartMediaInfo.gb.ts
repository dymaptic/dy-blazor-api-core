// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ColumnChartMediaInfo from '@arcgis/core/popup/content/ColumnChartMediaInfo';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ColumnChartMediaInfoGenerated implements IPropertyWrapper {
    public component: ColumnChartMediaInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ColumnChartMediaInfo) {
        this.component = component;
        // set all properties from component
        for (let prop in component) {
            if (component.hasOwnProperty(prop)) {
                this[prop] = component[prop];
            }
        }
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getValue(): Promise<any> {
        let { buildDotNetChartMediaInfoValue } = await import('./chartMediaInfoValue');
        return await buildDotNetChartMediaInfoValue(this.component.value);
    }
    async setValue(value: any): Promise<void> {
        let { buildJsChartMediaInfoValue } = await import('./chartMediaInfoValue');
        this.component.value =  buildJsChartMediaInfoValue(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsColumnChartMediaInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsColumnChartMediaInfo = new ColumnChartMediaInfo();
    if (hasValue(dotNetObject.value)) {
        let { buildJsChartMediaInfoValue } = await import('./jsBuilder');
        jsColumnChartMediaInfo.value = buildJsChartMediaInfoValue(dotNetObject.value) as any;
    }

    if (hasValue(dotNetObject.altText)) {
        jsColumnChartMediaInfo.altText = dotNetObject.altText;
    }
    if (hasValue(dotNetObject.caption)) {
        jsColumnChartMediaInfo.caption = dotNetObject.caption;
    }
    if (hasValue(dotNetObject.title)) {
        jsColumnChartMediaInfo.title = dotNetObject.title;
    }
    let { default: ColumnChartMediaInfoWrapper } = await import('./columnChartMediaInfo');
    let columnChartMediaInfoWrapper = new ColumnChartMediaInfoWrapper(jsColumnChartMediaInfo);
    columnChartMediaInfoWrapper.geoBlazorId = dotNetObject.id;
    columnChartMediaInfoWrapper.viewId = viewId;
    columnChartMediaInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(columnChartMediaInfoWrapper);
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = columnChartMediaInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsColumnChartMediaInfo;
    
    return jsColumnChartMediaInfo;
}

export async function buildDotNetColumnChartMediaInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetColumnChartMediaInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.value)) {
            let { buildDotNetChartMediaInfoValue } = await import('./chartMediaInfoValue');
            dotNetColumnChartMediaInfo.value = await buildDotNetChartMediaInfoValue(jsObject.value);
        }
        dotNetColumnChartMediaInfo.altText = jsObject.altText;
        dotNetColumnChartMediaInfo.caption = jsObject.caption;
        dotNetColumnChartMediaInfo.title = jsObject.title;
        dotNetColumnChartMediaInfo.type = jsObject.type;

    return dotNetColumnChartMediaInfo;
}

