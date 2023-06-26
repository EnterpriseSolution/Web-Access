namespace Matrix.MasterData {
    export class ExchangeRateForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.ExchangeRate';

    }

    export interface ExchangeRateForm {
        Ccy: Serenity.StringEditor;
        EntryNo: Serenity.DecimalEditor;
        FromDate: Serenity.DateEditor;
        ToDate: Serenity.DateEditor;
        ExchRate: Serenity.DecimalEditor;
        Suspended: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['Ccy', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['FromDate', () => Serenity.DateEditor]
   , ['ToDate', () => Serenity.DateEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(ExchangeRateForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

