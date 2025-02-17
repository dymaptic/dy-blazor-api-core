// override generated code in this file
import Symbol from '@arcgis/core/symbols/Symbol';
import {buildDotNetSimpleMarkerSymbol, buildJsSimpleMarkerSymbol} from './simpleMarkerSymbol';
import {buildDotNetSimpleLineSymbol, buildJsSimpleLineSymbol} from './simpleLineSymbol';
import {buildDotNetPictureMarkerSymbol, buildJsPictureMarkerSymbol} from "./pictureMarkerSymbol";
import {buildDotNetPictureFillSymbol, buildJsPictureFillSymbol} from "./pictureFillSymbol";
import {buildDotNetSimpleFillSymbol, buildJsSimpleFillSymbol} from './simpleFillSymbol';
import {buildDotNetTextSymbol, buildJsTextSymbol} from "./textSymbol";

export function buildJsSymbol(symbol: any): any {
    switch (symbol?.type) {
        case "simple-marker":
            return buildJsSimpleMarkerSymbol(symbol);
        case "simple-line":
            return buildJsSimpleLineSymbol(symbol);
        case "picture-marker":
            return buildJsPictureMarkerSymbol(symbol);
        case "picture-fill":
            return buildJsPictureFillSymbol(symbol);
        case "simple-fill":
            return buildJsSimpleFillSymbol(symbol);
        case "text":
            return buildJsTextSymbol(symbol);
        default:
            throw new Error('Unknown symbol type');
    }
}

export function buildDotNetSymbol(symbol: Symbol): any {
    switch (symbol.type) {
        case 'picture-fill':
            return buildDotNetPictureFillSymbol(symbol);
        case 'picture-marker':
            return buildDotNetPictureMarkerSymbol(symbol);
        case 'simple-fill':
            return buildDotNetSimpleFillSymbol(symbol);
        case 'simple-line':
            return buildDotNetSimpleLineSymbol(symbol);
        case 'simple-marker':
            return buildDotNetSimpleMarkerSymbol(symbol);
        case 'text':
            return buildDotNetTextSymbol(symbol);
        default:
            throw new Error('Unknown symbol type');
    }
}