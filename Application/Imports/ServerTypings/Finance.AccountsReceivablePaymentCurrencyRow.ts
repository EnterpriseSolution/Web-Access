namespace Matrix.Finance {
    export interface AccountsReceivablePaymentCurrencyRow {
        Recnum?: number;
        ReceiptNo?: string;
        Ccy?: string;
        Description?: string;
        ExchRate?: number;
        BalAmt?: number;
        RevisedDate?: string;
        RevisedBy?: string;
    }

    export namespace AccountsReceivablePaymentCurrencyRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ReceiptNo';
        export const localTextPrefix = 'Finance.AccountsReceivablePaymentCurrency';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ReceiptNo: string;
            export declare const Ccy: string;
            export declare const Description: string;
            export declare const ExchRate: string;
            export declare const BalAmt: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
        }

        [
            'Recnum', 
            'ReceiptNo', 
            'Ccy', 
            'Description', 
            'ExchRate', 
            'BalAmt', 
            'RevisedDate', 
            'RevisedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

