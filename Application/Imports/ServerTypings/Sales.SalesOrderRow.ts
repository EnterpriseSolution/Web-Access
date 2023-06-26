namespace Matrix.Sales {
    export interface SalesOrderRow {
        Recnum?: number;
        OrderNo?: string;
        Posted?: string;
        Closed?: string;
        CustomerNo?: string;
        CustomerName?: string;
        OrderDate?: string;
        DueDate?: string;
        SchedDate?: string;
        CustomerPo?: string;
        ShipTo?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        MultiShip?: string;
        AutoPo?: string;
        AutoJob?: string;
        ComputeTax?: string;
        AutoResv?: string;
        AutoWait?: string;
        VendorNo?: string;
        PoNo?: string;
        PoPayTerms?: string;
        PoShipTo?: string;
        PoBuyer?: string;
        ShipVia?: string;
        ShipmentTerms?: string;
        Salesman?: string;
        PayTerms?: string;
        PriceCode?: string;
        Anlys1?: string;
        Anlys2?: string;
        Ccy?: string;
        ExchRate?: number;
        ShipFrom?: string;
        LastSchedNo?: number;
        LastLineNo?: number;
        LastTextNo?: number;
        LastCtnNo?: number;
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
        DpsReceiptNo?: string;
        DpsFundCode?: string;
        DpsReference?: string;
        DpsRcptDate?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        PrevisedDate?: string;
        PrevisedBy?: string;
        LockType?: string;
        LockRefNo?: string;
        LastLogNo?: number;
        VendTaxCode?: string;
        CustTaxCode?: string;
        PackingOk?: string;
        WeightUom?: string;
        GrWt?: number;
        NtWt?: number;
        DimensionUom?: string;
        Volume?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        CheckCrlimit?: string;
        CheckCrbal?: number;
        WebPublished?: string;
        SendWebMsg?: string;
        WebUserName?: string;
        Attention?: string;
        TelNo?: string;
        FaxNo?: string;
        PortLoading?: string;
        PortDischarge?: string;
        VesselName?: string;
        Forwarder?: string;
        LcNo?: string;
        OriginCountry?: string;
        MrpExclude?: string;
        SltaxType?: string;
        GsltaxPcent?: number;
        TotGsltaxAmt?: number;
        TotLsltaxAmt?: number;
        LastTextNo1?: number;
        Comments5?: string;
        Comments6?: string;
        Comments7?: string;
        Comments8?: string;
        Anlys7?: string;
        Anlys8?: string;
        Flag?: string;
        HoldBy?: string;
        QuoRefNo?: string;
        BrandCode?: string;
        ItemCode?: string;
        PkgUnit?: string;
        WeightUnit?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        OrderType?: string;
        RefCompanyCode?: string;
        RefPurchaseOrderNo?: string;
        DetailList?: SalesOrderDetailRow[];
    }

    export namespace SalesOrderRow {
        export const idProperty = 'OrderNo';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'Sales.SalesOrder';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OrderNo: string;
            export declare const Posted: string;
            export declare const Closed: string;
            export declare const CustomerNo: string;
            export declare const CustomerName: string;
            export declare const OrderDate: string;
            export declare const DueDate: string;
            export declare const SchedDate: string;
            export declare const CustomerPo: string;
            export declare const ShipTo: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const MultiShip: string;
            export declare const AutoPo: string;
            export declare const AutoJob: string;
            export declare const ComputeTax: string;
            export declare const AutoResv: string;
            export declare const AutoWait: string;
            export declare const VendorNo: string;
            export declare const PoNo: string;
            export declare const PoPayTerms: string;
            export declare const PoShipTo: string;
            export declare const PoBuyer: string;
            export declare const ShipVia: string;
            export declare const ShipmentTerms: string;
            export declare const Salesman: string;
            export declare const PayTerms: string;
            export declare const PriceCode: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const ShipFrom: string;
            export declare const LastSchedNo: string;
            export declare const LastLineNo: string;
            export declare const LastTextNo: string;
            export declare const LastCtnNo: string;
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
            export declare const DpsReceiptNo: string;
            export declare const DpsFundCode: string;
            export declare const DpsReference: string;
            export declare const DpsRcptDate: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const PrevisedDate: string;
            export declare const PrevisedBy: string;
            export declare const LockType: string;
            export declare const LockRefNo: string;
            export declare const LastLogNo: string;
            export declare const VendTaxCode: string;
            export declare const CustTaxCode: string;
            export declare const PackingOk: string;
            export declare const WeightUom: string;
            export declare const GrWt: string;
            export declare const NtWt: string;
            export declare const DimensionUom: string;
            export declare const Volume: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const CheckCrlimit: string;
            export declare const CheckCrbal: string;
            export declare const WebPublished: string;
            export declare const SendWebMsg: string;
            export declare const WebUserName: string;
            export declare const Attention: string;
            export declare const TelNo: string;
            export declare const FaxNo: string;
            export declare const PortLoading: string;
            export declare const PortDischarge: string;
            export declare const VesselName: string;
            export declare const Forwarder: string;
            export declare const LcNo: string;
            export declare const OriginCountry: string;
            export declare const MrpExclude: string;
            export declare const SltaxType: string;
            export declare const GsltaxPcent: string;
            export declare const TotGsltaxAmt: string;
            export declare const TotLsltaxAmt: string;
            export declare const LastTextNo1: string;
            export declare const Comments5: string;
            export declare const Comments6: string;
            export declare const Comments7: string;
            export declare const Comments8: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Flag: string;
            export declare const HoldBy: string;
            export declare const QuoRefNo: string;
            export declare const BrandCode: string;
            export declare const ItemCode: string;
            export declare const PkgUnit: string;
            export declare const WeightUnit: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const OrderType: string;
            export declare const RefCompanyCode: string;
            export declare const RefPurchaseOrderNo: string;
            export declare const DetailList: string;
        }

        [
            'Recnum', 
            'OrderNo', 
            'Posted', 
            'Closed', 
            'CustomerNo', 
            'CustomerName', 
            'OrderDate', 
            'DueDate', 
            'SchedDate', 
            'CustomerPo', 
            'ShipTo', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'MultiShip', 
            'AutoPo', 
            'AutoJob', 
            'ComputeTax', 
            'AutoResv', 
            'AutoWait', 
            'VendorNo', 
            'PoNo', 
            'PoPayTerms', 
            'PoShipTo', 
            'PoBuyer', 
            'ShipVia', 
            'ShipmentTerms', 
            'Salesman', 
            'PayTerms', 
            'PriceCode', 
            'Anlys1', 
            'Anlys2', 
            'Ccy', 
            'ExchRate', 
            'ShipFrom', 
            'LastSchedNo', 
            'LastLineNo', 
            'LastTextNo', 
            'LastCtnNo', 
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
            'DpsReceiptNo', 
            'DpsFundCode', 
            'DpsReference', 
            'DpsRcptDate', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'PrevisedDate', 
            'PrevisedBy', 
            'LockType', 
            'LockRefNo', 
            'LastLogNo', 
            'VendTaxCode', 
            'CustTaxCode', 
            'PackingOk', 
            'WeightUom', 
            'GrWt', 
            'NtWt', 
            'DimensionUom', 
            'Volume', 
            'OwnerBranch', 
            'SourceBranch', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'CheckCrlimit', 
            'CheckCrbal', 
            'WebPublished', 
            'SendWebMsg', 
            'WebUserName', 
            'Attention', 
            'TelNo', 
            'FaxNo', 
            'PortLoading', 
            'PortDischarge', 
            'VesselName', 
            'Forwarder', 
            'LcNo', 
            'OriginCountry', 
            'MrpExclude', 
            'SltaxType', 
            'GsltaxPcent', 
            'TotGsltaxAmt', 
            'TotLsltaxAmt', 
            'LastTextNo1', 
            'Comments5', 
            'Comments6', 
            'Comments7', 
            'Comments8', 
            'Anlys7', 
            'Anlys8', 
            'Flag', 
            'HoldBy', 
            'QuoRefNo', 
            'BrandCode', 
            'ItemCode', 
            'PkgUnit', 
            'WeightUnit', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'OrderType', 
            'RefCompanyCode', 
            'RefPurchaseOrderNo', 
            'DetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

