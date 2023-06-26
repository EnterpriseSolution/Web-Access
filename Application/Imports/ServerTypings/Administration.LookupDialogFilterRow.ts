namespace Matrix.Administration {
    export interface LookupDialogFilterRow {
        LookupName?: string;
        FilterName?: string;
        Description?: string;
        Filter?: string;
        LookupNameDescription?: string;
        LookupNameQueryId?: string;
        LookupNameKeyField1?: string;
        LookupNameKeyField2?: string;
        LookupNameKeyField3?: string;
        LookupNameSuspended?: boolean;
        LookupNameCreatedBy?: string;
        LookupNameCreatedDate?: string;
        LookupNameRevisedBy?: string;
        LookupNameRevisedDate?: string;
    }

    export namespace LookupDialogFilterRow {
        export const idProperty = 'LookupName';
        export const nameProperty = 'LookupName';
        export const localTextPrefix = 'Administration.LookupDialogFilter';

        export namespace Fields {
            export declare const LookupName: string;
            export declare const FilterName: string;
            export declare const Description: string;
            export declare const Filter: string;
            export declare const LookupNameDescription: string;
            export declare const LookupNameQueryId: string;
            export declare const LookupNameKeyField1: string;
            export declare const LookupNameKeyField2: string;
            export declare const LookupNameKeyField3: string;
            export declare const LookupNameSuspended: string;
            export declare const LookupNameCreatedBy: string;
            export declare const LookupNameCreatedDate: string;
            export declare const LookupNameRevisedBy: string;
            export declare const LookupNameRevisedDate: string;
        }

        [
            'LookupName', 
            'FilterName', 
            'Description', 
            'Filter', 
            'LookupNameDescription', 
            'LookupNameQueryId', 
            'LookupNameKeyField1', 
            'LookupNameKeyField2', 
            'LookupNameKeyField3', 
            'LookupNameSuspended', 
            'LookupNameCreatedBy', 
            'LookupNameCreatedDate', 
            'LookupNameRevisedBy', 
            'LookupNameRevisedDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

