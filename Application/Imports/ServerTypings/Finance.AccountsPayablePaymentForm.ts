namespace Matrix.Finance {
    export class AccountsPayablePaymentForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayablePayment';

    }

    export interface AccountsPayablePaymentForm {
        RefNo: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        FundCode: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PaidAmt: Serenity.DecimalEditor;
        DetailList: AccountsPayablePaymentDetailEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['FundCode', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PaidAmt', () => Serenity.DecimalEditor]
   , ['DetailList', () => AccountsPayablePaymentDetailEditor]
].forEach(x => Object.defineProperty(AccountsPayablePaymentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

