// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import CoverageDescriptionV201EoMetadata = __esri.CoverageDescriptionV201EoMetadata;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class CoverageDescriptionV201EoMetadataGenerated implements IPropertyWrapper {
    public component: CoverageDescriptionV201EoMetadata;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: CoverageDescriptionV201EoMetadata) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getObservation(): Promise<any> {
        if (!hasValue(this.component.observation)) {
            return null;
        }
        
        let { buildDotNetCoverageDescriptionV201EoMetadataObservation } = await import('./coverageDescriptionV201EoMetadataObservation');
        return await buildDotNetCoverageDescriptionV201EoMetadataObservation(this.component.observation, this.layerId, this.viewId);
    }
    async setObservation(value: any): Promise<void> {
        let { buildJsCoverageDescriptionV201EoMetadataObservation } = await import('./coverageDescriptionV201EoMetadataObservation');
        this.component.observation = await  buildJsCoverageDescriptionV201EoMetadataObservation(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsCoverageDescriptionV201EoMetadataGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsCoverageDescriptionV201EoMetadata: any = {}
    if (hasValue(dotNetObject.observation)) {
        let { buildJsCoverageDescriptionV201EoMetadataObservation } = await import('./coverageDescriptionV201EoMetadataObservation');
        jsCoverageDescriptionV201EoMetadata.observation = await buildJsCoverageDescriptionV201EoMetadataObservation(dotNetObject.observation, layerId, viewId) as any;
    }

    let { default: CoverageDescriptionV201EoMetadataWrapper } = await import('./coverageDescriptionV201EoMetadata');
    let coverageDescriptionV201EoMetadataWrapper = new CoverageDescriptionV201EoMetadataWrapper(jsCoverageDescriptionV201EoMetadata);
    coverageDescriptionV201EoMetadataWrapper.geoBlazorId = dotNetObject.id;
    coverageDescriptionV201EoMetadataWrapper.viewId = viewId;
    coverageDescriptionV201EoMetadataWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(coverageDescriptionV201EoMetadataWrapper);
    jsObjectRefs[dotNetObject.id] = coverageDescriptionV201EoMetadataWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsCoverageDescriptionV201EoMetadata;
    
    let dnInstantiatedObject = await buildDotNetCoverageDescriptionV201EoMetadata(jsCoverageDescriptionV201EoMetadata, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for CoverageDescriptionV201EoMetadata', e);
    }
    
    return jsCoverageDescriptionV201EoMetadata;
}

export async function buildDotNetCoverageDescriptionV201EoMetadataGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetCoverageDescriptionV201EoMetadata: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.observation)) {
            let { buildDotNetCoverageDescriptionV201EoMetadataObservation } = await import('./coverageDescriptionV201EoMetadataObservation');
            dotNetCoverageDescriptionV201EoMetadata.observation = await buildDotNetCoverageDescriptionV201EoMetadataObservation(jsObject.observation, layerId, viewId);
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetCoverageDescriptionV201EoMetadata.id = k;
                break;
            }
        }
    }

    return dotNetCoverageDescriptionV201EoMetadata;
}

