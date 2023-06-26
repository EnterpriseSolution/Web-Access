namespace Matrix.Finance {
    export interface AccountsPayablePaymentDetailRow {
        Recnum?: number;
        RefNo?: string;
        InvoCtrlNo?: string;
        InvoiceNo?: string;
        InvoiceDate?: string;
        DiscountDate?: string;
        DueDate?: string;
        DiscPercent?: number;
        Ccy?: string;
        InvoExchRate?: number;
        PayExchRate?: number;
        Settle?: string;
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
        PaidDate?: string;
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
        RefNoRecnum?: number;
        RefNoDeposit?: string;
        RefNoPosted?: string;
        RefNoVendorNo?: string;
        RefNoVendorName?: string;
        RefNoOrderNo?: string;
        RefNoPaidDate?: string;
        RefNoPeriod?: string;
        RefNoFiscalYear?: number;
        RefNoPeriodNo?: number;
        RefNoFundCode?: string;
        RefNoPayee?: string;
        RefNoChequeNo?: string;
        RefNoCcy?: string;
        RefNoExchRate?: number;
        RefNoSameCurrency?: string;
        RefNoPaidAmt?: number;
        RefNoPaidAmtLocal?: number;
        RefNoBalAmt?: number;
        RefNoDiscAmt?: number;
        RefNoDueAmt?: number;
        RefNoDueAmtLocal?: number;
        RefNoAppliedAmt?: number;
        RefNoAppliedAmtLoc?: number;
        RefNoSettledAmt?: number;
        RefNoForexGainAmt?: number;
        RefNoEndAmt?: number;
        RefNoEndAmtLocal?: number;
        RefNoUnusedAmt?: number;
        RefNoUnusedAmtLoc?: number;
        RefNoAppliedLocCpd?: number;
        RefNoRoundDiff?: number;
        RefNoCreatedDate?: string;
        RefNoCreatedBy?: string;
        RefNoRevisedDate?: string;
        RefNoRevisedBy?: string;
        RefNoPostedDate?: string;
        RefNoPostedBy?: string;
        RefNoAcctVendor?: string;
        RefNoAcctCash?: string;
        RefNoAcctForexDiff?: string;
        RefNoAcctTermDisc?: string;
        RefNoAcctRoundDiff?: string;
        RefNoBatchSelect?: string;
        RefNoGlLink?: string;
        RefNoGlLinkType?: string;
        RefNoGlLinkNo?: string;
        RefNoFixedCcy?: string;
        RefNoDefaultCcy?: string;
        RefNoPaidLocalCpd?: number;
        RefNoOwnerBranch?: string;
        RefNoSourceBranch?: string;
        RefNoCanEdit?: string;
        RefNoDiscAmtInvo?: number;
        RefNoTotalDebit?: number;
        RefNoTotalCredit?: number;
        RefNoLastAdjCount?: number;
        RefNoCcyInv?: string;
        RefNoExchRateInv?: number;
        RefNoAppliedAmtInv?: number;
        RefNoBankAmt?: number;
        RefNoAnlys1?: string;
        RefNoAnlys2?: string;
        RefNoAnlys7?: string;
        RefNoAnlys8?: string;
        RefNoRemarks?: string;
        RefNoToOpen?: string;
        RefNoToRound?: string;
        RefNoGbvendInvoAmtDiff?: number;
        RefNoGbvendOpenAmtDiff?: number;
        RefNoApledgTotalDebit?: number;
        RefNoApledgTotalCredit?: number;
        RefNoAllowCancel?: string;
        RefNoChargeAmt?: number;
        RefNoChargeAmtLocal?: number;
        RefNoAnlys9?: string;
        RefNoAnlys10?: string;
        RefNoAnlys11?: string;
        RefNoAnlys12?: string;
        RefNoAnlys13?: string;
        RefNoAnlys14?: string;
        RefNoAcctDeposit?: string;
        InvoCtrlNoRecnum?: number;
        InvoCtrlNoMiscellaneous?: string;
        InvoCtrlNoPosted?: string;
        InvoCtrlNoClosed?: string;
        InvoCtrlNoReturned?: string;
        InvoCtrlNoVendorNo?: string;
        InvoCtrlNoVendorName?: string;
        InvoCtrlNoInvoiceNo?: string;
        InvoCtrlNoInvoiceDate?: string;
        InvoCtrlNoReceivedDate?: string;
        InvoCtrlNoPeriod?: string;
        InvoCtrlNoFiscalYear?: number;
        InvoCtrlNoPeriodNo?: number;
        InvoCtrlNoPayTerms?: string;
        InvoCtrlNoDiscPercent?: number;
        InvoCtrlNoDiscDays?: number;
        InvoCtrlNoNetDays?: number;
        InvoCtrlNoDiscountDate?: string;
        InvoCtrlNoDueDate?: string;
        InvoCtrlNoPlannedDate?: string;
        InvoCtrlNoPaymentBranch?: string;
        InvoCtrlNoCcy?: string;
        InvoCtrlNoExchRate?: number;
        InvoCtrlNoTotPriceAmt?: number;
        InvoCtrlNoTotPtaxAmt?: number;
        InvoCtrlNoTotExtPrice?: number;
        InvoCtrlNoTotLdiscAmt?: number;
        InvoCtrlNoTotAtaxAmt?: number;
        InvoCtrlNoTotItemAmt?: number;
        InvoCtrlNoTotTdiscAmt?: number;
        InvoCtrlNoNetTradeAmt?: number;
        InvoCtrlNoTotChgsAmt?: number;
        InvoCtrlNoNetOrdrAmt?: number;
        InvoCtrlNoTotGtaxAmt?: number;
        InvoCtrlNoNetInvoAmt?: number;
        InvoCtrlNoDpsApplied?: number;
        InvoCtrlNoNetBalAmt?: number;
        InvoCtrlNoLocPriceAmt?: number;
        InvoCtrlNoLocPtaxAmt?: number;
        InvoCtrlNoLocExtPrice?: number;
        InvoCtrlNoLocLdiscAmt?: number;
        InvoCtrlNoLocAtaxAmt?: number;
        InvoCtrlNoLocItemAmt?: number;
        InvoCtrlNoLocTdiscAmt?: number;
        InvoCtrlNoLocChgsAmt?: number;
        InvoCtrlNoLocGtaxAmt?: number;
        InvoCtrlNoLocInvoAmt?: number;
        InvoCtrlNoLocDpsApplied?: number;
        InvoCtrlNoGrnNetAmt?: number;
        InvoCtrlNoLgrnNetAmt?: number;
        InvoCtrlNoVariaAmt?: number;
        InvoCtrlNoLvariaAmt?: number;
        InvoCtrlNoItemVariaAmt?: number;
        InvoCtrlNoLitemVariaAmt?: number;
        InvoCtrlNoChgsVariaAmt?: number;
        InvoCtrlNoLchgsVariaAmt?: number;
        InvoCtrlNoLastLineNo?: number;
        InvoCtrlNoCreatedDate?: string;
        InvoCtrlNoCreatedBy?: string;
        InvoCtrlNoRevisedDate?: string;
        InvoCtrlNoRevisedBy?: string;
        InvoCtrlNoPostedDate?: string;
        InvoCtrlNoPostedBy?: string;
        InvoCtrlNoHold?: string;
        InvoCtrlNoHoldUntil?: string;
        InvoCtrlNoHoldDate?: string;
        InvoCtrlNoHoldBy?: string;
        InvoCtrlNoAcctVendor?: string;
        InvoCtrlNoAcctTdisc?: string;
        InvoCtrlNoAcctGtax?: string;
        InvoCtrlNoAcctVariance?: string;
        InvoCtrlNoSettledAmt?: number;
        InvoCtrlNoLsettledAmt?: number;
        InvoCtrlNoTermDiscAmt?: number;
        InvoCtrlNoLtermDiscAmt?: number;
        InvoCtrlNoReturnAmt?: number;
        InvoCtrlNoLreturnAmt?: number;
        InvoCtrlNoBalAmt?: number;
        InvoCtrlNoBalAmtLocal?: number;
        InvoCtrlNoOverAllocAmt?: number;
        InvoCtrlNoLoverAllocAmt?: number;
        InvoCtrlNoBatchSelect?: string;
        InvoCtrlNoGlLink?: string;
        InvoCtrlNoGlLinkType?: string;
        InvoCtrlNoGlLinkNo?: string;
        InvoCtrlNoLastLogNo?: number;
        InvoCtrlNoLockType?: string;
        InvoCtrlNoLockRefNo?: string;
        InvoCtrlNoHoldReason?: string;
        InvoCtrlNoOwnerBranch?: string;
        InvoCtrlNoSourceBranch?: string;
        InvoCtrlNoParticulars?: string;
        InvoCtrlNoCheckCrlimit?: string;
        InvoCtrlNoCheckCrbal?: number;
        InvoCtrlNoAcctPutax?: string;
        InvoCtrlNoPutaxType?: string;
        InvoCtrlNoGputaxPcent?: number;
        InvoCtrlNoTotGputaxAmt?: number;
        InvoCtrlNoTotLputaxAmt?: number;
        InvoCtrlNoLocGputaxAmt?: number;
        InvoCtrlNoLocLputaxAmt?: number;
        InvoCtrlNoGrnPutaxType?: string;
        InvoCtrlNoGrnGputaxPcent?: number;
        InvoCtrlNoGrnCount?: number;
        InvoCtrlNoAiLink?: string;
        InvoCtrlNoAiLinkType?: string;
        InvoCtrlNoAiLinkNo?: string;
        InvoCtrlNoAnlys9?: string;
        InvoCtrlNoAnlys10?: string;
        InvoCtrlNoAnlys11?: string;
        InvoCtrlNoAnlys12?: string;
        InvoCtrlNoAnlys13?: string;
        InvoCtrlNoAnlys14?: string;
        InvoCtrlNoAnlys15?: string;
        InvoCtrlNoAnlys16?: string;
        InvoCtrlNoAnlys17?: string;
        InvoCtrlNoAnlys18?: string;
        InvoCtrlNoPoNo?: string;
        InvoCtrlNoOriginCountry?: string;
    }

    export namespace AccountsPayablePaymentDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Finance.AccountsPayablePaymentDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const InvoCtrlNo: string;
            export declare const InvoiceNo: string;
            export declare const InvoiceDate: string;
            export declare const DiscountDate: string;
            export declare const DueDate: string;
            export declare const DiscPercent: string;
            export declare const Ccy: string;
            export declare const InvoExchRate: string;
            export declare const PayExchRate: string;
            export declare const Settle: string;
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
            export declare const PaidDate: string;
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
            export declare const RefNoRecnum: string;
            export declare const RefNoDeposit: string;
            export declare const RefNoPosted: string;
            export declare const RefNoVendorNo: string;
            export declare const RefNoVendorName: string;
            export declare const RefNoOrderNo: string;
            export declare const RefNoPaidDate: string;
            export declare const RefNoPeriod: string;
            export declare const RefNoFiscalYear: string;
            export declare const RefNoPeriodNo: string;
            export declare const RefNoFundCode: string;
            export declare const RefNoPayee: string;
            export declare const RefNoChequeNo: string;
            export declare const RefNoCcy: string;
            export declare const RefNoExchRate: string;
            export declare const RefNoSameCurrency: string;
            export declare const RefNoPaidAmt: string;
            export declare const RefNoPaidAmtLocal: string;
            export declare const RefNoBalAmt: string;
            export declare const RefNoDiscAmt: string;
            export declare const RefNoDueAmt: string;
            export declare const RefNoDueAmtLocal: string;
            export declare const RefNoAppliedAmt: string;
            export declare const RefNoAppliedAmtLoc: string;
            export declare const RefNoSettledAmt: string;
            export declare const RefNoForexGainAmt: string;
            export declare const RefNoEndAmt: string;
            export declare const RefNoEndAmtLocal: string;
            export declare const RefNoUnusedAmt: string;
            export declare const RefNoUnusedAmtLoc: string;
            export declare const RefNoAppliedLocCpd: string;
            export declare const RefNoRoundDiff: string;
            export declare const RefNoCreatedDate: string;
            export declare const RefNoCreatedBy: string;
            export declare const RefNoRevisedDate: string;
            export declare const RefNoRevisedBy: string;
            export declare const RefNoPostedDate: string;
            export declare const RefNoPostedBy: string;
            export declare const RefNoAcctVendor: string;
            export declare const RefNoAcctCash: string;
            export declare const RefNoAcctForexDiff: string;
            export declare const RefNoAcctTermDisc: string;
            export declare const RefNoAcctRoundDiff: string;
            export declare const RefNoBatchSelect: string;
            export declare const RefNoGlLink: string;
            export declare const RefNoGlLinkType: string;
            export declare const RefNoGlLinkNo: string;
            export declare const RefNoFixedCcy: string;
            export declare const RefNoDefaultCcy: string;
            export declare const RefNoPaidLocalCpd: string;
            export declare const RefNoOwnerBranch: string;
            export declare const RefNoSourceBranch: string;
            export declare const RefNoCanEdit: string;
            export declare const RefNoDiscAmtInvo: string;
            export declare const RefNoTotalDebit: string;
            export declare const RefNoTotalCredit: string;
            export declare const RefNoLastAdjCount: string;
            export declare const RefNoCcyInv: string;
            export declare const RefNoExchRateInv: string;
            export declare const RefNoAppliedAmtInv: string;
            export declare const RefNoBankAmt: string;
            export declare const RefNoAnlys1: string;
            export declare const RefNoAnlys2: string;
            export declare const RefNoAnlys7: string;
            export declare const RefNoAnlys8: string;
            export declare const RefNoRemarks: string;
            export declare const RefNoToOpen: string;
            export declare const RefNoToRound: string;
            export declare const RefNoGbvendInvoAmtDiff: string;
            export declare const RefNoGbvendOpenAmtDiff: string;
            export declare const RefNoApledgTotalDebit: string;
            export declare const RefNoApledgTotalCredit: string;
            export declare const RefNoAllowCancel: string;
            export declare const RefNoChargeAmt: string;
            export declare const RefNoChargeAmtLocal: string;
            export declare const RefNoAnlys9: string;
            export declare const RefNoAnlys10: string;
            export declare const RefNoAnlys11: string;
            export declare const RefNoAnlys12: string;
            export declare const RefNoAnlys13: string;
            export declare const RefNoAnlys14: string;
            export declare const RefNoAcctDeposit: string;
            export declare const InvoCtrlNoRecnum: string;
            export declare const InvoCtrlNoMiscellaneous: string;
            export declare const InvoCtrlNoPosted: string;
            export declare const InvoCtrlNoClosed: string;
            export declare const InvoCtrlNoReturned: string;
            export declare const InvoCtrlNoVendorNo: string;
            export declare const InvoCtrlNoVendorName: string;
            export declare const InvoCtrlNoInvoiceNo: string;
            export declare const InvoCtrlNoInvoiceDate: string;
            export declare const InvoCtrlNoReceivedDate: string;
            export declare const InvoCtrlNoPeriod: string;
            export declare const InvoCtrlNoFiscalYear: string;
            export declare const InvoCtrlNoPeriodNo: string;
            export declare const InvoCtrlNoPayTerms: string;
            export declare const InvoCtrlNoDiscPercent: string;
            export declare const InvoCtrlNoDiscDays: string;
            export declare const InvoCtrlNoNetDays: string;
            export declare const InvoCtrlNoDiscountDate: string;
            export declare const InvoCtrlNoDueDate: string;
            export declare const InvoCtrlNoPlannedDate: string;
            export declare const InvoCtrlNoPaymentBranch: string;
            export declare const InvoCtrlNoCcy: string;
            export declare const InvoCtrlNoExchRate: string;
            export declare const InvoCtrlNoTotPriceAmt: string;
            export declare const InvoCtrlNoTotPtaxAmt: string;
            export declare const InvoCtrlNoTotExtPrice: string;
            export declare const InvoCtrlNoTotLdiscAmt: string;
            export declare const InvoCtrlNoTotAtaxAmt: string;
            export declare const InvoCtrlNoTotItemAmt: string;
            export declare const InvoCtrlNoTotTdiscAmt: string;
            export declare const InvoCtrlNoNetTradeAmt: string;
            export declare const InvoCtrlNoTotChgsAmt: string;
            export declare const InvoCtrlNoNetOrdrAmt: string;
            export declare const InvoCtrlNoTotGtaxAmt: string;
            export declare const InvoCtrlNoNetInvoAmt: string;
            export declare const InvoCtrlNoDpsApplied: string;
            export declare const InvoCtrlNoNetBalAmt: string;
            export declare const InvoCtrlNoLocPriceAmt: string;
            export declare const InvoCtrlNoLocPtaxAmt: string;
            export declare const InvoCtrlNoLocExtPrice: string;
            export declare const InvoCtrlNoLocLdiscAmt: string;
            export declare const InvoCtrlNoLocAtaxAmt: string;
            export declare const InvoCtrlNoLocItemAmt: string;
            export declare const InvoCtrlNoLocTdiscAmt: string;
            export declare const InvoCtrlNoLocChgsAmt: string;
            export declare const InvoCtrlNoLocGtaxAmt: string;
            export declare const InvoCtrlNoLocInvoAmt: string;
            export declare const InvoCtrlNoLocDpsApplied: string;
            export declare const InvoCtrlNoGrnNetAmt: string;
            export declare const InvoCtrlNoLgrnNetAmt: string;
            export declare const InvoCtrlNoVariaAmt: string;
            export declare const InvoCtrlNoLvariaAmt: string;
            export declare const InvoCtrlNoItemVariaAmt: string;
            export declare const InvoCtrlNoLitemVariaAmt: string;
            export declare const InvoCtrlNoChgsVariaAmt: string;
            export declare const InvoCtrlNoLchgsVariaAmt: string;
            export declare const InvoCtrlNoLastLineNo: string;
            export declare const InvoCtrlNoCreatedDate: string;
            export declare const InvoCtrlNoCreatedBy: string;
            export declare const InvoCtrlNoRevisedDate: string;
            export declare const InvoCtrlNoRevisedBy: string;
            export declare const InvoCtrlNoPostedDate: string;
            export declare const InvoCtrlNoPostedBy: string;
            export declare const InvoCtrlNoHold: string;
            export declare const InvoCtrlNoHoldUntil: string;
            export declare const InvoCtrlNoHoldDate: string;
            export declare const InvoCtrlNoHoldBy: string;
            export declare const InvoCtrlNoAcctVendor: string;
            export declare const InvoCtrlNoAcctTdisc: string;
            export declare const InvoCtrlNoAcctGtax: string;
            export declare const InvoCtrlNoAcctVariance: string;
            export declare const InvoCtrlNoSettledAmt: string;
            export declare const InvoCtrlNoLsettledAmt: string;
            export declare const InvoCtrlNoTermDiscAmt: string;
            export declare const InvoCtrlNoLtermDiscAmt: string;
            export declare const InvoCtrlNoReturnAmt: string;
            export declare const InvoCtrlNoLreturnAmt: string;
            export declare const InvoCtrlNoBalAmt: string;
            export declare const InvoCtrlNoBalAmtLocal: string;
            export declare const InvoCtrlNoOverAllocAmt: string;
            export declare const InvoCtrlNoLoverAllocAmt: string;
            export declare const InvoCtrlNoBatchSelect: string;
            export declare const InvoCtrlNoGlLink: string;
            export declare const InvoCtrlNoGlLinkType: string;
            export declare const InvoCtrlNoGlLinkNo: string;
            export declare const InvoCtrlNoLastLogNo: string;
            export declare const InvoCtrlNoLockType: string;
            export declare const InvoCtrlNoLockRefNo: string;
            export declare const InvoCtrlNoHoldReason: string;
            export declare const InvoCtrlNoOwnerBranch: string;
            export declare const InvoCtrlNoSourceBranch: string;
            export declare const InvoCtrlNoParticulars: string;
            export declare const InvoCtrlNoCheckCrlimit: string;
            export declare const InvoCtrlNoCheckCrbal: string;
            export declare const InvoCtrlNoAcctPutax: string;
            export declare const InvoCtrlNoPutaxType: string;
            export declare const InvoCtrlNoGputaxPcent: string;
            export declare const InvoCtrlNoTotGputaxAmt: string;
            export declare const InvoCtrlNoTotLputaxAmt: string;
            export declare const InvoCtrlNoLocGputaxAmt: string;
            export declare const InvoCtrlNoLocLputaxAmt: string;
            export declare const InvoCtrlNoGrnPutaxType: string;
            export declare const InvoCtrlNoGrnGputaxPcent: string;
            export declare const InvoCtrlNoGrnCount: string;
            export declare const InvoCtrlNoAiLink: string;
            export declare const InvoCtrlNoAiLinkType: string;
            export declare const InvoCtrlNoAiLinkNo: string;
            export declare const InvoCtrlNoAnlys9: string;
            export declare const InvoCtrlNoAnlys10: string;
            export declare const InvoCtrlNoAnlys11: string;
            export declare const InvoCtrlNoAnlys12: string;
            export declare const InvoCtrlNoAnlys13: string;
            export declare const InvoCtrlNoAnlys14: string;
            export declare const InvoCtrlNoAnlys15: string;
            export declare const InvoCtrlNoAnlys16: string;
            export declare const InvoCtrlNoAnlys17: string;
            export declare const InvoCtrlNoAnlys18: string;
            export declare const InvoCtrlNoPoNo: string;
            export declare const InvoCtrlNoOriginCountry: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'InvoCtrlNo', 
            'InvoiceNo', 
            'InvoiceDate', 
            'DiscountDate', 
            'DueDate', 
            'DiscPercent', 
            'Ccy', 
            'InvoExchRate', 
            'PayExchRate', 
            'Settle', 
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
            'PaidDate', 
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
            'RefNoRecnum', 
            'RefNoDeposit', 
            'RefNoPosted', 
            'RefNoVendorNo', 
            'RefNoVendorName', 
            'RefNoOrderNo', 
            'RefNoPaidDate', 
            'RefNoPeriod', 
            'RefNoFiscalYear', 
            'RefNoPeriodNo', 
            'RefNoFundCode', 
            'RefNoPayee', 
            'RefNoChequeNo', 
            'RefNoCcy', 
            'RefNoExchRate', 
            'RefNoSameCurrency', 
            'RefNoPaidAmt', 
            'RefNoPaidAmtLocal', 
            'RefNoBalAmt', 
            'RefNoDiscAmt', 
            'RefNoDueAmt', 
            'RefNoDueAmtLocal', 
            'RefNoAppliedAmt', 
            'RefNoAppliedAmtLoc', 
            'RefNoSettledAmt', 
            'RefNoForexGainAmt', 
            'RefNoEndAmt', 
            'RefNoEndAmtLocal', 
            'RefNoUnusedAmt', 
            'RefNoUnusedAmtLoc', 
            'RefNoAppliedLocCpd', 
            'RefNoRoundDiff', 
            'RefNoCreatedDate', 
            'RefNoCreatedBy', 
            'RefNoRevisedDate', 
            'RefNoRevisedBy', 
            'RefNoPostedDate', 
            'RefNoPostedBy', 
            'RefNoAcctVendor', 
            'RefNoAcctCash', 
            'RefNoAcctForexDiff', 
            'RefNoAcctTermDisc', 
            'RefNoAcctRoundDiff', 
            'RefNoBatchSelect', 
            'RefNoGlLink', 
            'RefNoGlLinkType', 
            'RefNoGlLinkNo', 
            'RefNoFixedCcy', 
            'RefNoDefaultCcy', 
            'RefNoPaidLocalCpd', 
            'RefNoOwnerBranch', 
            'RefNoSourceBranch', 
            'RefNoCanEdit', 
            'RefNoDiscAmtInvo', 
            'RefNoTotalDebit', 
            'RefNoTotalCredit', 
            'RefNoLastAdjCount', 
            'RefNoCcyInv', 
            'RefNoExchRateInv', 
            'RefNoAppliedAmtInv', 
            'RefNoBankAmt', 
            'RefNoAnlys1', 
            'RefNoAnlys2', 
            'RefNoAnlys7', 
            'RefNoAnlys8', 
            'RefNoRemarks', 
            'RefNoToOpen', 
            'RefNoToRound', 
            'RefNoGbvendInvoAmtDiff', 
            'RefNoGbvendOpenAmtDiff', 
            'RefNoApledgTotalDebit', 
            'RefNoApledgTotalCredit', 
            'RefNoAllowCancel', 
            'RefNoChargeAmt', 
            'RefNoChargeAmtLocal', 
            'RefNoAnlys9', 
            'RefNoAnlys10', 
            'RefNoAnlys11', 
            'RefNoAnlys12', 
            'RefNoAnlys13', 
            'RefNoAnlys14', 
            'RefNoAcctDeposit', 
            'InvoCtrlNoRecnum', 
            'InvoCtrlNoMiscellaneous', 
            'InvoCtrlNoPosted', 
            'InvoCtrlNoClosed', 
            'InvoCtrlNoReturned', 
            'InvoCtrlNoVendorNo', 
            'InvoCtrlNoVendorName', 
            'InvoCtrlNoInvoiceNo', 
            'InvoCtrlNoInvoiceDate', 
            'InvoCtrlNoReceivedDate', 
            'InvoCtrlNoPeriod', 
            'InvoCtrlNoFiscalYear', 
            'InvoCtrlNoPeriodNo', 
            'InvoCtrlNoPayTerms', 
            'InvoCtrlNoDiscPercent', 
            'InvoCtrlNoDiscDays', 
            'InvoCtrlNoNetDays', 
            'InvoCtrlNoDiscountDate', 
            'InvoCtrlNoDueDate', 
            'InvoCtrlNoPlannedDate', 
            'InvoCtrlNoPaymentBranch', 
            'InvoCtrlNoCcy', 
            'InvoCtrlNoExchRate', 
            'InvoCtrlNoTotPriceAmt', 
            'InvoCtrlNoTotPtaxAmt', 
            'InvoCtrlNoTotExtPrice', 
            'InvoCtrlNoTotLdiscAmt', 
            'InvoCtrlNoTotAtaxAmt', 
            'InvoCtrlNoTotItemAmt', 
            'InvoCtrlNoTotTdiscAmt', 
            'InvoCtrlNoNetTradeAmt', 
            'InvoCtrlNoTotChgsAmt', 
            'InvoCtrlNoNetOrdrAmt', 
            'InvoCtrlNoTotGtaxAmt', 
            'InvoCtrlNoNetInvoAmt', 
            'InvoCtrlNoDpsApplied', 
            'InvoCtrlNoNetBalAmt', 
            'InvoCtrlNoLocPriceAmt', 
            'InvoCtrlNoLocPtaxAmt', 
            'InvoCtrlNoLocExtPrice', 
            'InvoCtrlNoLocLdiscAmt', 
            'InvoCtrlNoLocAtaxAmt', 
            'InvoCtrlNoLocItemAmt', 
            'InvoCtrlNoLocTdiscAmt', 
            'InvoCtrlNoLocChgsAmt', 
            'InvoCtrlNoLocGtaxAmt', 
            'InvoCtrlNoLocInvoAmt', 
            'InvoCtrlNoLocDpsApplied', 
            'InvoCtrlNoGrnNetAmt', 
            'InvoCtrlNoLgrnNetAmt', 
            'InvoCtrlNoVariaAmt', 
            'InvoCtrlNoLvariaAmt', 
            'InvoCtrlNoItemVariaAmt', 
            'InvoCtrlNoLitemVariaAmt', 
            'InvoCtrlNoChgsVariaAmt', 
            'InvoCtrlNoLchgsVariaAmt', 
            'InvoCtrlNoLastLineNo', 
            'InvoCtrlNoCreatedDate', 
            'InvoCtrlNoCreatedBy', 
            'InvoCtrlNoRevisedDate', 
            'InvoCtrlNoRevisedBy', 
            'InvoCtrlNoPostedDate', 
            'InvoCtrlNoPostedBy', 
            'InvoCtrlNoHold', 
            'InvoCtrlNoHoldUntil', 
            'InvoCtrlNoHoldDate', 
            'InvoCtrlNoHoldBy', 
            'InvoCtrlNoAcctVendor', 
            'InvoCtrlNoAcctTdisc', 
            'InvoCtrlNoAcctGtax', 
            'InvoCtrlNoAcctVariance', 
            'InvoCtrlNoSettledAmt', 
            'InvoCtrlNoLsettledAmt', 
            'InvoCtrlNoTermDiscAmt', 
            'InvoCtrlNoLtermDiscAmt', 
            'InvoCtrlNoReturnAmt', 
            'InvoCtrlNoLreturnAmt', 
            'InvoCtrlNoBalAmt', 
            'InvoCtrlNoBalAmtLocal', 
            'InvoCtrlNoOverAllocAmt', 
            'InvoCtrlNoLoverAllocAmt', 
            'InvoCtrlNoBatchSelect', 
            'InvoCtrlNoGlLink', 
            'InvoCtrlNoGlLinkType', 
            'InvoCtrlNoGlLinkNo', 
            'InvoCtrlNoLastLogNo', 
            'InvoCtrlNoLockType', 
            'InvoCtrlNoLockRefNo', 
            'InvoCtrlNoHoldReason', 
            'InvoCtrlNoOwnerBranch', 
            'InvoCtrlNoSourceBranch', 
            'InvoCtrlNoParticulars', 
            'InvoCtrlNoCheckCrlimit', 
            'InvoCtrlNoCheckCrbal', 
            'InvoCtrlNoAcctPutax', 
            'InvoCtrlNoPutaxType', 
            'InvoCtrlNoGputaxPcent', 
            'InvoCtrlNoTotGputaxAmt', 
            'InvoCtrlNoTotLputaxAmt', 
            'InvoCtrlNoLocGputaxAmt', 
            'InvoCtrlNoLocLputaxAmt', 
            'InvoCtrlNoGrnPutaxType', 
            'InvoCtrlNoGrnGputaxPcent', 
            'InvoCtrlNoGrnCount', 
            'InvoCtrlNoAiLink', 
            'InvoCtrlNoAiLinkType', 
            'InvoCtrlNoAiLinkNo', 
            'InvoCtrlNoAnlys9', 
            'InvoCtrlNoAnlys10', 
            'InvoCtrlNoAnlys11', 
            'InvoCtrlNoAnlys12', 
            'InvoCtrlNoAnlys13', 
            'InvoCtrlNoAnlys14', 
            'InvoCtrlNoAnlys15', 
            'InvoCtrlNoAnlys16', 
            'InvoCtrlNoAnlys17', 
            'InvoCtrlNoAnlys18', 
            'InvoCtrlNoPoNo', 
            'InvoCtrlNoOriginCountry'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

