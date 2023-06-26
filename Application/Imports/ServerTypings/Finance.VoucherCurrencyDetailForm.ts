namespace Matrix.Finance {
    export class VoucherCurrencyDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.VoucherCurrencyDetail';

    }

    export interface VoucherCurrencyDetailForm {
        VoucherType: Serenity.StringEditor;
        VoucherNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        LastExchRate: Serenity.DecimalEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['VoucherType', () => Serenity.StringEditor]
   , ['VoucherNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['LastExchRate', () => Serenity.DecimalEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(VoucherCurrencyDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

