namespace Matrix.Finance {
    export class AccountsPayablePaymentDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayablePaymentDetail';

    }

    export interface AccountsPayablePaymentDetailForm {
        RefNo: Serenity.StringEditor;
        InvoCtrlNo: Serenity.StringEditor;
        InvoiceNo: Serenity.StringEditor;
        InvoiceDate: Serenity.DateEditor;
        DiscountDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        DiscPercent: Serenity.DecimalEditor;
        Ccy: Serenity.StringEditor;
        InvoExchRate: Serenity.DecimalEditor;
        PayExchRate: Serenity.DecimalEditor;
        Settle: Serenity.StringEditor;
        BalAmt: Serenity.DecimalEditor;
        BalAmtInvo: Serenity.DecimalEditor;
        DiscAmt: Serenity.DecimalEditor;
        DiscAmtInvo: Serenity.DecimalEditor;
        DueAmt: Serenity.DecimalEditor;
        DueAmtInvo: Serenity.DecimalEditor;
        DueAmtLocal: Serenity.DecimalEditor;
        AppliedAmt: Serenity.DecimalEditor;
        AppliedAmtLoc: Serenity.DecimalEditor;
        SettledAmt: Serenity.DecimalEditor;
        ForexGainAmt: Serenity.DecimalEditor;
        EndAmt: Serenity.DecimalEditor;
        EndAmtLocal: Serenity.DecimalEditor;
        Posted: Serenity.StringEditor;
        LogNo: Serenity.DecimalEditor;
        LastLogNo: Serenity.DecimalEditor;
        PaidDate: Serenity.DateEditor;
        AppliedAmtInv: Serenity.DecimalEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        InvRoundDiff: Serenity.DecimalEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['InvoCtrlNo', () => Serenity.StringEditor]
   , ['InvoiceNo', () => Serenity.StringEditor]
   , ['InvoiceDate', () => Serenity.DateEditor]
   , ['DiscountDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['DiscPercent', () => Serenity.DecimalEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['InvoExchRate', () => Serenity.DecimalEditor]
   , ['PayExchRate', () => Serenity.DecimalEditor]
   , ['Settle', () => Serenity.StringEditor]
   , ['BalAmt', () => Serenity.DecimalEditor]
   , ['BalAmtInvo', () => Serenity.DecimalEditor]
   , ['DiscAmt', () => Serenity.DecimalEditor]
   , ['DiscAmtInvo', () => Serenity.DecimalEditor]
   , ['DueAmt', () => Serenity.DecimalEditor]
   , ['DueAmtInvo', () => Serenity.DecimalEditor]
   , ['DueAmtLocal', () => Serenity.DecimalEditor]
   , ['AppliedAmt', () => Serenity.DecimalEditor]
   , ['AppliedAmtLoc', () => Serenity.DecimalEditor]
   , ['SettledAmt', () => Serenity.DecimalEditor]
   , ['ForexGainAmt', () => Serenity.DecimalEditor]
   , ['EndAmt', () => Serenity.DecimalEditor]
   , ['EndAmtLocal', () => Serenity.DecimalEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['LogNo', () => Serenity.DecimalEditor]
   , ['LastLogNo', () => Serenity.DecimalEditor]
   , ['PaidDate', () => Serenity.DateEditor]
   , ['AppliedAmtInv', () => Serenity.DecimalEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['InvRoundDiff', () => Serenity.DecimalEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsPayablePaymentDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

