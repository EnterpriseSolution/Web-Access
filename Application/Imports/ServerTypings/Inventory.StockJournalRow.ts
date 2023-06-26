namespace Matrix.Inventory {
    export interface StockJournalRow {
        Recnum?: number;
        Loc?: string;
        ItemNo?: string;
        Period?: string;
        ValueDate?: string;
        LogNo?: number;
        LineNo?: number;
        MoveIn?: string;
        RefNo?: string;
        QtyIn?: number;
        QtyOut?: number;
        CostIn?: number;
        CostOut?: number;
        MoveDate?: string;
        LineRef?: string;
        Description?: string;
        MoveType?: string;
        Reference?: string;
        Transfer?: string;
        FromTo?: string;
        BalQty?: number;
        BalCost?: number;
        BalQtyItem?: number;
        BalCostItem?: number;
        UnitCost?: number;
        Quantity?: number;
        Cost?: number;
    }

    export namespace StockJournalRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Loc';
        export const localTextPrefix = 'Inventory.StockJournal';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Loc: string;
            export declare const ItemNo: string;
            export declare const Period: string;
            export declare const ValueDate: string;
            export declare const LogNo: string;
            export declare const LineNo: string;
            export declare const MoveIn: string;
            export declare const RefNo: string;
            export declare const QtyIn: string;
            export declare const QtyOut: string;
            export declare const CostIn: string;
            export declare const CostOut: string;
            export declare const MoveDate: string;
            export declare const LineRef: string;
            export declare const Description: string;
            export declare const MoveType: string;
            export declare const Reference: string;
            export declare const Transfer: string;
            export declare const FromTo: string;
            export declare const BalQty: string;
            export declare const BalCost: string;
            export declare const BalQtyItem: string;
            export declare const BalCostItem: string;
            export declare const UnitCost: string;
            export declare const Quantity: string;
            export declare const Cost: string;
        }

        [
            'Recnum', 
            'Loc', 
            'ItemNo', 
            'Period', 
            'ValueDate', 
            'LogNo', 
            'LineNo', 
            'MoveIn', 
            'RefNo', 
            'QtyIn', 
            'QtyOut', 
            'CostIn', 
            'CostOut', 
            'MoveDate', 
            'LineRef', 
            'Description', 
            'MoveType', 
            'Reference', 
            'Transfer', 
            'FromTo', 
            'BalQty', 
            'BalCost', 
            'BalQtyItem', 
            'BalCostItem', 
            'UnitCost', 
            'Quantity', 
            'Cost'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

