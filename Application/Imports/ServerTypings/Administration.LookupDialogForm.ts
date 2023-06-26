namespace Matrix.Administration {
    export class LookupDialogForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.LookupDialog';

    }

    export interface LookupDialogForm {
        Description: Serenity.StringEditor;
        QueryId: Serenity.StringEditor;
        KeyField1: Serenity.StringEditor;
        KeyField2: Serenity.StringEditor;
        KeyField3: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        CreatedBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
    }

    [['Description', () => Serenity.StringEditor]
   , ['QueryId', () => Serenity.StringEditor]
   , ['KeyField1', () => Serenity.StringEditor]
   , ['KeyField2', () => Serenity.StringEditor]
   , ['KeyField3', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
].forEach(x => Object.defineProperty(LookupDialogForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

