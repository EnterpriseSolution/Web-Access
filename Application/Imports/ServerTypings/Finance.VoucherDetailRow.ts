namespace Matrix.Finance {
    export interface VoucherDetailRow {
        Recnum?: number;
        VoucherType?: string;
        VoucherNo?: string;
        LineNo?: number;
        AcctNo?: string;
        AcctName?: string;
        BranchNo?: string;
        CostCentre?: string;
        Dept?: string;
        LineRef?: string;
        Ccy?: string;
        ExchRate?: number;
        Debit?: number;
        Credit?: number;
        ForexAmt?: number;
        LedgerAmt?: number;
        Sign?: string;
        LedgerDebit?: number;
        LedgerCredit?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        Posted?: string;
        Reconciled?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        JournalNo?: number;
        VoucherDate?: string;
        LedgerAmtCpd?: number;
        Reference?: string;
        PostedDate?: string;
        RunningBalance?: number;
        BalanceSign?: string;
        ExchDiff?: string;
        Particulars?: string;
        ItemGroup?: string;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        InvoiceNo?: string;
    }

    export namespace VoucherDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'VoucherType';
        export const localTextPrefix = 'Finance.VoucherDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const VoucherType: string;
            export declare const VoucherNo: string;
            export declare const LineNo: string;
            export declare const AcctNo: string;
            export declare const AcctName: string;
            export declare const BranchNo: string;
            export declare const CostCentre: string;
            export declare const Dept: string;
            export declare const LineRef: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const Debit: string;
            export declare const Credit: string;
            export declare const ForexAmt: string;
            export declare const LedgerAmt: string;
            export declare const Sign: string;
            export declare const LedgerDebit: string;
            export declare const LedgerCredit: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Posted: string;
            export declare const Reconciled: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const JournalNo: string;
            export declare const VoucherDate: string;
            export declare const LedgerAmtCpd: string;
            export declare const Reference: string;
            export declare const PostedDate: string;
            export declare const RunningBalance: string;
            export declare const BalanceSign: string;
            export declare const ExchDiff: string;
            export declare const Particulars: string;
            export declare const ItemGroup: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const InvoiceNo: string;
        }

        [
            'Recnum', 
            'VoucherType', 
            'VoucherNo', 
            'LineNo', 
            'AcctNo', 
            'AcctName', 
            'BranchNo', 
            'CostCentre', 
            'Dept', 
            'LineRef', 
            'Ccy', 
            'ExchRate', 
            'Debit', 
            'Credit', 
            'ForexAmt', 
            'LedgerAmt', 
            'Sign', 
            'LedgerDebit', 
            'LedgerCredit', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'Posted', 
            'Reconciled', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'JournalNo', 
            'VoucherDate', 
            'LedgerAmtCpd', 
            'Reference', 
            'PostedDate', 
            'RunningBalance', 
            'BalanceSign', 
            'ExchDiff', 
            'Particulars', 
            'ItemGroup', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'InvoiceNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

