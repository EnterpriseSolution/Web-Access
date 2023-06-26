namespace Matrix.Administration {
    export class LookupDialogFilterForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.LookupDialogFilter';

    }

    export interface LookupDialogFilterForm {
        FilterName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Filter: Serenity.StringEditor;
    }

    [['FilterName', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Filter', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(LookupDialogFilterForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

