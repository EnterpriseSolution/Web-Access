namespace Matrix.Finance {
    export interface AccountsPayableJournalRow {
        Recnum?: number;
        EntryNo?: number;
        VendorNo?: string;
        Period?: string;
        TranDate?: string;
        TranType?: string;
        RefNo?: string;
        Ccy?: string;
        ExchRate?: number;
        TotalAmt?: number;
        Credit?: number;
        Debit?: number;
        LocalCredit?: number;
        LocalDebit?: number;
        LocalBalance?: number;
        Particulars?: string;
    }

    export namespace AccountsPayableJournalRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'VendorNo';
        export const localTextPrefix = 'Finance.AccountsPayableJournal';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const EntryNo: string;
            export declare const VendorNo: string;
            export declare const Period: string;
            export declare const TranDate: string;
            export declare const TranType: string;
            export declare const RefNo: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const TotalAmt: string;
            export declare const Credit: string;
            export declare const Debit: string;
            export declare const LocalCredit: string;
            export declare const LocalDebit: string;
            export declare const LocalBalance: string;
            export declare const Particulars: string;
        }

        [
            'Recnum', 
            'EntryNo', 
            'VendorNo', 
            'Period', 
            'TranDate', 
            'TranType', 
            'RefNo', 
            'Ccy', 
            'ExchRate', 
            'TotalAmt', 
            'Credit', 
            'Debit', 
            'LocalCredit', 
            'LocalDebit', 
            'LocalBalance', 
            'Particulars'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

