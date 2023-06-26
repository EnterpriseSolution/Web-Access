namespace Matrix.Purchasing {
    export interface VendorQuotationItemAdditionalInfoRow {
        Recnum?: number;
        OrderNo?: string;
        LineNo?: number;
        EntryNo?: number;
        Caption?: string;
        Description?: string;
        BitmapPath?: string;
    }

    export namespace VendorQuotationItemAdditionalInfoRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'Purchasing.VendorQuotationItemAdditionalInfo';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OrderNo: string;
            export declare const LineNo: string;
            export declare const EntryNo: string;
            export declare const Caption: string;
            export declare const Description: string;
            export declare const BitmapPath: string;
        }

        [
            'Recnum', 
            'OrderNo', 
            'LineNo', 
            'EntryNo', 
            'Caption', 
            'Description', 
            'BitmapPath'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

