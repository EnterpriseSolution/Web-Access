namespace Matrix.Purchasing {
    export interface GrnOrderDetailRow {
        Recnum?: number;
        GrnNo?: string;
        EntryNo?: number;
        OrderNo?: string;
        LineNo?: number;
        ItemNo?: string;
        Description?: string;
        Uom?: string;
        LotSize?: number;
        QtyBalance?: number;
        QtyDue?: number;
        QtyReceived?: number;
        Price?: number;
        Ptax?: number;
        NetPrice?: number;
        ExtPrice?: number;
        LdiscPcent?: number;
        LdiscAmt?: number;
        AtaxAmt?: number;
        NetItemAmt?: number;
        PriceAmt?: number;
        PtaxAmt?: number;
        AtaxRate?: number;
        LdiscRate?: number;
        AtaxAmtCpd?: number;
        LdiscAmtCpd?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        Posted?: string;
        LogNo?: number;
        ReceivedDate?: string;
        VendorNo?: string;
        ShipTo?: string;
        Inspected?: string;
        QtyInspected?: number;
        QtyAccepted?: number;
        QtyRejected?: number;
        Returned?: string;
        QcHold?: string;
        AcctPurchase?: string;
        AcctLdisc?: string;
        AcctPtax?: string;
        AcctAtax?: string;
        ItemTaxCode?: string;
        QtyReturned?: number;
        RetPriceAmt?: number;
        RetPtaxAmt?: number;
        RetExtPrice?: number;
        RetLdiscAmt?: number;
        RetAtaxAmt?: number;
        RetItemAmt?: number;
        LretPriceAmt?: number;
        LretPtaxAmt?: number;
        LretExtPrice?: number;
        LretLdiscAmt?: number;
        LretAtaxAmt?: number;
        LretItemAmt?: number;
        CostAccepted?: number;
        CostRejected?: number;
        CostReturned?: number;
        ExtDescription?: string;
        Loc?: string;
        PutaxPcent?: number;
        PutaxAmt?: number;
        LocPutaxAmt?: number;
        InspectPriority?: number;
        QcHoldLoc?: string;
        JobNo?: string;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        MaterialCost?: number;
        VendorItemNo?: string;
        GrnNoRecnum?: number;
        GrnNoEntryMethod?: string;
        GrnNoWithInvoice?: string;
        GrnNoReceivedDate?: string;
        GrnNoPosted?: string;
        GrnNoInspected?: string;
        GrnNoReturned?: string;
        GrnNoShipTo?: string;
        GrnNoOwnerBranch?: string;
        GrnNoSourceBranch?: string;
        GrnNoVendorNo?: string;
        GrnNoVendorName?: string;
        GrnNoDoNo?: string;
        GrnNoInvoiceNo?: string;
        GrnNoPayTerms?: string;
        GrnNoDiscDays?: number;
        GrnNoDiscPcent?: number;
        GrnNoDueDays?: number;
        GrnNoDiscountDate?: string;
        GrnNoDueDate?: string;
        GrnNoCcy?: string;
        GrnNoExchRate?: number;
        GrnNoComputeTax?: string;
        GrnNoTotPriceAmt?: number;
        GrnNoTotPtaxAmt?: number;
        GrnNoTotExtPrice?: number;
        GrnNoTotLdiscAmt?: number;
        GrnNoTotAtaxAmt?: number;
        GrnNoTotItemAmt?: number;
        GrnNoTotTdiscAmt?: number;
        GrnNoNetTradeAmt?: number;
        GrnNoTotChgsAmt?: number;
        GrnNoNetOrdrAmt?: number;
        GrnNoTotGtaxAmt?: number;
        GrnNoNetPayAmt?: number;
        GrnNoDpsCover?: number;
        GrnNoDpsApplied?: number;
        GrnNoNetBalAmt?: number;
        GrnNoLocPriceAmt?: number;
        GrnNoLocPtaxAmt?: number;
        GrnNoLocExtPrice?: number;
        GrnNoLocLdiscAmt?: number;
        GrnNoLocAtaxAmt?: number;
        GrnNoLocItemAmt?: number;
        GrnNoLocTdiscAmt?: number;
        GrnNoLocChgsAmt?: number;
        GrnNoLocGtaxAmt?: number;
        GrnNoLocPayAmt?: number;
        GrnNoLocDpsApplied?: number;
        GrnNoCreatedDate?: string;
        GrnNoCreatedBy?: string;
        GrnNoRevisedDate?: string;
        GrnNoRevisedBy?: string;
        GrnNoPostedDate?: string;
        GrnNoPostedBy?: string;
        GrnNoLastOrderNo?: number;
        GrnNoLastEntryNo?: number;
        GrnNoLastChgsNo?: number;
        GrnNoLockType?: string;
        GrnNoLockRefNo?: string;
        GrnNoLastLogNo?: number;
        GrnNoAcctVendor?: string;
        GrnNoAcctTdisc?: string;
        GrnNoAcctGtax?: string;
        GrnNoVendTaxCode?: string;
        GrnNoCustTaxCode?: string;
        GrnNoRetPriceAmt?: number;
        GrnNoRetPtaxAmt?: number;
        GrnNoRetExtPrice?: number;
        GrnNoRetLdiscAmt?: number;
        GrnNoRetAtaxAmt?: number;
        GrnNoRetItemAmt?: number;
        GrnNoRetTdiscAmt?: number;
        GrnNoRetGtaxAmt?: number;
        GrnNoRetChgsAmt?: number;
        GrnNoRetPayAmt?: number;
        GrnNoLretPriceAmt?: number;
        GrnNoLretPtaxAmt?: number;
        GrnNoLretExtPrice?: number;
        GrnNoLretLdiscAmt?: number;
        GrnNoLretAtaxAmt?: number;
        GrnNoLretItemAmt?: number;
        GrnNoLretTdiscAmt?: number;
        GrnNoLretGtaxAmt?: number;
        GrnNoLretChgsAmt?: number;
        GrnNoLretPayAmt?: number;
        GrnNoSettleAt?: string;
        GrnNoCheckCrlimit?: string;
        GrnNoCheckCrbal?: number;
        GrnNoManual?: string;
        GrnNoPutaxType?: string;
        GrnNoGputaxPcent?: number;
        GrnNoTotGputaxAmt?: number;
        GrnNoPoPutaxType?: string;
        GrnNoPoGputaxPcent?: number;
        GrnNoLocGputaxAmt?: number;
        GrnNoOrderCount?: number;
        GrnNoTotLputaxAmt?: number;
        GrnNoLocLputaxAmt?: number;
        GrnNoCutoffDate?: string;
        GrnNoInspectPriority?: number;
        GrnNoAnlys9?: string;
        GrnNoAnlys10?: string;
        GrnNoAnlys11?: string;
        GrnNoAnlys12?: string;
        GrnNoFlag?: string;
        GrnNoHoldBy?: string;
        GrnNoComments1?: string;
        GrnNoComments2?: string;
        GrnNoComments3?: string;
        GrnNoComments4?: string;
        GrnNoLastTextNo?: number;
        GrnNoAnlys13?: string;
        GrnNoAnlys14?: string;
        GrnNoAnlys15?: string;
        GrnNoAnlys16?: string;
        GrnNoAnlys17?: string;
        GrnNoAnlys18?: string;
        GrnNoRefCompanyCode?: string;
        GrnNoRefShipmentRefNo?: string;
    }

    export namespace GrnOrderDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'GrnNo';
        export const localTextPrefix = 'Purchasing.GrnOrderDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const GrnNo: string;
            export declare const EntryNo: string;
            export declare const OrderNo: string;
            export declare const LineNo: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const LotSize: string;
            export declare const QtyBalance: string;
            export declare const QtyDue: string;
            export declare const QtyReceived: string;
            export declare const Price: string;
            export declare const Ptax: string;
            export declare const NetPrice: string;
            export declare const ExtPrice: string;
            export declare const LdiscPcent: string;
            export declare const LdiscAmt: string;
            export declare const AtaxAmt: string;
            export declare const NetItemAmt: string;
            export declare const PriceAmt: string;
            export declare const PtaxAmt: string;
            export declare const AtaxRate: string;
            export declare const LdiscRate: string;
            export declare const AtaxAmtCpd: string;
            export declare const LdiscAmtCpd: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Posted: string;
            export declare const LogNo: string;
            export declare const ReceivedDate: string;
            export declare const VendorNo: string;
            export declare const ShipTo: string;
            export declare const Inspected: string;
            export declare const QtyInspected: string;
            export declare const QtyAccepted: string;
            export declare const QtyRejected: string;
            export declare const Returned: string;
            export declare const QcHold: string;
            export declare const AcctPurchase: string;
            export declare const AcctLdisc: string;
            export declare const AcctPtax: string;
            export declare const AcctAtax: string;
            export declare const ItemTaxCode: string;
            export declare const QtyReturned: string;
            export declare const RetPriceAmt: string;
            export declare const RetPtaxAmt: string;
            export declare const RetExtPrice: string;
            export declare const RetLdiscAmt: string;
            export declare const RetAtaxAmt: string;
            export declare const RetItemAmt: string;
            export declare const LretPriceAmt: string;
            export declare const LretPtaxAmt: string;
            export declare const LretExtPrice: string;
            export declare const LretLdiscAmt: string;
            export declare const LretAtaxAmt: string;
            export declare const LretItemAmt: string;
            export declare const CostAccepted: string;
            export declare const CostRejected: string;
            export declare const CostReturned: string;
            export declare const ExtDescription: string;
            export declare const Loc: string;
            export declare const PutaxPcent: string;
            export declare const PutaxAmt: string;
            export declare const LocPutaxAmt: string;
            export declare const InspectPriority: string;
            export declare const QcHoldLoc: string;
            export declare const JobNo: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const MaterialCost: string;
            export declare const VendorItemNo: string;
            export declare const GrnNoRecnum: string;
            export declare const GrnNoEntryMethod: string;
            export declare const GrnNoWithInvoice: string;
            export declare const GrnNoReceivedDate: string;
            export declare const GrnNoPosted: string;
            export declare const GrnNoInspected: string;
            export declare const GrnNoReturned: string;
            export declare const GrnNoShipTo: string;
            export declare const GrnNoOwnerBranch: string;
            export declare const GrnNoSourceBranch: string;
            export declare const GrnNoVendorNo: string;
            export declare const GrnNoVendorName: string;
            export declare const GrnNoDoNo: string;
            export declare const GrnNoInvoiceNo: string;
            export declare const GrnNoPayTerms: string;
            export declare const GrnNoDiscDays: string;
            export declare const GrnNoDiscPcent: string;
            export declare const GrnNoDueDays: string;
            export declare const GrnNoDiscountDate: string;
            export declare const GrnNoDueDate: string;
            export declare const GrnNoCcy: string;
            export declare const GrnNoExchRate: string;
            export declare const GrnNoComputeTax: string;
            export declare const GrnNoTotPriceAmt: string;
            export declare const GrnNoTotPtaxAmt: string;
            export declare const GrnNoTotExtPrice: string;
            export declare const GrnNoTotLdiscAmt: string;
            export declare const GrnNoTotAtaxAmt: string;
            export declare const GrnNoTotItemAmt: string;
            export declare const GrnNoTotTdiscAmt: string;
            export declare const GrnNoNetTradeAmt: string;
            export declare const GrnNoTotChgsAmt: string;
            export declare const GrnNoNetOrdrAmt: string;
            export declare const GrnNoTotGtaxAmt: string;
            export declare const GrnNoNetPayAmt: string;
            export declare const GrnNoDpsCover: string;
            export declare const GrnNoDpsApplied: string;
            export declare const GrnNoNetBalAmt: string;
            export declare const GrnNoLocPriceAmt: string;
            export declare const GrnNoLocPtaxAmt: string;
            export declare const GrnNoLocExtPrice: string;
            export declare const GrnNoLocLdiscAmt: string;
            export declare const GrnNoLocAtaxAmt: string;
            export declare const GrnNoLocItemAmt: string;
            export declare const GrnNoLocTdiscAmt: string;
            export declare const GrnNoLocChgsAmt: string;
            export declare const GrnNoLocGtaxAmt: string;
            export declare const GrnNoLocPayAmt: string;
            export declare const GrnNoLocDpsApplied: string;
            export declare const GrnNoCreatedDate: string;
            export declare const GrnNoCreatedBy: string;
            export declare const GrnNoRevisedDate: string;
            export declare const GrnNoRevisedBy: string;
            export declare const GrnNoPostedDate: string;
            export declare const GrnNoPostedBy: string;
            export declare const GrnNoLastOrderNo: string;
            export declare const GrnNoLastEntryNo: string;
            export declare const GrnNoLastChgsNo: string;
            export declare const GrnNoLockType: string;
            export declare const GrnNoLockRefNo: string;
            export declare const GrnNoLastLogNo: string;
            export declare const GrnNoAcctVendor: string;
            export declare const GrnNoAcctTdisc: string;
            export declare const GrnNoAcctGtax: string;
            export declare const GrnNoVendTaxCode: string;
            export declare const GrnNoCustTaxCode: string;
            export declare const GrnNoRetPriceAmt: string;
            export declare const GrnNoRetPtaxAmt: string;
            export declare const GrnNoRetExtPrice: string;
            export declare const GrnNoRetLdiscAmt: string;
            export declare const GrnNoRetAtaxAmt: string;
            export declare const GrnNoRetItemAmt: string;
            export declare const GrnNoRetTdiscAmt: string;
            export declare const GrnNoRetGtaxAmt: string;
            export declare const GrnNoRetChgsAmt: string;
            export declare const GrnNoRetPayAmt: string;
            export declare const GrnNoLretPriceAmt: string;
            export declare const GrnNoLretPtaxAmt: string;
            export declare const GrnNoLretExtPrice: string;
            export declare const GrnNoLretLdiscAmt: string;
            export declare const GrnNoLretAtaxAmt: string;
            export declare const GrnNoLretItemAmt: string;
            export declare const GrnNoLretTdiscAmt: string;
            export declare const GrnNoLretGtaxAmt: string;
            export declare const GrnNoLretChgsAmt: string;
            export declare const GrnNoLretPayAmt: string;
            export declare const GrnNoSettleAt: string;
            export declare const GrnNoCheckCrlimit: string;
            export declare const GrnNoCheckCrbal: string;
            export declare const GrnNoManual: string;
            export declare const GrnNoPutaxType: string;
            export declare const GrnNoGputaxPcent: string;
            export declare const GrnNoTotGputaxAmt: string;
            export declare const GrnNoPoPutaxType: string;
            export declare const GrnNoPoGputaxPcent: string;
            export declare const GrnNoLocGputaxAmt: string;
            export declare const GrnNoOrderCount: string;
            export declare const GrnNoTotLputaxAmt: string;
            export declare const GrnNoLocLputaxAmt: string;
            export declare const GrnNoCutoffDate: string;
            export declare const GrnNoInspectPriority: string;
            export declare const GrnNoAnlys9: string;
            export declare const GrnNoAnlys10: string;
            export declare const GrnNoAnlys11: string;
            export declare const GrnNoAnlys12: string;
            export declare const GrnNoFlag: string;
            export declare const GrnNoHoldBy: string;
            export declare const GrnNoComments1: string;
            export declare const GrnNoComments2: string;
            export declare const GrnNoComments3: string;
            export declare const GrnNoComments4: string;
            export declare const GrnNoLastTextNo: string;
            export declare const GrnNoAnlys13: string;
            export declare const GrnNoAnlys14: string;
            export declare const GrnNoAnlys15: string;
            export declare const GrnNoAnlys16: string;
            export declare const GrnNoAnlys17: string;
            export declare const GrnNoAnlys18: string;
            export declare const GrnNoRefCompanyCode: string;
            export declare const GrnNoRefShipmentRefNo: string;
        }

        [
            'Recnum', 
            'GrnNo', 
            'EntryNo', 
            'OrderNo', 
            'LineNo', 
            'ItemNo', 
            'Description', 
            'Uom', 
            'LotSize', 
            'QtyBalance', 
            'QtyDue', 
            'QtyReceived', 
            'Price', 
            'Ptax', 
            'NetPrice', 
            'ExtPrice', 
            'LdiscPcent', 
            'LdiscAmt', 
            'AtaxAmt', 
            'NetItemAmt', 
            'PriceAmt', 
            'PtaxAmt', 
            'AtaxRate', 
            'LdiscRate', 
            'AtaxAmtCpd', 
            'LdiscAmtCpd', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'Posted', 
            'LogNo', 
            'ReceivedDate', 
            'VendorNo', 
            'ShipTo', 
            'Inspected', 
            'QtyInspected', 
            'QtyAccepted', 
            'QtyRejected', 
            'Returned', 
            'QcHold', 
            'AcctPurchase', 
            'AcctLdisc', 
            'AcctPtax', 
            'AcctAtax', 
            'ItemTaxCode', 
            'QtyReturned', 
            'RetPriceAmt', 
            'RetPtaxAmt', 
            'RetExtPrice', 
            'RetLdiscAmt', 
            'RetAtaxAmt', 
            'RetItemAmt', 
            'LretPriceAmt', 
            'LretPtaxAmt', 
            'LretExtPrice', 
            'LretLdiscAmt', 
            'LretAtaxAmt', 
            'LretItemAmt', 
            'CostAccepted', 
            'CostRejected', 
            'CostReturned', 
            'ExtDescription', 
            'Loc', 
            'PutaxPcent', 
            'PutaxAmt', 
            'LocPutaxAmt', 
            'InspectPriority', 
            'QcHoldLoc', 
            'JobNo', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'MaterialCost', 
            'VendorItemNo', 
            'GrnNoRecnum', 
            'GrnNoEntryMethod', 
            'GrnNoWithInvoice', 
            'GrnNoReceivedDate', 
            'GrnNoPosted', 
            'GrnNoInspected', 
            'GrnNoReturned', 
            'GrnNoShipTo', 
            'GrnNoOwnerBranch', 
            'GrnNoSourceBranch', 
            'GrnNoVendorNo', 
            'GrnNoVendorName', 
            'GrnNoDoNo', 
            'GrnNoInvoiceNo', 
            'GrnNoPayTerms', 
            'GrnNoDiscDays', 
            'GrnNoDiscPcent', 
            'GrnNoDueDays', 
            'GrnNoDiscountDate', 
            'GrnNoDueDate', 
            'GrnNoCcy', 
            'GrnNoExchRate', 
            'GrnNoComputeTax', 
            'GrnNoTotPriceAmt', 
            'GrnNoTotPtaxAmt', 
            'GrnNoTotExtPrice', 
            'GrnNoTotLdiscAmt', 
            'GrnNoTotAtaxAmt', 
            'GrnNoTotItemAmt', 
            'GrnNoTotTdiscAmt', 
            'GrnNoNetTradeAmt', 
            'GrnNoTotChgsAmt', 
            'GrnNoNetOrdrAmt', 
            'GrnNoTotGtaxAmt', 
            'GrnNoNetPayAmt', 
            'GrnNoDpsCover', 
            'GrnNoDpsApplied', 
            'GrnNoNetBalAmt', 
            'GrnNoLocPriceAmt', 
            'GrnNoLocPtaxAmt', 
            'GrnNoLocExtPrice', 
            'GrnNoLocLdiscAmt', 
            'GrnNoLocAtaxAmt', 
            'GrnNoLocItemAmt', 
            'GrnNoLocTdiscAmt', 
            'GrnNoLocChgsAmt', 
            'GrnNoLocGtaxAmt', 
            'GrnNoLocPayAmt', 
            'GrnNoLocDpsApplied', 
            'GrnNoCreatedDate', 
            'GrnNoCreatedBy', 
            'GrnNoRevisedDate', 
            'GrnNoRevisedBy', 
            'GrnNoPostedDate', 
            'GrnNoPostedBy', 
            'GrnNoLastOrderNo', 
            'GrnNoLastEntryNo', 
            'GrnNoLastChgsNo', 
            'GrnNoLockType', 
            'GrnNoLockRefNo', 
            'GrnNoLastLogNo', 
            'GrnNoAcctVendor', 
            'GrnNoAcctTdisc', 
            'GrnNoAcctGtax', 
            'GrnNoVendTaxCode', 
            'GrnNoCustTaxCode', 
            'GrnNoRetPriceAmt', 
            'GrnNoRetPtaxAmt', 
            'GrnNoRetExtPrice', 
            'GrnNoRetLdiscAmt', 
            'GrnNoRetAtaxAmt', 
            'GrnNoRetItemAmt', 
            'GrnNoRetTdiscAmt', 
            'GrnNoRetGtaxAmt', 
            'GrnNoRetChgsAmt', 
            'GrnNoRetPayAmt', 
            'GrnNoLretPriceAmt', 
            'GrnNoLretPtaxAmt', 
            'GrnNoLretExtPrice', 
            'GrnNoLretLdiscAmt', 
            'GrnNoLretAtaxAmt', 
            'GrnNoLretItemAmt', 
            'GrnNoLretTdiscAmt', 
            'GrnNoLretGtaxAmt', 
            'GrnNoLretChgsAmt', 
            'GrnNoLretPayAmt', 
            'GrnNoSettleAt', 
            'GrnNoCheckCrlimit', 
            'GrnNoCheckCrbal', 
            'GrnNoManual', 
            'GrnNoPutaxType', 
            'GrnNoGputaxPcent', 
            'GrnNoTotGputaxAmt', 
            'GrnNoPoPutaxType', 
            'GrnNoPoGputaxPcent', 
            'GrnNoLocGputaxAmt', 
            'GrnNoOrderCount', 
            'GrnNoTotLputaxAmt', 
            'GrnNoLocLputaxAmt', 
            'GrnNoCutoffDate', 
            'GrnNoInspectPriority', 
            'GrnNoAnlys9', 
            'GrnNoAnlys10', 
            'GrnNoAnlys11', 
            'GrnNoAnlys12', 
            'GrnNoFlag', 
            'GrnNoHoldBy', 
            'GrnNoComments1', 
            'GrnNoComments2', 
            'GrnNoComments3', 
            'GrnNoComments4', 
            'GrnNoLastTextNo', 
            'GrnNoAnlys13', 
            'GrnNoAnlys14', 
            'GrnNoAnlys15', 
            'GrnNoAnlys16', 
            'GrnNoAnlys17', 
            'GrnNoAnlys18', 
            'GrnNoRefCompanyCode', 
            'GrnNoRefShipmentRefNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

