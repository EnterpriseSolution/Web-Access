namespace Matrix.Finance {
    export class CurrencyLedgerForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.CurrencyLedger';

    }

    export interface CurrencyLedgerForm {
        AcctNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        ForexBeg: Serenity.DecimalEditor;
        ForexBegSign: Serenity.StringEditor;
        ForexDebit: Serenity.DecimalEditor;
        ForexCredit: Serenity.DecimalEditor;
        ForexEnd: Serenity.DecimalEditor;
        ForexEndSign: Serenity.StringEditor;
        LocalBeg: Serenity.DecimalEditor;
        LocalBegSign: Serenity.StringEditor;
        LocalDebit: Serenity.DecimalEditor;
        LocalCredit: Serenity.DecimalEditor;
        LocalEnd: Serenity.DecimalEditor;
        LocalEndSign: Serenity.StringEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['ForexBeg', () => Serenity.DecimalEditor]
   , ['ForexBegSign', () => Serenity.StringEditor]
   , ['ForexDebit', () => Serenity.DecimalEditor]
   , ['ForexCredit', () => Serenity.DecimalEditor]
   , ['ForexEnd', () => Serenity.DecimalEditor]
   , ['ForexEndSign', () => Serenity.StringEditor]
   , ['LocalBeg', () => Serenity.DecimalEditor]
   , ['LocalBegSign', () => Serenity.StringEditor]
   , ['LocalDebit', () => Serenity.DecimalEditor]
   , ['LocalCredit', () => Serenity.DecimalEditor]
   , ['LocalEnd', () => Serenity.DecimalEditor]
   , ['LocalEndSign', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CurrencyLedgerForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

