namespace Matrix.Purchasing {
    export interface VendorQuotationScheduleRow {
        Recnum?: number;
        OrderNo?: string;
        LineNo?: number;
        ShipNo?: number;
        DueDate?: string;
        SchedDate?: string;
        ShipVia?: string;
        ShipmentTerms?: string;
        Qty?: number;
        ItemNo?: string;
        ShipTo?: string;
        Uom?: string;
        LotSize?: number;
        VendorNo?: string;
        Buyer?: string;
        VendorName?: string;
    }

    export namespace VendorQuotationScheduleRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'Purchasing.VendorQuotationSchedule';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OrderNo: string;
            export declare const LineNo: string;
            export declare const ShipNo: string;
            export declare const DueDate: string;
            export declare const SchedDate: string;
            export declare const ShipVia: string;
            export declare const ShipmentTerms: string;
            export declare const Qty: string;
            export declare const ItemNo: string;
            export declare const ShipTo: string;
            export declare const Uom: string;
            export declare const LotSize: string;
            export declare const VendorNo: string;
            export declare const Buyer: string;
            export declare const VendorName: string;
        }

        [
            'Recnum', 
            'OrderNo', 
            'LineNo', 
            'ShipNo', 
            'DueDate', 
            'SchedDate', 
            'ShipVia', 
            'ShipmentTerms', 
            'Qty', 
            'ItemNo', 
            'ShipTo', 
            'Uom', 
            'LotSize', 
            'VendorNo', 
            'Buyer', 
            'VendorName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

