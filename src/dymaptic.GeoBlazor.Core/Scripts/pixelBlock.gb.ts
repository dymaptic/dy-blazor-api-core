// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import PixelBlock from '@arcgis/core/layers/support/PixelBlock';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class PixelBlockGenerated implements IPropertyWrapper {
    public component: PixelBlock;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: PixelBlock) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async addData(planeData: any): Promise<void> {
        this.component.addData(planeData);
    }

    async getAsRGBA(): Promise<any> {
        return this.component.getAsRGBA();
    }

    async getAsRGBAFloat(): Promise<any> {
        return this.component.getAsRGBAFloat();
    }

    async getPlaneCount(): Promise<any> {
        return this.component.getPlaneCount();
    }

    // region properties
    
    async getStatistics(): Promise<any> {
        if (!hasValue(this.component.statistics)) {
            return null;
        }
        
        let { buildDotNetPixelBlockStatistics } = await import('./pixelBlockStatistics');
        return await Promise.all(this.component.statistics.map(async i => await buildDotNetPixelBlockStatistics(i)));
    }
    
    async setStatistics(value: any): Promise<void> {
        let { buildJsPixelBlockStatistics } = await import('./pixelBlockStatistics');
        this.component.statistics = await Promise.all(value.map(async i => await buildJsPixelBlockStatistics(i, this.layerId, this.viewId))) as any;
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsPixelBlockGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsPixelBlock = new PixelBlock();
    if (hasValue(dotNetObject.statistics)) {
        let { buildJsPixelBlockStatistics } = await import('./pixelBlockStatistics');
        jsPixelBlock.statistics = await Promise.all(dotNetObject.statistics.map(async i => await buildJsPixelBlockStatistics(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.height)) {
        jsPixelBlock.height = dotNetObject.height;
    }
    if (hasValue(dotNetObject.mask)) {
        jsPixelBlock.mask = dotNetObject.mask;
    }
    if (hasValue(dotNetObject.maskIsAlpha)) {
        jsPixelBlock.maskIsAlpha = dotNetObject.maskIsAlpha;
    }
    if (hasValue(dotNetObject.pixels)) {
        jsPixelBlock.pixels = dotNetObject.pixels;
    }
    if (hasValue(dotNetObject.pixelType)) {
        jsPixelBlock.pixelType = dotNetObject.pixelType;
    }
    if (hasValue(dotNetObject.validPixelCount)) {
        jsPixelBlock.validPixelCount = dotNetObject.validPixelCount;
    }
    if (hasValue(dotNetObject.width)) {
        jsPixelBlock.width = dotNetObject.width;
    }
    let { default: PixelBlockWrapper } = await import('./pixelBlock');
    let pixelBlockWrapper = new PixelBlockWrapper(jsPixelBlock);
    pixelBlockWrapper.geoBlazorId = dotNetObject.id;
    pixelBlockWrapper.viewId = viewId;
    pixelBlockWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(pixelBlockWrapper);
    jsObjectRefs[dotNetObject.id] = pixelBlockWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsPixelBlock;
    
    let dnInstantiatedObject = await buildDotNetPixelBlock(jsPixelBlock);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for PixelBlock', e);
    }
    
    return jsPixelBlock;
}

export async function buildDotNetPixelBlockGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetPixelBlock: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.statistics)) {
            let { buildDotNetPixelBlockStatistics } = await import('./pixelBlockStatistics');
            dotNetPixelBlock.statistics = await Promise.all(jsObject.statistics.map(async i => await buildDotNetPixelBlockStatistics(i)));
        }
        if (hasValue(jsObject.height)) {
            dotNetPixelBlock.height = jsObject.height;
        }
        if (hasValue(jsObject.mask)) {
            dotNetPixelBlock.mask = jsObject.mask;
        }
        if (hasValue(jsObject.maskIsAlpha)) {
            dotNetPixelBlock.maskIsAlpha = jsObject.maskIsAlpha;
        }
        if (hasValue(jsObject.pixels)) {
            dotNetPixelBlock.pixels = jsObject.pixels;
        }
        if (hasValue(jsObject.pixelType)) {
            dotNetPixelBlock.pixelType = jsObject.pixelType;
        }
        if (hasValue(jsObject.validPixelCount)) {
            dotNetPixelBlock.validPixelCount = jsObject.validPixelCount;
        }
        if (hasValue(jsObject.width)) {
            dotNetPixelBlock.width = jsObject.width;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetPixelBlock.id = k;
                break;
            }
        }
    }

    return dotNetPixelBlock;
}

