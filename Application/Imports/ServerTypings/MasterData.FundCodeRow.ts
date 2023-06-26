namespace Matrix.MasterData {
    export interface FundCodeRow {
        Recnum?: number;
        FundCode?: string;
        Description?: string;
        RcptSuspended?: boolean;
        PmntSuspended?: boolean;
        DefaultCcy?: string;
        FixedCurrency?: boolean;
        IsBankAcct?: boolean;
        IsCurrAcct?: boolean;
        BankAcctNo?: string;
        NextChequeNo?: number;
        AcctCash?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace FundCodeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'FundCode';
        export const localTextPrefix = 'MasterData.FundCode';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const FundCode: string;
            export declare const Description: string;
            export declare const RcptSuspended: string;
            export declare const PmntSuspended: string;
            export declare const DefaultCcy: string;
            export declare const FixedCurrency: string;
            export declare const IsBankAcct: string;
            export declare const IsCurrAcct: string;
            export declare const BankAcctNo: string;
            export declare const NextChequeNo: string;
            export declare const AcctCash: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'FundCode', 
            'Description', 
            'RcptSuspended', 
            'PmntSuspended', 
            'DefaultCcy', 
            'FixedCurrency', 
            'IsBankAcct', 
            'IsCurrAcct', 
            'BankAcctNo', 
            'NextChequeNo', 
            'AcctCash', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

