// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import UniqueValueRenderer from '@arcgis/core/renderers/UniqueValueRenderer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class UniqueValueRendererGenerated implements IPropertyWrapper {
    public component: UniqueValueRenderer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: UniqueValueRenderer) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async addUniqueValueInfo(valueOrInfo: any,
        symbol: any): Promise<void> {
        let { buildJsSymbol } = await import('./symbol');
        let jsSymbol = buildJsSymbol(symbol) as any;
        this.component.addUniqueValueInfo(valueOrInfo,
            jsSymbol);
    }

    async getUniqueValueInfo(graphic: any): Promise<any> {
        let { buildJsGraphic } = await import('./graphic');
        let jsGraphic = await buildJsGraphic(graphic, this.layerId, this.viewId) as any;
        let result = await this.component.getUniqueValueInfo(jsGraphic);
        let { buildDotNetUniqueValueInfo } = await import('./uniqueValueInfo');
        return await buildDotNetUniqueValueInfo(result);
    }

    async removeUniqueValueInfo(value: any): Promise<void> {
        this.component.removeUniqueValueInfo(value);
    }

    // region properties
    
    async getAuthoringInfo(): Promise<any> {
        let { buildDotNetAuthoringInfo } = await import('./authoringInfo');
        return await buildDotNetAuthoringInfo(this.component.authoringInfo);
    }
    async setAuthoringInfo(value: any): Promise<void> {
        let { buildJsAuthoringInfo } = await import('./authoringInfo');
        this.component.authoringInfo =  buildJsAuthoringInfo(value);
    }
    async getLegendOptions(): Promise<any> {
        let { buildDotNetUniqueValueRendererLegendOptions } = await import('./uniqueValueRendererLegendOptions');
        return await buildDotNetUniqueValueRendererLegendOptions(this.component.legendOptions);
    }
    async setLegendOptions(value: any): Promise<void> {
        let { buildJsUniqueValueRendererLegendOptions } = await import('./uniqueValueRendererLegendOptions');
        this.component.legendOptions = await  buildJsUniqueValueRendererLegendOptions(value, this.layerId, this.viewId);
    }
    async getUniqueValueGroups(): Promise<any> {
        let { buildDotNetUniqueValueGroup } = await import('./uniqueValueGroup');
        return this.component.uniqueValueGroups.map(async i => await buildDotNetUniqueValueGroup(i));
    }
    
    async setUniqueValueGroups(value: any): Promise<void> {
        let { buildJsUniqueValueGroup } = await import('./uniqueValueGroup');
        this.component.uniqueValueGroups = value.map(async i => await buildJsUniqueValueGroup(i, this.layerId, this.viewId));
    }
    
    async getUniqueValueInfos(): Promise<any> {
        let { buildDotNetUniqueValueInfo } = await import('./uniqueValueInfo');
        return this.component.uniqueValueInfos.map(async i => await buildDotNetUniqueValueInfo(i));
    }
    
    async setUniqueValueInfos(value: any): Promise<void> {
        let { buildJsUniqueValueInfo } = await import('./uniqueValueInfo');
        this.component.uniqueValueInfos = value.map(async i => await buildJsUniqueValueInfo(i, this.layerId, this.viewId));
    }
    
    async getVisualVariables(): Promise<any> {
        let { buildDotNetVisualVariable } = await import('./visualVariable');
        return this.component.visualVariables.map(async i => await buildDotNetVisualVariable(i));
    }
    
    async setVisualVariables(value: any): Promise<void> {
        let { buildJsVisualVariable } = await import('./visualVariable');
        this.component.visualVariables = value.map(i => buildJsVisualVariable(i));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsUniqueValueRendererGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsUniqueValueRenderer = new UniqueValueRenderer();
    if (hasValue(dotNetObject.authoringInfo)) {
        let { buildJsAuthoringInfo } = await import('./jsBuilder');
        jsUniqueValueRenderer.authoringInfo = buildJsAuthoringInfo(dotNetObject.authoringInfo) as any;
    }
    if (hasValue(dotNetObject.legendOptions)) {
        let { buildJsUniqueValueRendererLegendOptions } = await import('./uniqueValueRendererLegendOptions');
        jsUniqueValueRenderer.legendOptions = await buildJsUniqueValueRendererLegendOptions(dotNetObject.legendOptions, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.uniqueValueGroups)) {
        let { buildJsUniqueValueGroup } = await import('./uniqueValueGroup');
        jsUniqueValueRenderer.uniqueValueGroups = await Promise.all(dotNetObject.uniqueValueGroups.map(async i => await buildJsUniqueValueGroup(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.uniqueValueInfos)) {
        let { buildJsUniqueValueInfo } = await import('./uniqueValueInfo');
        jsUniqueValueRenderer.uniqueValueInfos = await Promise.all(dotNetObject.uniqueValueInfos.map(async i => await buildJsUniqueValueInfo(i, layerId, viewId))) as any;
    }
    if (hasValue(dotNetObject.visualVariables)) {
        let { buildJsVisualVariable } = await import('./jsBuilder');
        jsUniqueValueRenderer.visualVariables = dotNetObject.visualVariables.map(i => buildJsVisualVariable(i)) as any;
    }

    if (hasValue(dotNetObject.backgroundFillSymbol)) {
        jsUniqueValueRenderer.backgroundFillSymbol = dotNetObject.backgroundFillSymbol;
    }
    if (hasValue(dotNetObject.defaultLabel)) {
        jsUniqueValueRenderer.defaultLabel = dotNetObject.defaultLabel;
    }
    if (hasValue(dotNetObject.defaultSymbol)) {
        jsUniqueValueRenderer.defaultSymbol = dotNetObject.defaultSymbol;
    }
    if (hasValue(dotNetObject.field)) {
        jsUniqueValueRenderer.field = dotNetObject.field;
    }
    if (hasValue(dotNetObject.field2)) {
        jsUniqueValueRenderer.field2 = dotNetObject.field2;
    }
    if (hasValue(dotNetObject.field3)) {
        jsUniqueValueRenderer.field3 = dotNetObject.field3;
    }
    if (hasValue(dotNetObject.fieldDelimiter)) {
        jsUniqueValueRenderer.fieldDelimiter = dotNetObject.fieldDelimiter;
    }
    if (hasValue(dotNetObject.orderByClassesEnabled)) {
        jsUniqueValueRenderer.orderByClassesEnabled = dotNetObject.orderByClassesEnabled;
    }
    if (hasValue(dotNetObject.valueExpression)) {
        jsUniqueValueRenderer.valueExpression = dotNetObject.valueExpression;
    }
    if (hasValue(dotNetObject.valueExpressionTitle)) {
        jsUniqueValueRenderer.valueExpressionTitle = dotNetObject.valueExpressionTitle;
    }
    let { default: UniqueValueRendererWrapper } = await import('./uniqueValueRenderer');
    let uniqueValueRendererWrapper = new UniqueValueRendererWrapper(jsUniqueValueRenderer);
    uniqueValueRendererWrapper.geoBlazorId = dotNetObject.id;
    uniqueValueRendererWrapper.viewId = viewId;
    uniqueValueRendererWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(uniqueValueRendererWrapper);
    jsObjectRefs[dotNetObject.id] = uniqueValueRendererWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsUniqueValueRenderer;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for UniqueValueRenderer', e);
    }
    
    return jsUniqueValueRenderer;
}

export async function buildDotNetUniqueValueRendererGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetUniqueValueRenderer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.authoringInfo)) {
            let { buildDotNetAuthoringInfo } = await import('./authoringInfo');
            dotNetUniqueValueRenderer.authoringInfo = await buildDotNetAuthoringInfo(jsObject.authoringInfo);
        }
        if (hasValue(jsObject.legendOptions)) {
            let { buildDotNetUniqueValueRendererLegendOptions } = await import('./uniqueValueRendererLegendOptions');
            dotNetUniqueValueRenderer.legendOptions = await buildDotNetUniqueValueRendererLegendOptions(jsObject.legendOptions);
        }
        if (hasValue(jsObject.uniqueValueGroups)) {
            let { buildDotNetUniqueValueGroup } = await import('./uniqueValueGroup');
            dotNetUniqueValueRenderer.uniqueValueGroups = await Promise.all(jsObject.uniqueValueGroups.map(async i => await buildDotNetUniqueValueGroup(i)));
        }
        if (hasValue(jsObject.uniqueValueInfos)) {
            let { buildDotNetUniqueValueInfo } = await import('./uniqueValueInfo');
            dotNetUniqueValueRenderer.uniqueValueInfos = await Promise.all(jsObject.uniqueValueInfos.map(async i => await buildDotNetUniqueValueInfo(i)));
        }
        if (hasValue(jsObject.visualVariables)) {
            let { buildDotNetVisualVariable } = await import('./visualVariable');
            dotNetUniqueValueRenderer.visualVariables = await Promise.all(jsObject.visualVariables.map(async i => await buildDotNetVisualVariable(i)));
        }
        if (hasValue(jsObject.backgroundFillSymbol)) {
            dotNetUniqueValueRenderer.backgroundFillSymbol = jsObject.backgroundFillSymbol;
        }
        if (hasValue(jsObject.defaultLabel)) {
            dotNetUniqueValueRenderer.defaultLabel = jsObject.defaultLabel;
        }
        if (hasValue(jsObject.defaultSymbol)) {
            dotNetUniqueValueRenderer.defaultSymbol = jsObject.defaultSymbol;
        }
        if (hasValue(jsObject.field)) {
            dotNetUniqueValueRenderer.field = jsObject.field;
        }
        if (hasValue(jsObject.field2)) {
            dotNetUniqueValueRenderer.field2 = jsObject.field2;
        }
        if (hasValue(jsObject.field3)) {
            dotNetUniqueValueRenderer.field3 = jsObject.field3;
        }
        if (hasValue(jsObject.fieldDelimiter)) {
            dotNetUniqueValueRenderer.fieldDelimiter = jsObject.fieldDelimiter;
        }
        if (hasValue(jsObject.orderByClassesEnabled)) {
            dotNetUniqueValueRenderer.orderByClassesEnabled = jsObject.orderByClassesEnabled;
        }
        if (hasValue(jsObject.type)) {
            dotNetUniqueValueRenderer.type = jsObject.type;
        }
        if (hasValue(jsObject.valueExpression)) {
            dotNetUniqueValueRenderer.valueExpression = jsObject.valueExpression;
        }
        if (hasValue(jsObject.valueExpressionTitle)) {
            dotNetUniqueValueRenderer.valueExpressionTitle = jsObject.valueExpressionTitle;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetUniqueValueRenderer.id = k;
                break;
            }
        }
    }

    return dotNetUniqueValueRenderer;
}

