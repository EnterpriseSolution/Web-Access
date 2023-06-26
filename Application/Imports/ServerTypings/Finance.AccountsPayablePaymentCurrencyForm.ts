namespace Matrix.Finance {
    export class AccountsPayablePaymentCurrencyForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayablePaymentCurrency';

    }

    export interface AccountsPayablePaymentCurrencyForm {
        RefNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        BalAmt: Serenity.DecimalEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['BalAmt', () => Serenity.DecimalEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsPayablePaymentCurrencyForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

