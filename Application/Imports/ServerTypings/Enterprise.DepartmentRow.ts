namespace Matrix.Enterprise {
    export interface DepartmentRow {
        Recnum?: number;
        Dept?: string;
        Description?: string;
        Suspended?: boolean;
        AcctMvtIssue?: string;
        AcctMvtRcpt?: string;
        AcctPurMisc?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        ArevisedDate?: string;
        ArevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace DepartmentRow {
        export const idProperty = 'Dept';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Enterprise.Department';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Dept: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const AcctMvtIssue: string;
            export declare const AcctMvtRcpt: string;
            export declare const AcctPurMisc: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const ArevisedDate: string;
            export declare const ArevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'Dept', 
            'Description', 
            'Suspended', 
            'AcctMvtIssue', 
            'AcctMvtRcpt', 
            'AcctPurMisc', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'ArevisedDate', 
            'ArevisedBy', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

