import GraphicGenerated from './graphic.gb';
import Graphic from "@arcgis/core/Graphic";
import {DotNetGeometry, DotNetPopupTemplate} from "./definitions";
import {buildJsGeometry, buildJsPopupTemplate, buildJsSymbol} from "./jsBuilder";
import {buildDotNetGeometry, buildDotNetPopupTemplate} from "./dotNetBuilder";

export default class GraphicWrapper extends GraphicGenerated {

    constructor(component: Graphic) {
        super(component);
    }


    setAttribute(name: string, value: any): void {
        if (this.component.attributes[name] !== value) {
            this.component.attributes[name] = value;
        }
    }

    getAttribute(name: string): any {
        return this.component.attributes[name];
    }

    removeAttribute(name: string): void {
        delete this.component.attributes[name];
    }

    setGeometry(geometry: DotNetGeometry): void {
        let jsGeometry = buildJsGeometry(geometry);
        if (jsGeometry !== null && this.component.geometry !== jsGeometry) {
            this.component.geometry = jsGeometry;
        }
    }

    getGeometry(): DotNetGeometry | null {
        return buildDotNetGeometry(this.component.geometry);
    }

    setSymbol(symbol: any): void {
        if (this.component.symbol !== symbol) {
            this.component.symbol = buildJsSymbol(symbol) as any;
        }
    }

    getSymbol(): any {
        return this.component.symbol;
    }

    setVisibility(visible: boolean): void {
        this.component.visible = visible;
    }

    getVisibility(): boolean {
        return this.component.visible;
    }

    setPopupTemplate(popupTemplate: DotNetPopupTemplate): void {
        let jsPopupTemplate = buildJsPopupTemplate(popupTemplate, this.layerId, this.viewId);
        if (jsPopupTemplate !== null && this.component.popupTemplate !== jsPopupTemplate) {
            this.component.popupTemplate = jsPopupTemplate;
        }
    }

    getPopupTemplate(): DotNetPopupTemplate | null {
        return buildDotNetPopupTemplate(this.component.popupTemplate);
    }




}
export async function buildJsGraphic(dotNetObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildJsGraphicGenerated } = await import('./graphic.gb');
    return await buildJsGraphicGenerated(dotNetObject, layerId, viewId);
}
export async function buildDotNetGraphic(jsObject: any, layerId: string | null, viewId: string | null): Promise<any> {
    let { buildDotNetGraphicGenerated } = await import('./graphic.gb');
    return await buildDotNetGraphicGenerated(jsObject, layerId, viewId);
}
