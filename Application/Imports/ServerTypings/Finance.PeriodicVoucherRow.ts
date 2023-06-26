namespace Matrix.Finance {
    export interface PeriodicVoucherRow {
        ScheduleList?: PeriodicVoucherScheduleRow[];
        DetailList?: PeriodicVoucherDetailRow[];
        Recnum?: number;
        EntryKey?: string;
        Description?: string;
        VoucherType?: string;
        SeriesCode?: string;
        Ccy?: string;
        Suspended?: boolean;
        EffectiveFrom?: string;
        EffectiveTo?: string;
        LastLineNo?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Anlys1?: string;
        Anlys2?: string;
        Reference?: string;
        TotalDebit?: number;
        TotalCredit?: number;
        Particulars?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
    }

    export namespace PeriodicVoucherRow {
        export const idProperty = 'EntryKey';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Finance.PeriodicVoucher';

        export namespace Fields {
            export declare const ScheduleList: string;
            export declare const DetailList: string;
            export declare const Recnum: string;
            export declare const EntryKey: string;
            export declare const Description: string;
            export declare const VoucherType: string;
            export declare const SeriesCode: string;
            export declare const Ccy: string;
            export declare const Suspended: string;
            export declare const EffectiveFrom: string;
            export declare const EffectiveTo: string;
            export declare const LastLineNo: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Reference: string;
            export declare const TotalDebit: string;
            export declare const TotalCredit: string;
            export declare const Particulars: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
        }

        [
            'ScheduleList', 
            'DetailList', 
            'Recnum', 
            'EntryKey', 
            'Description', 
            'VoucherType', 
            'SeriesCode', 
            'Ccy', 
            'Suspended', 
            'EffectiveFrom', 
            'EffectiveTo', 
            'LastLineNo', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Anlys1', 
            'Anlys2', 
            'Reference', 
            'TotalDebit', 
            'TotalCredit', 
            'Particulars', 
            'Anlys7', 
            'Anlys8', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

