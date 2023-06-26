namespace Matrix.MasterData {
    export class UnitForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Unit';

    }

    export interface UnitForm {
        Uom: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        DiscreteQty: Serenity.BooleanEditor;
    }

    [['Uom', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['DiscreteQty', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(UnitForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

