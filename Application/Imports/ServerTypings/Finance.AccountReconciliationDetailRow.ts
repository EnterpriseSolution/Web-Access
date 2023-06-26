namespace Matrix.Finance {
    export interface AccountReconciliationDetailRow {
        Recnum?: number;
        AcctNo?: string;
        RefNo?: string;
        VoucherDate?: string;
        JournalNo?: number;
        LineNo?: number;
        VoucherType?: string;
        VoucherNo?: string;
        Reference?: string;
        LineRef?: string;
        Ccy?: string;
        Debit?: number;
        Credit?: number;
        LedgerAmt?: number;
        Sign?: string;
        IncludeThis?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
    }

    export namespace AccountReconciliationDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'AcctNo';
        export const localTextPrefix = 'Finance.AccountReconciliationDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const AcctNo: string;
            export declare const RefNo: string;
            export declare const VoucherDate: string;
            export declare const JournalNo: string;
            export declare const LineNo: string;
            export declare const VoucherType: string;
            export declare const VoucherNo: string;
            export declare const Reference: string;
            export declare const LineRef: string;
            export declare const Ccy: string;
            export declare const Debit: string;
            export declare const Credit: string;
            export declare const LedgerAmt: string;
            export declare const Sign: string;
            export declare const IncludeThis: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
        }

        [
            'Recnum', 
            'AcctNo', 
            'RefNo', 
            'VoucherDate', 
            'JournalNo', 
            'LineNo', 
            'VoucherType', 
            'VoucherNo', 
            'Reference', 
            'LineRef', 
            'Ccy', 
            'Debit', 
            'Credit', 
            'LedgerAmt', 
            'Sign', 
            'IncludeThis', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

