namespace Matrix.Finance {
    export interface AccountsReceivablePaymentDetailRow {
        Recnum?: number;
        ReceiptNo?: string;
        InvoiceNo?: string;
        InvoiceDate?: string;
        DiscountDate?: string;
        DueDate?: string;
        DiscPercent?: number;
        Ccy?: string;
        InvoExchRate?: number;
        PayExchRate?: number;
        BalAmt?: number;
        BalAmtInvo?: number;
        DiscAmt?: number;
        DiscAmtInvo?: number;
        DueAmt?: number;
        DueAmtInvo?: number;
        DueAmtLocal?: number;
        AppliedAmt?: number;
        AppliedAmtLoc?: number;
        SettledAmt?: number;
        ForexGainAmt?: number;
        EndAmt?: number;
        EndAmtLocal?: number;
        Posted?: string;
        LogNo?: number;
        LastLogNo?: number;
        ReceiptDate?: string;
        Settle?: string;
        AppliedAmtInv?: number;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        InvRoundDiff?: number;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        ReceiptNoRecnum?: number;
        ReceiptNoDeposit?: string;
        ReceiptNoPosted?: string;
        ReceiptNoCustomerNo?: string;
        ReceiptNoCustomerName?: string;
        ReceiptNoOrderNo?: string;
        ReceiptNoReceiptDate?: string;
        ReceiptNoPeriod?: string;
        ReceiptNoFiscalYear?: number;
        ReceiptNoPeriodNo?: number;
        ReceiptNoFundCode?: string;
        ReceiptNoReference?: string;
        ReceiptNoCcy?: string;
        ReceiptNoExchRate?: number;
        ReceiptNoSameCurrency?: string;
        ReceiptNoPaidAmt?: number;
        ReceiptNoPaidAmtLocal?: number;
        ReceiptNoBalAmt?: number;
        ReceiptNoDiscAmt?: number;
        ReceiptNoDueAmt?: number;
        ReceiptNoDueAmtLocal?: number;
        ReceiptNoAppliedAmt?: number;
        ReceiptNoAppliedAmtLoc?: number;
        ReceiptNoSettledAmt?: number;
        ReceiptNoForexGainAmt?: number;
        ReceiptNoEndAmt?: number;
        ReceiptNoEndAmtLocal?: number;
        ReceiptNoUnusedAmt?: number;
        ReceiptNoUnusedAmtLoc?: number;
        ReceiptNoAppliedLocCpd?: number;
        ReceiptNoRoundDiff?: number;
        ReceiptNoCreatedDate?: string;
        ReceiptNoCreatedBy?: string;
        ReceiptNoRevisedDate?: string;
        ReceiptNoRevisedBy?: string;
        ReceiptNoPostedDate?: string;
        ReceiptNoPostedBy?: string;
        ReceiptNoAcctCustomer?: string;
        ReceiptNoAcctCash?: string;
        ReceiptNoAcctForexDiff?: string;
        ReceiptNoAcctTermDisc?: string;
        ReceiptNoAcctRoundDiff?: string;
        ReceiptNoBatchSelect?: string;
        ReceiptNoGlLink?: string;
        ReceiptNoGlLinkType?: string;
        ReceiptNoGlLinkNo?: string;
        ReceiptNoFixedCcy?: string;
        ReceiptNoDefaultCcy?: string;
        ReceiptNoOwnerBranch?: string;
        ReceiptNoSourceBranch?: string;
        ReceiptNoCanEdit?: string;
        ReceiptNoDiscAmtInvo?: number;
        ReceiptNoTotalDebit?: number;
        ReceiptNoTotalCredit?: number;
        ReceiptNoLastAdjCount?: number;
        ReceiptNoCcyInv?: string;
        ReceiptNoExchRateInv?: number;
        ReceiptNoAppliedAmtInv?: number;
        ReceiptNoBankAmt?: number;
        ReceiptNoAnlys1?: string;
        ReceiptNoAnlys2?: string;
        ReceiptNoAnlys7?: string;
        ReceiptNoAnlys8?: string;
        ReceiptNoToOpen?: string;
        ReceiptNoToRound?: string;
        ReceiptNoGbcustInvoAmtDiff?: number;
        ReceiptNoGbcustOpenAmtDiff?: number;
        ReceiptNoArledgTotalDebit?: number;
        ReceiptNoArledgTotalCredit?: number;
        ReceiptNoAllowCancel?: string;
        ReceiptNoPayer?: string;
        ReceiptNoChargeAmt?: number;
        ReceiptNoChargeAmtLocal?: number;
        ReceiptNoAnlys9?: string;
        ReceiptNoAnlys10?: string;
        ReceiptNoAnlys11?: string;
        ReceiptNoAnlys12?: string;
        ReceiptNoAnlys13?: string;
        ReceiptNoAnlys14?: string;
        ReceiptNoAcctDeposit?: string;
        ReceiptNoBalAmtLocal?: number;
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

    export namespace AccountsReceivablePaymentDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ReceiptNo';
        export const localTextPrefix = 'Finance.AccountsReceivablePaymentDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ReceiptNo: string;
            export declare const InvoiceNo: string;
            export declare const InvoiceDate: string;
            export declare const DiscountDate: string;
            export declare const DueDate: string;
            export declare const DiscPercent: string;
            export declare const Ccy: string;
            export declare const InvoExchRate: string;
            export declare const PayExchRate: string;
            export declare const BalAmt: string;
            export declare const BalAmtInvo: string;
            export declare const DiscAmt: string;
            export declare const DiscAmtInvo: string;
            export declare const DueAmt: string;
            export declare const DueAmtInvo: string;
            export declare const DueAmtLocal: string;
            export declare const AppliedAmt: string;
            export declare const AppliedAmtLoc: string;
            export declare const SettledAmt: string;
            export declare const ForexGainAmt: string;
            export declare const EndAmt: string;
            export declare const EndAmtLocal: string;
            export declare const Posted: string;
            export declare const LogNo: string;
            export declare const LastLogNo: string;
            export declare const ReceiptDate: string;
            export declare const Settle: string;
            export declare const AppliedAmtInv: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const InvRoundDiff: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const ReceiptNoRecnum: string;
            export declare const ReceiptNoDeposit: string;
            export declare const ReceiptNoPosted: string;
            export declare const ReceiptNoCustomerNo: string;
            export declare const ReceiptNoCustomerName: string;
            export declare const ReceiptNoOrderNo: string;
            export declare const ReceiptNoReceiptDate: string;
            export declare const ReceiptNoPeriod: string;
            export declare const ReceiptNoFiscalYear: string;
            export declare const ReceiptNoPeriodNo: string;
            export declare const ReceiptNoFundCode: string;
            export declare const ReceiptNoReference: string;
            export declare const ReceiptNoCcy: string;
            export declare const ReceiptNoExchRate: string;
            export declare const ReceiptNoSameCurrency: string;
            export declare const ReceiptNoPaidAmt: string;
            export declare const ReceiptNoPaidAmtLocal: string;
            export declare const ReceiptNoBalAmt: string;
            export declare const ReceiptNoDiscAmt: string;
            export declare const ReceiptNoDueAmt: string;
            export declare const ReceiptNoDueAmtLocal: string;
            export declare const ReceiptNoAppliedAmt: string;
            export declare const ReceiptNoAppliedAmtLoc: string;
            export declare const ReceiptNoSettledAmt: string;
            export declare const ReceiptNoForexGainAmt: string;
            export declare const ReceiptNoEndAmt: string;
            export declare const ReceiptNoEndAmtLocal: string;
            export declare const ReceiptNoUnusedAmt: string;
            export declare const ReceiptNoUnusedAmtLoc: string;
            export declare const ReceiptNoAppliedLocCpd: string;
            export declare const ReceiptNoRoundDiff: string;
            export declare const ReceiptNoCreatedDate: string;
            export declare const ReceiptNoCreatedBy: string;
            export declare const ReceiptNoRevisedDate: string;
            export declare const ReceiptNoRevisedBy: string;
            export declare const ReceiptNoPostedDate: string;
            export declare const ReceiptNoPostedBy: string;
            export declare const ReceiptNoAcctCustomer: string;
            export declare const ReceiptNoAcctCash: string;
            export declare const ReceiptNoAcctForexDiff: string;
            export declare const ReceiptNoAcctTermDisc: string;
            export declare const ReceiptNoAcctRoundDiff: string;
            export declare const ReceiptNoBatchSelect: string;
            export declare const ReceiptNoGlLink: string;
            export declare const ReceiptNoGlLinkType: string;
            export declare const ReceiptNoGlLinkNo: string;
            export declare const ReceiptNoFixedCcy: string;
            export declare const ReceiptNoDefaultCcy: string;
            export declare const ReceiptNoOwnerBranch: string;
            export declare const ReceiptNoSourceBranch: string;
            export declare const ReceiptNoCanEdit: string;
            export declare const ReceiptNoDiscAmtInvo: string;
            export declare const ReceiptNoTotalDebit: string;
            export declare const ReceiptNoTotalCredit: string;
            export declare const ReceiptNoLastAdjCount: string;
            export declare const ReceiptNoCcyInv: string;
            export declare const ReceiptNoExchRateInv: string;
            export declare const ReceiptNoAppliedAmtInv: string;
            export declare const ReceiptNoBankAmt: string;
            export declare const ReceiptNoAnlys1: string;
            export declare const ReceiptNoAnlys2: string;
            export declare const ReceiptNoAnlys7: string;
            export declare const ReceiptNoAnlys8: string;
            export declare const ReceiptNoToOpen: string;
            export declare const ReceiptNoToRound: string;
            export declare const ReceiptNoGbcustInvoAmtDiff: string;
            export declare const ReceiptNoGbcustOpenAmtDiff: string;
            export declare const ReceiptNoArledgTotalDebit: string;
            export declare const ReceiptNoArledgTotalCredit: string;
            export declare const ReceiptNoAllowCancel: string;
            export declare const ReceiptNoPayer: string;
            export declare const ReceiptNoChargeAmt: string;
            export declare const ReceiptNoChargeAmtLocal: string;
            export declare const ReceiptNoAnlys9: string;
            export declare const ReceiptNoAnlys10: string;
            export declare const ReceiptNoAnlys11: string;
            export declare const ReceiptNoAnlys12: string;
            export declare const ReceiptNoAnlys13: string;
            export declare const ReceiptNoAnlys14: string;
            export declare const ReceiptNoAcctDeposit: string;
            export declare const ReceiptNoBalAmtLocal: string;
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
            'Recnum', 
            'ReceiptNo', 
            'InvoiceNo', 
            'InvoiceDate', 
            'DiscountDate', 
            'DueDate', 
            'DiscPercent', 
            'Ccy', 
            'InvoExchRate', 
            'PayExchRate', 
            'BalAmt', 
            'BalAmtInvo', 
            'DiscAmt', 
            'DiscAmtInvo', 
            'DueAmt', 
            'DueAmtInvo', 
            'DueAmtLocal', 
            'AppliedAmt', 
            'AppliedAmtLoc', 
            'SettledAmt', 
            'ForexGainAmt', 
            'EndAmt', 
            'EndAmtLocal', 
            'Posted', 
            'LogNo', 
            'LastLogNo', 
            'ReceiptDate', 
            'Settle', 
            'AppliedAmtInv', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'InvRoundDiff', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'ReceiptNoRecnum', 
            'ReceiptNoDeposit', 
            'ReceiptNoPosted', 
            'ReceiptNoCustomerNo', 
            'ReceiptNoCustomerName', 
            'ReceiptNoOrderNo', 
            'ReceiptNoReceiptDate', 
            'ReceiptNoPeriod', 
            'ReceiptNoFiscalYear', 
            'ReceiptNoPeriodNo', 
            'ReceiptNoFundCode', 
            'ReceiptNoReference', 
            'ReceiptNoCcy', 
            'ReceiptNoExchRate', 
            'ReceiptNoSameCurrency', 
            'ReceiptNoPaidAmt', 
            'ReceiptNoPaidAmtLocal', 
            'ReceiptNoBalAmt', 
            'ReceiptNoDiscAmt', 
            'ReceiptNoDueAmt', 
            'ReceiptNoDueAmtLocal', 
            'ReceiptNoAppliedAmt', 
            'ReceiptNoAppliedAmtLoc', 
            'ReceiptNoSettledAmt', 
            'ReceiptNoForexGainAmt', 
            'ReceiptNoEndAmt', 
            'ReceiptNoEndAmtLocal', 
            'ReceiptNoUnusedAmt', 
            'ReceiptNoUnusedAmtLoc', 
            'ReceiptNoAppliedLocCpd', 
            'ReceiptNoRoundDiff', 
            'ReceiptNoCreatedDate', 
            'ReceiptNoCreatedBy', 
            'ReceiptNoRevisedDate', 
            'ReceiptNoRevisedBy', 
            'ReceiptNoPostedDate', 
            'ReceiptNoPostedBy', 
            'ReceiptNoAcctCustomer', 
            'ReceiptNoAcctCash', 
            'ReceiptNoAcctForexDiff', 
            'ReceiptNoAcctTermDisc', 
            'ReceiptNoAcctRoundDiff', 
            'ReceiptNoBatchSelect', 
            'ReceiptNoGlLink', 
            'ReceiptNoGlLinkType', 
            'ReceiptNoGlLinkNo', 
            'ReceiptNoFixedCcy', 
            'ReceiptNoDefaultCcy', 
            'ReceiptNoOwnerBranch', 
            'ReceiptNoSourceBranch', 
            'ReceiptNoCanEdit', 
            'ReceiptNoDiscAmtInvo', 
            'ReceiptNoTotalDebit', 
            'ReceiptNoTotalCredit', 
            'ReceiptNoLastAdjCount', 
            'ReceiptNoCcyInv', 
            'ReceiptNoExchRateInv', 
            'ReceiptNoAppliedAmtInv', 
            'ReceiptNoBankAmt', 
            'ReceiptNoAnlys1', 
            'ReceiptNoAnlys2', 
            'ReceiptNoAnlys7', 
            'ReceiptNoAnlys8', 
            'ReceiptNoToOpen', 
            'ReceiptNoToRound', 
            'ReceiptNoGbcustInvoAmtDiff', 
            'ReceiptNoGbcustOpenAmtDiff', 
            'ReceiptNoArledgTotalDebit', 
            'ReceiptNoArledgTotalCredit', 
            'ReceiptNoAllowCancel', 
            'ReceiptNoPayer', 
            'ReceiptNoChargeAmt', 
            'ReceiptNoChargeAmtLocal', 
            'ReceiptNoAnlys9', 
            'ReceiptNoAnlys10', 
            'ReceiptNoAnlys11', 
            'ReceiptNoAnlys12', 
            'ReceiptNoAnlys13', 
            'ReceiptNoAnlys14', 
            'ReceiptNoAcctDeposit', 
            'ReceiptNoBalAmtLocal', 
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

