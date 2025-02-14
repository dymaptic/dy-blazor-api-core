// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import SimpleMarkerSymbol from '@arcgis/core/symbols/SimpleMarkerSymbol';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class SimpleMarkerSymbolGenerated implements IPropertyWrapper {
    public component: SimpleMarkerSymbol;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: SimpleMarkerSymbol) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getColor(): Promise<any> {
        let { buildDotNetMapColor } = await import('./mapColor');
        return buildDotNetMapColor(this.component.color);
    }
    async setColor(value: any): Promise<void> {
        let { buildJsMapColor } = await import('./mapColor');
        this.component.color =  buildJsMapColor(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsSimpleMarkerSymbolGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsSimpleMarkerSymbol = new SimpleMarkerSymbol();
    if (hasValue(dotNetObject.color)) {
        let { buildJsMapColor } = await import('./mapColor');
        jsSimpleMarkerSymbol.color = buildJsMapColor(dotNetObject.color) as any;
    }

    if (hasValue(dotNetObject.angle)) {
        jsSimpleMarkerSymbol.angle = dotNetObject.angle;
    }
    if (hasValue(dotNetObject.outline)) {
        jsSimpleMarkerSymbol.outline = dotNetObject.outline;
    }
    if (hasValue(dotNetObject.path)) {
        jsSimpleMarkerSymbol.path = dotNetObject.path;
    }
    if (hasValue(dotNetObject.size)) {
        jsSimpleMarkerSymbol.size = dotNetObject.size;
    }
    if (hasValue(dotNetObject.style)) {
        jsSimpleMarkerSymbol.style = dotNetObject.style;
    }
    if (hasValue(dotNetObject.xoffset)) {
        jsSimpleMarkerSymbol.xoffset = dotNetObject.xoffset;
    }
    if (hasValue(dotNetObject.yoffset)) {
        jsSimpleMarkerSymbol.yoffset = dotNetObject.yoffset;
    }
    let { default: SimpleMarkerSymbolWrapper } = await import('./simpleMarkerSymbol');
    let simpleMarkerSymbolWrapper = new SimpleMarkerSymbolWrapper(jsSimpleMarkerSymbol);
    simpleMarkerSymbolWrapper.geoBlazorId = dotNetObject.id;
    simpleMarkerSymbolWrapper.viewId = viewId;
    simpleMarkerSymbolWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(simpleMarkerSymbolWrapper);
    jsObjectRefs[dotNetObject.id] = simpleMarkerSymbolWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsSimpleMarkerSymbol;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for SimpleMarkerSymbol', e);
    }
    
    return jsSimpleMarkerSymbol;
}

export async function buildDotNetSimpleMarkerSymbolGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetSimpleMarkerSymbol: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.color)) {
            let { buildDotNetMapColor } = await import('./mapColor');
            dotNetSimpleMarkerSymbol.color = buildDotNetMapColor(jsObject.color);
        }
        if (hasValue(jsObject.angle)) {
            dotNetSimpleMarkerSymbol.angle = jsObject.angle;
        }
        if (hasValue(jsObject.outline)) {
            dotNetSimpleMarkerSymbol.outline = jsObject.outline;
        }
        if (hasValue(jsObject.path)) {
            dotNetSimpleMarkerSymbol.path = jsObject.path;
        }
        if (hasValue(jsObject.size)) {
            dotNetSimpleMarkerSymbol.size = jsObject.size;
        }
        if (hasValue(jsObject.style)) {
            dotNetSimpleMarkerSymbol.style = jsObject.style;
        }
        if (hasValue(jsObject.type)) {
            dotNetSimpleMarkerSymbol.type = jsObject.type;
        }
        if (hasValue(jsObject.xoffset)) {
            dotNetSimpleMarkerSymbol.xoffset = jsObject.xoffset;
        }
        if (hasValue(jsObject.yoffset)) {
            dotNetSimpleMarkerSymbol.yoffset = jsObject.yoffset;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetSimpleMarkerSymbol.id = k;
                break;
            }
        }
    }

    return dotNetSimpleMarkerSymbol;
}

