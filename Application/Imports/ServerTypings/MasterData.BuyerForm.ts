namespace Matrix.MasterData {
    export class BuyerForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Buyer';

    }

    export interface BuyerForm {
        BuyerCode: Serenity.StringEditor;
        BuyerName: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Supervisor: Serenity.StringEditor;
    }

    [['BuyerCode', () => Serenity.StringEditor]
   , ['BuyerName', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Supervisor', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(BuyerForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

