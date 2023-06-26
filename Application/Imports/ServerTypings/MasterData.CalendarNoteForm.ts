namespace Matrix.MasterData {
    export class CalendarNoteForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.CalendarNote';

    }

    export interface CalendarNoteForm {
        TranDate: Serenity.DateEditor;
        EntryNo: Serenity.DecimalEditor;
        EntryBy: Serenity.StringEditor;
        EntryDate: Serenity.DateEditor;
        EntryType: Serenity.StringEditor;
        Subject: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        Notes: Serenity.StringEditor;
    }

    [['TranDate', () => Serenity.DateEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['EntryBy', () => Serenity.StringEditor]
   , ['EntryDate', () => Serenity.DateEditor]
   , ['EntryType', () => Serenity.StringEditor]
   , ['Subject', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['Notes', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CalendarNoteForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

