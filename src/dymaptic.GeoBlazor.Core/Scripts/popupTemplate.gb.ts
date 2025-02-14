// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import PopupTemplate from '@arcgis/core/PopupTemplate';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class PopupTemplateGenerated implements IPropertyWrapper {
    public component: PopupTemplate;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: PopupTemplate) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async setContent(value: any): Promise<void> {
        let { buildJsPopupContent } = await import('./popupContent');
        this.component.content = await Promise.all(value.map(async i => await buildJsPopupContent(i))) as any;
    }
    
    async getExpressionInfos(): Promise<any> {
        if (!hasValue(this.component.expressionInfos)) {
            return null;
        }
        
        let { buildDotNetExpressionInfo } = await import('./expressionInfo');
        return await Promise.all(this.component.expressionInfos.map(async i => await buildDotNetExpressionInfo(i)));
    }
    
    async setExpressionInfos(value: any): Promise<void> {
        let { buildJsExpressionInfo } = await import('./expressionInfo');
        this.component.expressionInfos = await Promise.all(value.map(async i => await buildJsExpressionInfo(i))) as any;
    }
    
    async getFieldInfos(): Promise<any> {
        if (!hasValue(this.component.fieldInfos)) {
            return null;
        }
        
        let { buildDotNetFieldInfo } = await import('./fieldInfo');
        return await Promise.all(this.component.fieldInfos.map(async i => await buildDotNetFieldInfo(i)));
    }
    
    async setFieldInfos(value: any): Promise<void> {
        let { buildJsFieldInfo } = await import('./fieldInfo');
        this.component.fieldInfos = await Promise.all(value.map(async i => await buildJsFieldInfo(i))) as any;
    }
    
    async getLayerOptions(): Promise<any> {
        if (!hasValue(this.component.layerOptions)) {
            return null;
        }
        
        let { buildDotNetLayerOptions } = await import('./layerOptions');
        return await buildDotNetLayerOptions(this.component.layerOptions);
    }
    async setLayerOptions(value: any): Promise<void> {
        let { buildJsLayerOptions } = await import('./layerOptions');
        this.component.layerOptions = await  buildJsLayerOptions(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsPopupTemplateGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsPopupTemplate = new PopupTemplate();
    if (hasValue(dotNetObject.content)) {
        let { buildJsPopupContent } = await import('./jsBuilder');
        jsPopupTemplate.content = dotNetObject.content.map(i => buildJsPopupContent(i)) as any;
    }
    if (hasValue(dotNetObject.expressionInfos)) {
        let { buildJsExpressionInfo } = await import('./jsBuilder');
        jsPopupTemplate.expressionInfos = await Promise.all(dotNetObject.expressionInfos.map(async i => await buildJsExpressionInfo(i))) as any;
    }
    if (hasValue(dotNetObject.fieldInfos)) {
        let { buildJsFieldInfo } = await import('./jsBuilder');
        jsPopupTemplate.fieldInfos = await Promise.all(dotNetObject.fieldInfos.map(async i => await buildJsFieldInfo(i))) as any;
    }
    if (hasValue(dotNetObject.layerOptions)) {
        let { buildJsLayerOptions } = await import('./layerOptions');
        jsPopupTemplate.layerOptions = await buildJsLayerOptions(dotNetObject.layerOptions, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.actions)) {
        jsPopupTemplate.actions = dotNetObject.actions;
    }
    if (hasValue(dotNetObject.lastEditInfoEnabled)) {
        jsPopupTemplate.lastEditInfoEnabled = dotNetObject.lastEditInfoEnabled;
    }
    if (hasValue(dotNetObject.outFields)) {
        jsPopupTemplate.outFields = dotNetObject.outFields;
    }
    if (hasValue(dotNetObject.overwriteActions)) {
        jsPopupTemplate.overwriteActions = dotNetObject.overwriteActions;
    }
    if (hasValue(dotNetObject.returnGeometry)) {
        jsPopupTemplate.returnGeometry = dotNetObject.returnGeometry;
    }
    if (hasValue(dotNetObject.title)) {
        jsPopupTemplate.title = dotNetObject.title;
    }
    let { default: PopupTemplateWrapper } = await import('./popupTemplate');
    let popupTemplateWrapper = new PopupTemplateWrapper(jsPopupTemplate);
    popupTemplateWrapper.geoBlazorId = dotNetObject.id;
    popupTemplateWrapper.viewId = viewId;
    popupTemplateWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(popupTemplateWrapper);
    jsObjectRefs[dotNetObject.id] = popupTemplateWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsPopupTemplate;
    
    let dnInstantiatedObject = await buildDotNetPopupTemplate(jsPopupTemplate);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for PopupTemplate', e);
    }
    
    return jsPopupTemplate;
}

export async function buildDotNetPopupTemplateGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetPopupTemplate: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.content)) {
            let { buildDotNetPopupContent } = await import('./popupContent');
            dotNetPopupTemplate.content = await Promise.all(jsObject.content.map(async i => await buildDotNetPopupContent(i)));
        }
        if (hasValue(jsObject.expressionInfos)) {
            let { buildDotNetExpressionInfo } = await import('./expressionInfo');
            dotNetPopupTemplate.expressionInfos = await Promise.all(jsObject.expressionInfos.map(async i => await buildDotNetExpressionInfo(i)));
        }
        if (hasValue(jsObject.fieldInfos)) {
            let { buildDotNetFieldInfo } = await import('./fieldInfo');
            dotNetPopupTemplate.fieldInfos = await Promise.all(jsObject.fieldInfos.map(async i => await buildDotNetFieldInfo(i)));
        }
        if (hasValue(jsObject.layerOptions)) {
            let { buildDotNetLayerOptions } = await import('./layerOptions');
            dotNetPopupTemplate.layerOptions = await buildDotNetLayerOptions(jsObject.layerOptions);
        }
        if (hasValue(jsObject.actions)) {
            dotNetPopupTemplate.actions = jsObject.actions;
        }
        if (hasValue(jsObject.lastEditInfoEnabled)) {
            dotNetPopupTemplate.lastEditInfoEnabled = jsObject.lastEditInfoEnabled;
        }
        if (hasValue(jsObject.outFields)) {
            dotNetPopupTemplate.outFields = jsObject.outFields;
        }
        if (hasValue(jsObject.overwriteActions)) {
            dotNetPopupTemplate.overwriteActions = jsObject.overwriteActions;
        }
        if (hasValue(jsObject.returnGeometry)) {
            dotNetPopupTemplate.returnGeometry = jsObject.returnGeometry;
        }
        if (hasValue(jsObject.title)) {
            dotNetPopupTemplate.title = jsObject.title;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetPopupTemplate.id = k;
                break;
            }
        }
    }

    return dotNetPopupTemplate;
}

