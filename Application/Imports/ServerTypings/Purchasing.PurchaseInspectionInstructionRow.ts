namespace Matrix.Purchasing {
    export interface PurchaseInspectionInstructionRow {
        Recnum?: number;
        RefNo?: string;
        LineNo?: number;
        EntryNo?: number;
        InspectCode?: string;
        Description?: string;
        Remarks?: string;
        Qty?: number;
    }

    export namespace PurchaseInspectionInstructionRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Purchasing.PurchaseInspectionInstruction';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const LineNo: string;
            export declare const EntryNo: string;
            export declare const InspectCode: string;
            export declare const Description: string;
            export declare const Remarks: string;
            export declare const Qty: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'LineNo', 
            'EntryNo', 
            'InspectCode', 
            'Description', 
            'Remarks', 
            'Qty'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

