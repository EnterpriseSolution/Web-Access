namespace Matrix.MasterData {
    export interface ExchangeRateRow {
        Recnum?: number;
        Ccy?: string;
        EntryNo?: number;
        FromDate?: string;
        ToDate?: string;
        ExchRate?: number;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        CcyRecnum?: number;
        CcyDescription?: string;
        CcySuspended?: string;
        CcyDefaultRate?: number;
        CcyAcctArForex?: string;
        CcyAcctApForex?: string;
        CcyLastEntryNo?: number;
        CcyRateUseCount?: number;
        CcyCreatedDate?: string;
        CcyCreatedBy?: string;
        CcyRevisedDate?: string;
        CcyRevisedBy?: string;
        CcyArevisedDate?: string;
        CcyArevisedBy?: string;
        CcyOwnerBranch?: string;
        CcySourceBranch?: string;
        CcyApInvoBal?: number;
        CcyApOpenBal?: number;
        CcyApNetBal?: number;
        CcyApLinvoBal?: number;
        CcyApLopenBal?: number;
        CcyApLnetBal?: number;
        CcyArInvoBal?: number;
        CcyArOpenBal?: number;
        CcyArNetBal?: number;
        CcyArLinvoBal?: number;
        CcyArLopenBal?: number;
        CcyArLnetBal?: number;
    }

    export namespace ExchangeRateRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Ccy';
        export const localTextPrefix = 'MasterData.ExchangeRate';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Ccy: string;
            export declare const EntryNo: string;
            export declare const FromDate: string;
            export declare const ToDate: string;
            export declare const ExchRate: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const CcyRecnum: string;
            export declare const CcyDescription: string;
            export declare const CcySuspended: string;
            export declare const CcyDefaultRate: string;
            export declare const CcyAcctArForex: string;
            export declare const CcyAcctApForex: string;
            export declare const CcyLastEntryNo: string;
            export declare const CcyRateUseCount: string;
            export declare const CcyCreatedDate: string;
            export declare const CcyCreatedBy: string;
            export declare const CcyRevisedDate: string;
            export declare const CcyRevisedBy: string;
            export declare const CcyArevisedDate: string;
            export declare const CcyArevisedBy: string;
            export declare const CcyOwnerBranch: string;
            export declare const CcySourceBranch: string;
            export declare const CcyApInvoBal: string;
            export declare const CcyApOpenBal: string;
            export declare const CcyApNetBal: string;
            export declare const CcyApLinvoBal: string;
            export declare const CcyApLopenBal: string;
            export declare const CcyApLnetBal: string;
            export declare const CcyArInvoBal: string;
            export declare const CcyArOpenBal: string;
            export declare const CcyArNetBal: string;
            export declare const CcyArLinvoBal: string;
            export declare const CcyArLopenBal: string;
            export declare const CcyArLnetBal: string;
        }

        [
            'Recnum', 
            'Ccy', 
            'EntryNo', 
            'FromDate', 
            'ToDate', 
            'ExchRate', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'CcyRecnum', 
            'CcyDescription', 
            'CcySuspended', 
            'CcyDefaultRate', 
            'CcyAcctArForex', 
            'CcyAcctApForex', 
            'CcyLastEntryNo', 
            'CcyRateUseCount', 
            'CcyCreatedDate', 
            'CcyCreatedBy', 
            'CcyRevisedDate', 
            'CcyRevisedBy', 
            'CcyArevisedDate', 
            'CcyArevisedBy', 
            'CcyOwnerBranch', 
            'CcySourceBranch', 
            'CcyApInvoBal', 
            'CcyApOpenBal', 
            'CcyApNetBal', 
            'CcyApLinvoBal', 
            'CcyApLopenBal', 
            'CcyApLnetBal', 
            'CcyArInvoBal', 
            'CcyArOpenBal', 
            'CcyArNetBal', 
            'CcyArLinvoBal', 
            'CcyArLopenBal', 
            'CcyArLnetBal'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

