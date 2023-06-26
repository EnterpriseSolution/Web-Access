namespace Matrix.Sales {
    export interface QuotationRow {
        Recnum?: number;
        RefNo?: string;
        IssueDate?: string;
        ValidUntil?: string;
        Closed?: string;
        CustomerNo?: string;
        CustomerName?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        Attention?: string;
        ShipVia?: string;
        ShipmentTerms?: string;
        BaseLoc?: string;
        Salesman?: string;
        PayTerms?: string;
        PriceCode?: string;
        Anlys1?: string;
        Anlys2?: string;
        Ccy?: string;
        ExchRate?: number;
        ComputeTax?: string;
        LastLineNo?: number;
        LastMailNo?: number;
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
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        TotTdiscCpd?: number;
        TotGtaxCpd?: number;
        TotDpsCpd?: number;
        ClosedDate?: string;
        ClosedBy?: string;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        WebPublished?: string;
        Confirmed?: string;
        RfqNo?: string;
        WebUserName?: string;
        ShipTo?: string;
        TelNo?: string;
        FaxNo?: string;
        PortLoading?: string;
        PortDischarge?: string;
        OriginCountry?: string;
        SltaxType?: string;
        GsltaxPcent?: number;
        TotGsltaxAmt?: number;
        TotLsltaxAmt?: number;
        Anlys7?: string;
        Anlys8?: string;
        MarkupDecimal?: number;
        PkgUnit?: string;
        WeightUnit?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        ItemCode?: string;
        Transport?: string;
        DetailList?: QuotationDetailRow[];
    }

    export namespace QuotationRow {
        export const idProperty = 'RefNo';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Sales.Quotation';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const IssueDate: string;
            export declare const ValidUntil: string;
            export declare const Closed: string;
            export declare const CustomerNo: string;
            export declare const CustomerName: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const Attention: string;
            export declare const ShipVia: string;
            export declare const ShipmentTerms: string;
            export declare const BaseLoc: string;
            export declare const Salesman: string;
            export declare const PayTerms: string;
            export declare const PriceCode: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const ComputeTax: string;
            export declare const LastLineNo: string;
            export declare const LastMailNo: string;
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
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const TotTdiscCpd: string;
            export declare const TotGtaxCpd: string;
            export declare const TotDpsCpd: string;
            export declare const ClosedDate: string;
            export declare const ClosedBy: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const WebPublished: string;
            export declare const Confirmed: string;
            export declare const RfqNo: string;
            export declare const WebUserName: string;
            export declare const ShipTo: string;
            export declare const TelNo: string;
            export declare const FaxNo: string;
            export declare const PortLoading: string;
            export declare const PortDischarge: string;
            export declare const OriginCountry: string;
            export declare const SltaxType: string;
            export declare const GsltaxPcent: string;
            export declare const TotGsltaxAmt: string;
            export declare const TotLsltaxAmt: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const MarkupDecimal: string;
            export declare const PkgUnit: string;
            export declare const WeightUnit: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const ItemCode: string;
            export declare const Transport: string;
            export declare const DetailList: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'IssueDate', 
            'ValidUntil', 
            'Closed', 
            'CustomerNo', 
            'CustomerName', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'Attention', 
            'ShipVia', 
            'ShipmentTerms', 
            'BaseLoc', 
            'Salesman', 
            'PayTerms', 
            'PriceCode', 
            'Anlys1', 
            'Anlys2', 
            'Ccy', 
            'ExchRate', 
            'ComputeTax', 
            'LastLineNo', 
            'LastMailNo', 
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
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'TotTdiscCpd', 
            'TotGtaxCpd', 
            'TotDpsCpd', 
            'ClosedDate', 
            'ClosedBy', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'WebPublished', 
            'Confirmed', 
            'RfqNo', 
            'WebUserName', 
            'ShipTo', 
            'TelNo', 
            'FaxNo', 
            'PortLoading', 
            'PortDischarge', 
            'OriginCountry', 
            'SltaxType', 
            'GsltaxPcent', 
            'TotGsltaxAmt', 
            'TotLsltaxAmt', 
            'Anlys7', 
            'Anlys8', 
            'MarkupDecimal', 
            'PkgUnit', 
            'WeightUnit', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'ItemCode', 
            'Transport', 
            'DetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

