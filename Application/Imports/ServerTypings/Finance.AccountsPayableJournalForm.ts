namespace Matrix.Finance {
    export class AccountsPayableJournalForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayableJournal';

    }

    export interface AccountsPayableJournalForm {
        EntryNo: Serenity.DecimalEditor;
        VendorNo: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        TranDate: Serenity.DateEditor;
        TranType: Serenity.StringEditor;
        RefNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        TotalAmt: Serenity.DecimalEditor;
        Credit: Serenity.DecimalEditor;
        Debit: Serenity.DecimalEditor;
        LocalCredit: Serenity.DecimalEditor;
        LocalDebit: Serenity.DecimalEditor;
        LocalBalance: Serenity.DecimalEditor;
        Particulars: Serenity.StringEditor;
    }

    [['EntryNo', () => Serenity.DecimalEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['TranDate', () => Serenity.DateEditor]
   , ['TranType', () => Serenity.StringEditor]
   , ['RefNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['TotalAmt', () => Serenity.DecimalEditor]
   , ['Credit', () => Serenity.DecimalEditor]
   , ['Debit', () => Serenity.DecimalEditor]
   , ['LocalCredit', () => Serenity.DecimalEditor]
   , ['LocalDebit', () => Serenity.DecimalEditor]
   , ['LocalBalance', () => Serenity.DecimalEditor]
   , ['Particulars', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsPayableJournalForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

