namespace Matrix.Purchasing {
    export interface VendorQuotationRow {
        Recnum?: number;
        OrderNo?: string;
        Closed?: string;
        VendorNo?: string;
        VendorName?: string;
        VendorAddress?: string;
        VendorAddress2?: string;
        VendorAddress3?: string;
        VendorAddress4?: string;
        OrderDate?: string;
        DueDate?: string;
        SchedDate?: string;
        ShipTo?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        MultiShip?: string;
        ComputeTax?: string;
        ShipVia?: string;
        ShipmentTerms?: string;
        Buyer?: string;
        PayTerms?: string;
        Anlys1?: string;
        Anlys2?: string;
        Ccy?: string;
        ExchRate?: number;
        SourceType?: string;
        SourceRefNo?: string;
        LastSchedNo?: number;
        LastLineNo?: number;
        LastTextNo?: number;
        TotPriceAmt?: number;
        TotPtaxAmt?: number;
        TotExtPrice?: number;
        TotLdiscAmt?: number;
        TotAtaxAmt?: number;
        TotItemAmt?: number;
        TdiscPcent?: number;
        TotTdiscAmt?: number;
        NetTradeAmt?: number;
        TotChgsAmt?: number;
        NetOrdrAmt?: number;
        TotGtaxAmt?: number;
        NetPayAmt?: number;
        DpsPcent?: number;
        TotDpsAmt?: number;
        NetBalAmt?: number;
        TotTdiscCpd?: number;
        TotGtaxCpd?: number;
        TotDpsCpd?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        LockRefNo?: string;
        LastLogNo?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        PortLoading?: string;
        PortDischarge?: string;
        VesselName?: string;
        Forwarder?: string;
        LcNo?: string;
        OriginCountry?: string;
        PutaxType?: string;
        GputaxPcent?: number;
        TotGputaxAmt?: number;
        TotLputaxAmt?: number;
        Anlys7?: string;
        Anlys8?: string;
        VendorRefNo?: string;
        ValidUntil?: string;
        ClosedBy?: string;
        ClosedDate?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
    }

    export namespace VendorQuotationRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'Purchasing.VendorQuotation';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OrderNo: string;
            export declare const Closed: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
            export declare const VendorAddress: string;
            export declare const VendorAddress2: string;
            export declare const VendorAddress3: string;
            export declare const VendorAddress4: string;
            export declare const OrderDate: string;
            export declare const DueDate: string;
            export declare const SchedDate: string;
            export declare const ShipTo: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const MultiShip: string;
            export declare const ComputeTax: string;
            export declare const ShipVia: string;
            export declare const ShipmentTerms: string;
            export declare const Buyer: string;
            export declare const PayTerms: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const SourceType: string;
            export declare const SourceRefNo: string;
            export declare const LastSchedNo: string;
            export declare const LastLineNo: string;
            export declare const LastTextNo: string;
            export declare const TotPriceAmt: string;
            export declare const TotPtaxAmt: string;
            export declare const TotExtPrice: string;
            export declare const TotLdiscAmt: string;
            export declare const TotAtaxAmt: string;
            export declare const TotItemAmt: string;
            export declare const TdiscPcent: string;
            export declare const TotTdiscAmt: string;
            export declare const NetTradeAmt: string;
            export declare const TotChgsAmt: string;
            export declare const NetOrdrAmt: string;
            export declare const TotGtaxAmt: string;
            export declare const NetPayAmt: string;
            export declare const DpsPcent: string;
            export declare const TotDpsAmt: string;
            export declare const NetBalAmt: string;
            export declare const TotTdiscCpd: string;
            export declare const TotGtaxCpd: string;
            export declare const TotDpsCpd: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const LockRefNo: string;
            export declare const LastLogNo: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const PortLoading: string;
            export declare const PortDischarge: string;
            export declare const VesselName: string;
            export declare const Forwarder: string;
            export declare const LcNo: string;
            export declare const OriginCountry: string;
            export declare const PutaxType: string;
            export declare const GputaxPcent: string;
            export declare const TotGputaxAmt: string;
            export declare const TotLputaxAmt: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const VendorRefNo: string;
            export declare const ValidUntil: string;
            export declare const ClosedBy: string;
            export declare const ClosedDate: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
        }

        [
            'Recnum', 
            'OrderNo', 
            'Closed', 
            'VendorNo', 
            'VendorName', 
            'VendorAddress', 
            'VendorAddress2', 
            'VendorAddress3', 
            'VendorAddress4', 
            'OrderDate', 
            'DueDate', 
            'SchedDate', 
            'ShipTo', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'MultiShip', 
            'ComputeTax', 
            'ShipVia', 
            'ShipmentTerms', 
            'Buyer', 
            'PayTerms', 
            'Anlys1', 
            'Anlys2', 
            'Ccy', 
            'ExchRate', 
            'SourceType', 
            'SourceRefNo', 
            'LastSchedNo', 
            'LastLineNo', 
            'LastTextNo', 
            'TotPriceAmt', 
            'TotPtaxAmt', 
            'TotExtPrice', 
            'TotLdiscAmt', 
            'TotAtaxAmt', 
            'TotItemAmt', 
            'TdiscPcent', 
            'TotTdiscAmt', 
            'NetTradeAmt', 
            'TotChgsAmt', 
            'NetOrdrAmt', 
            'TotGtaxAmt', 
            'NetPayAmt', 
            'DpsPcent', 
            'TotDpsAmt', 
            'NetBalAmt', 
            'TotTdiscCpd', 
            'TotGtaxCpd', 
            'TotDpsCpd', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'LockRefNo', 
            'LastLogNo', 
            'OwnerBranch', 
            'SourceBranch', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'PortLoading', 
            'PortDischarge', 
            'VesselName', 
            'Forwarder', 
            'LcNo', 
            'OriginCountry', 
            'PutaxType', 
            'GputaxPcent', 
            'TotGputaxAmt', 
            'TotLputaxAmt', 
            'Anlys7', 
            'Anlys8', 
            'VendorRefNo', 
            'ValidUntil', 
            'ClosedBy', 
            'ClosedDate', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

