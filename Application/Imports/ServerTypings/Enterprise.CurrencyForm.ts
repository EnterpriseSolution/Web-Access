namespace Matrix.Enterprise {
    export class CurrencyForm extends Serenity.PrefixedContext {
        static formKey = 'Enterprise.Currency';

    }

    export interface CurrencyForm {
        Ccy: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        DefaultRate: Serenity.DecimalEditor;
        DetailList: MasterData.ExchangeRateDetailEditor;
    }

    [['Ccy', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['DefaultRate', () => Serenity.DecimalEditor]
   , ['DetailList', () => MasterData.ExchangeRateDetailEditor]
].forEach(x => Object.defineProperty(CurrencyForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

