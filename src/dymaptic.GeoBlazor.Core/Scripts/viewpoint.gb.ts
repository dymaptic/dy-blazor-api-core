// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import Viewpoint from '@arcgis/core/Viewpoint';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ViewpointGenerated implements IPropertyWrapper {
    public component: Viewpoint;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: Viewpoint) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getCamera(): Promise<any> {
        if (!hasValue(this.component.camera)) {
            return null;
        }
        
        let { buildDotNetCamera } = await import('./camera');
        return await buildDotNetCamera(this.component.camera, this.layerId, this.viewId);
    }
    async setCamera(value: any): Promise<void> {
        let { buildJsCamera } = await import('./camera');
        this.component.camera = await  buildJsCamera(value, this.layerId, this.viewId);
    }
    async getTargetGeometry(): Promise<any> {
        if (!hasValue(this.component.targetGeometry)) {
            return null;
        }
        
        let { buildDotNetGeometry } = await import('./geometry');
        return buildDotNetGeometry(this.component.targetGeometry);
    }
    async setTargetGeometry(value: any): Promise<void> {
        let { buildJsGeometry } = await import('./geometry');
        this.component.targetGeometry =  buildJsGeometry(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

