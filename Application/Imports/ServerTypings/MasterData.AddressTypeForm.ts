namespace Matrix.MasterData {
    export class AddressTypeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.AddressType';

    }

    export interface AddressTypeForm {
        AddressType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
    }

    [['AddressType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(AddressTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

