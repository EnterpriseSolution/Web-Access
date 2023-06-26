namespace Matrix.Finance {
    export class LedgerSummaryForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.LedgerSummary';

    }

    export interface LedgerSummaryForm {
        AcctNo: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        BalBeg: Serenity.DecimalEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        BalEnd: Serenity.DecimalEditor;
        BalBegSign: Serenity.StringEditor;
        BalEndSign: Serenity.StringEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['BalBeg', () => Serenity.DecimalEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['BalEnd', () => Serenity.DecimalEditor]
   , ['BalBegSign', () => Serenity.StringEditor]
   , ['BalEndSign', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(LedgerSummaryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

