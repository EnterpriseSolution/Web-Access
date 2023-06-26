namespace Matrix.Purchasing {
    export interface GrnRow {
        Recnum?: number;
        GrnNo?: string;
        EntryMethod?: string;
        WithInvoice?: string;
        ReceivedDate?: string;
        Posted?: string;
        Inspected?: string;
        Returned?: string;
        ShipTo?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        VendorNo?: string;
        VendorName?: string;
        DoNo?: string;
        InvoiceNo?: string;
        PayTerms?: string;
        DiscDays?: number;
        DiscPcent?: number;
        DueDays?: number;
        DiscountDate?: string;
        DueDate?: string;
        Ccy?: string;
        ExchRate?: number;
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
        LastOrderNo?: number;
        LastEntryNo?: number;
        LastChgsNo?: number;
        LockType?: string;
        LockRefNo?: string;
        LastLogNo?: number;
        AcctVendor?: string;
        AcctTdisc?: string;
        AcctGtax?: string;
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
        SettleAt?: string;
        CheckCrlimit?: string;
        CheckCrbal?: number;
        Manual?: string;
        PutaxType?: string;
        GputaxPcent?: number;
        TotGputaxAmt?: number;
        PoPutaxType?: string;
        PoGputaxPcent?: number;
        LocGputaxAmt?: number;
        OrderCount?: number;
        TotLputaxAmt?: number;
        LocLputaxAmt?: number;
        CutoffDate?: string;
        InspectPriority?: number;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Flag?: string;
        HoldBy?: string;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        LastTextNo?: number;
        Anlys13?: string;
        Anlys14?: string;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        RefCompanyCode?: string;
        RefShipmentRefNo?: string;
        ItemDetailList?: GrnOrderDetailRow[];
        OrderDetailList?: GrnOrderRow[];
    }

    export namespace GrnRow {
        export const idProperty = 'GrnNo';
        export const nameProperty = 'GrnNo';
        export const localTextPrefix = 'Purchasing.Grn';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const GrnNo: string;
            export declare const EntryMethod: string;
            export declare const WithInvoice: string;
            export declare const ReceivedDate: string;
            export declare const Posted: string;
            export declare const Inspected: string;
            export declare const Returned: string;
            export declare const ShipTo: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
            export declare const DoNo: string;
            export declare const InvoiceNo: string;
            export declare const PayTerms: string;
            export declare const DiscDays: string;
            export declare const DiscPcent: string;
            export declare const DueDays: string;
            export declare const DiscountDate: string;
            export declare const DueDate: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
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
            export declare const LastOrderNo: string;
            export declare const LastEntryNo: string;
            export declare const LastChgsNo: string;
            export declare const LockType: string;
            export declare const LockRefNo: string;
            export declare const LastLogNo: string;
            export declare const AcctVendor: string;
            export declare const AcctTdisc: string;
            export declare const AcctGtax: string;
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
            export declare const SettleAt: string;
            export declare const CheckCrlimit: string;
            export declare const CheckCrbal: string;
            export declare const Manual: string;
            export declare const PutaxType: string;
            export declare const GputaxPcent: string;
            export declare const TotGputaxAmt: string;
            export declare const PoPutaxType: string;
            export declare const PoGputaxPcent: string;
            export declare const LocGputaxAmt: string;
            export declare const OrderCount: string;
            export declare const TotLputaxAmt: string;
            export declare const LocLputaxAmt: string;
            export declare const CutoffDate: string;
            export declare const InspectPriority: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Flag: string;
            export declare const HoldBy: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const LastTextNo: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const RefCompanyCode: string;
            export declare const RefShipmentRefNo: string;
            export declare const ItemDetailList: string;
            export declare const OrderDetailList: string;
        }

        [
            'Recnum', 
            'GrnNo', 
            'EntryMethod', 
            'WithInvoice', 
            'ReceivedDate', 
            'Posted', 
            'Inspected', 
            'Returned', 
            'ShipTo', 
            'OwnerBranch', 
            'SourceBranch', 
            'VendorNo', 
            'VendorName', 
            'DoNo', 
            'InvoiceNo', 
            'PayTerms', 
            'DiscDays', 
            'DiscPcent', 
            'DueDays', 
            'DiscountDate', 
            'DueDate', 
            'Ccy', 
            'ExchRate', 
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
            'LastOrderNo', 
            'LastEntryNo', 
            'LastChgsNo', 
            'LockType', 
            'LockRefNo', 
            'LastLogNo', 
            'AcctVendor', 
            'AcctTdisc', 
            'AcctGtax', 
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
            'SettleAt', 
            'CheckCrlimit', 
            'CheckCrbal', 
            'Manual', 
            'PutaxType', 
            'GputaxPcent', 
            'TotGputaxAmt', 
            'PoPutaxType', 
            'PoGputaxPcent', 
            'LocGputaxAmt', 
            'OrderCount', 
            'TotLputaxAmt', 
            'LocLputaxAmt', 
            'CutoffDate', 
            'InspectPriority', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Flag', 
            'HoldBy', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'LastTextNo', 
            'Anlys13', 
            'Anlys14', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'RefCompanyCode', 
            'RefShipmentRefNo', 
            'ItemDetailList', 
            'OrderDetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

