// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ArcGISImageServiceCapabilitiesOperations = __esri.ArcGISImageServiceCapabilitiesOperations;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ArcGISImageServiceCapabilitiesOperationsGenerated implements IPropertyWrapper {
    public component: ArcGISImageServiceCapabilitiesOperations;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: ArcGISImageServiceCapabilitiesOperations) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsArcGISImageServiceCapabilitiesOperationsGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsArcGISImageServiceCapabilitiesOperations: any = {}

    if (hasValue(dotNetObject.supportsCalculateVolume)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsCalculateVolume = dotNetObject.supportsCalculateVolume;
    }
    if (hasValue(dotNetObject.supportsComputeHistograms)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsComputeHistograms = dotNetObject.supportsComputeHistograms;
    }
    if (hasValue(dotNetObject.supportsComputePixelLocation)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsComputePixelLocation = dotNetObject.supportsComputePixelLocation;
    }
    if (hasValue(dotNetObject.supportsComputeStatisticsHistograms)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsComputeStatisticsHistograms = dotNetObject.supportsComputeStatisticsHistograms;
    }
    if (hasValue(dotNetObject.supportsDownload)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsDownload = dotNetObject.supportsDownload;
    }
    if (hasValue(dotNetObject.supportsExportImage)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsExportImage = dotNetObject.supportsExportImage;
    }
    if (hasValue(dotNetObject.supportsFindImages)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsFindImages = dotNetObject.supportsFindImages;
    }
    if (hasValue(dotNetObject.supportsGetImageUrl)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsGetImageUrl = dotNetObject.supportsGetImageUrl;
    }
    if (hasValue(dotNetObject.supportsGetSamples)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsGetSamples = dotNetObject.supportsGetSamples;
    }
    if (hasValue(dotNetObject.supportsIdentify)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsIdentify = dotNetObject.supportsIdentify;
    }
    if (hasValue(dotNetObject.supportsImageToMap)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsImageToMap = dotNetObject.supportsImageToMap;
    }
    if (hasValue(dotNetObject.supportsImageToMapMultiray)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsImageToMapMultiray = dotNetObject.supportsImageToMapMultiray;
    }
    if (hasValue(dotNetObject.supportsMapToImage)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsMapToImage = dotNetObject.supportsMapToImage;
    }
    if (hasValue(dotNetObject.supportsMeasure)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsMeasure = dotNetObject.supportsMeasure;
    }
    if (hasValue(dotNetObject.supportsProject)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsProject = dotNetObject.supportsProject;
    }
    if (hasValue(dotNetObject.supportsQuery)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsQuery = dotNetObject.supportsQuery;
    }
    if (hasValue(dotNetObject.supportsQueryBoundary)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsQueryBoundary = dotNetObject.supportsQueryBoundary;
    }
    if (hasValue(dotNetObject.supportsQueryGPSInfo)) {
        jsArcGISImageServiceCapabilitiesOperations.supportsQueryGPSInfo = dotNetObject.supportsQueryGPSInfo;
    }
    let { default: ArcGISImageServiceCapabilitiesOperationsWrapper } = await import('./arcGISImageServiceCapabilitiesOperations');
    let arcGISImageServiceCapabilitiesOperationsWrapper = new ArcGISImageServiceCapabilitiesOperationsWrapper(jsArcGISImageServiceCapabilitiesOperations);
    arcGISImageServiceCapabilitiesOperationsWrapper.geoBlazorId = dotNetObject.id;
    arcGISImageServiceCapabilitiesOperationsWrapper.viewId = viewId;
    arcGISImageServiceCapabilitiesOperationsWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(arcGISImageServiceCapabilitiesOperationsWrapper);
    jsObjectRefs[dotNetObject.id] = arcGISImageServiceCapabilitiesOperationsWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsArcGISImageServiceCapabilitiesOperations;
    let { buildDotNetArcGISImageServiceCapabilitiesOperations } = await import('./arcGISImageServiceCapabilitiesOperations');
    let dnInstantiatedObject = await buildDotNetArcGISImageServiceCapabilitiesOperations(jsArcGISImageServiceCapabilitiesOperations);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ArcGISImageServiceCapabilitiesOperations', e);
    }
    
    return jsArcGISImageServiceCapabilitiesOperations;
}

export async function buildDotNetArcGISImageServiceCapabilitiesOperationsGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetArcGISImageServiceCapabilitiesOperations: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.supportsCalculateVolume)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsCalculateVolume = jsObject.supportsCalculateVolume;
        }
        if (hasValue(jsObject.supportsComputeHistograms)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsComputeHistograms = jsObject.supportsComputeHistograms;
        }
        if (hasValue(jsObject.supportsComputePixelLocation)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsComputePixelLocation = jsObject.supportsComputePixelLocation;
        }
        if (hasValue(jsObject.supportsComputeStatisticsHistograms)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsComputeStatisticsHistograms = jsObject.supportsComputeStatisticsHistograms;
        }
        if (hasValue(jsObject.supportsDownload)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsDownload = jsObject.supportsDownload;
        }
        if (hasValue(jsObject.supportsExportImage)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsExportImage = jsObject.supportsExportImage;
        }
        if (hasValue(jsObject.supportsFindImages)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsFindImages = jsObject.supportsFindImages;
        }
        if (hasValue(jsObject.supportsGetImageUrl)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsGetImageUrl = jsObject.supportsGetImageUrl;
        }
        if (hasValue(jsObject.supportsGetSamples)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsGetSamples = jsObject.supportsGetSamples;
        }
        if (hasValue(jsObject.supportsIdentify)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsIdentify = jsObject.supportsIdentify;
        }
        if (hasValue(jsObject.supportsImageToMap)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsImageToMap = jsObject.supportsImageToMap;
        }
        if (hasValue(jsObject.supportsImageToMapMultiray)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsImageToMapMultiray = jsObject.supportsImageToMapMultiray;
        }
        if (hasValue(jsObject.supportsMapToImage)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsMapToImage = jsObject.supportsMapToImage;
        }
        if (hasValue(jsObject.supportsMeasure)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsMeasure = jsObject.supportsMeasure;
        }
        if (hasValue(jsObject.supportsProject)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsProject = jsObject.supportsProject;
        }
        if (hasValue(jsObject.supportsQuery)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsQuery = jsObject.supportsQuery;
        }
        if (hasValue(jsObject.supportsQueryBoundary)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsQueryBoundary = jsObject.supportsQueryBoundary;
        }
        if (hasValue(jsObject.supportsQueryGPSInfo)) {
            dotNetArcGISImageServiceCapabilitiesOperations.supportsQueryGPSInfo = jsObject.supportsQueryGPSInfo;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetArcGISImageServiceCapabilitiesOperations.id = k;
                break;
            }
        }
    }

    return dotNetArcGISImageServiceCapabilitiesOperations;
}

