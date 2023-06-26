namespace Matrix.Finance {
    export class AccountsReceivablePaymentDepositForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivablePaymentDeposit';

    }

    export interface AccountsReceivablePaymentDepositForm {
        ReceiptNo: Serenity.StringEditor;
        LineNo: Serenity.IntegerEditor;
        OrderNo: Serenity.StringEditor;
        DepositReceiptNo: Serenity.StringEditor;
        Posted: Serenity.BooleanEditor;
        ReceiptDate: Serenity.DateEditor;
        DepositAmt: Serenity.DecimalEditor;
        DepositAmtLocal: Serenity.DecimalEditor;
        BalAmt: Serenity.DecimalEditor;
        BalAmtLocal: Serenity.DecimalEditor;
        PaidAmt: Serenity.DecimalEditor;
        PaidAmtLocal: Serenity.DecimalEditor;
        Settle: Serenity.BooleanEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        Anlys13: Serenity.StringEditor;
        Anlys14: Serenity.StringEditor;
    }

    [['ReceiptNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.IntegerEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['DepositReceiptNo', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.BooleanEditor]
   , ['ReceiptDate', () => Serenity.DateEditor]
   , ['DepositAmt', () => Serenity.DecimalEditor]
   , ['DepositAmtLocal', () => Serenity.DecimalEditor]
   , ['BalAmt', () => Serenity.DecimalEditor]
   , ['BalAmtLocal', () => Serenity.DecimalEditor]
   , ['PaidAmt', () => Serenity.DecimalEditor]
   , ['PaidAmtLocal', () => Serenity.DecimalEditor]
   , ['Settle', () => Serenity.BooleanEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['Anlys13', () => Serenity.StringEditor]
   , ['Anlys14', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsReceivablePaymentDepositForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

