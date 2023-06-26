namespace Matrix.MasterData {
    export class ContactTypeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.ContactType';

    }

    export interface ContactTypeForm {
        ContactType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
    }

    [['ContactType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(ContactTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

