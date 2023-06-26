namespace Matrix.MasterData {
    export class ShipViaCodeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.ShipViaCode';

    }

    export interface ShipViaCodeForm {
        ShipViaCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    [['ShipViaCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(ShipViaCodeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

