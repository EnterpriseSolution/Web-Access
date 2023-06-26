namespace Matrix.Administration {
    export class LookupDialogFilterColumnDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.LookupDialogFilterColumnDetail';

    }

    export interface LookupDialogFilterColumnDetailForm {
        FilterName: Serenity.StringEditor;
        EntryNo: Serenity.IntegerEditor;
        FieldName: Serenity.StringEditor;
    }

    [['FilterName', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.IntegerEditor]
   , ['FieldName', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(LookupDialogFilterColumnDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

