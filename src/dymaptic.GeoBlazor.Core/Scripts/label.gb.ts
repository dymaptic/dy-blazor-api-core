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
        // set all properties from component
        for (let prop in component) {
            if (component.hasOwnProperty(prop)) {
                this[prop] = component[prop];
            }
        }
    }
    
    // region methods
   
    unwrap() {
        return this.component;
    }
    
    // region properties
    
    async getSymbol(layerId: string | null, viewId: string | null): Promise<any> {
        let { buildDotNetSymbol } = await import('./symbol');
        return await buildDotNetSymbol(this.component.symbol, layerId, viewId);
    }
    async setSymbol(value: any, layerId: string | null, viewId: string | null): Promise<void> {
        let { buildJsSymbol } = await import('./symbol');
        this.component.symbol = await buildJsSymbol(value, layerId, viewId);
    }
    getProperty(prop: string): any {
        return this.component[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.component[prop] = value;
    }
}

export async function buildJsLabelGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let LabelClass = __esri.LabelClass;
    let jsLabelClass = new LabelClass();
    if (hasValue(dotNetObject.symbol)) {
        let { buildJsSymbol } = await import('./jsBuilder');
        jsLabelClass.symbol = buildJsSymbol(dotNetObject.symbol, layerId, viewId) as any;
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
    await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef);
    jsObjectRefs[dotNetObject.id] = labelWrapper;
    arcGisObjectRefs[dotNetObject.id] = jsLabelClass;
    
    return jsLabelClass;
}

export async function buildDotNetLabelGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetLabel: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.symbol)) {
            let { buildDotNetSymbol } = await import('./dotNetBuilder');
            dotNetLabel.symbol = buildDotNetSymbol(jsObject.symbol, layerId, viewId);
        }
        dotNetLabel.allowOverrun = jsObject.allowOverrun;
        dotNetLabel.deconflictionStrategy = jsObject.deconflictionStrategy;
        dotNetLabel.labelExpression = jsObject.labelExpression;
        dotNetLabel.labelExpressionInfo = jsObject.labelExpressionInfo;
        dotNetLabel.labelPlacement = jsObject.labelPlacement;
        dotNetLabel.labelPosition = jsObject.labelPosition;
        dotNetLabel.maxScale = jsObject.maxScale;
        dotNetLabel.minScale = jsObject.minScale;
        dotNetLabel.repeatLabel = jsObject.repeatLabel;
        dotNetLabel.repeatLabelDistance = jsObject.repeatLabelDistance;
        dotNetLabel.useCodedValues = jsObject.useCodedValues;
        dotNetLabel.where = jsObject.where;
    return dotNetLabel;
}

