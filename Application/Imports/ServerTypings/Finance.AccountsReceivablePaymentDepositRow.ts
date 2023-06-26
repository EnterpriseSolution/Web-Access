namespace Matrix.Finance {
    export interface AccountsReceivablePaymentDepositRow {
        Recnum?: number;
        ReceiptNo?: string;
        LineNo?: number;
        OrderNo?: string;
        DepositReceiptNo?: string;
        Posted?: boolean;
        ReceiptDate?: string;
        DepositAmt?: number;
        DepositAmtLocal?: number;
        BalAmt?: number;
        BalAmtLocal?: number;
        PaidAmt?: number;
        PaidAmtLocal?: number;
        Settle?: boolean;
        Anlys1?: string;
        Anlys2?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
    }

    export namespace AccountsReceivablePaymentDepositRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ReceiptNo';
        export const localTextPrefix = 'Finance.AccountsReceivablePaymentDeposit';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ReceiptNo: string;
            export declare const LineNo: string;
            export declare const OrderNo: string;
            export declare const DepositReceiptNo: string;
            export declare const Posted: string;
            export declare const ReceiptDate: string;
            export declare const DepositAmt: string;
            export declare const DepositAmtLocal: string;
            export declare const BalAmt: string;
            export declare const BalAmtLocal: string;
            export declare const PaidAmt: string;
            export declare const PaidAmtLocal: string;
            export declare const Settle: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
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
            'Recnum', 
            'ReceiptNo', 
            'LineNo', 
            'OrderNo', 
            'DepositReceiptNo', 
            'Posted', 
            'ReceiptDate', 
            'DepositAmt', 
            'DepositAmtLocal', 
            'BalAmt', 
            'BalAmtLocal', 
            'PaidAmt', 
            'PaidAmtLocal', 
            'Settle', 
            'Anlys1', 
            'Anlys2', 
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

