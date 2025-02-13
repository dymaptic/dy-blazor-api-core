// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import TileInfo from '@arcgis/core/layers/support/TileInfo';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class TileInfoGenerated implements IPropertyWrapper {
    public component: TileInfo;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: TileInfo) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    async scaleToZoom(scale: any): Promise<any> {
        return this.component.scaleToZoom(scale);
    }

    async zoomToScale(zoom: any): Promise<any> {
        return this.component.zoomToScale(zoom);
    }

    // region properties
    
    async getLods(): Promise<any> {
        let { buildDotNetLOD } = await import('./lOD');
        return this.component.lods.map(async i => await buildDotNetLOD(i));
    }
    
    async setLods(value: any): Promise<void> {
        let { buildJsLOD } = await import('./lOD');
        this.component.lods = value.map(async i => await buildJsLOD(i, this.layerId, this.viewId));
    }
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsTileInfoGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsTileInfo = new TileInfo();
    if (hasValue(dotNetObject.lods)) {
        let { buildJsLOD } = await import('./lOD');
        jsTileInfo.lods = await Promise.all(dotNetObject.lods.map(async i => await buildJsLOD(i, layerId, viewId))) as any;
    }

    if (hasValue(dotNetObject.dpi)) {
        jsTileInfo.dpi = dotNetObject.dpi;
    }
    if (hasValue(dotNetObject.format)) {
        jsTileInfo.format = dotNetObject.format;
    }
    if (hasValue(dotNetObject.isWrappable)) {
        jsTileInfo.isWrappable = dotNetObject.isWrappable;
    }
    if (hasValue(dotNetObject.origin)) {
        jsTileInfo.origin = dotNetObject.origin;
    }
    if (hasValue(dotNetObject.size)) {
        jsTileInfo.size = dotNetObject.size;
    }
    if (hasValue(dotNetObject.spatialReference)) {
        jsTileInfo.spatialReference = dotNetObject.spatialReference;
    }
    let { default: TileInfoWrapper } = await import('./tileInfo');
    let tileInfoWrapper = new TileInfoWrapper(jsTileInfo);
    tileInfoWrapper.geoBlazorId = dotNetObject.id;
    tileInfoWrapper.viewId = viewId;
    tileInfoWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(tileInfoWrapper);
    jsObjectRefs[dotNetObject.id] = tileInfoWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsTileInfo;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for TileInfo', e);
    }
    
    return jsTileInfo;
}

export async function buildDotNetTileInfoGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetTileInfo: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.lods)) {
            let { buildDotNetLOD } = await import('./lOD');
            dotNetTileInfo.lods = await Promise.all(jsObject.lods.map(async i => await buildDotNetLOD(i)));
        }
        if (hasValue(jsObject.dpi)) {
            dotNetTileInfo.dpi = jsObject.dpi;
        }
        if (hasValue(jsObject.format)) {
            dotNetTileInfo.format = jsObject.format;
        }
        if (hasValue(jsObject.isWrappable)) {
            dotNetTileInfo.isWrappable = jsObject.isWrappable;
        }
        if (hasValue(jsObject.origin)) {
            dotNetTileInfo.origin = jsObject.origin;
        }
        if (hasValue(jsObject.size)) {
            dotNetTileInfo.size = jsObject.size;
        }
        if (hasValue(jsObject.spatialReference)) {
            dotNetTileInfo.spatialReference = jsObject.spatialReference;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetTileInfo.id = k;
                break;
            }
        }
    }

    return dotNetTileInfo;
}

