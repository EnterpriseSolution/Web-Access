namespace Matrix.Administration {
    export interface LookupDialogFilterColumnDetailRow {
        LookupName?: string;
        FilterName?: string;
        EntryNo?: number;
        FieldName?: string;
    }

    export namespace LookupDialogFilterColumnDetailRow {
        export const idProperty = 'LookupName';
        export const nameProperty = 'LookupName';
        export const localTextPrefix = 'Administration.LookupDialogFilterColumnDetail';

        export namespace Fields {
            export declare const LookupName: string;
            export declare const FilterName: string;
            export declare const EntryNo: string;
            export declare const FieldName: string;
        }

        [
            'LookupName', 
            'FilterName', 
            'EntryNo', 
            'FieldName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

