namespace Matrix.MasterData {
    export class CalendarForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Calendar';

    }

    export interface CalendarForm {
        TranMonth: Serenity.StringEditor;
        TranYear: Serenity.DecimalEditor;
        MonthNo: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['TranMonth', () => Serenity.StringEditor]
   , ['TranYear', () => Serenity.DecimalEditor]
   , ['MonthNo', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CalendarForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

