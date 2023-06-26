namespace Matrix.Finance {
    export interface AccountsReceivableJournalRow {
        Recnum?: number;
        EntryNo?: number;
        CustomerNo?: string;
        Period?: string;
        TranDate?: string;
        TranType?: string;
        RefNo?: string;
        Ccy?: string;
        ExchRate?: number;
        TotalAmt?: number;
        Debit?: number;
        Credit?: number;
        LocalDebit?: number;
        LocalCredit?: number;
        LocalBalance?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
    }

    export namespace AccountsReceivableJournalRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'CustomerNo';
        export const localTextPrefix = 'Finance.AccountsReceivableJournal';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const EntryNo: string;
            export declare const CustomerNo: string;
            export declare const Period: string;
            export declare const TranDate: string;
            export declare const TranType: string;
            export declare const RefNo: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const TotalAmt: string;
            export declare const Debit: string;
            export declare const Credit: string;
            export declare const LocalDebit: string;
            export declare const LocalCredit: string;
            export declare const LocalBalance: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
        }

        [
            'Recnum', 
            'EntryNo', 
            'CustomerNo', 
            'Period', 
            'TranDate', 
            'TranType', 
            'RefNo', 
            'Ccy', 
            'ExchRate', 
            'TotalAmt', 
            'Debit', 
            'Credit', 
            'LocalDebit', 
            'LocalCredit', 
            'LocalBalance', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

