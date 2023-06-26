namespace Matrix.Finance {
    export interface AccountsReceivablePaymentRow {
        DetailList?: AccountsReceivablePaymentDetailRow[];
        DepositList?: AccountsReceivablePaymentDepositRow[];
        CurrencyList?: AccountsReceivablePaymentCurrencyRow[];
        Recnum?: number;
        ReceiptNo?: string;
        Deposit?: string;
        Posted?: string;
        CustomerNo?: string;
        CustomerName?: string;
        OrderNo?: string;
        ReceiptDate?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        FundCode?: string;
        Reference?: string;
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
        AcctCustomer?: string;
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
        ToOpen?: string;
        ToRound?: string;
        GbcustInvoAmtDiff?: number;
        GbcustOpenAmtDiff?: number;
        ArledgTotalDebit?: number;
        ArledgTotalCredit?: number;
        AllowCancel?: string;
        Payer?: string;
        ChargeAmt?: number;
        ChargeAmtLocal?: number;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        AcctDeposit?: string;
        BalAmtLocal?: number;
    }

    export namespace AccountsReceivablePaymentRow {
        export const idProperty = 'ReceiptNo';
        export const nameProperty = 'ReceiptNo';
        export const localTextPrefix = 'Finance.AccountsReceivablePayment';

        export namespace Fields {
            export declare const DetailList: string;
            export declare const DepositList: string;
            export declare const CurrencyList: string;
            export declare const Recnum: string;
            export declare const ReceiptNo: string;
            export declare const Deposit: string;
            export declare const Posted: string;
            export declare const CustomerNo: string;
            export declare const CustomerName: string;
            export declare const OrderNo: string;
            export declare const ReceiptDate: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const FundCode: string;
            export declare const Reference: string;
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
            export declare const AcctCustomer: string;
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
            export declare const ToOpen: string;
            export declare const ToRound: string;
            export declare const GbcustInvoAmtDiff: string;
            export declare const GbcustOpenAmtDiff: string;
            export declare const ArledgTotalDebit: string;
            export declare const ArledgTotalCredit: string;
            export declare const AllowCancel: string;
            export declare const Payer: string;
            export declare const ChargeAmt: string;
            export declare const ChargeAmtLocal: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const AcctDeposit: string;
            export declare const BalAmtLocal: string;
        }

        [
            'DetailList', 
            'DepositList', 
            'CurrencyList', 
            'Recnum', 
            'ReceiptNo', 
            'Deposit', 
            'Posted', 
            'CustomerNo', 
            'CustomerName', 
            'OrderNo', 
            'ReceiptDate', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'FundCode', 
            'Reference', 
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
            'AcctCustomer', 
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
            'ToOpen', 
            'ToRound', 
            'GbcustInvoAmtDiff', 
            'GbcustOpenAmtDiff', 
            'ArledgTotalDebit', 
            'ArledgTotalCredit', 
            'AllowCancel', 
            'Payer', 
            'ChargeAmt', 
            'ChargeAmtLocal', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'AcctDeposit', 
            'BalAmtLocal'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

