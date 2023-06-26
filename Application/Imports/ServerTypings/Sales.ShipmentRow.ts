namespace Matrix.Sales {
    export interface ShipmentRow {
        Recnum?: number;
        RefNo?: string;
        ShipmentDate?: string;
        Posted?: boolean;
        Returned?: boolean;
        CustomerNo?: string;
        CustomerName?: string;
        ShipTo?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        CutoffDate?: string;
        ShipVia?: string;
        ShipmentTerms?: string;
        VesselName?: string;
        Etd?: string;
        Eta?: string;
        PayTerms?: string;
        DiscDays?: number;
        DiscPercent?: number;
        NetDays?: number;
        DiscountDate?: string;
        DueDate?: string;
        ExpectedDate?: string;
        Ccy?: string;
        ExchRate?: number;
        ShipFrom?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        ComputeTax?: string;
        TotPriceAmt?: number;
        TotPtaxAmt?: number;
        TotExtPrice?: number;
        TotLdiscAmt?: number;
        TotAtaxAmt?: number;
        TotItemAmt?: number;
        TotTdiscAmt?: number;
        NetTradeAmt?: number;
        TotChgsAmt?: number;
        NetOrdrAmt?: number;
        TotGtaxAmt?: number;
        NetPayAmt?: number;
        DpsCover?: number;
        DpsApplied?: number;
        NetBalAmt?: number;
        CpdTdiscAmt?: number;
        CpdGtaxAmt?: number;
        CpdDpsAmt?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        LocTdiscAmt?: number;
        LocChgsAmt?: number;
        LocGtaxAmt?: number;
        LocPayAmt?: number;
        LocDpsApplied?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        PrevisedDate?: string;
        PrevisedBy?: string;
        LastEntryNo?: number;
        LastChgsNo?: number;
        LastTextNo?: number;
        LastCtnNo?: number;
        LockType?: string;
        LockRefNo?: string;
        LastLogNo?: number;
        NewItemCount?: number;
        NewChgsCount?: number;
        AcctCustomer?: string;
        AcctTdisc?: string;
        AcctGtax?: string;
        DpsApplyRef?: string;
        VendTaxCode?: string;
        CustTaxCode?: string;
        RetPriceAmt?: number;
        RetPtaxAmt?: number;
        RetExtPrice?: number;
        RetLdiscAmt?: number;
        RetAtaxAmt?: number;
        RetItemAmt?: number;
        RetTdiscAmt?: number;
        RetGtaxAmt?: number;
        RetChgsAmt?: number;
        RetPayAmt?: number;
        LretPriceAmt?: number;
        LretPtaxAmt?: number;
        LretExtPrice?: number;
        LretLdiscAmt?: number;
        LretAtaxAmt?: number;
        LretItemAmt?: number;
        LretTdiscAmt?: number;
        LretGtaxAmt?: number;
        LretChgsAmt?: number;
        LretPayAmt?: number;
        WeightUom?: string;
        GrWt?: number;
        NtWt?: number;
        DimensionUom?: string;
        Volume?: number;
        GlLink?: string;
        GlLinkType?: string;
        GlLinkNo?: string;
        PackingOk?: string;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        SettleAt?: string;
        CheckCrlimit?: string;
        CheckCrbal?: number;
        Attention?: string;
        TelNo?: string;
        FaxNo?: string;
        PortLoading?: string;
        PortDischarge?: string;
        Forwarder?: string;
        LcNo?: string;
        OriginCountry?: string;
        Comments5?: string;
        Comments6?: string;
        Comments7?: string;
        Comments8?: string;
        IssueBank?: string;
        IssueDate?: string;
        SltaxType?: string;
        GsltaxPcent?: number;
        TotGsltaxAmt?: number;
        TotLsltaxAmt?: number;
        LocGsltaxAmt?: number;
        LocLsltaxAmt?: number;
        SoSltaxType?: string;
        SoGsltaxPcent?: number;
        OrderCount?: number;
        AcctSltax?: string;
        LastTextNo1?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys7?: string;
        Anlys8?: string;
        DnOnly?: string;
        Invoiced?: boolean;
        InvoiceNo?: string;
        Flag?: string;
        HoldBy?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        ManualShipmentDetail?: boolean;
        RefCompanyCode?: string;
        RefGrnNo?: string;
        LcName?: string;
        DetailList?: ShipmentDetailRow[];
    }

    export namespace ShipmentRow {
        export const idProperty = 'RefNo';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Sales.Shipment';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const ShipmentDate: string;
            export declare const Posted: string;
            export declare const Returned: string;
            export declare const CustomerNo: string;
            export declare const CustomerName: string;
            export declare const ShipTo: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const CutoffDate: string;
            export declare const ShipVia: string;
            export declare const ShipmentTerms: string;
            export declare const VesselName: string;
            export declare const Etd: string;
            export declare const Eta: string;
            export declare const PayTerms: string;
            export declare const DiscDays: string;
            export declare const DiscPercent: string;
            export declare const NetDays: string;
            export declare const DiscountDate: string;
            export declare const DueDate: string;
            export declare const ExpectedDate: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const ShipFrom: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const ComputeTax: string;
            export declare const TotPriceAmt: string;
            export declare const TotPtaxAmt: string;
            export declare const TotExtPrice: string;
            export declare const TotLdiscAmt: string;
            export declare const TotAtaxAmt: string;
            export declare const TotItemAmt: string;
            export declare const TotTdiscAmt: string;
            export declare const NetTradeAmt: string;
            export declare const TotChgsAmt: string;
            export declare const NetOrdrAmt: string;
            export declare const TotGtaxAmt: string;
            export declare const NetPayAmt: string;
            export declare const DpsCover: string;
            export declare const DpsApplied: string;
            export declare const NetBalAmt: string;
            export declare const CpdTdiscAmt: string;
            export declare const CpdGtaxAmt: string;
            export declare const CpdDpsAmt: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const LocTdiscAmt: string;
            export declare const LocChgsAmt: string;
            export declare const LocGtaxAmt: string;
            export declare const LocPayAmt: string;
            export declare const LocDpsApplied: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const PrevisedDate: string;
            export declare const PrevisedBy: string;
            export declare const LastEntryNo: string;
            export declare const LastChgsNo: string;
            export declare const LastTextNo: string;
            export declare const LastCtnNo: string;
            export declare const LockType: string;
            export declare const LockRefNo: string;
            export declare const LastLogNo: string;
            export declare const NewItemCount: string;
            export declare const NewChgsCount: string;
            export declare const AcctCustomer: string;
            export declare const AcctTdisc: string;
            export declare const AcctGtax: string;
            export declare const DpsApplyRef: string;
            export declare const VendTaxCode: string;
            export declare const CustTaxCode: string;
            export declare const RetPriceAmt: string;
            export declare const RetPtaxAmt: string;
            export declare const RetExtPrice: string;
            export declare const RetLdiscAmt: string;
            export declare const RetAtaxAmt: string;
            export declare const RetItemAmt: string;
            export declare const RetTdiscAmt: string;
            export declare const RetGtaxAmt: string;
            export declare const RetChgsAmt: string;
            export declare const RetPayAmt: string;
            export declare const LretPriceAmt: string;
            export declare const LretPtaxAmt: string;
            export declare const LretExtPrice: string;
            export declare const LretLdiscAmt: string;
            export declare const LretAtaxAmt: string;
            export declare const LretItemAmt: string;
            export declare const LretTdiscAmt: string;
            export declare const LretGtaxAmt: string;
            export declare const LretChgsAmt: string;
            export declare const LretPayAmt: string;
            export declare const WeightUom: string;
            export declare const GrWt: string;
            export declare const NtWt: string;
            export declare const DimensionUom: string;
            export declare const Volume: string;
            export declare const GlLink: string;
            export declare const GlLinkType: string;
            export declare const GlLinkNo: string;
            export declare const PackingOk: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const SettleAt: string;
            export declare const CheckCrlimit: string;
            export declare const CheckCrbal: string;
            export declare const Attention: string;
            export declare const TelNo: string;
            export declare const FaxNo: string;
            export declare const PortLoading: string;
            export declare const PortDischarge: string;
            export declare const Forwarder: string;
            export declare const LcNo: string;
            export declare const OriginCountry: string;
            export declare const Comments5: string;
            export declare const Comments6: string;
            export declare const Comments7: string;
            export declare const Comments8: string;
            export declare const IssueBank: string;
            export declare const IssueDate: string;
            export declare const SltaxType: string;
            export declare const GsltaxPcent: string;
            export declare const TotGsltaxAmt: string;
            export declare const TotLsltaxAmt: string;
            export declare const LocGsltaxAmt: string;
            export declare const LocLsltaxAmt: string;
            export declare const SoSltaxType: string;
            export declare const SoGsltaxPcent: string;
            export declare const OrderCount: string;
            export declare const AcctSltax: string;
            export declare const LastTextNo1: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const DnOnly: string;
            export declare const Invoiced: string;
            export declare const InvoiceNo: string;
            export declare const Flag: string;
            export declare const HoldBy: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const ManualShipmentDetail: string;
            export declare const RefCompanyCode: string;
            export declare const RefGrnNo: string;
            export declare const LcName: string;
            export declare const DetailList: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'ShipmentDate', 
            'Posted', 
            'Returned', 
            'CustomerNo', 
            'CustomerName', 
            'ShipTo', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'CutoffDate', 
            'ShipVia', 
            'ShipmentTerms', 
            'VesselName', 
            'Etd', 
            'Eta', 
            'PayTerms', 
            'DiscDays', 
            'DiscPercent', 
            'NetDays', 
            'DiscountDate', 
            'DueDate', 
            'ExpectedDate', 
            'Ccy', 
            'ExchRate', 
            'ShipFrom', 
            'OwnerBranch', 
            'SourceBranch', 
            'ComputeTax', 
            'TotPriceAmt', 
            'TotPtaxAmt', 
            'TotExtPrice', 
            'TotLdiscAmt', 
            'TotAtaxAmt', 
            'TotItemAmt', 
            'TotTdiscAmt', 
            'NetTradeAmt', 
            'TotChgsAmt', 
            'NetOrdrAmt', 
            'TotGtaxAmt', 
            'NetPayAmt', 
            'DpsCover', 
            'DpsApplied', 
            'NetBalAmt', 
            'CpdTdiscAmt', 
            'CpdGtaxAmt', 
            'CpdDpsAmt', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'LocTdiscAmt', 
            'LocChgsAmt', 
            'LocGtaxAmt', 
            'LocPayAmt', 
            'LocDpsApplied', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'PrevisedDate', 
            'PrevisedBy', 
            'LastEntryNo', 
            'LastChgsNo', 
            'LastTextNo', 
            'LastCtnNo', 
            'LockType', 
            'LockRefNo', 
            'LastLogNo', 
            'NewItemCount', 
            'NewChgsCount', 
            'AcctCustomer', 
            'AcctTdisc', 
            'AcctGtax', 
            'DpsApplyRef', 
            'VendTaxCode', 
            'CustTaxCode', 
            'RetPriceAmt', 
            'RetPtaxAmt', 
            'RetExtPrice', 
            'RetLdiscAmt', 
            'RetAtaxAmt', 
            'RetItemAmt', 
            'RetTdiscAmt', 
            'RetGtaxAmt', 
            'RetChgsAmt', 
            'RetPayAmt', 
            'LretPriceAmt', 
            'LretPtaxAmt', 
            'LretExtPrice', 
            'LretLdiscAmt', 
            'LretAtaxAmt', 
            'LretItemAmt', 
            'LretTdiscAmt', 
            'LretGtaxAmt', 
            'LretChgsAmt', 
            'LretPayAmt', 
            'WeightUom', 
            'GrWt', 
            'NtWt', 
            'DimensionUom', 
            'Volume', 
            'GlLink', 
            'GlLinkType', 
            'GlLinkNo', 
            'PackingOk', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'SettleAt', 
            'CheckCrlimit', 
            'CheckCrbal', 
            'Attention', 
            'TelNo', 
            'FaxNo', 
            'PortLoading', 
            'PortDischarge', 
            'Forwarder', 
            'LcNo', 
            'OriginCountry', 
            'Comments5', 
            'Comments6', 
            'Comments7', 
            'Comments8', 
            'IssueBank', 
            'IssueDate', 
            'SltaxType', 
            'GsltaxPcent', 
            'TotGsltaxAmt', 
            'TotLsltaxAmt', 
            'LocGsltaxAmt', 
            'LocLsltaxAmt', 
            'SoSltaxType', 
            'SoGsltaxPcent', 
            'OrderCount', 
            'AcctSltax', 
            'LastTextNo1', 
            'Anlys1', 
            'Anlys2', 
            'Anlys7', 
            'Anlys8', 
            'DnOnly', 
            'Invoiced', 
            'InvoiceNo', 
            'Flag', 
            'HoldBy', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'ManualShipmentDetail', 
            'RefCompanyCode', 
            'RefGrnNo', 
            'LcName', 
            'DetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

