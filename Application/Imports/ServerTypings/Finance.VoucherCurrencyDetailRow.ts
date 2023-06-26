namespace Matrix.Finance {
    export interface VoucherCurrencyDetailRow {
        Recnum?: number;
        VoucherType?: string;
        VoucherNo?: string;
        Ccy?: string;
        LastExchRate?: number;
        TotalDebit?: number;
        TotalCredit?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace VoucherCurrencyDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'VoucherType';
        export const localTextPrefix = 'Finance.VoucherCurrencyDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const VoucherType: string;
            export declare const VoucherNo: string;
            export declare const Ccy: string;
            export declare const LastExchRate: string;
            export declare const TotalDebit: string;
            export declare const TotalCredit: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'VoucherType', 
            'VoucherNo', 
            'Ccy', 
            'LastExchRate', 
            'TotalDebit', 
            'TotalCredit', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

