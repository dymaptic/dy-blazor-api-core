// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import SimpleRenderer from '@arcgis/core/renderers/SimpleRenderer';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class SimpleRendererGenerated implements IPropertyWrapper {
    public component: SimpleRenderer;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: SimpleRenderer) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getAuthoringInfo(): Promise<any> {
        if (!hasValue(this.component.authoringInfo)) {
            return null;
        }
        
        let { buildDotNetAuthoringInfo } = await import('./authoringInfo');
        return await buildDotNetAuthoringInfo(this.component.authoringInfo);
    }
    async setAuthoringInfo(value: any): Promise<void> {
        let { buildJsAuthoringInfo } = await import('./authoringInfo');
        this.component.authoringInfo = await  buildJsAuthoringInfo(value, this.layerId, this.viewId);
    }
    async getSymbol(): Promise<any> {
        if (!hasValue(this.component.symbol)) {
            return null;
        }
        
        let { buildDotNetSymbol } = await import('./symbol');
        return await buildDotNetSymbol(this.component.symbol);
    }
    async setSymbol(value: any): Promise<void> {
        let { buildJsSymbol } = await import('./symbol');
        this.component.symbol = await  buildJsSymbol(value);
    }
    async getVisualVariables(): Promise<any> {
        if (!hasValue(this.component.visualVariables)) {
            return null;
        }
        
        let { buildDotNetVisualVariable } = await import('./visualVariable');
        return await Promise.all(this.component.visualVariables.map(async i => await buildDotNetVisualVariable(i)));
    }
    
    async setVisualVariables(value: any): Promise<void> {
        let { buildJsVisualVariable } = await import('./visualVariable');
        this.component.visualVariables = await Promise.all(value.map(async i => await buildJsVisualVariable(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsSimpleRendererGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsSimpleRenderer = new SimpleRenderer();
    if (hasValue(dotNetObject.authoringInfo)) {
        let { buildJsAuthoringInfo } = await import('./authoringInfo');
        jsSimpleRenderer.authoringInfo = await buildJsAuthoringInfo(dotNetObject.authoringInfo, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.symbol)) {
        let { buildJsSymbol } = await import('./symbol');
        jsSimpleRenderer.symbol = await buildJsSymbol(dotNetObject.symbol) as any;
    }
    if (hasValue(dotNetObject.visualVariables)) {
        let { buildJsVisualVariable } = await import('./visualVariable');
        jsSimpleRenderer.visualVariables = await Promise.all(dotNetObject.visualVariables.map(async i => await buildJsVisualVariable(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.label)) {
        jsSimpleRenderer.label = dotNetObject.label;
    }
    let { default: SimpleRendererWrapper } = await import('./simpleRenderer');
    let simpleRendererWrapper = new SimpleRendererWrapper(jsSimpleRenderer);
    simpleRendererWrapper.geoBlazorId = dotNetObject.id;
    simpleRendererWrapper.viewId = viewId;
    simpleRendererWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(simpleRendererWrapper);
    jsObjectRefs[dotNetObject.id] = simpleRendererWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsSimpleRenderer;
    
    let { buildDotNetSimpleRenderer } = await import('./simpleRenderer');
    let dnInstantiatedObject = await buildDotNetSimpleRenderer(jsSimpleRenderer);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for SimpleRenderer', e);
    }
    
    return jsSimpleRenderer;
}

export async function buildDotNetSimpleRendererGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetSimpleRenderer: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.authoringInfo)) {
            let { buildDotNetAuthoringInfo } = await import('./authoringInfo');
            dotNetSimpleRenderer.authoringInfo = await buildDotNetAuthoringInfo(jsObject.authoringInfo);
        }
        if (hasValue(jsObject.symbol)) {
            let { buildDotNetSymbol } = await import('./symbol');
            dotNetSimpleRenderer.symbol = await buildDotNetSymbol(jsObject.symbol);
        }
        if (hasValue(jsObject.visualVariables)) {
            let { buildDotNetVisualVariable } = await import('./visualVariable');
            dotNetSimpleRenderer.visualVariables = await Promise.all(jsObject.visualVariables.map(async i => await buildDotNetVisualVariable(i)));
        }
        if (hasValue(jsObject.label)) {
            dotNetSimpleRenderer.label = jsObject.label;
        }
        if (hasValue(jsObject.type)) {
            dotNetSimpleRenderer.type = jsObject.type;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetSimpleRenderer.id = k;
                break;
            }
        }
    }

    return dotNetSimpleRenderer;
}

