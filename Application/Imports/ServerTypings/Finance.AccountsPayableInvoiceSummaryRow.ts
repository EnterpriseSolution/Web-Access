﻿namespace Matrix.Finance {
    export interface AccountsPayableInvoiceSummaryRow {
        Recnum?: number;
        ControlNo?: string;
        GrnNo?: string;
        Posted?: string;
        Returned?: string;
        DoNo?: string;
        ReceivedDate?: string;
        Loc?: string;
        Inspected?: string;
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
        NetInvoAmt?: number;
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
        LocInvoAmt?: number;
        LocDpsApplied?: number;
        GrnNetAmt?: number;
        LgrnNetAmt?: number;
        VariaAmt?: number;
        LocalVariaAmt?: number;
        ItemVariaAmt?: number;
        LitemVariaAmt?: number;
        ChgsVariaAmt?: number;
        LchgsVariaAmt?: number;
        PutaxType?: string;
        GputaxPcent?: number;
        TotGputaxAmt?: number;
        TotLputaxAmt?: number;
        LocGputaxAmt?: number;
        LocLputaxAmt?: number;
        PoPutaxType?: string;
        PoGputaxPcent?: number;
        ControlNoRecnum?: number;
        ControlNoMiscellaneous?: string;
        ControlNoPosted?: string;
        ControlNoClosed?: string;
        ControlNoReturned?: string;
        ControlNoVendorNo?: string;
        ControlNoVendorName?: string;
        ControlNoInvoiceNo?: string;
        ControlNoInvoiceDate?: string;
        ControlNoReceivedDate?: string;
        ControlNoPeriod?: string;
        ControlNoFiscalYear?: number;
        ControlNoPeriodNo?: number;
        ControlNoPayTerms?: string;
        ControlNoDiscPercent?: number;
        ControlNoDiscDays?: number;
        ControlNoNetDays?: number;
        ControlNoDiscountDate?: string;
        ControlNoDueDate?: string;
        ControlNoPlannedDate?: string;
        ControlNoPaymentBranch?: string;
        ControlNoCcy?: string;
        ControlNoExchRate?: number;
        ControlNoTotPriceAmt?: number;
        ControlNoTotPtaxAmt?: number;
        ControlNoTotExtPrice?: number;
        ControlNoTotLdiscAmt?: number;
        ControlNoTotAtaxAmt?: number;
        ControlNoTotItemAmt?: number;
        ControlNoTotTdiscAmt?: number;
        ControlNoNetTradeAmt?: number;
        ControlNoTotChgsAmt?: number;
        ControlNoNetOrdrAmt?: number;
        ControlNoTotGtaxAmt?: number;
        ControlNoNetInvoAmt?: number;
        ControlNoDpsApplied?: number;
        ControlNoNetBalAmt?: number;
        ControlNoLocPriceAmt?: number;
        ControlNoLocPtaxAmt?: number;
        ControlNoLocExtPrice?: number;
        ControlNoLocLdiscAmt?: number;
        ControlNoLocAtaxAmt?: number;
        ControlNoLocItemAmt?: number;
        ControlNoLocTdiscAmt?: number;
        ControlNoLocChgsAmt?: number;
        ControlNoLocGtaxAmt?: number;
        ControlNoLocInvoAmt?: number;
        ControlNoLocDpsApplied?: number;
        ControlNoGrnNetAmt?: number;
        ControlNoLgrnNetAmt?: number;
        ControlNoVariaAmt?: number;
        ControlNoLvariaAmt?: number;
        ControlNoItemVariaAmt?: number;
        ControlNoLitemVariaAmt?: number;
        ControlNoChgsVariaAmt?: number;
        ControlNoLchgsVariaAmt?: number;
        ControlNoLastLineNo?: number;
        ControlNoCreatedDate?: string;
        ControlNoCreatedBy?: string;
        ControlNoRevisedDate?: string;
        ControlNoRevisedBy?: string;
        ControlNoPostedDate?: string;
        ControlNoPostedBy?: string;
        ControlNoHold?: string;
        ControlNoHoldUntil?: string;
        ControlNoHoldDate?: string;
        ControlNoHoldBy?: string;
        ControlNoAcctVendor?: string;
        ControlNoAcctTdisc?: string;
        ControlNoAcctGtax?: string;
        ControlNoAcctVariance?: string;
        ControlNoSettledAmt?: number;
        ControlNoLsettledAmt?: number;
        ControlNoTermDiscAmt?: number;
        ControlNoLtermDiscAmt?: number;
        ControlNoReturnAmt?: number;
        ControlNoLreturnAmt?: number;
        ControlNoBalAmt?: number;
        ControlNoBalAmtLocal?: number;
        ControlNoOverAllocAmt?: number;
        ControlNoLoverAllocAmt?: number;
        ControlNoBatchSelect?: string;
        ControlNoGlLink?: string;
        ControlNoGlLinkType?: string;
        ControlNoGlLinkNo?: string;
        ControlNoLastLogNo?: number;
        ControlNoLockType?: string;
        ControlNoLockRefNo?: string;
        ControlNoHoldReason?: string;
        ControlNoOwnerBranch?: string;
        ControlNoSourceBranch?: string;
        ControlNoParticulars?: string;
        ControlNoCheckCrlimit?: string;
        ControlNoCheckCrbal?: number;
        ControlNoAcctPutax?: string;
        ControlNoPutaxType?: string;
        ControlNoGputaxPcent?: number;
        ControlNoTotGputaxAmt?: number;
        ControlNoTotLputaxAmt?: number;
        ControlNoLocGputaxAmt?: number;
        ControlNoLocLputaxAmt?: number;
        ControlNoGrnPutaxType?: string;
        ControlNoGrnGputaxPcent?: number;
        ControlNoGrnCount?: number;
        ControlNoAiLink?: string;
        ControlNoAiLinkType?: string;
        ControlNoAiLinkNo?: string;
        ControlNoAnlys9?: string;
        ControlNoAnlys10?: string;
        ControlNoAnlys11?: string;
        ControlNoAnlys12?: string;
        ControlNoAnlys13?: string;
        ControlNoAnlys14?: string;
        ControlNoAnlys15?: string;
        ControlNoAnlys16?: string;
        ControlNoAnlys17?: string;
        ControlNoAnlys18?: string;
        ControlNoPoNo?: string;
        ControlNoOriginCountry?: string;
    }

    export namespace AccountsPayableInvoiceSummaryRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ControlNo';
        export const localTextPrefix = 'Finance.AccountsPayableInvoiceSummary';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ControlNo: string;
            export declare const GrnNo: string;
            export declare const Posted: string;
            export declare const Returned: string;
            export declare const DoNo: string;
            export declare const ReceivedDate: string;
            export declare const Loc: string;
            export declare const Inspected: string;
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
            export declare const NetInvoAmt: string;
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
            export declare const LocInvoAmt: string;
            export declare const LocDpsApplied: string;
            export declare const GrnNetAmt: string;
            export declare const LgrnNetAmt: string;
            export declare const VariaAmt: string;
            export declare const LocalVariaAmt: string;
            export declare const ItemVariaAmt: string;
            export declare const LitemVariaAmt: string;
            export declare const ChgsVariaAmt: string;
            export declare const LchgsVariaAmt: string;
            export declare const PutaxType: string;
            export declare const GputaxPcent: string;
            export declare const TotGputaxAmt: string;
            export declare const TotLputaxAmt: string;
            export declare const LocGputaxAmt: string;
            export declare const LocLputaxAmt: string;
            export declare const PoPutaxType: string;
            export declare const PoGputaxPcent: string;
            export declare const ControlNoRecnum: string;
            export declare const ControlNoMiscellaneous: string;
            export declare const ControlNoPosted: string;
            export declare const ControlNoClosed: string;
            export declare const ControlNoReturned: string;
            export declare const ControlNoVendorNo: string;
            export declare const ControlNoVendorName: string;
            export declare const ControlNoInvoiceNo: string;
            export declare const ControlNoInvoiceDate: string;
            export declare const ControlNoReceivedDate: string;
            export declare const ControlNoPeriod: string;
            export declare const ControlNoFiscalYear: string;
            export declare const ControlNoPeriodNo: string;
            export declare const ControlNoPayTerms: string;
            export declare const ControlNoDiscPercent: string;
            export declare const ControlNoDiscDays: string;
            export declare const ControlNoNetDays: string;
            export declare const ControlNoDiscountDate: string;
            export declare const ControlNoDueDate: string;
            export declare const ControlNoPlannedDate: string;
            export declare const ControlNoPaymentBranch: string;
            export declare const ControlNoCcy: string;
            export declare const ControlNoExchRate: string;
            export declare const ControlNoTotPriceAmt: string;
            export declare const ControlNoTotPtaxAmt: string;
            export declare const ControlNoTotExtPrice: string;
            export declare const ControlNoTotLdiscAmt: string;
            export declare const ControlNoTotAtaxAmt: string;
            export declare const ControlNoTotItemAmt: string;
            export declare const ControlNoTotTdiscAmt: string;
            export declare const ControlNoNetTradeAmt: string;
            export declare const ControlNoTotChgsAmt: string;
            export declare const ControlNoNetOrdrAmt: string;
            export declare const ControlNoTotGtaxAmt: string;
            export declare const ControlNoNetInvoAmt: string;
            export declare const ControlNoDpsApplied: string;
            export declare const ControlNoNetBalAmt: string;
            export declare const ControlNoLocPriceAmt: string;
            export declare const ControlNoLocPtaxAmt: string;
            export declare const ControlNoLocExtPrice: string;
            export declare const ControlNoLocLdiscAmt: string;
            export declare const ControlNoLocAtaxAmt: string;
            export declare const ControlNoLocItemAmt: string;
            export declare const ControlNoLocTdiscAmt: string;
            export declare const ControlNoLocChgsAmt: string;
            export declare const ControlNoLocGtaxAmt: string;
            export declare const ControlNoLocInvoAmt: string;
            export declare const ControlNoLocDpsApplied: string;
            export declare const ControlNoGrnNetAmt: string;
            export declare const ControlNoLgrnNetAmt: string;
            export declare const ControlNoVariaAmt: string;
            export declare const ControlNoLvariaAmt: string;
            export declare const ControlNoItemVariaAmt: string;
            export declare const ControlNoLitemVariaAmt: string;
            export declare const ControlNoChgsVariaAmt: string;
            export declare const ControlNoLchgsVariaAmt: string;
            export declare const ControlNoLastLineNo: string;
            export declare const ControlNoCreatedDate: string;
            export declare const ControlNoCreatedBy: string;
            export declare const ControlNoRevisedDate: string;
            export declare const ControlNoRevisedBy: string;
            export declare const ControlNoPostedDate: string;
            export declare const ControlNoPostedBy: string;
            export declare const ControlNoHold: string;
            export declare const ControlNoHoldUntil: string;
            export declare const ControlNoHoldDate: string;
            export declare const ControlNoHoldBy: string;
            export declare const ControlNoAcctVendor: string;
            export declare const ControlNoAcctTdisc: string;
            export declare const ControlNoAcctGtax: string;
            export declare const ControlNoAcctVariance: string;
            export declare const ControlNoSettledAmt: string;
            export declare const ControlNoLsettledAmt: string;
            export declare const ControlNoTermDiscAmt: string;
            export declare const ControlNoLtermDiscAmt: string;
            export declare const ControlNoReturnAmt: string;
            export declare const ControlNoLreturnAmt: string;
            export declare const ControlNoBalAmt: string;
            export declare const ControlNoBalAmtLocal: string;
            export declare const ControlNoOverAllocAmt: string;
            export declare const ControlNoLoverAllocAmt: string;
            export declare const ControlNoBatchSelect: string;
            export declare const ControlNoGlLink: string;
            export declare const ControlNoGlLinkType: string;
            export declare const ControlNoGlLinkNo: string;
            export declare const ControlNoLastLogNo: string;
            export declare const ControlNoLockType: string;
            export declare const ControlNoLockRefNo: string;
            export declare const ControlNoHoldReason: string;
            export declare const ControlNoOwnerBranch: string;
            export declare const ControlNoSourceBranch: string;
            export declare const ControlNoParticulars: string;
            export declare const ControlNoCheckCrlimit: string;
            export declare const ControlNoCheckCrbal: string;
            export declare const ControlNoAcctPutax: string;
            export declare const ControlNoPutaxType: string;
            export declare const ControlNoGputaxPcent: string;
            export declare const ControlNoTotGputaxAmt: string;
            export declare const ControlNoTotLputaxAmt: string;
            export declare const ControlNoLocGputaxAmt: string;
            export declare const ControlNoLocLputaxAmt: string;
            export declare const ControlNoGrnPutaxType: string;
            export declare const ControlNoGrnGputaxPcent: string;
            export declare const ControlNoGrnCount: string;
            export declare const ControlNoAiLink: string;
            export declare const ControlNoAiLinkType: string;
            export declare const ControlNoAiLinkNo: string;
            export declare const ControlNoAnlys9: string;
            export declare const ControlNoAnlys10: string;
            export declare const ControlNoAnlys11: string;
            export declare const ControlNoAnlys12: string;
            export declare const ControlNoAnlys13: string;
            export declare const ControlNoAnlys14: string;
            export declare const ControlNoAnlys15: string;
            export declare const ControlNoAnlys16: string;
            export declare const ControlNoAnlys17: string;
            export declare const ControlNoAnlys18: string;
            export declare const ControlNoPoNo: string;
            export declare const ControlNoOriginCountry: string;
        }

        [
            'Recnum', 
            'ControlNo', 
            'GrnNo', 
            'Posted', 
            'Returned', 
            'DoNo', 
            'ReceivedDate', 
            'Loc', 
            'Inspected', 
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
            'NetInvoAmt', 
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
            'LocInvoAmt', 
            'LocDpsApplied', 
            'GrnNetAmt', 
            'LgrnNetAmt', 
            'VariaAmt', 
            'LocalVariaAmt', 
            'ItemVariaAmt', 
            'LitemVariaAmt', 
            'ChgsVariaAmt', 
            'LchgsVariaAmt', 
            'PutaxType', 
            'GputaxPcent', 
            'TotGputaxAmt', 
            'TotLputaxAmt', 
            'LocGputaxAmt', 
            'LocLputaxAmt', 
            'PoPutaxType', 
            'PoGputaxPcent', 
            'ControlNoRecnum', 
            'ControlNoMiscellaneous', 
            'ControlNoPosted', 
            'ControlNoClosed', 
            'ControlNoReturned', 
            'ControlNoVendorNo', 
            'ControlNoVendorName', 
            'ControlNoInvoiceNo', 
            'ControlNoInvoiceDate', 
            'ControlNoReceivedDate', 
            'ControlNoPeriod', 
            'ControlNoFiscalYear', 
            'ControlNoPeriodNo', 
            'ControlNoPayTerms', 
            'ControlNoDiscPercent', 
            'ControlNoDiscDays', 
            'ControlNoNetDays', 
            'ControlNoDiscountDate', 
            'ControlNoDueDate', 
            'ControlNoPlannedDate', 
            'ControlNoPaymentBranch', 
            'ControlNoCcy', 
            'ControlNoExchRate', 
            'ControlNoTotPriceAmt', 
            'ControlNoTotPtaxAmt', 
            'ControlNoTotExtPrice', 
            'ControlNoTotLdiscAmt', 
            'ControlNoTotAtaxAmt', 
            'ControlNoTotItemAmt', 
            'ControlNoTotTdiscAmt', 
            'ControlNoNetTradeAmt', 
            'ControlNoTotChgsAmt', 
            'ControlNoNetOrdrAmt', 
            'ControlNoTotGtaxAmt', 
            'ControlNoNetInvoAmt', 
            'ControlNoDpsApplied', 
            'ControlNoNetBalAmt', 
            'ControlNoLocPriceAmt', 
            'ControlNoLocPtaxAmt', 
            'ControlNoLocExtPrice', 
            'ControlNoLocLdiscAmt', 
            'ControlNoLocAtaxAmt', 
            'ControlNoLocItemAmt', 
            'ControlNoLocTdiscAmt', 
            'ControlNoLocChgsAmt', 
            'ControlNoLocGtaxAmt', 
            'ControlNoLocInvoAmt', 
            'ControlNoLocDpsApplied', 
            'ControlNoGrnNetAmt', 
            'ControlNoLgrnNetAmt', 
            'ControlNoVariaAmt', 
            'ControlNoLvariaAmt', 
            'ControlNoItemVariaAmt', 
            'ControlNoLitemVariaAmt', 
            'ControlNoChgsVariaAmt', 
            'ControlNoLchgsVariaAmt', 
            'ControlNoLastLineNo', 
            'ControlNoCreatedDate', 
            'ControlNoCreatedBy', 
            'ControlNoRevisedDate', 
            'ControlNoRevisedBy', 
            'ControlNoPostedDate', 
            'ControlNoPostedBy', 
            'ControlNoHold', 
            'ControlNoHoldUntil', 
            'ControlNoHoldDate', 
            'ControlNoHoldBy', 
            'ControlNoAcctVendor', 
            'ControlNoAcctTdisc', 
            'ControlNoAcctGtax', 
            'ControlNoAcctVariance', 
            'ControlNoSettledAmt', 
            'ControlNoLsettledAmt', 
            'ControlNoTermDiscAmt', 
            'ControlNoLtermDiscAmt', 
            'ControlNoReturnAmt', 
            'ControlNoLreturnAmt', 
            'ControlNoBalAmt', 
            'ControlNoBalAmtLocal', 
            'ControlNoOverAllocAmt', 
            'ControlNoLoverAllocAmt', 
            'ControlNoBatchSelect', 
            'ControlNoGlLink', 
            'ControlNoGlLinkType', 
            'ControlNoGlLinkNo', 
            'ControlNoLastLogNo', 
            'ControlNoLockType', 
            'ControlNoLockRefNo', 
            'ControlNoHoldReason', 
            'ControlNoOwnerBranch', 
            'ControlNoSourceBranch', 
            'ControlNoParticulars', 
            'ControlNoCheckCrlimit', 
            'ControlNoCheckCrbal', 
            'ControlNoAcctPutax', 
            'ControlNoPutaxType', 
            'ControlNoGputaxPcent', 
            'ControlNoTotGputaxAmt', 
            'ControlNoTotLputaxAmt', 
            'ControlNoLocGputaxAmt', 
            'ControlNoLocLputaxAmt', 
            'ControlNoGrnPutaxType', 
            'ControlNoGrnGputaxPcent', 
            'ControlNoGrnCount', 
            'ControlNoAiLink', 
            'ControlNoAiLinkType', 
            'ControlNoAiLinkNo', 
            'ControlNoAnlys9', 
            'ControlNoAnlys10', 
            'ControlNoAnlys11', 
            'ControlNoAnlys12', 
            'ControlNoAnlys13', 
            'ControlNoAnlys14', 
            'ControlNoAnlys15', 
            'ControlNoAnlys16', 
            'ControlNoAnlys17', 
            'ControlNoAnlys18', 
            'ControlNoPoNo', 
            'ControlNoOriginCountry'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

