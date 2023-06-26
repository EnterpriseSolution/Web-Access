namespace Matrix.Administration {
    export interface LookupDialogRow {
        LookupName?: string;
        Description?: string;
        QueryId?: string;
        KeyField1?: string;
        KeyField2?: string;
        KeyField3?: string;
        Suspended?: boolean;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
    }

    export namespace LookupDialogRow {
        export const idProperty = 'LookupName';
        export const nameProperty = 'LookupName';
        export const localTextPrefix = 'Administration.LookupDialog';

        export namespace Fields {
            export declare const LookupName: string;
            export declare const Description: string;
            export declare const QueryId: string;
            export declare const KeyField1: string;
            export declare const KeyField2: string;
            export declare const KeyField3: string;
            export declare const Suspended: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
        }

        [
            'LookupName', 
            'Description', 
            'QueryId', 
            'KeyField1', 
            'KeyField2', 
            'KeyField3', 
            'Suspended', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

