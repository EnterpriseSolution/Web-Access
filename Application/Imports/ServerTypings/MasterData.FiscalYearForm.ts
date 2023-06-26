namespace Matrix.MasterData {
    export class FiscalYearForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.FiscalYear';

    }

    export interface FiscalYearForm {
        FiscalYear: Serenity.DecimalEditor;
        AllowEntries: Serenity.StringEditor;
        Closed: Serenity.StringEditor;
        LastPeriod: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        ClosedDate: Serenity.DateEditor;
        ClosedBy: Serenity.StringEditor;
        YtdPlCredit: Serenity.DecimalEditor;
        YtdPlDebit: Serenity.DecimalEditor;
        YtdPlNet: Serenity.DecimalEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['FiscalYear', () => Serenity.DecimalEditor]
   , ['AllowEntries', () => Serenity.StringEditor]
   , ['Closed', () => Serenity.StringEditor]
   , ['LastPeriod', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['ClosedDate', () => Serenity.DateEditor]
   , ['ClosedBy', () => Serenity.StringEditor]
   , ['YtdPlCredit', () => Serenity.DecimalEditor]
   , ['YtdPlDebit', () => Serenity.DecimalEditor]
   , ['YtdPlNet', () => Serenity.DecimalEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(FiscalYearForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

