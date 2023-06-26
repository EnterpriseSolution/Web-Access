namespace Matrix.Enterprise {
    export interface CurrencyRow {
        Recnum?: number;
        Ccy?: string;
        Description?: string;
        Suspended?: boolean;
        DefaultRate?: number;
        AcctArForex?: string;
        AcctApForex?: string;
        LastEntryNo?: number;
        RateUseCount?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        ArevisedDate?: string;
        ArevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        ApInvoBal?: number;
        ApOpenBal?: number;
        ApNetBal?: number;
        ApLinvoBal?: number;
        ApLopenBal?: number;
        ApLnetBal?: number;
        ArInvoBal?: number;
        ArOpenBal?: number;
        ArNetBal?: number;
        ArLinvoBal?: number;
        ArLopenBal?: number;
        ArLnetBal?: number;
        DetailList?: MasterData.ExchangeRateRow[];
    }

    export namespace CurrencyRow {
        export const idProperty = 'Ccy';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Enterprise.Currency';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Ccy: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const DefaultRate: string;
            export declare const AcctArForex: string;
            export declare const AcctApForex: string;
            export declare const LastEntryNo: string;
            export declare const RateUseCount: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const ArevisedDate: string;
            export declare const ArevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const ApInvoBal: string;
            export declare const ApOpenBal: string;
            export declare const ApNetBal: string;
            export declare const ApLinvoBal: string;
            export declare const ApLopenBal: string;
            export declare const ApLnetBal: string;
            export declare const ArInvoBal: string;
            export declare const ArOpenBal: string;
            export declare const ArNetBal: string;
            export declare const ArLinvoBal: string;
            export declare const ArLopenBal: string;
            export declare const ArLnetBal: string;
            export declare const DetailList: string;
        }

        [
            'Recnum', 
            'Ccy', 
            'Description', 
            'Suspended', 
            'DefaultRate', 
            'AcctArForex', 
            'AcctApForex', 
            'LastEntryNo', 
            'RateUseCount', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'ArevisedDate', 
            'ArevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'ApInvoBal', 
            'ApOpenBal', 
            'ApNetBal', 
            'ApLinvoBal', 
            'ApLopenBal', 
            'ApLnetBal', 
            'ArInvoBal', 
            'ArOpenBal', 
            'ArNetBal', 
            'ArLinvoBal', 
            'ArLopenBal', 
            'ArLnetBal', 
            'DetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

