// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import LabelClass = __esri.LabelClass;
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class LabelGenerated implements IPropertyWrapper {
    public component: LabelClass;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(component: LabelClass) {
        this.component = component;
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getSymbol(): Promise<any> {
        let { buildDotNetSymbol } = await import('./symbol');
        return await buildDotNetSymbol(this.component.symbol);
    }
    async setSymbol(value: any): Promise<void> {
        let { buildJsSymbol } = await import('./symbol');
        this.component.symbol =  buildJsSymbol(value);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsLabelGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsLabelClass = new LabelClass();
    if (hasValue(dotNetObject.symbol)) {
        let { buildJsSymbol } = await import('./jsBuilder');
        jsLabelClass.symbol = buildJsSymbol(dotNetObject.symbol) as any;
    }

    if (hasValue(dotNetObject.allowOverrun)) {
        jsLabelClass.allowOverrun = dotNetObject.allowOverrun;
    }
    if (hasValue(dotNetObject.deconflictionStrategy)) {
        jsLabelClass.deconflictionStrategy = dotNetObject.deconflictionStrategy;
    }
    if (hasValue(dotNetObject.labelExpression)) {
        jsLabelClass.labelExpression = dotNetObject.labelExpression;
    }
    if (hasValue(dotNetObject.labelExpressionInfo)) {
        jsLabelClass.labelExpressionInfo = dotNetObject.labelExpressionInfo;
    }
    if (hasValue(dotNetObject.labelPlacement)) {
        jsLabelClass.labelPlacement = dotNetObject.labelPlacement;
    }
    if (hasValue(dotNetObject.labelPosition)) {
        jsLabelClass.labelPosition = dotNetObject.labelPosition;
    }
    if (hasValue(dotNetObject.maxScale)) {
        jsLabelClass.maxScale = dotNetObject.maxScale;
    }
    if (hasValue(dotNetObject.minScale)) {
        jsLabelClass.minScale = dotNetObject.minScale;
    }
    if (hasValue(dotNetObject.repeatLabel)) {
        jsLabelClass.repeatLabel = dotNetObject.repeatLabel;
    }
    if (hasValue(dotNetObject.repeatLabelDistance)) {
        jsLabelClass.repeatLabelDistance = dotNetObject.repeatLabelDistance;
    }
    if (hasValue(dotNetObject.useCodedValues)) {
        jsLabelClass.useCodedValues = dotNetObject.useCodedValues;
    }
    if (hasValue(dotNetObject.where)) {
        jsLabelClass.where = dotNetObject.where;
    }
    let { default: LabelWrapper } = await import('./label');
    let labelWrapper = new LabelWrapper(jsLabelClass);
    labelWrapper.geoBlazorId = dotNetObject.id;
    labelWrapper.viewId = viewId;
    labelWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(labelWrapper);
    jsObjectRefs[dotNetObject.id] = labelWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsLabelClass;
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for Label', e);
    }
    
    return jsLabelClass;
}

export async function buildDotNetLabelGenerated(jsObject: any): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetLabel: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.symbol)) {
            let { buildDotNetSymbol } = await import('./symbol');
            dotNetLabel.symbol = await buildDotNetSymbol(jsObject.symbol);
        }
        if (hasValue(jsObject.allowOverrun)) {
            dotNetLabel.allowOverrun = jsObject.allowOverrun;
        }
        if (hasValue(jsObject.deconflictionStrategy)) {
            dotNetLabel.deconflictionStrategy = jsObject.deconflictionStrategy;
        }
        if (hasValue(jsObject.labelExpression)) {
            dotNetLabel.labelExpression = jsObject.labelExpression;
        }
        if (hasValue(jsObject.labelExpressionInfo)) {
            dotNetLabel.labelExpressionInfo = jsObject.labelExpressionInfo;
        }
        if (hasValue(jsObject.labelPlacement)) {
            dotNetLabel.labelPlacement = jsObject.labelPlacement;
        }
        if (hasValue(jsObject.labelPosition)) {
            dotNetLabel.labelPosition = jsObject.labelPosition;
        }
        if (hasValue(jsObject.maxScale)) {
            dotNetLabel.maxScale = jsObject.maxScale;
        }
        if (hasValue(jsObject.minScale)) {
            dotNetLabel.minScale = jsObject.minScale;
        }
        if (hasValue(jsObject.repeatLabel)) {
            dotNetLabel.repeatLabel = jsObject.repeatLabel;
        }
        if (hasValue(jsObject.repeatLabelDistance)) {
            dotNetLabel.repeatLabelDistance = jsObject.repeatLabelDistance;
        }
        if (hasValue(jsObject.useCodedValues)) {
            dotNetLabel.useCodedValues = jsObject.useCodedValues;
        }
        if (hasValue(jsObject.where)) {
            dotNetLabel.where = jsObject.where;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetLabel.id = k;
                break;
            }
        }
    }

    return dotNetLabel;
}

