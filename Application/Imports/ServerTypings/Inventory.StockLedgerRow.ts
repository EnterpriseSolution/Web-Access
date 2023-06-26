namespace Matrix.Inventory {
    export interface StockLedgerRow {
        Fullname?: string;
        Recnum?: number;
        Loc?: string;
        ItemNo?: string;
        Period?: string;
        Loc2?: string;
        ItemNo2?: string;
        Period2?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        QtyIn?: number;
        QtyOut?: number;
        QtyOutAlloc?: number;
        CostIn?: number;
        CostOut?: number;
        QtyInTrf?: number;
        QtyOutTrf?: number;
        CostInTrf?: number;
        CostOutTrf?: number;
        QtyBeg?: number;
        QtyEnd?: number;
        ValueBeg?: number;
        ValueEnd?: number;
    }

    export namespace StockLedgerRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'Inventory.StockLedger';

        export namespace Fields {
            export declare const Fullname: string;
            export declare const Recnum: string;
            export declare const Loc: string;
            export declare const ItemNo: string;
            export declare const Period: string;
            export declare const Loc2: string;
            export declare const ItemNo2: string;
            export declare const Period2: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const QtyIn: string;
            export declare const QtyOut: string;
            export declare const QtyOutAlloc: string;
            export declare const CostIn: string;
            export declare const CostOut: string;
            export declare const QtyInTrf: string;
            export declare const QtyOutTrf: string;
            export declare const CostInTrf: string;
            export declare const CostOutTrf: string;
            export declare const QtyBeg: string;
            export declare const QtyEnd: string;
            export declare const ValueBeg: string;
            export declare const ValueEnd: string;
        }

        [
            'Fullname', 
            'Recnum', 
            'Loc', 
            'ItemNo', 
            'Period', 
            'Loc2', 
            'ItemNo2', 
            'Period2', 
            'FiscalYear', 
            'PeriodNo', 
            'QtyIn', 
            'QtyOut', 
            'QtyOutAlloc', 
            'CostIn', 
            'CostOut', 
            'QtyInTrf', 
            'QtyOutTrf', 
            'CostInTrf', 
            'CostOutTrf', 
            'QtyBeg', 
            'QtyEnd', 
            'ValueBeg', 
            'ValueEnd'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

