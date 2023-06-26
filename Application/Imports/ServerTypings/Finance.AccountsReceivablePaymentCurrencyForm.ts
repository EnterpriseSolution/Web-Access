namespace Matrix.Finance {
    export class AccountsReceivablePaymentCurrencyForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivablePaymentCurrency';

    }

    export interface AccountsReceivablePaymentCurrencyForm {
        ReceiptNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        BalAmt: Serenity.DecimalEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
    }

    [['ReceiptNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['BalAmt', () => Serenity.DecimalEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsReceivablePaymentCurrencyForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

