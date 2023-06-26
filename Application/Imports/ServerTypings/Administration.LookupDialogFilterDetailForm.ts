namespace Matrix.Administration {
    export class LookupDialogFilterDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.LookupDialogFilterDetail';

    }

    export interface LookupDialogFilterDetailForm {
        FilterName: Serenity.StringEditor;
        EntryNo: Serenity.IntegerEditor;
        EntityName: Serenity.StringEditor;
        FieldName: Serenity.StringEditor;
        FieldValue: Serenity.StringEditor;
        Operator: Serenity.IntegerEditor;
    }

    [['FilterName', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.IntegerEditor]
   , ['EntityName', () => Serenity.StringEditor]
   , ['FieldName', () => Serenity.StringEditor]
   , ['FieldValue', () => Serenity.StringEditor]
   , ['Operator', () => Serenity.IntegerEditor]
].forEach(x => Object.defineProperty(LookupDialogFilterDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

