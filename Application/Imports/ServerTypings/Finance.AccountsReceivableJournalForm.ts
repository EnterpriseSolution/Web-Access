namespace Matrix.Finance {
    export class AccountsReceivableJournalForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivableJournal';

    }

    export interface AccountsReceivableJournalForm {
        EntryNo: Serenity.DecimalEditor;
        CustomerNo: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        TranDate: Serenity.DateEditor;
        TranType: Serenity.StringEditor;
        RefNo: Serenity.StringEditor;
        Debit: Serenity.DecimalEditor;
        Credit: Serenity.DecimalEditor;
        TotalAmt: Serenity.DecimalEditor;
        LocalDebit: Serenity.DecimalEditor;
        LocalCredit: Serenity.DecimalEditor;
        LocalBalance: Serenity.DecimalEditor;
        Particulars: Serenity.TextAreaEditor;
    }

    [['EntryNo', () => Serenity.DecimalEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['TranDate', () => Serenity.DateEditor]
   , ['TranType', () => Serenity.StringEditor]
   , ['RefNo', () => Serenity.StringEditor]
   , ['Debit', () => Serenity.DecimalEditor]
   , ['Credit', () => Serenity.DecimalEditor]
   , ['TotalAmt', () => Serenity.DecimalEditor]
   , ['LocalDebit', () => Serenity.DecimalEditor]
   , ['LocalCredit', () => Serenity.DecimalEditor]
   , ['LocalBalance', () => Serenity.DecimalEditor]
   , ['Particulars', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(AccountsReceivableJournalForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

