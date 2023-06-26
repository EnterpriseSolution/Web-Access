namespace Matrix.Finance {
    export interface AccountReconciliationRow {
        Recnum?: number;
        AcctNo?: string;
        RefNo?: string;
        Posted?: string;
        AcctName?: string;
        TranDate?: string;
        BeginAmt?: number;
        BeginSign?: string;
        TotalDebit?: number;
        TotalCredit?: number;
        AllocDebit?: number;
        AllocCredit?: number;
        AdjustDebit?: number;
        AdjustCredit?: number;
        EndAmt?: number;
        EndSign?: string;
        EndAllocAmt?: number;
        EndAllocSign?: string;
        DetailCount?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        CutoffDate?: string;
        PostedDate?: string;
        PostedBy?: string;
    }

    export namespace AccountReconciliationRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'AcctNo';
        export const localTextPrefix = 'Finance.AccountReconciliation';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const AcctNo: string;
            export declare const RefNo: string;
            export declare const Posted: string;
            export declare const AcctName: string;
            export declare const TranDate: string;
            export declare const BeginAmt: string;
            export declare const BeginSign: string;
            export declare const TotalDebit: string;
            export declare const TotalCredit: string;
            export declare const AllocDebit: string;
            export declare const AllocCredit: string;
            export declare const AdjustDebit: string;
            export declare const AdjustCredit: string;
            export declare const EndAmt: string;
            export declare const EndSign: string;
            export declare const EndAllocAmt: string;
            export declare const EndAllocSign: string;
            export declare const DetailCount: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const CutoffDate: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
        }

        [
            'Recnum', 
            'AcctNo', 
            'RefNo', 
            'Posted', 
            'AcctName', 
            'TranDate', 
            'BeginAmt', 
            'BeginSign', 
            'TotalDebit', 
            'TotalCredit', 
            'AllocDebit', 
            'AllocCredit', 
            'AdjustDebit', 
            'AdjustCredit', 
            'EndAmt', 
            'EndSign', 
            'EndAllocAmt', 
            'EndAllocSign', 
            'DetailCount', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'CutoffDate', 
            'PostedDate', 
            'PostedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

