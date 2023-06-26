namespace Matrix.MasterData {
    export class PortCodeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.PortCode';

    }

    export interface PortCodeForm {
        PortCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    [['PortCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PortCodeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

