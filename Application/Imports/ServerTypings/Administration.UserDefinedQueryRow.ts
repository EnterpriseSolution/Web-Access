namespace Matrix.Administration {
    export interface UserDefinedQueryRow {
        QueryId?: string;
        Description?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        AllowDuplicates?: boolean;
        Suspended?: boolean;
        DataSource?: number;
        UseAsEnquiry?: boolean;
        UseAsLookup?: boolean;
        UseAsAlert?: boolean;
        UseAsComparation?: boolean;
        FunctionCode?: string;
        PrimaryKeyFields?: string;
        CustomerNoEntityName?: string;
        CustomerNoFieldName?: string;
        VendorNoEntityName?: string;
        VendorNoFieldName?: string;
        Filter?: string;
        Sql?: string;
    }

    export namespace UserDefinedQueryRow {
        export const idProperty = 'QueryId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Administration.UserDefinedQuery';

        export namespace Fields {
            export declare const QueryId: string;
            export declare const Description: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const AllowDuplicates: string;
            export declare const Suspended: string;
            export declare const DataSource: string;
            export declare const UseAsEnquiry: string;
            export declare const UseAsLookup: string;
            export declare const UseAsAlert: string;
            export declare const UseAsComparation: string;
            export declare const FunctionCode: string;
            export declare const PrimaryKeyFields: string;
            export declare const CustomerNoEntityName: string;
            export declare const CustomerNoFieldName: string;
            export declare const VendorNoEntityName: string;
            export declare const VendorNoFieldName: string;
            export declare const Filter: string;
            export declare const Sql: string;
        }

        [
            'QueryId', 
            'Description', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'AllowDuplicates', 
            'Suspended', 
            'DataSource', 
            'UseAsEnquiry', 
            'UseAsLookup', 
            'UseAsAlert', 
            'UseAsComparation', 
            'FunctionCode', 
            'PrimaryKeyFields', 
            'CustomerNoEntityName', 
            'CustomerNoFieldName', 
            'VendorNoEntityName', 
            'VendorNoFieldName', 
            'Filter', 
            'Sql'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

