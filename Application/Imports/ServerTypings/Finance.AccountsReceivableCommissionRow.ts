namespace Matrix.Finance {
    export interface AccountsReceivableCommissionRow {
        InvoiceNo?: string;
        Salesman?: string;
        SalesmanName?: string;
        Rate?: number;
        InvoiceNoRecnum?: number;
        InvoiceNoDirectEntry?: string;
        InvoiceNoPosted?: string;
        InvoiceNoClosed?: string;
        InvoiceNoReturned?: string;
        InvoiceNoDebitNote?: string;
        InvoiceNoCustomerNo?: string;
        InvoiceNoCustomerName?: string;
        InvoiceNoAddress?: string;
        InvoiceNoAddress2?: string;
        InvoiceNoAddress3?: string;
        InvoiceNoAddress4?: string;
        InvoiceNoAttention?: string;
        InvoiceNoInvoiceDate?: string;
        InvoiceNoPeriod?: string;
        InvoiceNoFiscalYear?: number;
        InvoiceNoPeriodNo?: number;
        InvoiceNoSalesman?: string;
        InvoiceNoCcy?: string;
        InvoiceNoExchRate?: number;
        InvoiceNoPayTerms?: string;
        InvoiceNoDiscDays?: number;
        InvoiceNoDiscPcent?: number;
        InvoiceNoDueDays?: number;
        InvoiceNoDiscountDate?: string;
        InvoiceNoDueDate?: string;
        InvoiceNoExpectedDate?: string;
        InvoiceNoAnlys1?: string;
        InvoiceNoAnlys2?: string;
        InvoiceNoTotPriceAmt?: number;
        InvoiceNoLocPriceAmt?: number;
        InvoiceNoTotPtaxAmt?: number;
        InvoiceNoLocPtaxAmt?: number;
        InvoiceNoTotExtPrice?: number;
        InvoiceNoLocExtPrice?: number;
        InvoiceNoTotLdiscAmt?: number;
        InvoiceNoLocLdiscAmt?: number;
        InvoiceNoTotAtaxAmt?: number;
        InvoiceNoLocAtaxAmt?: number;
        InvoiceNoTotItemAmt?: number;
        InvoiceNoLocItemAmt?: number;
        InvoiceNoTdiscPcent?: number;
        InvoiceNoTdiscAmt?: number;
        InvoiceNoLocalTdiscAmt?: number;
        InvoiceNoChgsAmt?: number;
        InvoiceNoLocChgsAmt?: number;
        InvoiceNoGtaxAmt?: number;
        InvoiceNoLocalGtaxAmt?: number;
        InvoiceNoNetAmt?: number;
        InvoiceNoLocalNetAmt?: number;
        InvoiceNoTdiscAmtCpd?: number;
        InvoiceNoLastLineNo?: number;
        InvoiceNoCreatedDate?: string;
        InvoiceNoCreatedBy?: string;
        InvoiceNoRevisedDate?: string;
        InvoiceNoRevisedBy?: string;
        InvoiceNoPostedDate?: string;
        InvoiceNoPostedBy?: string;
        InvoiceNoLastLogNo?: number;
        InvoiceNoSettledAmt?: number;
        InvoiceNoLsettledAmt?: number;
        InvoiceNoTermDiscAmt?: number;
        InvoiceNoLtermDiscAmt?: number;
        InvoiceNoReturnAmt?: number;
        InvoiceNoLreturnAmt?: number;
        InvoiceNoBalAmt?: number;
        InvoiceNoBalAmtLocal?: number;
        InvoiceNoOverAllocAmt?: number;
        InvoiceNoLoverAllocAmt?: number;
        InvoiceNoAcctCustomer?: string;
        InvoiceNoAcctTdisc?: string;
        InvoiceNoAcctGtax?: string;
        InvoiceNoLockType?: string;
        InvoiceNoLockRefNo?: string;
        InvoiceNoBatchSelect?: string;
        InvoiceNoGlLink?: string;
        InvoiceNoGlLinkType?: string;
        InvoiceNoGlLinkNo?: string;
        InvoiceNoOwnerBranch?: string;
        InvoiceNoSourceBranch?: string;
        InvoiceNoCheckCrlimit?: string;
        InvoiceNoCheckCrbal?: number;
        InvoiceNoComments1?: string;
        InvoiceNoComments2?: string;
        InvoiceNoComments3?: string;
        InvoiceNoComments4?: string;
        InvoiceNoLastTextNo?: number;
        InvoiceNoShipTo?: string;
        InvoiceNoTelNo?: string;
        InvoiceNoFaxNo?: string;
        InvoiceNoSltaxType?: string;
        InvoiceNoGsltaxPcent?: number;
        InvoiceNoTotGsltaxAmt?: number;
        InvoiceNoTotLsltaxAmt?: number;
        InvoiceNoLocGsltaxAmt?: number;
        InvoiceNoLocLsltaxAmt?: number;
        InvoiceNoAcctSltax?: string;
        InvoiceNoCustomerPo?: string;
        InvoiceNoAiLink?: string;
        InvoiceNoAiLinkType?: string;
        InvoiceNoAiLinkNo?: string;
        InvoiceNoAnlys7?: string;
        InvoiceNoAnlys8?: string;
        InvoiceNoNetTradeAmt?: number;
        InvoiceNoNetOrdrAmt?: number;
        InvoiceNoShipAmt?: number;
        InvoiceNoLshipAmt?: number;
        InvoiceNoVariaAmt?: number;
        InvoiceNoLvariaAmt?: number;
        InvoiceNoItemVariaAmt?: number;
        InvoiceNoLitemVariaAmt?: number;
        InvoiceNoChgsVariaAmt?: number;
        InvoiceNoLchgsVariaAmt?: number;
        InvoiceNoDpsApplied?: number;
        InvoiceNoLocDpsApplied?: number;
        InvoiceNoShipSltaxType?: string;
        InvoiceNoShipGsltaxPcent?: number;
        InvoiceNoShipCount?: number;
        InvoiceNoSourceType?: string;
        InvoiceNoLastChgsNo?: number;
        InvoiceNoDocType?: string;
        InvoiceNoDocId?: string;
        InvoiceNoAnlys9?: string;
        InvoiceNoAnlys10?: string;
        InvoiceNoAnlys11?: string;
        InvoiceNoAnlys12?: string;
        InvoiceNoAnlys13?: string;
        InvoiceNoAnlys14?: string;
        InvoiceNoBreakDebitNote?: boolean;
        InvoiceNoFreezed?: boolean;
        InvoiceNoRelatedDebitNote?: string;
        InvoiceNoCloned?: boolean;
        InvoiceNoClonedCompanyCode?: string;
        InvoiceNoUseSampleAcct?: boolean;
        InvoiceNoReferenceDate?: string;
    }

    export namespace AccountsReceivableCommissionRow {
        export const idProperty = 'InvoiceNo';
        export const nameProperty = 'InvoiceNo';
        export const localTextPrefix = 'Finance.AccountsReceivableCommission';

        export namespace Fields {
            export declare const InvoiceNo: string;
            export declare const Salesman: string;
            export declare const SalesmanName: string;
            export declare const Rate: string;
            export declare const InvoiceNoRecnum: string;
            export declare const InvoiceNoDirectEntry: string;
            export declare const InvoiceNoPosted: string;
            export declare const InvoiceNoClosed: string;
            export declare const InvoiceNoReturned: string;
            export declare const InvoiceNoDebitNote: string;
            export declare const InvoiceNoCustomerNo: string;
            export declare const InvoiceNoCustomerName: string;
            export declare const InvoiceNoAddress: string;
            export declare const InvoiceNoAddress2: string;
            export declare const InvoiceNoAddress3: string;
            export declare const InvoiceNoAddress4: string;
            export declare const InvoiceNoAttention: string;
            export declare const InvoiceNoInvoiceDate: string;
            export declare const InvoiceNoPeriod: string;
            export declare const InvoiceNoFiscalYear: string;
            export declare const InvoiceNoPeriodNo: string;
            export declare const InvoiceNoSalesman: string;
            export declare const InvoiceNoCcy: string;
            export declare const InvoiceNoExchRate: string;
            export declare const InvoiceNoPayTerms: string;
            export declare const InvoiceNoDiscDays: string;
            export declare const InvoiceNoDiscPcent: string;
            export declare const InvoiceNoDueDays: string;
            export declare const InvoiceNoDiscountDate: string;
            export declare const InvoiceNoDueDate: string;
            export declare const InvoiceNoExpectedDate: string;
            export declare const InvoiceNoAnlys1: string;
            export declare const InvoiceNoAnlys2: string;
            export declare const InvoiceNoTotPriceAmt: string;
            export declare const InvoiceNoLocPriceAmt: string;
            export declare const InvoiceNoTotPtaxAmt: string;
            export declare const InvoiceNoLocPtaxAmt: string;
            export declare const InvoiceNoTotExtPrice: string;
            export declare const InvoiceNoLocExtPrice: string;
            export declare const InvoiceNoTotLdiscAmt: string;
            export declare const InvoiceNoLocLdiscAmt: string;
            export declare const InvoiceNoTotAtaxAmt: string;
            export declare const InvoiceNoLocAtaxAmt: string;
            export declare const InvoiceNoTotItemAmt: string;
            export declare const InvoiceNoLocItemAmt: string;
            export declare const InvoiceNoTdiscPcent: string;
            export declare const InvoiceNoTdiscAmt: string;
            export declare const InvoiceNoLocalTdiscAmt: string;
            export declare const InvoiceNoChgsAmt: string;
            export declare const InvoiceNoLocChgsAmt: string;
            export declare const InvoiceNoGtaxAmt: string;
            export declare const InvoiceNoLocalGtaxAmt: string;
            export declare const InvoiceNoNetAmt: string;
            export declare const InvoiceNoLocalNetAmt: string;
            export declare const InvoiceNoTdiscAmtCpd: string;
            export declare const InvoiceNoLastLineNo: string;
            export declare const InvoiceNoCreatedDate: string;
            export declare const InvoiceNoCreatedBy: string;
            export declare const InvoiceNoRevisedDate: string;
            export declare const InvoiceNoRevisedBy: string;
            export declare const InvoiceNoPostedDate: string;
            export declare const InvoiceNoPostedBy: string;
            export declare const InvoiceNoLastLogNo: string;
            export declare const InvoiceNoSettledAmt: string;
            export declare const InvoiceNoLsettledAmt: string;
            export declare const InvoiceNoTermDiscAmt: string;
            export declare const InvoiceNoLtermDiscAmt: string;
            export declare const InvoiceNoReturnAmt: string;
            export declare const InvoiceNoLreturnAmt: string;
            export declare const InvoiceNoBalAmt: string;
            export declare const InvoiceNoBalAmtLocal: string;
            export declare const InvoiceNoOverAllocAmt: string;
            export declare const InvoiceNoLoverAllocAmt: string;
            export declare const InvoiceNoAcctCustomer: string;
            export declare const InvoiceNoAcctTdisc: string;
            export declare const InvoiceNoAcctGtax: string;
            export declare const InvoiceNoLockType: string;
            export declare const InvoiceNoLockRefNo: string;
            export declare const InvoiceNoBatchSelect: string;
            export declare const InvoiceNoGlLink: string;
            export declare const InvoiceNoGlLinkType: string;
            export declare const InvoiceNoGlLinkNo: string;
            export declare const InvoiceNoOwnerBranch: string;
            export declare const InvoiceNoSourceBranch: string;
            export declare const InvoiceNoCheckCrlimit: string;
            export declare const InvoiceNoCheckCrbal: string;
            export declare const InvoiceNoComments1: string;
            export declare const InvoiceNoComments2: string;
            export declare const InvoiceNoComments3: string;
            export declare const InvoiceNoComments4: string;
            export declare const InvoiceNoLastTextNo: string;
            export declare const InvoiceNoShipTo: string;
            export declare const InvoiceNoTelNo: string;
            export declare const InvoiceNoFaxNo: string;
            export declare const InvoiceNoSltaxType: string;
            export declare const InvoiceNoGsltaxPcent: string;
            export declare const InvoiceNoTotGsltaxAmt: string;
            export declare const InvoiceNoTotLsltaxAmt: string;
            export declare const InvoiceNoLocGsltaxAmt: string;
            export declare const InvoiceNoLocLsltaxAmt: string;
            export declare const InvoiceNoAcctSltax: string;
            export declare const InvoiceNoCustomerPo: string;
            export declare const InvoiceNoAiLink: string;
            export declare const InvoiceNoAiLinkType: string;
            export declare const InvoiceNoAiLinkNo: string;
            export declare const InvoiceNoAnlys7: string;
            export declare const InvoiceNoAnlys8: string;
            export declare const InvoiceNoNetTradeAmt: string;
            export declare const InvoiceNoNetOrdrAmt: string;
            export declare const InvoiceNoShipAmt: string;
            export declare const InvoiceNoLshipAmt: string;
            export declare const InvoiceNoVariaAmt: string;
            export declare const InvoiceNoLvariaAmt: string;
            export declare const InvoiceNoItemVariaAmt: string;
            export declare const InvoiceNoLitemVariaAmt: string;
            export declare const InvoiceNoChgsVariaAmt: string;
            export declare const InvoiceNoLchgsVariaAmt: string;
            export declare const InvoiceNoDpsApplied: string;
            export declare const InvoiceNoLocDpsApplied: string;
            export declare const InvoiceNoShipSltaxType: string;
            export declare const InvoiceNoShipGsltaxPcent: string;
            export declare const InvoiceNoShipCount: string;
            export declare const InvoiceNoSourceType: string;
            export declare const InvoiceNoLastChgsNo: string;
            export declare const InvoiceNoDocType: string;
            export declare const InvoiceNoDocId: string;
            export declare const InvoiceNoAnlys9: string;
            export declare const InvoiceNoAnlys10: string;
            export declare const InvoiceNoAnlys11: string;
            export declare const InvoiceNoAnlys12: string;
            export declare const InvoiceNoAnlys13: string;
            export declare const InvoiceNoAnlys14: string;
            export declare const InvoiceNoBreakDebitNote: string;
            export declare const InvoiceNoFreezed: string;
            export declare const InvoiceNoRelatedDebitNote: string;
            export declare const InvoiceNoCloned: string;
            export declare const InvoiceNoClonedCompanyCode: string;
            export declare const InvoiceNoUseSampleAcct: string;
            export declare const InvoiceNoReferenceDate: string;
        }

        [
            'InvoiceNo', 
            'Salesman', 
            'SalesmanName', 
            'Rate', 
            'InvoiceNoRecnum', 
            'InvoiceNoDirectEntry', 
            'InvoiceNoPosted', 
            'InvoiceNoClosed', 
            'InvoiceNoReturned', 
            'InvoiceNoDebitNote', 
            'InvoiceNoCustomerNo', 
            'InvoiceNoCustomerName', 
            'InvoiceNoAddress', 
            'InvoiceNoAddress2', 
            'InvoiceNoAddress3', 
            'InvoiceNoAddress4', 
            'InvoiceNoAttention', 
            'InvoiceNoInvoiceDate', 
            'InvoiceNoPeriod', 
            'InvoiceNoFiscalYear', 
            'InvoiceNoPeriodNo', 
            'InvoiceNoSalesman', 
            'InvoiceNoCcy', 
            'InvoiceNoExchRate', 
            'InvoiceNoPayTerms', 
            'InvoiceNoDiscDays', 
            'InvoiceNoDiscPcent', 
            'InvoiceNoDueDays', 
            'InvoiceNoDiscountDate', 
            'InvoiceNoDueDate', 
            'InvoiceNoExpectedDate', 
            'InvoiceNoAnlys1', 
            'InvoiceNoAnlys2', 
            'InvoiceNoTotPriceAmt', 
            'InvoiceNoLocPriceAmt', 
            'InvoiceNoTotPtaxAmt', 
            'InvoiceNoLocPtaxAmt', 
            'InvoiceNoTotExtPrice', 
            'InvoiceNoLocExtPrice', 
            'InvoiceNoTotLdiscAmt', 
            'InvoiceNoLocLdiscAmt', 
            'InvoiceNoTotAtaxAmt', 
            'InvoiceNoLocAtaxAmt', 
            'InvoiceNoTotItemAmt', 
            'InvoiceNoLocItemAmt', 
            'InvoiceNoTdiscPcent', 
            'InvoiceNoTdiscAmt', 
            'InvoiceNoLocalTdiscAmt', 
            'InvoiceNoChgsAmt', 
            'InvoiceNoLocChgsAmt', 
            'InvoiceNoGtaxAmt', 
            'InvoiceNoLocalGtaxAmt', 
            'InvoiceNoNetAmt', 
            'InvoiceNoLocalNetAmt', 
            'InvoiceNoTdiscAmtCpd', 
            'InvoiceNoLastLineNo', 
            'InvoiceNoCreatedDate', 
            'InvoiceNoCreatedBy', 
            'InvoiceNoRevisedDate', 
            'InvoiceNoRevisedBy', 
            'InvoiceNoPostedDate', 
            'InvoiceNoPostedBy', 
            'InvoiceNoLastLogNo', 
            'InvoiceNoSettledAmt', 
            'InvoiceNoLsettledAmt', 
            'InvoiceNoTermDiscAmt', 
            'InvoiceNoLtermDiscAmt', 
            'InvoiceNoReturnAmt', 
            'InvoiceNoLreturnAmt', 
            'InvoiceNoBalAmt', 
            'InvoiceNoBalAmtLocal', 
            'InvoiceNoOverAllocAmt', 
            'InvoiceNoLoverAllocAmt', 
            'InvoiceNoAcctCustomer', 
            'InvoiceNoAcctTdisc', 
            'InvoiceNoAcctGtax', 
            'InvoiceNoLockType', 
            'InvoiceNoLockRefNo', 
            'InvoiceNoBatchSelect', 
            'InvoiceNoGlLink', 
            'InvoiceNoGlLinkType', 
            'InvoiceNoGlLinkNo', 
            'InvoiceNoOwnerBranch', 
            'InvoiceNoSourceBranch', 
            'InvoiceNoCheckCrlimit', 
            'InvoiceNoCheckCrbal', 
            'InvoiceNoComments1', 
            'InvoiceNoComments2', 
            'InvoiceNoComments3', 
            'InvoiceNoComments4', 
            'InvoiceNoLastTextNo', 
            'InvoiceNoShipTo', 
            'InvoiceNoTelNo', 
            'InvoiceNoFaxNo', 
            'InvoiceNoSltaxType', 
            'InvoiceNoGsltaxPcent', 
            'InvoiceNoTotGsltaxAmt', 
            'InvoiceNoTotLsltaxAmt', 
            'InvoiceNoLocGsltaxAmt', 
            'InvoiceNoLocLsltaxAmt', 
            'InvoiceNoAcctSltax', 
            'InvoiceNoCustomerPo', 
            'InvoiceNoAiLink', 
            'InvoiceNoAiLinkType', 
            'InvoiceNoAiLinkNo', 
            'InvoiceNoAnlys7', 
            'InvoiceNoAnlys8', 
            'InvoiceNoNetTradeAmt', 
            'InvoiceNoNetOrdrAmt', 
            'InvoiceNoShipAmt', 
            'InvoiceNoLshipAmt', 
            'InvoiceNoVariaAmt', 
            'InvoiceNoLvariaAmt', 
            'InvoiceNoItemVariaAmt', 
            'InvoiceNoLitemVariaAmt', 
            'InvoiceNoChgsVariaAmt', 
            'InvoiceNoLchgsVariaAmt', 
            'InvoiceNoDpsApplied', 
            'InvoiceNoLocDpsApplied', 
            'InvoiceNoShipSltaxType', 
            'InvoiceNoShipGsltaxPcent', 
            'InvoiceNoShipCount', 
            'InvoiceNoSourceType', 
            'InvoiceNoLastChgsNo', 
            'InvoiceNoDocType', 
            'InvoiceNoDocId', 
            'InvoiceNoAnlys9', 
            'InvoiceNoAnlys10', 
            'InvoiceNoAnlys11', 
            'InvoiceNoAnlys12', 
            'InvoiceNoAnlys13', 
            'InvoiceNoAnlys14', 
            'InvoiceNoBreakDebitNote', 
            'InvoiceNoFreezed', 
            'InvoiceNoRelatedDebitNote', 
            'InvoiceNoCloned', 
            'InvoiceNoClonedCompanyCode', 
            'InvoiceNoUseSampleAcct', 
            'InvoiceNoReferenceDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

