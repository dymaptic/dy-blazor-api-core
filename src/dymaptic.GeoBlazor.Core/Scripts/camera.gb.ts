// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import Camera from '@arcgis/core/Camera';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CameraGenerated implements IPropertyWrapper {
    public component: Camera;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: Camera) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getLayout(): Promise<any> {
        if (!hasValue(this.component.layout)) {
            return null;
        }
        
        let { buildDotNetCameraLayout } = await import('./cameraLayout');
        return await buildDotNetCameraLayout(this.component.layout, this.layerId, this.viewId);
    }
    async setLayout(value: any): Promise<void> {
        let { buildJsCameraLayout } = await import('./cameraLayout');
        this.component.layout = await  buildJsCameraLayout(value, this.layerId, this.viewId);
    }
    async getPosition(): Promise<any> {
        if (!hasValue(this.component.position)) {
            return null;
        }
        
        let { buildDotNetPoint } = await import('./point');
        return buildDotNetPoint(this.component.position);
    }
    async setPosition(value: any): Promise<void> {
        let { buildJsPoint } = await import('./point');
        this.component.position =  buildJsPoint(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsCameraGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCamera = new Camera();
    if (hasValue(dotNetObject.layout)) {
        let { buildJsCameraLayout } = await import('./cameraLayout');
        jsCamera.layout = await buildJsCameraLayout(dotNetObject.layout, layerId, viewId) as any;
    }
    if (hasValue(dotNetObject.position)) {
        let { buildJsPoint } = await import('./point');
        jsCamera.position = buildJsPoint(dotNetObject.position) as any;
    }

    if (hasValue(dotNetObject.fov)) {
        jsCamera.fov = dotNetObject.fov;
    }
    if (hasValue(dotNetObject.heading)) {
        jsCamera.heading = dotNetObject.heading;
    }
    if (hasValue(dotNetObject.tilt)) {
        jsCamera.tilt = dotNetObject.tilt;
    }
    let { default: CameraWrapper } = await import('./camera');
    let cameraWrapper = new CameraWrapper(jsCamera);
    cameraWrapper.geoBlazorId = dotNetObject.id;
    cameraWrapper.viewId = viewId;
    cameraWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(cameraWrapper);
    jsObjectRefs[dotNetObject.id] = cameraWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsCamera;
    let { buildDotNetCamera } = await import('./camera');
    let dnInstantiatedObject = await buildDotNetCamera(jsCamera, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for Camera', e);
    }
    
    return jsCamera;
}

export async function buildDotNetCameraGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCamera: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.layout)) {
            let { buildDotNetCameraLayout } = await import('./cameraLayout');
            dotNetCamera.layout = await buildDotNetCameraLayout(jsObject.layout, layerId, viewId);
        }
        if (hasValue(jsObject.position)) {
            let { buildDotNetPoint } = await import('./point');
            dotNetCamera.position = buildDotNetPoint(jsObject.position);
        }
        if (hasValue(jsObject.fov)) {
            dotNetCamera.fov = jsObject.fov;
        }
        if (hasValue(jsObject.heading)) {
            dotNetCamera.heading = jsObject.heading;
        }
        if (hasValue(jsObject.tilt)) {
            dotNetCamera.tilt = jsObject.tilt;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetCamera.id = k;
                break;
            }
        }
    }

    return dotNetCamera;
}

