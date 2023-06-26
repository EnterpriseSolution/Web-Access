namespace Matrix.Administration {
    export interface LookupDialogFilterDetailRow {
        LookupName?: string;
        FilterName?: string;
        EntryNo?: number;
        EntityName?: string;
        FieldName?: string;
        FieldValue?: string;
        Operator?: number;
    }

    export namespace LookupDialogFilterDetailRow {
        export const idProperty = 'LookupName';
        export const nameProperty = 'LookupName';
        export const localTextPrefix = 'Administration.LookupDialogFilterDetail';

        export namespace Fields {
            export declare const LookupName: string;
            export declare const FilterName: string;
            export declare const EntryNo: string;
            export declare const EntityName: string;
            export declare const FieldName: string;
            export declare const FieldValue: string;
            export declare const Operator: string;
        }

        [
            'LookupName', 
            'FilterName', 
            'EntryNo', 
            'EntityName', 
            'FieldName', 
            'FieldValue', 
            'Operator'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

