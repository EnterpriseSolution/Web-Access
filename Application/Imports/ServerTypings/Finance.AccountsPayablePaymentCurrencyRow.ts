namespace Matrix.Finance {
    export interface AccountsPayablePaymentCurrencyRow {
        Recnum?: number;
        RefNo?: string;
        Ccy?: string;
        Description?: string;
        ExchRate?: number;
        BalAmt?: number;
        RevisedDate?: string;
        RevisedBy?: string;
    }

    export namespace AccountsPayablePaymentCurrencyRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Finance.AccountsPayablePaymentCurrency';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const Ccy: string;
            export declare const Description: string;
            export declare const ExchRate: string;
            export declare const BalAmt: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'Ccy', 
            'Description', 
            'ExchRate', 
            'BalAmt', 
            'RevisedDate', 
            'RevisedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

