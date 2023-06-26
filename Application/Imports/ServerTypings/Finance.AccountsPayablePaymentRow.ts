namespace Matrix.Finance {
    export interface AccountsPayablePaymentRow {
        DetailList?: AccountsPayablePaymentDetailRow[];
        Recnum?: number;
        RefNo?: string;
        Deposit?: string;
        Posted?: string;
        VendorNo?: string;
        VendorName?: string;
        OrderNo?: string;
        PaidDate?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        FundCode?: string;
        Payee?: string;
        ChequeNo?: string;
        Ccy?: string;
        ExchRate?: number;
        SameCurrency?: string;
        PaidAmt?: number;
        PaidAmtLocal?: number;
        BalAmt?: number;
        DiscAmt?: number;
        DueAmt?: number;
        DueAmtLocal?: number;
        AppliedAmt?: number;
        AppliedAmtLoc?: number;
        SettledAmt?: number;
        ForexGainAmt?: number;
        EndAmt?: number;
        EndAmtLocal?: number;
        UnusedAmt?: number;
        UnusedAmtLoc?: number;
        AppliedLocCpd?: number;
        RoundDiff?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        AcctVendor?: string;
        AcctCash?: string;
        AcctForexDiff?: string;
        AcctTermDisc?: string;
        AcctRoundDiff?: string;
        BatchSelect?: string;
        GlLink?: string;
        GlLinkType?: string;
        GlLinkNo?: string;
        FixedCcy?: string;
        DefaultCcy?: string;
        PaidLocalCpd?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        CanEdit?: string;
        DiscAmtInvo?: number;
        TotalDebit?: number;
        TotalCredit?: number;
        LastAdjCount?: number;
        CcyInv?: string;
        ExchRateInv?: number;
        AppliedAmtInv?: number;
        BankAmt?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys7?: string;
        Anlys8?: string;
        Remarks?: string;
        ToOpen?: string;
        ToRound?: string;
        GbvendInvoAmtDiff?: number;
        GbvendOpenAmtDiff?: number;
        ApledgTotalDebit?: number;
        ApledgTotalCredit?: number;
        AllowCancel?: string;
        ChargeAmt?: number;
        ChargeAmtLocal?: number;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        AcctDeposit?: string;
    }

    export namespace AccountsPayablePaymentRow {
        export const idProperty = 'RefNo';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Finance.AccountsPayablePayment';

        export namespace Fields {
            export declare const DetailList: string;
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const Deposit: string;
            export declare const Posted: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
            export declare const OrderNo: string;
            export declare const PaidDate: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const FundCode: string;
            export declare const Payee: string;
            export declare const ChequeNo: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const SameCurrency: string;
            export declare const PaidAmt: string;
            export declare const PaidAmtLocal: string;
            export declare const BalAmt: string;
            export declare const DiscAmt: string;
            export declare const DueAmt: string;
            export declare const DueAmtLocal: string;
            export declare const AppliedAmt: string;
            export declare const AppliedAmtLoc: string;
            export declare const SettledAmt: string;
            export declare const ForexGainAmt: string;
            export declare const EndAmt: string;
            export declare const EndAmtLocal: string;
            export declare const UnusedAmt: string;
            export declare const UnusedAmtLoc: string;
            export declare const AppliedLocCpd: string;
            export declare const RoundDiff: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const AcctVendor: string;
            export declare const AcctCash: string;
            export declare const AcctForexDiff: string;
            export declare const AcctTermDisc: string;
            export declare const AcctRoundDiff: string;
            export declare const BatchSelect: string;
            export declare const GlLink: string;
            export declare const GlLinkType: string;
            export declare const GlLinkNo: string;
            export declare const FixedCcy: string;
            export declare const DefaultCcy: string;
            export declare const PaidLocalCpd: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const CanEdit: string;
            export declare const DiscAmtInvo: string;
            export declare const TotalDebit: string;
            export declare const TotalCredit: string;
            export declare const LastAdjCount: string;
            export declare const CcyInv: string;
            export declare const ExchRateInv: string;
            export declare const AppliedAmtInv: string;
            export declare const BankAmt: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Remarks: string;
            export declare const ToOpen: string;
            export declare const ToRound: string;
            export declare const GbvendInvoAmtDiff: string;
            export declare const GbvendOpenAmtDiff: string;
            export declare const ApledgTotalDebit: string;
            export declare const ApledgTotalCredit: string;
            export declare const AllowCancel: string;
            export declare const ChargeAmt: string;
            export declare const ChargeAmtLocal: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const AcctDeposit: string;
        }

        [
            'DetailList', 
            'Recnum', 
            'RefNo', 
            'Deposit', 
            'Posted', 
            'VendorNo', 
            'VendorName', 
            'OrderNo', 
            'PaidDate', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'FundCode', 
            'Payee', 
            'ChequeNo', 
            'Ccy', 
            'ExchRate', 
            'SameCurrency', 
            'PaidAmt', 
            'PaidAmtLocal', 
            'BalAmt', 
            'DiscAmt', 
            'DueAmt', 
            'DueAmtLocal', 
            'AppliedAmt', 
            'AppliedAmtLoc', 
            'SettledAmt', 
            'ForexGainAmt', 
            'EndAmt', 
            'EndAmtLocal', 
            'UnusedAmt', 
            'UnusedAmtLoc', 
            'AppliedLocCpd', 
            'RoundDiff', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'AcctVendor', 
            'AcctCash', 
            'AcctForexDiff', 
            'AcctTermDisc', 
            'AcctRoundDiff', 
            'BatchSelect', 
            'GlLink', 
            'GlLinkType', 
            'GlLinkNo', 
            'FixedCcy', 
            'DefaultCcy', 
            'PaidLocalCpd', 
            'OwnerBranch', 
            'SourceBranch', 
            'CanEdit', 
            'DiscAmtInvo', 
            'TotalDebit', 
            'TotalCredit', 
            'LastAdjCount', 
            'CcyInv', 
            'ExchRateInv', 
            'AppliedAmtInv', 
            'BankAmt', 
            'Anlys1', 
            'Anlys2', 
            'Anlys7', 
            'Anlys8', 
            'Remarks', 
            'ToOpen', 
            'ToRound', 
            'GbvendInvoAmtDiff', 
            'GbvendOpenAmtDiff', 
            'ApledgTotalDebit', 
            'ApledgTotalCredit', 
            'AllowCancel', 
            'ChargeAmt', 
            'ChargeAmtLocal', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'AcctDeposit'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

