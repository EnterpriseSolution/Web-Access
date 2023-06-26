namespace Matrix.Purchasing {
    export interface GrnOrderRow {
        Recnum?: number;
        GrnNo?: string;
        SeqNo?: number;
        OrderNo?: string;
        Posted?: string;
        OrderDate?: string;
        NextDueDate?: string;
        Final?: string;
        Anlys1?: string;
        Anlys2?: string;
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
        DpsCover?: number;
        DpsPcent?: number;
        DpsApplied?: number;
        LocDpsApplied?: number;
        NetBalAmt?: number;
        TdiscRate?: number;
        GtaxRate?: number;
        DpsRate?: number;
        TotTdiscCpd?: number;
        TotGtaxCpd?: number;
        DpsAppliedCpd?: number;
        LastLineNo?: number;
        LastChgsNo?: number;
        LogNo?: number;
        LastLogNo?: number;
        Buyer?: string;
        ReceivedDate?: string;
        DetailCount?: number;
        ChargesCount?: number;
        DpsEntryNo?: number;
        CheckCrbal?: number;
        PutaxType?: string;
        GputaxPcent?: number;
        TotGputaxAmt?: number;
        TotLputaxAmt?: number;
        Anlys7?: string;
        Anlys8?: string;
        ReceiveAll?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
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

    export namespace GrnOrderRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'GrnNo';
        export const localTextPrefix = 'Purchasing.GrnOrder';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const GrnNo: string;
            export declare const SeqNo: string;
            export declare const OrderNo: string;
            export declare const Posted: string;
            export declare const OrderDate: string;
            export declare const NextDueDate: string;
            export declare const Final: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
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
            export declare const DpsCover: string;
            export declare const DpsPcent: string;
            export declare const DpsApplied: string;
            export declare const LocDpsApplied: string;
            export declare const NetBalAmt: string;
            export declare const TdiscRate: string;
            export declare const GtaxRate: string;
            export declare const DpsRate: string;
            export declare const TotTdiscCpd: string;
            export declare const TotGtaxCpd: string;
            export declare const DpsAppliedCpd: string;
            export declare const LastLineNo: string;
            export declare const LastChgsNo: string;
            export declare const LogNo: string;
            export declare const LastLogNo: string;
            export declare const Buyer: string;
            export declare const ReceivedDate: string;
            export declare const DetailCount: string;
            export declare const ChargesCount: string;
            export declare const DpsEntryNo: string;
            export declare const CheckCrbal: string;
            export declare const PutaxType: string;
            export declare const GputaxPcent: string;
            export declare const TotGputaxAmt: string;
            export declare const TotLputaxAmt: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const ReceiveAll: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
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
            'SeqNo', 
            'OrderNo', 
            'Posted', 
            'OrderDate', 
            'NextDueDate', 
            'Final', 
            'Anlys1', 
            'Anlys2', 
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
            'DpsCover', 
            'DpsPcent', 
            'DpsApplied', 
            'LocDpsApplied', 
            'NetBalAmt', 
            'TdiscRate', 
            'GtaxRate', 
            'DpsRate', 
            'TotTdiscCpd', 
            'TotGtaxCpd', 
            'DpsAppliedCpd', 
            'LastLineNo', 
            'LastChgsNo', 
            'LogNo', 
            'LastLogNo', 
            'Buyer', 
            'ReceivedDate', 
            'DetailCount', 
            'ChargesCount', 
            'DpsEntryNo', 
            'CheckCrbal', 
            'PutaxType', 
            'GputaxPcent', 
            'TotGputaxAmt', 
            'TotLputaxAmt', 
            'Anlys7', 
            'Anlys8', 
            'ReceiveAll', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
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

