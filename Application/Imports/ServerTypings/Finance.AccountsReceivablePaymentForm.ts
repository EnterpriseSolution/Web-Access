namespace Matrix.Finance {
    export class AccountsReceivablePaymentForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivablePayment';

    }

    export interface AccountsReceivablePaymentForm {
        ReceiptNo: Serenity.StringEditor;
        Deposit: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        OrderNo: Serenity.StringEditor;
        ReceiptDate: Serenity.DateEditor;
        Period: Serenity.StringEditor;
        FiscalYear: Serenity.DecimalEditor;
        PeriodNo: Serenity.DecimalEditor;
        FundCode: Serenity.StringEditor;
        Reference: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        SameCurrency: Serenity.StringEditor;
        PaidAmt: Serenity.DecimalEditor;
        PaidAmtLocal: Serenity.DecimalEditor;
        BalAmt: Serenity.DecimalEditor;
        DiscAmt: Serenity.DecimalEditor;
        DueAmt: Serenity.DecimalEditor;
        DueAmtLocal: Serenity.DecimalEditor;
        AppliedAmt: Serenity.DecimalEditor;
        AppliedAmtLoc: Serenity.DecimalEditor;
        SettledAmt: Serenity.DecimalEditor;
        ForexGainAmt: Serenity.DecimalEditor;
        EndAmt: Serenity.DecimalEditor;
        EndAmtLocal: Serenity.DecimalEditor;
        UnusedAmt: Serenity.DecimalEditor;
        UnusedAmtLoc: Serenity.DecimalEditor;
        AppliedLocCpd: Serenity.DecimalEditor;
        RoundDiff: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        PostedDate: Serenity.DateEditor;
        PostedBy: Serenity.StringEditor;
        AcctCustomer: Serenity.StringEditor;
        AcctCash: Serenity.StringEditor;
        AcctForexDiff: Serenity.StringEditor;
        AcctTermDisc: Serenity.StringEditor;
        AcctRoundDiff: Serenity.StringEditor;
        BatchSelect: Serenity.StringEditor;
        GlLink: Serenity.StringEditor;
        GlLinkType: Serenity.StringEditor;
        GlLinkNo: Serenity.StringEditor;
        FixedCcy: Serenity.StringEditor;
        DefaultCcy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        CanEdit: Serenity.StringEditor;
        DiscAmtInvo: Serenity.DecimalEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        LastAdjCount: Serenity.DecimalEditor;
        CcyInv: Serenity.StringEditor;
        ExchRateInv: Serenity.DecimalEditor;
        AppliedAmtInv: Serenity.DecimalEditor;
        BankAmt: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        ToOpen: Serenity.StringEditor;
        ToRound: Serenity.StringEditor;
        GbcustInvoAmtDiff: Serenity.DecimalEditor;
        GbcustOpenAmtDiff: Serenity.DecimalEditor;
        ArledgTotalDebit: Serenity.DecimalEditor;
        ArledgTotalCredit: Serenity.DecimalEditor;
        AllowCancel: Serenity.StringEditor;
        Payer: Serenity.StringEditor;
        ChargeAmt: Serenity.DecimalEditor;
        ChargeAmtLocal: Serenity.DecimalEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        Anlys13: Serenity.StringEditor;
        Anlys14: Serenity.StringEditor;
        AcctDeposit: Serenity.StringEditor;
        BalAmtLocal: Serenity.DecimalEditor;
        DetailList: AccountsReceivablePaymentDetailDetailEditor;
    }

    [['ReceiptNo', () => Serenity.StringEditor]
   , ['Deposit', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['ReceiptDate', () => Serenity.DateEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['FiscalYear', () => Serenity.DecimalEditor]
   , ['PeriodNo', () => Serenity.DecimalEditor]
   , ['FundCode', () => Serenity.StringEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['SameCurrency', () => Serenity.StringEditor]
   , ['PaidAmt', () => Serenity.DecimalEditor]
   , ['PaidAmtLocal', () => Serenity.DecimalEditor]
   , ['BalAmt', () => Serenity.DecimalEditor]
   , ['DiscAmt', () => Serenity.DecimalEditor]
   , ['DueAmt', () => Serenity.DecimalEditor]
   , ['DueAmtLocal', () => Serenity.DecimalEditor]
   , ['AppliedAmt', () => Serenity.DecimalEditor]
   , ['AppliedAmtLoc', () => Serenity.DecimalEditor]
   , ['SettledAmt', () => Serenity.DecimalEditor]
   , ['ForexGainAmt', () => Serenity.DecimalEditor]
   , ['EndAmt', () => Serenity.DecimalEditor]
   , ['EndAmtLocal', () => Serenity.DecimalEditor]
   , ['UnusedAmt', () => Serenity.DecimalEditor]
   , ['UnusedAmtLoc', () => Serenity.DecimalEditor]
   , ['AppliedLocCpd', () => Serenity.DecimalEditor]
   , ['RoundDiff', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['PostedDate', () => Serenity.DateEditor]
   , ['PostedBy', () => Serenity.StringEditor]
   , ['AcctCustomer', () => Serenity.StringEditor]
   , ['AcctCash', () => Serenity.StringEditor]
   , ['AcctForexDiff', () => Serenity.StringEditor]
   , ['AcctTermDisc', () => Serenity.StringEditor]
   , ['AcctRoundDiff', () => Serenity.StringEditor]
   , ['BatchSelect', () => Serenity.StringEditor]
   , ['GlLink', () => Serenity.StringEditor]
   , ['GlLinkType', () => Serenity.StringEditor]
   , ['GlLinkNo', () => Serenity.StringEditor]
   , ['FixedCcy', () => Serenity.StringEditor]
   , ['DefaultCcy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['CanEdit', () => Serenity.StringEditor]
   , ['DiscAmtInvo', () => Serenity.DecimalEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['LastAdjCount', () => Serenity.DecimalEditor]
   , ['CcyInv', () => Serenity.StringEditor]
   , ['ExchRateInv', () => Serenity.DecimalEditor]
   , ['AppliedAmtInv', () => Serenity.DecimalEditor]
   , ['BankAmt', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['ToOpen', () => Serenity.StringEditor]
   , ['ToRound', () => Serenity.StringEditor]
   , ['GbcustInvoAmtDiff', () => Serenity.DecimalEditor]
   , ['GbcustOpenAmtDiff', () => Serenity.DecimalEditor]
   , ['ArledgTotalDebit', () => Serenity.DecimalEditor]
   , ['ArledgTotalCredit', () => Serenity.DecimalEditor]
   , ['AllowCancel', () => Serenity.StringEditor]
   , ['Payer', () => Serenity.StringEditor]
   , ['ChargeAmt', () => Serenity.DecimalEditor]
   , ['ChargeAmtLocal', () => Serenity.DecimalEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['Anlys13', () => Serenity.StringEditor]
   , ['Anlys14', () => Serenity.StringEditor]
   , ['AcctDeposit', () => Serenity.StringEditor]
   , ['BalAmtLocal', () => Serenity.DecimalEditor]
   , ['DetailList', () => AccountsReceivablePaymentDetailDetailEditor]
].forEach(x => Object.defineProperty(AccountsReceivablePaymentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

