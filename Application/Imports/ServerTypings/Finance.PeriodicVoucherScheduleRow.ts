namespace Matrix.Finance {
    export interface PeriodicVoucherScheduleRow {
        Recnum?: number;
        EntryKey?: string;
        Period?: string;
        Suspended?: string;
        VoucherNo?: string;
        VoucherDate?: string;
        ExchRate?: number;
        DebitTotal?: number;
        CreditTotal?: number;
        SourceDate?: string;
        SourceBy?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        EntryKeyRecnum?: number;
        EntryKeyDescription?: string;
        EntryKeyVoucherType?: string;
        EntryKeySeriesCode?: string;
        EntryKeyCcy?: string;
        EntryKeySuspended?: string;
        EntryKeyEffectiveFrom?: string;
        EntryKeyEffectiveTo?: string;
        EntryKeyLastLineNo?: number;
        EntryKeyCreatedDate?: string;
        EntryKeyCreatedBy?: string;
        EntryKeyRevisedDate?: string;
        EntryKeyRevisedBy?: string;
        EntryKeyOwnerBranch?: string;
        EntryKeySourceBranch?: string;
        EntryKeyAnlys1?: string;
        EntryKeyAnlys2?: string;
        EntryKeyReference?: string;
        EntryKeyTotalDebit?: number;
        EntryKeyTotalCredit?: number;
        EntryKeyParticulars?: string;
        EntryKeyAnlys7?: string;
        EntryKeyAnlys8?: string;
        EntryKeyAnlys9?: string;
        EntryKeyAnlys10?: string;
        EntryKeyAnlys11?: string;
        EntryKeyAnlys12?: string;
        EntryKeyAnlys13?: string;
        EntryKeyAnlys14?: string;
    }

    export namespace PeriodicVoucherScheduleRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'EntryKey';
        export const localTextPrefix = 'Finance.PeriodicVoucherSchedule';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const EntryKey: string;
            export declare const Period: string;
            export declare const Suspended: string;
            export declare const VoucherNo: string;
            export declare const VoucherDate: string;
            export declare const ExchRate: string;
            export declare const DebitTotal: string;
            export declare const CreditTotal: string;
            export declare const SourceDate: string;
            export declare const SourceBy: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const EntryKeyRecnum: string;
            export declare const EntryKeyDescription: string;
            export declare const EntryKeyVoucherType: string;
            export declare const EntryKeySeriesCode: string;
            export declare const EntryKeyCcy: string;
            export declare const EntryKeySuspended: string;
            export declare const EntryKeyEffectiveFrom: string;
            export declare const EntryKeyEffectiveTo: string;
            export declare const EntryKeyLastLineNo: string;
            export declare const EntryKeyCreatedDate: string;
            export declare const EntryKeyCreatedBy: string;
            export declare const EntryKeyRevisedDate: string;
            export declare const EntryKeyRevisedBy: string;
            export declare const EntryKeyOwnerBranch: string;
            export declare const EntryKeySourceBranch: string;
            export declare const EntryKeyAnlys1: string;
            export declare const EntryKeyAnlys2: string;
            export declare const EntryKeyReference: string;
            export declare const EntryKeyTotalDebit: string;
            export declare const EntryKeyTotalCredit: string;
            export declare const EntryKeyParticulars: string;
            export declare const EntryKeyAnlys7: string;
            export declare const EntryKeyAnlys8: string;
            export declare const EntryKeyAnlys9: string;
            export declare const EntryKeyAnlys10: string;
            export declare const EntryKeyAnlys11: string;
            export declare const EntryKeyAnlys12: string;
            export declare const EntryKeyAnlys13: string;
            export declare const EntryKeyAnlys14: string;
        }

        [
            'Recnum', 
            'EntryKey', 
            'Period', 
            'Suspended', 
            'VoucherNo', 
            'VoucherDate', 
            'ExchRate', 
            'DebitTotal', 
            'CreditTotal', 
            'SourceDate', 
            'SourceBy', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'EntryKeyRecnum', 
            'EntryKeyDescription', 
            'EntryKeyVoucherType', 
            'EntryKeySeriesCode', 
            'EntryKeyCcy', 
            'EntryKeySuspended', 
            'EntryKeyEffectiveFrom', 
            'EntryKeyEffectiveTo', 
            'EntryKeyLastLineNo', 
            'EntryKeyCreatedDate', 
            'EntryKeyCreatedBy', 
            'EntryKeyRevisedDate', 
            'EntryKeyRevisedBy', 
            'EntryKeyOwnerBranch', 
            'EntryKeySourceBranch', 
            'EntryKeyAnlys1', 
            'EntryKeyAnlys2', 
            'EntryKeyReference', 
            'EntryKeyTotalDebit', 
            'EntryKeyTotalCredit', 
            'EntryKeyParticulars', 
            'EntryKeyAnlys7', 
            'EntryKeyAnlys8', 
            'EntryKeyAnlys9', 
            'EntryKeyAnlys10', 
            'EntryKeyAnlys11', 
            'EntryKeyAnlys12', 
            'EntryKeyAnlys13', 
            'EntryKeyAnlys14'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

