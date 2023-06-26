namespace Matrix.Inventory {
    export interface FifoControlRow {
        Recnum?: number;
        Loc?: string;
        ItemNo?: string;
        Allocated?: string;
        ValueDate?: string;
        LogNo?: number;
        LineNo?: number;
        LogNoOut?: number;
        LineNoOut?: number;
        Qty?: number;
        Cost?: number;
    }

    export namespace FifoControlRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Loc';
        export const localTextPrefix = 'Inventory.FifoControl';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Loc: string;
            export declare const ItemNo: string;
            export declare const Allocated: string;
            export declare const ValueDate: string;
            export declare const LogNo: string;
            export declare const LineNo: string;
            export declare const LogNoOut: string;
            export declare const LineNoOut: string;
            export declare const Qty: string;
            export declare const Cost: string;
        }

        [
            'Recnum', 
            'Loc', 
            'ItemNo', 
            'Allocated', 
            'ValueDate', 
            'LogNo', 
            'LineNo', 
            'LogNoOut', 
            'LineNoOut', 
            'Qty', 
            'Cost'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

