namespace Matrix.Finance {
    export class CurrencyBalanceForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.CurrencyBalance';

    }

    export interface CurrencyBalanceForm {
        AcctNo: Serenity.StringEditor;
        AcctName: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ForexBalance: Serenity.DecimalEditor;
        ForexSign: Serenity.StringEditor;
        LocalBalance: Serenity.DecimalEditor;
        LocalSign: Serenity.StringEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['AcctName', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['ForexBalance', () => Serenity.DecimalEditor]
   , ['ForexSign', () => Serenity.StringEditor]
   , ['LocalBalance', () => Serenity.DecimalEditor]
   , ['LocalSign', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CurrencyBalanceForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

