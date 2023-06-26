namespace Matrix.Finance {
    export class CurrencyLedgerSummaryForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.CurrencyLedgerSummary';

    }

    export interface CurrencyLedgerSummaryForm {
        AcctNo: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        BalBeg: Serenity.DecimalEditor;
        BalBegSign: Serenity.StringEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        BalEnd: Serenity.DecimalEditor;
        BalEndSign: Serenity.StringEditor;
        LtotalDebit: Serenity.DecimalEditor;
        LtotalCredit: Serenity.DecimalEditor;
        LbalBeg: Serenity.DecimalEditor;
        LbalBegSign: Serenity.StringEditor;
        LbalEnd: Serenity.DecimalEditor;
        LbalEndSign: Serenity.StringEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['BalBeg', () => Serenity.DecimalEditor]
   , ['BalBegSign', () => Serenity.StringEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['BalEnd', () => Serenity.DecimalEditor]
   , ['BalEndSign', () => Serenity.StringEditor]
   , ['LtotalDebit', () => Serenity.DecimalEditor]
   , ['LtotalCredit', () => Serenity.DecimalEditor]
   , ['LbalBeg', () => Serenity.DecimalEditor]
   , ['LbalBegSign', () => Serenity.StringEditor]
   , ['LbalEnd', () => Serenity.DecimalEditor]
   , ['LbalEndSign', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CurrencyLedgerSummaryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

