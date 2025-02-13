// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import FieldsContent = __esri.FieldsContent;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class FieldsPopupContentGenerated implements IPropertyWrapper {
    public component: FieldsContent;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: FieldsContent) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getFieldInfos(): Promise<any> {
        let { buildDotNetFieldInfo } = await import('./fieldInfo');
        return this.component.fieldInfos.map(async i => await buildDotNetFieldInfo(i));
    }
    
    async setFieldInfos(value: any): Promise<void> {
        let { buildJsFieldInfo } = await import('./fieldInfo');
        this.component.fieldInfos = value.map(i => buildJsFieldInfo(i));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsFieldsPopupContentGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsFieldsContent = new FieldsContent();
    if (hasValue(dotNetObject.fieldInfos)) {
        let { buildJsFieldInfo } = await import('./jsBuilder');
        jsFieldsContent.fieldInfos = dotNetObject.fieldInfos.map(i => buildJsFieldInfo(i)) as any;
    }

    if (hasValue(dotNetObject.description)) {
        jsFieldsContent.description = dotNetObject.description;
    }
    if (hasValue(dotNetObject.title)) {
        jsFieldsContent.title = dotNetObject.title;
    }
    let { default: FieldsPopupContentWrapper } = await import('./fieldsPopupContent');
    let fieldsPopupContentWrapper = new FieldsPopupContentWrapper(jsFieldsContent);
    fieldsPopupContentWrapper.geoBlazorId = dotNetObject.id;
    fieldsPopupContentWrapper.viewId = viewId;
    fieldsPopupContentWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(fieldsPopupContentWrapper);
    jsObjectRefs[dotNetObject.id] = fieldsPopupContentWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsFieldsContent;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for FieldsPopupContent', e);
    }
    
    return jsFieldsContent;
}

export async function buildDotNetFieldsPopupContentGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetFieldsPopupContent: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.fieldInfos)) {
            let { buildDotNetFieldInfo } = await import('./fieldInfo');
            dotNetFieldsPopupContent.fieldInfos = await Promise.all(jsObject.fieldInfos.map(async i => await buildDotNetFieldInfo(i)));
        }
        if (hasValue(jsObject.description)) {
            dotNetFieldsPopupContent.description = jsObject.description;
        }
        if (hasValue(jsObject.title)) {
            dotNetFieldsPopupContent.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetFieldsPopupContent.type = jsObject.type;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetFieldsPopupContent.id = k;
                break;
            }
        }
    }

    return dotNetFieldsPopupContent;
}

