namespace Matrix.Finance {
    export interface AccountsReceivableLedgerRow {
        Recnum?: number;
        CustomerNo?: string;
        CustomerName?: string;
        Summary?: string;
        Ccy?: string;
        Period?: string;
        CustomerNo2?: string;
        Ccy2?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        InvoAmt?: number;
        MemoAmt?: number;
        AdjAmt?: number;
        PayAmt?: number;
        DiscAmt?: number;
        DiffAmt?: number;
        BalBeg?: number;
        Debit?: number;
        Credit?: number;
        BalEnd?: number;
        LocalInvoAmt?: number;
        LocalMemoAmt?: number;
        LocalAdjAmt?: number;
        LocalPayAmt?: number;
        LocalDiscAmt?: number;
        LocalDiffAmt?: number;
        LocalBalBeg?: number;
        LocalDebit?: number;
        LocalCredit?: number;
        LocalBalEnd?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        RfdAmt?: number;
        LocalRfdAmt?: number;
    }

    export namespace AccountsReceivableLedgerRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'CustomerNo';
        export const localTextPrefix = 'Finance.AccountsReceivableLedger';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const CustomerNo: string;
            export declare const CustomerName: string;
            export declare const Summary: string;
            export declare const Ccy: string;
            export declare const Period: string;
            export declare const CustomerNo2: string;
            export declare const Ccy2: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const InvoAmt: string;
            export declare const MemoAmt: string;
            export declare const AdjAmt: string;
            export declare const PayAmt: string;
            export declare const DiscAmt: string;
            export declare const DiffAmt: string;
            export declare const BalBeg: string;
            export declare const Debit: string;
            export declare const Credit: string;
            export declare const BalEnd: string;
            export declare const LocalInvoAmt: string;
            export declare const LocalMemoAmt: string;
            export declare const LocalAdjAmt: string;
            export declare const LocalPayAmt: string;
            export declare const LocalDiscAmt: string;
            export declare const LocalDiffAmt: string;
            export declare const LocalBalBeg: string;
            export declare const LocalDebit: string;
            export declare const LocalCredit: string;
            export declare const LocalBalEnd: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const RfdAmt: string;
            export declare const LocalRfdAmt: string;
        }

        [
            'Recnum', 
            'CustomerNo', 
            'CustomerName', 
            'Summary', 
            'Ccy', 
            'Period', 
            'CustomerNo2', 
            'Ccy2', 
            'FiscalYear', 
            'PeriodNo', 
            'InvoAmt', 
            'MemoAmt', 
            'AdjAmt', 
            'PayAmt', 
            'DiscAmt', 
            'DiffAmt', 
            'BalBeg', 
            'Debit', 
            'Credit', 
            'BalEnd', 
            'LocalInvoAmt', 
            'LocalMemoAmt', 
            'LocalAdjAmt', 
            'LocalPayAmt', 
            'LocalDiscAmt', 
            'LocalDiffAmt', 
            'LocalBalBeg', 
            'LocalDebit', 
            'LocalCredit', 
            'LocalBalEnd', 
            'OwnerBranch', 
            'SourceBranch', 
            'RfdAmt', 
            'LocalRfdAmt'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

