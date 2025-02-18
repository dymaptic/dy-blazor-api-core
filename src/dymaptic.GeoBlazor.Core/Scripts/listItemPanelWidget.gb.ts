// File auto-generated by dymaptic tooling. Any changes made here will be lost on future generation. To override functionality, use the relevant root .ts file


import ListItemPanel from '@arcgis/core/widgets/LayerList/ListItemPanel';
import {arcGisObjectRefs, hasValue, jsObjectRefs} from './arcGisJsInterop';
import {IPropertyWrapper} from './definitions';

export default class ListItemPanelWidgetGenerated implements IPropertyWrapper {
    public widget: ListItemPanel;
    public geoBlazorId: string | null = null;
    public viewId: string | null = null;
    public layerId: string | null = null;

    constructor(widget: ListItemPanel) {
        this.widget = widget;
    }
    
    // region methods
   
    unwrap() {
        return this.widget;
    }
    
    async classes(): Promise<any> {
        return this.widget.classes();
    }

    async isFulfilled(): Promise<any> {
        return this.widget.isFulfilled();
    }

    async isRejected(): Promise<any> {
        return this.widget.isRejected();
    }

    async isResolved(): Promise<any> {
        return this.widget.isResolved();
    }

    async own(handleOrHandles: any): Promise<void> {
        this.widget.own(handleOrHandles);
    }

    async postInitialize(): Promise<void> {
        this.widget.postInitialize();
    }

    async render(): Promise<any> {
        return this.widget.render();
    }

    async renderNow(): Promise<void> {
        this.widget.renderNow();
    }

    async scheduleRender(): Promise<void> {
        this.widget.scheduleRender();
    }

    async when(callback: any,
        errback: any): Promise<any> {
        return await this.widget.when(callback,
            errback);
    }

    // region properties
    
    async getListItem(): Promise<any> {
        if (!hasValue(this.widget.listItem)) {
            return null;
        }
        
        let { buildDotNetListItem } = await import('./listItem');
        return await buildDotNetListItem(this.widget.listItem, this.layerId, this.viewId);
    }
    async setListItem(value: any): Promise<void> {
        let { buildJsListItem } = await import('./listItem');
        this.widget.listItem = await  buildJsListItem(value, this.layerId, this.viewId);
    }
    getProperty(prop: string): any {
        return this.widget[prop];
    }
    
    setProperty(prop: string, value: any): void {
        this.widget[prop] = value;
    }
}

export async function buildJsListItemPanelWidgetGenerated(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let jsListItemPanel = new ListItemPanel();
    if (hasValue(dotNetObject.listItem)) {
        let { buildJsListItem } = await import('./listItem');
        jsListItemPanel.listItem = await buildJsListItem(dotNetObject.listItem, layerId, viewId) as any;
    }

    if (hasValue(dotNetObject.className)) {
        jsListItemPanel.className = dotNetObject.className;
    }
    if (hasValue(dotNetObject.container)) {
        jsListItemPanel.container = dotNetObject.container;
    }
    if (hasValue(dotNetObject.content)) {
        jsListItemPanel.content = dotNetObject.content;
    }
    if (hasValue(dotNetObject.disabled)) {
        jsListItemPanel.disabled = dotNetObject.disabled;
    }
    if (hasValue(dotNetObject.flowEnabled)) {
        jsListItemPanel.flowEnabled = dotNetObject.flowEnabled;
    }
    if (hasValue(dotNetObject.icon)) {
        jsListItemPanel.icon = dotNetObject.icon;
    }
    if (hasValue(dotNetObject.image)) {
        jsListItemPanel.image = dotNetObject.image;
    }
    if (hasValue(dotNetObject.label)) {
        jsListItemPanel.label = dotNetObject.label;
    }
    if (hasValue(dotNetObject.open)) {
        jsListItemPanel.open = dotNetObject.open;
    }
    if (hasValue(dotNetObject.title)) {
        jsListItemPanel.title = dotNetObject.title;
    }
    if (hasValue(dotNetObject.widgetId)) {
        jsListItemPanel.id = dotNetObject.widgetId;
    }
    let { default: ListItemPanelWidgetWrapper } = await import('./listItemPanelWidget');
    let listItemPanelWidgetWrapper = new ListItemPanelWidgetWrapper(jsListItemPanel);
    listItemPanelWidgetWrapper.geoBlazorId = dotNetObject.id;
    listItemPanelWidgetWrapper.viewId = viewId;
    listItemPanelWidgetWrapper.layerId = layerId;
    
    // @ts-ignore
    let jsObjectRef = DotNet.createJSObjectReference(listItemPanelWidgetWrapper);
    jsObjectRefs[dotNetObject.id] = listItemPanelWidgetWrapper;

    arcGisObjectRefs[dotNetObject.id] = jsListItemPanel;
    let { buildDotNetListItemPanelWidget } = await import('./listItemPanelWidget');
    let dnInstantiatedObject = await buildDotNetListItemPanelWidget(jsListItemPanel, layerId, viewId);
    
    try {
        await dotNetObject.dotNetComponentReference.invokeMethodAsync('OnJsComponentCreated', jsObjectRef, JSON.stringify(dnInstantiatedObject));
    } catch (e) {
        console.error('Error invoking OnJsComponentCreated for ListItemPanelWidget', e);
    }
    
    return jsListItemPanel;
}

export async function buildDotNetListItemPanelWidgetGenerated(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    if (!hasValue(jsObject)) {
        return null;
    }
    
    let dotNetListItemPanelWidget: any = {
        // @ts-ignore
        jsComponentReference: DotNet.createJSObjectReference(jsObject)
    };
        if (hasValue(jsObject.listItem)) {
            let { buildDotNetListItem } = await import('./listItem');
            dotNetListItemPanelWidget.listItem = await buildDotNetListItem(jsObject.listItem, layerId, viewId);
        }
        if (hasValue(jsObject.className)) {
            dotNetListItemPanelWidget.className = jsObject.className;
        }
        if (hasValue(jsObject.container)) {
            dotNetListItemPanelWidget.container = jsObject.container;
        }
        if (hasValue(jsObject.content)) {
            dotNetListItemPanelWidget.content = jsObject.content;
        }
        if (hasValue(jsObject.disabled)) {
            dotNetListItemPanelWidget.disabled = jsObject.disabled;
        }
        if (hasValue(jsObject.flowEnabled)) {
            dotNetListItemPanelWidget.flowEnabled = jsObject.flowEnabled;
        }
        if (hasValue(jsObject.icon)) {
            dotNetListItemPanelWidget.icon = jsObject.icon;
        }
        if (hasValue(jsObject.image)) {
            dotNetListItemPanelWidget.image = jsObject.image;
        }
        if (hasValue(jsObject.label)) {
            dotNetListItemPanelWidget.label = jsObject.label;
        }
        if (hasValue(jsObject.open)) {
            dotNetListItemPanelWidget.open = jsObject.open;
        }
        if (hasValue(jsObject.title)) {
            dotNetListItemPanelWidget.title = jsObject.title;
        }
        if (hasValue(jsObject.type)) {
            dotNetListItemPanelWidget.type = jsObject.type;
        }
        if (hasValue(jsObject.id)) {
            dotNetListItemPanelWidget.widgetId = jsObject.id;
        }

    if (Object.values(arcGisObjectRefs).includes(jsObject)) {
        for (const k of Object.keys(arcGisObjectRefs)) {
            if (arcGisObjectRefs[k] === jsObject) {
                dotNetListItemPanelWidget.id = k;
                break;
            }
        }
    }

    return dotNetListItemPanelWidget;
}

