// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ImageMediaInfo from '@arcgis/core/popup/content/ImageMediaInfo';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ImageMediaInfoGenerated implements IPropertyWrapper {
    public component: ImageMediaInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ImageMediaInfo) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getValue(): Promise<any> {
        if (!hasValue(this.component.value)) {
            return null;
        }
        
        let { buildDotNetImageMediaInfoValue } = await import('./imageMediaInfoValue');
        return await buildDotNetImageMediaInfoValue(this.component.value);
    }
    async setValue(value: any): Promise<void> {
        let { buildJsImageMediaInfoValue } = await import('./imageMediaInfoValue');
        this.component.value =  buildJsImageMediaInfoValue(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsImageMediaInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsImageMediaInfo = new ImageMediaInfo();
    if (hasValue(dotNetObject.value)) {
        let { buildJsImageMediaInfoValue } = await import('./jsBuilder');
        jsImageMediaInfo.value = buildJsImageMediaInfoValue(dotNetObject.value) as any;
    }

    if (hasValue(dotNetObject.altText)) {
        jsImageMediaInfo.altText = dotNetObject.altText;
    }
    if (hasValue(dotNetObject.caption)) {
        jsImageMediaInfo.caption = dotNetObject.caption;
    }
    if (hasValue(dotNetObject.refreshInterval)) {
        jsImageMediaInfo.refreshInterval = dotNetObject.refreshInterval;
    }
    if (hasValue(dotNetObject.title)) {
        jsImageMediaInfo.title = dotNetObject.title;
    }
    let { default: ImageMediaInfoWrapper } = await import('./imageMediaInfo');
    let imageMediaInfoWrapper = new ImageMediaInfoWrapper(jsImageMediaInfo);
    imageMediaInfoWrapper.geoBlazorId = dotNetObject.id;
    imageMediaInfoWrapper.viewId = viewId;
    imageMediaInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(imageMediaInfoWrapper);
    jsObjectRefs[dotNetObject.id] = imageMediaInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsImageMediaInfo;
    
    let dnInstantiatedObject = await buildDotNetImageMediaInfo(jsImageMediaInfo);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ImageMediaInfo', e);
    }
    
    return jsImageMediaInfo;
}

export async function buildDotNetImageMediaInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetImageMediaInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.value)) {
            let { buildDotNetImageMediaInfoValue } = await import('./imageMediaInfoValue');
            dotNetImageMediaInfo.value = await buildDotNetImageMediaInfoValue(jsObject.value);
        }
        if (hasValue(jsObject.altText)) {
            dotNetImageMediaInfo.altText = jsObject.altText;
        }
        if (hasValue(jsObject.caption)) {
            dotNetImageMediaInfo.caption = jsObject.caption;
        }
        if (hasValue(jsObject.refreshInterval)) {
            dotNetImageMediaInfo.refreshInterval = jsObject.refreshInterval;
        }
        if (hasValue(jsObject.title)) {
            dotNetImageMediaInfo.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetImageMediaInfo.type = jsObject.type;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetImageMediaInfo.id = k;
                break;
            }
        }
    }

    return dotNetImageMediaInfo;
}

